using Misstab.Common.Setting;
using Misstab.Common.TimeLine;
using Misstab.Common.TimeLine.Setting;
using Misstab.ScreenForms.DialogForm.Plain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Misstab.ScreenForms.DialogForm.Setting
{
    public partial class TimeLineOverAllSetting : Form
    {
        public DataGridTimeLine? _TimeLine = null;
        private TimeLineOverAllSettingPreference _Preference { get; set; } = new TimeLineOverAllSettingPreference();

        public TimeLineOverAllSetting()
        {
            InitializeComponent();
        }

        public void SetAlertData(DataGridTimeLine TimeLine)
        {
            this._TimeLine = TimeLine;
            this.TimeLineOverAllSetting_Load(null, new EventArgs());
        }

        private DataGridTimeLineViewSetting? ConvertToTimeLineViewSetting()
        {
            if (_TimeLine == null)
            {
                return null;
            }
            var TimeLineViewSetting = _TimeLine._ViewSetting;
            TimeLineViewSetting._ForeColorReplayedRaw = this.fbPostReplyed.DispFrontColor;
            TimeLineViewSetting._BackColorPostIsReplayed = this.fbPostReplyed.DispBackColor;
            TimeLineViewSetting._ForeColorPostRenote = this.fbPostRenote.DispFrontColor;
            TimeLineViewSetting._BackColorPostIsRenote = this.fbPostRenote.DispBackColor;

            TimeLineViewSetting._ForeColorPostHome = this.fbPostHome.DispFrontColor;
            TimeLineViewSetting._ForeColorPostDirect = this.fbPostDirect.DispFrontColor;
            TimeLineViewSetting._ForeColorPostFollower = this.fbPostFollower.DispFrontColor;
            TimeLineViewSetting._ForeColorPostIsChannel = this.fbPostChannel.DispFrontColor;

            TimeLineViewSetting._BackColorPostIsCW = this.fbPostCW.DispBackColor;

            return TimeLineViewSetting;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_TimeLine == null)
            {
                return;
            }
            if (this._Preference.CheckLowSpecTimeLine)
            {
                _TimeLine.SetSaveIconImages(!chkLowSpecMode.Checked);
            }
            _TimeLine._IsUpdateTL = this.chkUpdateTL.Checked;

            var TimeLineViewSetting = ConvertToTimeLineViewSetting();
            if (TimeLineViewSetting == null)
            {
                return;
            }
            if (chkUnlimitedLineCount.Checked)
            {
                TimeLineViewSetting.MaxTimeLineItemCount = -1;
            }
            else
            {
                TimeLineViewSetting.MaxTimeLineItemCount = (int)numMaxLineCount.Value;
            }
            _TimeLine.SetDataGridTimeLineViewSetting(TimeLineViewSetting);
            _TimeLine.SettingChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateTimeLineLowSpec()
        {
            if (_TimeLine == null)
            {
                return false;
            }
            if (_TimeLine._IsSaveIcon != !chkLowSpecMode.Checked)
            {
                if (MessageBox.Show(this, "設定を変更するとタイムラインが設定保存時にリセットされます。\r\n変更しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return false;
                }
                this._Preference.CheckLowSpecTimeLine = true;
            }
            return true;
        }

        private void TimeLineOverAllSetting_Load(object? sender, EventArgs e)
        {
            _Preference = new TimeLineOverAllSettingPreference();

            if (_TimeLine == null)
            {
                return;
            }

            this.txtDescription.Text = "";

            this.chkLowSpecMode.Checked = !_TimeLine._IsSaveIcon;
            this.chkUpdateTL.Checked = _TimeLine._IsUpdateTL;

            var TimeLineViewSetting = _TimeLine._ViewSetting;
            this.chkUnlimitedLineCount.Checked = TimeLineViewSetting.MaxTimeLineItemCount == -1;
            this.numMaxLineCount.Value = TimeLineViewSetting.MaxTimeLineItemCount == -1 ? SettingTimeLineConst.MAX_TIMELINE_COUNT : TimeLineViewSetting.MaxTimeLineItemCount;

            // 色設定
            this.fbPostReplyed.SetViewColor(TimeLineViewSetting._ForeColorReplayedRaw, TimeLineViewSetting._BackColorPostIsReplayed);
            this.fbPostPublic.SetViewColor(TimeLineViewSetting._ForeColorPostPublic, "FFFFFF");
            this.fbPostHome.SetViewColor(TimeLineViewSetting._ForeColorPostHome, "FFFFFF");
            this.fbPostDirect.SetViewColor(TimeLineViewSetting._ForeColorPostDirect, "FFFFFF");
            this.fbPostFollower.SetViewColor(TimeLineViewSetting._ForeColorPostFollower, "FFFFFF");
            this.fbPostLocal.SetViewColor(TimeLineViewSetting._ForeColorPostIsLocal, "FFFFFF");
            this.fbPostUnion.SetViewColor(TimeLineViewSetting._ForeColorPostIsUnion, "FFFFFF");
            this.fbPostRenote.SetViewColor(TimeLineViewSetting._ForeColorPostRenote, TimeLineViewSetting._BackColorPostIsRenote);
            this.fbPostChannel.SetViewColor(TimeLineViewSetting._ForeColorPostIsChannel, "FFFFFF");
            this.fbPostCW.SetViewColor("000000", TimeLineViewSetting._BackColorPostIsCW);

            this.fbPostReplyed.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            this.fbPostPublic.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.FORE;
            this.fbPostHome.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.FORE;
            this.fbPostDirect.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.FORE;
            this.fbPostFollower.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.FORE;
            this.fbPostRenote.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            this.fbPostLocal.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.FORE;
            this.fbPostUnion.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.FORE;
            this.fbPostChannel.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.FORE;
            this.fbPostCW.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BACK;
        }

        private void chkLowSpecMode_CheckedChanged(object sender, EventArgs e)
        {
            if (_TimeLine == null)
            {
                return;
            }
            if (!ValidateTimeLineLowSpec())
            {
                this.chkLowSpecMode.Checked = !_TimeLine._IsSaveIcon;
                return;
            }
        }

        private void cmdSaveColorTheme_Click(object sender, EventArgs e)
        {
            SimpleTextDialogForm Dlg = new SimpleTextDialogForm();
            Func<bool> Fnc = () =>
            {
                if (File.Exists(SettingConst.COLOR_THEME_SETTINGS_FILE + "\\" + Dlg.InputText + ".json"))
                {
                    MessageBox.Show("既に存在するカラーテーマ名です。");
                    return false;
                }
                MessageBox.Show("保存しました。");
                return true;
            };
            Dlg.SetCmdText(MessageBoxButtons.OKCancel, "");
            Dlg.AttachFunc(SimpleTextDialogForm.ADD_FUNC.FUNC1, Fnc, "存在チェック");
            Dlg.AttachFuncOK(Fnc);
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                var TimeLineViewSetting = ConvertToTimeLineViewSetting();
                if (TimeLineViewSetting == null)
                {
                    return;
                }
                SettingColorTheme Setting = new SettingColorTheme();
                Setting.SettingName = Dlg.InputText;
                SettingColorTheme.SaveSetting(Setting);
            }
        }

        private void cmdLoadColorTheme_Click(object sender, EventArgs e)
        {
        }
    }

    internal class TimeLineOverAllSettingPreference
    {
        public bool CheckLowSpec { get; set; } = false;
        public bool CheckPhyscalDelete { get; set; } = false;
        public bool CheckLowSpecTimeLine { get; set; } = false;
    }
}
