using Misstab.Common.TimeLine;
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
        private TimeLineOverAllSettingPreference _Preference {  get; set; } = new TimeLineOverAllSettingPreference();

        public TimeLineOverAllSetting()
        {
            InitializeComponent();
        }

        public void SetAlertData(DataGridTimeLine TimeLine)
        {
            this._TimeLine = TimeLine;
            this.TimeLineOverAllSetting_Load(null, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_TimeLine == null)
            {
                return;
            }
            if (this._Preference.CheckLowSpec)
            {
                _TimeLine.SetSaveIconImages(!chkLowSpecMode.Checked);
            }
            _TimeLine.SettingChanged(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateLowSpec()
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
                this._Preference.CheckLowSpec = true;
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
        }

        private void chkLowSpecMode_CheckedChanged(object sender, EventArgs e)
        {
            if (_TimeLine == null)
            {
                return;
            }
            if (!ValidateLowSpec())
            {
                this.chkLowSpecMode.Checked = !_TimeLine._IsSaveIcon;
                return;
            }
        }
    }

    internal class TimeLineOverAllSettingPreference
    {
        public bool CheckLowSpec { get; set; } = false;
        public bool CheckPhyscalDelete { get; set; } = false;
    }
}
