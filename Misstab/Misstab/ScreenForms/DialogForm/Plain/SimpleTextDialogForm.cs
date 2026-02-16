using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Misstab.ScreenForms.DialogForm.Plain
{
    public partial class SimpleTextDialogForm : Form
    {
        public SimpleTextDialogForm()
        {
            InitializeComponent();

            this.cmdAddFunc1.Visible = false;
            this.cmdAddFunc2.Visible = false;
            this.cmdAddFunc3.Visible = false;
            this.cmdAddFunc4.Visible = false;
            this.cmdAddFunc5.Visible = false;
            this.cmdAddFunc1.Text = string.Empty;
            this.cmdAddFunc2.Text = string.Empty;
            this.cmdAddFunc3.Text = string.Empty;
            this.cmdAddFunc4.Text = string.Empty;
            this.cmdAddFunc5.Text = string.Empty;
        }

        public string InputText { get { return this.txtInputBox.Text; } }

        private MessageBoxButtons _B { get; set; } = MessageBoxButtons.OK;
        public void SetCmdText(MessageBoxButtons Btn, string InitialText)
        {
            this.txtInputBox.Text = InitialText;
            this._B = Btn;

            switch (Btn)
            {
                case MessageBoxButtons.OK:
                    this.cmdYesOK.Text = "OK";
                    this.cmdNoCancel.Text = "Cancel";
                    this.cmdNoCancel.Visible = false;
                    break;
                case MessageBoxButtons.YesNo:
                    this.cmdYesOK.Text = "Yes";
                    this.cmdNoCancel.Text = "No";
                    this.cmdNoCancel.Visible = true;
                    break;
                case MessageBoxButtons.OKCancel:
                    this.cmdYesOK.Text = "OK";
                    this.cmdNoCancel.Text = "Cancel";
                    this.cmdNoCancel.Visible = true;
                    break;
                default:
                    throw new NotImplementedException("Undefined MessageBoxButton");
            }
        }

        private void cmdYesOK_Click(object sender, EventArgs e)
        {
            if (!this._OKFnc.Invoke())
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void cmdNoCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 拡張処理識別子
        /// </summary>
        public enum ADD_FUNC
        {
            FUNC1,
            FUNC2,
            FUNC3,
            FUNC4,
            FUNC5,
        }
        /// <summary>
        /// 拡張処理をアタッチする
        /// </summary>
        /// <param name="Def"></param>
        /// <param name="Fnc"></param>
        public void AttachFunc(ADD_FUNC Def, Func<bool> Fnc, string DispName)
        {
            EventHandler? hd = null;
            switch (Def)
            {
                case ADD_FUNC.FUNC1:
                    this.cmdAddFunc1.Text = DispName;
                    hd = (sender, e) => { Fnc.Invoke(); };
                    this.cmdAddFunc1.Click += hd;
                    this.cmdAddFunc1.Visible = true;
                    break;
                case ADD_FUNC.FUNC2:
                    this.cmdAddFunc2.Text = DispName;
                    hd = (sender, e) => { Fnc.Invoke(); };
                    this.cmdAddFunc2.Click += hd;
                    this.cmdAddFunc2.Visible = true;
                    break;
                case ADD_FUNC.FUNC3:
                    this.cmdAddFunc3.Text = DispName;
                    hd = (sender, e) => { Fnc.Invoke(); };
                    this.cmdAddFunc3.Click += hd;
                    this.cmdAddFunc3.Visible = true;
                    break;
                case ADD_FUNC.FUNC4:
                    this.cmdAddFunc4.Text = DispName;
                    hd = (sender, e) => { Fnc.Invoke(); };
                    this.cmdAddFunc4.Click += hd;
                    this.cmdAddFunc4.Visible = true;
                    break;
                case ADD_FUNC.FUNC5:
                    this.cmdAddFunc5.Text = DispName;
                    hd = (sender, e) => { Fnc.Invoke(); };
                    this.cmdAddFunc5.Click += hd;
                    this.cmdAddFunc5.Visible = true;
                    break;
            }
        }
        /// <summary>
        /// okボタン押下時の定義
        /// </summary>
        private Func<bool> _OKFnc = () => true;
        /// <summary>
        /// okボタン押下時の処理アタッチ
        /// </summary>
        /// <param name="Fnc"></param>
        public void AttachFuncOK(Func<bool> Fnc)
        {
            this._OKFnc = Fnc;
        }
    }
}
