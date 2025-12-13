using Misstab.Common.Notification.Baloon;
using Misstab.Common.Notification.Sound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misstab.Common.Notification.Connector.ConfirmationButton
{
    public partial class ConfirmationButtonControlForm : NotificationConnectorControlForm
    {
        public ConfirmationButtonControlForm()
        {
            base.Initialize();

            int PosY = 0;
            int PosX = 0;
            int TmPos = 0;

            PosX = _MarginX;
            PosY = 0;
            this.Controls.Add(CreateLabel("lblTitle", "タイトル", ref PosY, ref PosX));
            this.Controls.Add(CreateLabel("lblContent", "本文", ref PosY, ref PosX));
            this.Controls.Add(CreateLabel("lblFilepath", "ファイルパス", ref PosY, ref PosX));
            this.Controls.Add(CreateLabel("lblVolume", "音量", ref PosY, ref PosX));
            // this.Controls.Add(CreateLabel("lblPlayTimes", "回数", ref PosY, ref PosX));
            this.Controls.Add(CreateLabel("lblDistance", "再生間隔", ref PosY, ref PosX));
            this.Controls.Add(CreateLabel("lblListen", "視聴", ref PosY, ref PosX));

            PosX = _MarginX;
            PosY = 0;
            this.Controls.Add(CreateTextBox("txtTitle", "", ref PosY, ref PosX));
            this.SetTextBoxLength((TextBox)this._CreatedControls["txtTitle"], 15);
            this.Controls.Add(CreateTextBox("txtContent", "", ref PosY, ref PosX));
            this.SetTextBoxLength((TextBox)this._CreatedControls["txtContent"], 25);
            this.SetTextBoxHeight((TextBox)this._CreatedControls["txtContent"], 10);
            PosY += 80;
            this.Controls.Add(CreateTextBox("txtFilepath", "", ref PosY, ref PosX));
            this.Controls.Add(CreateNumberBox("numVolume", 100, ref PosY, ref PosX));
            // this.Controls.Add(CreateNumberBox("numPlayTimes", 1, ref PosY, ref PosX));
            this.Controls.Add(CreateNumberBox("numDistance", 1000, ref PosY, ref PosX, 0, 60000));
            this.Controls.Add(CreateButton("btnListen", "視聴", ref PosY, ref PosX));

            try
            {
                this.SetTextBoxLength((TextBox)this._CreatedControls["txtFilepath"], 32);
                this.SetTextBoxLength((NumericUpDown)this._CreatedControls["numVolume"], 5);
                //this.SetTextBoxLength((NumericUpDown)this._CreatedControls["numPlayTimes"], 5);
                this.SetTextBoxLength((NumericUpDown)this._CreatedControls["numDistance"], 5);
            }
            catch
            {
            }
            if (this._CreatedControls["txtFilepath"].Size.Width + this._CreatedControls["txtFilepath"].Location.X > _MarginX)
            {
                _MarginX = this._CreatedControls["txtFilepath"].Size.Width + this._CreatedControls["txtFilepath"].Location.X;
            }

            PosX = _MarginX;
            PosY = 0;
            TmPos = this._CreatedControls["txtFilepath"].Location.Y;
            this.Controls.Add(CreateButton("btnFile", "参照", ref TmPos, ref PosX));
            this._CreatedControls["btnFile"].Click += btnFile_Click;

            this._CreatedControls["btnListen"].Click += btnListen_Click;
        }

        private void btnFile_Click(object? sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.AddExtension = true;
            dialog.ShowDialog();
            if (dialog.FileName == string.Empty || dialog.FileName == null)
            {
                return;
            }

            ((TextBox)this._CreatedControls["txtFilepath"]).Text = dialog.FileName;
        }

        private void btnListen_Click(object? sender, EventArgs e)
        {
            ConfirmationButtonController _TController = new ConfirmationButtonController();
            this.SaveDataToControl(_TController);

            NotificationController _Controller = new NotificationSoundController();
            ((NotificationSoundController)_Controller).FilePath = _TController.FilePath;
            ((NotificationSoundController)_Controller).Volume = _TController.Volume;
            ((NotificationSoundController)_Controller).Distance = _TController.Distance;

            NotificationSoundControlForm _Form = new NotificationSoundControlForm();

            //_Controller = _Form.SaveDataToControl(_Controller);
            _Controller.Execute();
        }

        public override void LoadDataToControl(NotificationController Controller)
        {
            ((TextBox)this._CreatedControls["txtTitle"]).Text = ((ConfirmationButtonController)Controller).NotificationTitle;
            ((TextBox)this._CreatedControls["txtContent"]).Text = ((ConfirmationButtonController)Controller).NotificationContent;
            ((TextBox)this._CreatedControls["txtFilepath"]).Text = ((ConfirmationButtonController)Controller).FilePath;
            ((NumericUpDown)this._CreatedControls["numVolume"]).Value = ((ConfirmationButtonController)Controller).Volume;
            ((NumericUpDown)this._CreatedControls["numDistance"]).Value = ((ConfirmationButtonController)Controller).Distance;
        }

        public override NotificationController SaveDataToControl(NotificationController Controller)
        {
            ((ConfirmationButtonController)Controller).NotificationTitle = ((TextBox)this._CreatedControls["txtTitle"]).Text;
            ((ConfirmationButtonController)Controller).NotificationContent = ((TextBox)this._CreatedControls["txtContent"]).Text;
            ((ConfirmationButtonController)Controller).FilePath = ((TextBox)this._CreatedControls["txtFilepath"]).Text;
            ((ConfirmationButtonController)Controller).Volume = (int)((NumericUpDown)this._CreatedControls["numVolume"]).Value;
            ((ConfirmationButtonController)Controller).Distance = (int)((NumericUpDown)this._CreatedControls["numDistance"]).Value;

            return Controller;
        }
    }
}
