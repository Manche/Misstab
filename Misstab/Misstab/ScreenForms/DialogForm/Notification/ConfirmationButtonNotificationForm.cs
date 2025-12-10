using Misstab.Common.AnalyzeData.Format;
using Misstab.Common.Notification;
using Misstab.Common.Notification.Connector.ConfirmationButton;
using Misstab.Common.Notification.Sound;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Misstab.ScreenForms.DialogForm.Notification
{
    public partial class ConfirmationButtonNotificationForm : Form
    {
        /// <summary>
        /// シングルトンインスタンス
        /// </summary>
        public static ConfirmationButtonNotificationForm Instance = new ConfirmationButtonNotificationForm();

        public ConfirmationButtonNotificationForm()
        {
            InitializeComponent();

            _ = Task.Run(async () =>
            {
                await Task.Delay(1000);
                while (true)
                {
                    await UpdateNotificationWord();
                }
            });
        }

        private async Task UpdateNotificationWord()
        {
            if (InvokeRequired)
            {
                await this.Invoke(UpdateNotificationWord);
                return;
            }
            txtNotification.Text = string.Join("\r\n", this.NotificationData);
        }

        private List<string> NotificationData = new List<string>();

        public void SetNotificationData(ConfirmationButtonController NotificationCnt)
        {
            if (InvokeRequired)
            {
                this.Invoke(SetNotificationData, NotificationCnt);
                return;
            }
            this.NotificationData.Add(NotificationCnt.GetFormattedStr(NotificationCnt.NotificationTitle) + "/" + NotificationCnt.GetFormattedStr(NotificationCnt.NotificationContent));
        }

        private bool IsPlayingSound = false;
        public void OpenNotification(ConfirmationButtonController NotificationCnt)
        {
            this.NotificationData.Add(NotificationCnt.GetFormattedStr(NotificationCnt.NotificationTitle) + "/" + NotificationCnt.GetFormattedStr(NotificationCnt.NotificationContent));
            if (IsPlayingSound)
            {
                return;
            }
            this.IsPlayingSound = true;
            PlaySound(NotificationCnt);
            this.ShowDialog();
        }

        private void PlaySound(ConfirmationButtonController NotificationCnt)
        {
            _ = Task.Run(async () =>
            {
                await Task.Run(async () =>
                {
                    while (true)
                    {
                        if (!IsPlayingSound)
                        {
                            return;
                        }
                        try
                        {
                            NotificationSoundAudioHelper.Instance.PlaySound(NotificationCnt.FilePath, NotificationCnt.Volume);
                            await Task.Delay(NotificationCnt.Distance);
                        }
                        catch
                        {
                        }
                    }
                });
            });
        }

        private void cmdConfirmed_Click(object sender, EventArgs e)
        {
            this.IsPlayingSound = false;
            this.Close();
        }

        private void ConfirmationButtonNotificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.IsPlayingSound = false;
        }
    }
}
