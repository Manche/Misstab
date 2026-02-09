using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using DrawingImage = System.Drawing.Image;
using ImageSharpImage = SixLabors.ImageSharp.Image;
using Image = System.Drawing.Image;
using Point = System.Drawing.Point;

namespace Misstab.Common.Util
{
    public class ImageCacher
    {
        public static ImageCacher Instance { get; } = new ImageCacher();
        public event Action<string>? ImageLoaded;
        public event Action<string>? ImageDownloaded; // define

        private ImageCacher()
        {
            InitializeIconImage();
        }

        private int TaskCount { get; set; } = 0;
        private readonly object SingleCount = new object();

        private Dictionary<string, ImageInfo> _CachedImage { get; set; } = new Dictionary<string, ImageInfo>();

        /// <summary>
        /// 既存アイコンを初期化（破損画像はスキップ）
        /// </summary>
        public void InitializeIconImage()
        {
            foreach (var filePath in Directory.GetFiles(ImageInfo.IconPath))
            {
                string key = Path.GetFileName(filePath);
                var img = SafeLoadImage(filePath);
                if (img != null)
                {
                    _CachedImage[key] = new ImageInfo
                    {
                        Path = filePath,
                        SavedTime = DateTime.Now,
                        ImageData = img
                    };
                }
            }
        }

        /// <summary>
        /// VirtualMode 用の安全取得
        /// </summary>
        public Image? TryGetImage(string key)
        {
            if (_CachedImage.TryGetValue(key, out var info))
            {
                return info.ImageData;
            }
            return null;
        }

        /// <summary>
        /// アイコンを非同期取得してキャッシュする
        /// </summary>
        public void SaveIconImage(string Define, string Url)
        {
            if (_CachedImage.ContainsKey(Define) &&
                _CachedImage[Define].SavedTime.AddMinutes(5) >= DateTime.Now)
                return;

            lock (SingleCount) TaskCount++;

            _ = Task.Run(async () =>
            {
                try
                {
                    Directory.CreateDirectory(ImageInfo.IconPath);

                    using var client = new HttpClient();
                    using var response = await client.GetAsync(Url, HttpCompletionOption.ResponseHeadersRead);

                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"[ImageCacher] HTTP {response.StatusCode} : {Url}");
                        return;
                    }

                    string savePath = Path.Combine(ImageInfo.IconPath, Define + ".png");
                    string tempPath = savePath + ".tmp";

                    await using (var stream = await response.Content.ReadAsStreamAsync())
                    await using (var outFile = File.Create(tempPath))
                    {
                        await stream.CopyToAsync(outFile);
                        await outFile.FlushAsync();
                    }

                    // ファイル置き換え（書き込み完了後）
                    File.Copy(tempPath, savePath, true);
                    File.Delete(tempPath);

                    // WebP 対策 & 壊れ対策
                    var img = SafeLoadImageRobust(savePath);
                    if (img != null)
                    {
                        lock (_CachedImage)
                        {
                            _CachedImage[Define] = new ImageInfo
                            {
                                Path = savePath,
                                ImageData = img,
                                SavedTime = DateTime.Now
                            };
                        }
                        // 通知！
                        ImageDownloaded?.Invoke(Define);
                    }
                    else
                    {
                        Console.WriteLine($"[ImageCacher] Failed to load image: {savePath}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ImageCacher] Error: {ex}");
                }
                finally
                {
                    lock (SingleCount) TaskCount--;
                }
            });
        }
        private static readonly object GdiLock = new object();

