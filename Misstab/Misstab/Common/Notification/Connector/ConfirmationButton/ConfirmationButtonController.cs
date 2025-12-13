using Misstab.Common.Setting;
using Misstab.ScreenForms.DialogForm.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misstab.Common.Notification.Connector.ConfirmationButton
{
    public class ConfirmationButtonController : NotificationConnectorController
    {
        /// <summary>
        /// 名称
        /// </summary>
        public const string ControllerName = "通知ボタン";
        /// <summary>
        /// バルーンタイトル
        /// </summary>
        public string NotificationTitle { get; set; } = string.Empty;
        /// <summary>
        /// バルーン本文
        /// </summary>
        public string NotificationContent { get; set; } = string.Empty;

        /// <summary>
        /// 再生するかどうか
        /// </summary>
        public bool IsPlaySound { get; set; } = false;
        /// <summary>
        /// ファイルパス
        /// </summary>
        public string FilePath { get; set; } = string.Empty;
        /// <summary>
        /// ボリューム
        /// </summary>
        public int Volume { get; set; } = 100;
        /// <summary>
        /// 再生間隔
        /// </summary>
        public int Distance { get; set; } = 0;

        public ConfirmationButtonController()
        {
            this._ControllerKind = CONTROLLER_KIND.ConfirmationButton;
        }

        /// <summary>
        /// 通知処理本体
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void ExecuteMethod()
        {
            if (SettingState.Instance.IsMuted)
            {
                return;
            }
            if (!File.Exists(FilePath))
            {
                return;
            }
            ConfirmationButtonNotificationForm.Instance.OpenNotification(this);
        }

        public override NotificationControlForm GetControllerForm()
        {
            return new ConfirmationButtonControlForm();
        }

        public override string ToString()
        {
            return $"通知方法：通知ボタン, タイトル：{NotificationTitle}, 音量：{Volume}, ファイルパス：{FilePath}";
        }
    }
}
