using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Misstab.ScreenForms.DialogForm.Template
{
    public partial class TimeLineViewSetting_FontView : UserControl
    {
        private string? _DispText { get; set; }
        public string? DispText { get { return _DispText; } set { _DispText = value; this.lblDispText.Text = value; } }
        public string DispFrontColor { get; set; } = "000000";
        public string DispBackColor { get; set; } = "FFFFFF";
        public enum SETTING_MODE
        {
            FORE,
            BACK,
            BOTH
        }
        private SETTING_MODE _m { get; set; } = SETTING_MODE.BOTH;
        public SETTING_MODE Setting_Mode
        {
            get
            {
                return _m;
            }
            set
            {
                this._m = value;

                this.cmdChangeBackSetting.Enabled = false;
                this.cmdChangeForeSetting.Enabled = false;
                switch (value)
                {
                    case SETTING_MODE.FORE:
                        this.cmdChangeForeSetting.Enabled = true;
                        return;
                    case SETTING_MODE.BACK:
                        this.cmdChangeBackSetting.Enabled = true;
                        return;
                    default:
                        this.cmdChangeForeSetting.Enabled = true;
                        this.cmdChangeBackSetting.Enabled = true;
                        return;
                }
            }
        }

        public TimeLineViewSetting_FontView()
        {
            InitializeComponent();
            Setting_Mode = SETTING_MODE.BOTH;
        }

        public void SetViewColor(string _fColor, string _bgColor)
        {
            this.DispFrontColor = _fColor;
            this.DispBackColor = _bgColor;

            this.txtColorDisp.ForeColor = ColorTranslator.FromHtml("#" + this.DispFrontColor);
            this.txtColorDisp.BackColor = ColorTranslator.FromHtml("#" + this.DispBackColor);
        }

        private void cmdChangeBackSetting_Click(object sender, EventArgs e)
        {
            var Dlg = new ColorDialog();
            Dlg.Color = ColorTranslator.FromHtml("#" + this.DispBackColor);
            Dlg.FullOpen = true;
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                SetViewColor(this.DispFrontColor, $"{Dlg.Color.R:X2}{Dlg.Color.G:X2}{Dlg.Color.B:X2}");
            }
        }

        private void cmdChangeForeSetting_Click(object sender, EventArgs e)
        {
            var Dlg = new ColorDialog();
            Dlg.Color = ColorTranslator.FromHtml("#" + this.DispFrontColor);
            Dlg.FullOpen = true;
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                SetViewColor($"{Dlg.Color.R:X2}{Dlg.Color.G:X2}{Dlg.Color.B:X2}", this.DispBackColor);
            }
        }
    }
}
