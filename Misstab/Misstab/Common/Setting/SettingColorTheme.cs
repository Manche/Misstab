using Misstab.Common.TimeLine.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Misstab.Common.Setting
{
    public class SettingColorTheme
    {
        public static SettingColorTheme Instance { get; } = new SettingColorTheme();

        /// <summary>
        /// 設定バージョン
        /// </summary>
        public string SettingVersion { get; set; } = "v0.0.1";
        /// <summary>
        /// 設定名称
        /// </summary>
        public string SettingName { get; set; } = "名称未設定";
        /// <summary>
        /// 更新日時
        /// </summary>
        public string UpdatedAt { get; set; } = DateTime.Now.ToString();
        /// <summary>
        /// 設定内容
        /// </summary>
        public DataGridTimeLineViewSetting ViewSetting { get; set; } = new DataGridTimeLineViewSetting();

        /// <summary>
        /// 設定保存
        /// </summary>
        /// <param name="Setting"></param>
        /// <returns></returns>
        public static bool SaveSetting(SettingColorTheme Setting)
        {
            SettingConst.SettingDirCheck();
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(Setting, options);
            File.WriteAllText(SettingConst.COLOR_THEME_SETTINGS_FILE + "\\" + Setting.SettingName + ".json", json);

            return true;
        }

        /// <summary>
        /// 設定読み込み
        /// </summary>
        /// <param name="PhyscalName"></param>
        /// <returns></returns>
        public static SettingColorTheme LoadSetting(string PhyscalName)
        {
            if (!File.Exists(SettingConst.COLOR_THEME_SETTINGS_FILE + "\\" + PhyscalName + ".json"))
                return new SettingColorTheme(); // ファイルがなければデフォルト値で作成

            string json = File.ReadAllText(SettingConst.COLOR_THEME_SETTINGS_FILE + "\\" + PhyscalName + ".json");
            try
            {
                return JsonSerializer.Deserialize<SettingColorTheme>(json) ?? new SettingColorTheme() { };
            }
            catch
            {
                return new SettingColorTheme();
            }
        }
    }
}
