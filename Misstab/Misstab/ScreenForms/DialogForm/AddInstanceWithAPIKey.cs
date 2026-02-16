using Misstab.Common.Connection.REST;
using Misstab.Common.Connection.VersionInfo;
using Misstab.Common.Connection.WebSocket.Structures;
using Misstab.Common.Setting;
using Misstab.ScreenForms.Controls.Combo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Misstab.ScreenForms.DialogForm
{
    public partial class AddInstanceWithAPIKey : Form
    {
        private MainForm? _MainForm = null;
        private CSoftwareVersionInfo? _VerInfo { get; set; } = new CSoftwareVersionInfo();

        public AddInstanceWithAPIKey(MainForm MainForm)
        {
            InitializeComponent();
            this._MainForm = MainForm;
        }

        private void cmdApply_Click(object sender, EventArgs e)
        {
            // 状況的に発生しない
            if (_MainForm == null)
            {
                return;
            }

            // タイムラインの種類
            string SelectTL = string.Empty;
            if (cmbTLKind.SelectedItem == null || cmbTLKind.SelectedItem.ToString() == "")
            {
                MessageBox.Show("TLの種類を選択してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CmbInstance SelectedTLKind = ((CmbInstance)cmbTLKind.SelectedItem);
            bool InputChecked = false;

            // 入力が足らない
            if (SelectedTLKind._TLKind == Common.Connection.WebSocket.TimeLineBasic.ConnectTimeLineKind.Home)
            {
                InputChecked = (txtAPIKey.Text == string.Empty ||
                                txtInstanceURL.Text == string.Empty);
            }
            else
            {
                InputChecked = (txtInstanceURL.Text == string.Empty);
            }
            if (InputChecked)
            {
                MessageBox.Show("インスタンスURLもしくはAPIキーが入力されていません。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmdGetVersionInfo_Click(sender, new EventArgs());
            _ = Task.Run(async () =>
            {
                // URLが存在するかチェック
                HttpClient Clt = new HttpClient();
                try
                {
                    var HttpResult = await Clt.GetAsync(string.Format(@"https://{0}/", txtInstanceURL.Text));

                    if (HttpResult.StatusCode != System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("存在しないURLです。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                }

                //SettingWebSocket WSManager = new SettingWebSocket();
                //WSManager.InstanceURL = txtInstanceURL.Text;
                //WSManager.APIKey = txtAPIKey.Text;
                //WSManager.ConnectTimeLineKind = ((CmbInstance)cmbTLKind.SelectedItem)._TLKind;
                //WSManager.SoftwareVersionInfo = _VerInfo;
                //WSManager.AvoidIntg = false;
                //WSManager.TimeLineDefinition = new string[] { };
                //WSManager.LastUpdated = DateTime.Now.ToString();

                System.Diagnostics.Debug.WriteLine("WebSocket作成");
                // this._MainForm.LoadWebSocketManually(new SettingWebSocket[] { WSManager });
                try
                {
                    Func<bool> n = () =>
                    {
                        if (this._MainForm.InvokeRequired)
                        {
                            this._MainForm.Invoke(this._MainForm.AddWebSocketManually, _VerInfo, ((CmbInstance)cmbTLKind.SelectedItem)._TLKind, txtInstanceURL.Text, txtAPIKey.Text, false, new string[] { });
                        }
                        else
                        {
                            this._MainForm.AddWebSocketManually(_VerInfo, ((CmbInstance)cmbTLKind.SelectedItem)._TLKind, txtInstanceURL.Text, txtAPIKey.Text, false, new string[] { });
                        }
                        if (txtTabName.Text != "")
                        {
                            SettingTimeLine WSTimeLine = new SettingTimeLine()
                            {
                                Definition = Guid.NewGuid().ToString(),
                                TabName = this.txtTabName.Text,
                                IsSaveIcon = false
                            };
                            if(this._MainForm.InvokeRequired)
                            {
                                this._MainForm.Invoke(this._MainForm.LoadTimeLineManually, new SettingTimeLine[] { WSTimeLine });
                            }
                            else
                            {
                                this._MainForm.LoadTimeLineManually(new SettingTimeLine[] { WSTimeLine });
                            }
                        }
                        return true;
                    };
                    if (InvokeRequired)
                    {
                        this.Invoke(n);
                        return;
                    }
                    n.Invoke();
                }
                catch(Exception ce)
                {
                    System.Diagnostics.Debug.WriteLine("err");
                }
            });
        }

        private void cmdGetVersionInfo_Click(object sender, EventArgs e)
        {
            GetCommon VersionInfo = new GetCommon();
            _VerInfo = VersionInfo.GetSoftwareVersion(this.txtInstanceURL.Text,
                                                                            this.txtAPIKey.Text,
                                                                            Common.Connection.VersionInfo.CSoftwareVersionInfo.SOFTWARE_LIST.MISSKEY);
            if (_VerInfo == null)
            {
                MessageBox.Show("バージョン情報が取得できませんでした。");
                this.cmdApply.Enabled = false;
                return;
            }
            this.txtSoftwareName.Text = _VerInfo.SoftwareName;
            this.txtSoftwareVersion.Text = $"{_VerInfo.Version.MajorVersion}.{_VerInfo.Version.MinorVersion}.{_VerInfo.Version.Revision}.{_VerInfo.Version.BuildVersion}";
            this.cmdApply.Enabled = true;
        }

        private void AddInstanceWithAPIKey_Load(object sender, EventArgs e)
        {
            this.cmbTLKind.Items.Clear();

            // ホームTL
            this.cmbTLKind.Items.Add(new CmbInstance(Common.Connection.WebSocket.TimeLineBasic.ConnectTimeLineKind.Home,
                                     "ホームTL"));

            // ソーシャルTL
            this.cmbTLKind.Items.Add(new CmbInstance(Common.Connection.WebSocket.TimeLineBasic.ConnectTimeLineKind.Social,
                                     "ソーシャル"));

            // ローカルTL
            this.cmbTLKind.Items.Add(new CmbInstance(Common.Connection.WebSocket.TimeLineBasic.ConnectTimeLineKind.Local,
                                     "ローカルTL"));

            // グローバルTL
            this.cmbTLKind.Items.Add(new CmbInstance(Common.Connection.WebSocket.TimeLineBasic.ConnectTimeLineKind.Global,
                                     "グローバル"));
        }
    }
}