        private static DrawingImage? SafeLoadImageRobust(string path)
        {
            try
            {
                if (!File.Exists(path))
                    return null;

                // ファイルサイズが極端に小さいものは破損とみなす
                var fi = new FileInfo(path);
                if (fi.Length < 16)
                    return null;

                // ファイルを完全コピー（ロック回避）
                byte[] bytes;
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (var ms = new MemoryStream())
                {
                    fs.CopyTo(ms);
                    bytes = ms.ToArray();
                }

                // --- GDI+ が落ちやすいので排他制御 ---
                lock (GdiLock)
                {
                    try
                    {
                        using var ms = new MemoryStream(bytes);
                        return DrawingImage.FromStream(ms);
                    }
                    catch (ArgumentException)
                    {
                        // WebP または破損GIFを ImageSharp 経由で再試行
                        using var ms2 = new MemoryStream(bytes);
                        using var image = ImageSharpImage.Load(ms2);
                        using var outStream = new MemoryStream();
                        image.SaveAsPng(outStream);
                        outStream.Position = 0;
                        return DrawingImage.FromStream(outStream);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ImageCacher] SafeLoadImageRobust failed: {ex.Message}");
                return null;
            }
        }

        private static DrawingImage? ConvertWebPToBitmap(byte[] data)
        {
            try
            {
                using var ms = new MemoryStream(data);
                using var image = ImageSharpImage.Load(ms); // ← ImageSharp の Image
                using var output = new MemoryStream();
                image.SaveAsPng(output);
                output.Position = 0;
                return DrawingImage.FromStream(output); // ← System.Drawing.Image に変換
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ImageCacher] WebP convert failed: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// 破損ファイル対策でImageを安全に読み込む
        /// </summary>
        private static System.Drawing.Image? SafeLoadImage(string path)
        {
            try
            {
                // まずファイルサイズチェック（破損ファイル回避）
                var fileInfo = new FileInfo(path);
                if (!fileInfo.Exists || fileInfo.Length < 32) // 32バイト未満は確実に壊れている
                    return null;

                // 読み込み時にストリームを完全コピー（GDI+バグ対策）
                using (var ms = new MemoryStream(File.ReadAllBytes(path)))
                {
                    // GIF 対策：アニメーションGIFは1フレームだけ静止画化
                    using (var img = System.Drawing.Image.FromStream(ms, useEmbeddedColorManagement: false, validateImageData: false))
                    {
                        if (img.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Gif.Guid)
                        {
                            try
                            {
                                // アニメGIF → Bitmap化（1枚目のみ）
                                var bmp = new System.Drawing.Bitmap(img.Width, img.Height);
                                using (var g = System.Drawing.Graphics.FromImage(bmp))
                                {
                                    g.DrawImage(img, System.Drawing.Point.Empty);
                                }
                                return bmp;
                            }
                            catch
                            {
                                return null;
                            }
                        }
                        else
                        {
                            // 通常画像はクローンして返す（ファイルロック防止）
                            return new System.Drawing.Bitmap(img);
                        }
                    }
                }
            }
            catch (OutOfMemoryException)
            {
                // GDI+ が画像として認識できないファイル
                return null;
            }
            catch (ArgumentException)
            {
                // Parameter is not valid
                return null;
            }
            catch (Exception ce)
            {
                return null;
            }
        }


        public void CacheClear()
        {
            foreach (var info in _CachedImage.Values)
            {
                info.ImageData?.Dispose();
            }
            _CachedImage.Clear();
        }
    }

    public class ImageInfo
    {
        public string Path { get; set; } = string.Empty;
        public Image? ImageData { get; set; } = null;
        public DateTime SavedTime { get; set; } = DateTime.Now;

        private static string ApplicationDirectory()
        {
            var appDir = new DirectoryInfo(System.IO.Path.GetFullPath(System.Windows.Forms.Application.ExecutablePath)).Parent?.ToString();
            return appDir ?? "";
        }

        public static string BasePath = ApplicationDirectory() + CommonFilePath + AssetsFilePath + ImageFilePath;
        public static string IconPath = BasePath + IconFilePath;

        public const string CommonFilePath = "\\Common";
        public const string AssetsFilePath = "\\Assets";
        public const string ImageFilePath = "\\Images";
        public const string IconFilePath = "\\Icon";
    }
}
