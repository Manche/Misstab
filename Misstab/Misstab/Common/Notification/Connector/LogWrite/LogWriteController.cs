using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misstab.Common.Notification.Connector.LogWrite
{
    public class LogWriteController : NotificationConnectorController
    {
        public const string ControllerName = "ファイル書き出し";
        /// <summary>
        /// ファイルパス
        /// </summary>
        public string FilePath { get; set; } = string.Empty;
        /// <summary>
        /// 書き出し詳細
        /// </summary>
        public string FileDetail { get; set; } = string.Empty;

        public LogWriteController()
        {
            this._ControllerKind = CONTROLLER_KIND.LogWrite;
        }

        public override void ExecuteMethod()
        {
            throw new NotImplementedException();
        }

        public override NotificationControlForm GetControllerForm()
        {
            return new LogWriteControlForm();
        }

        public override string ToString()
        {
            return $"通知方法：ファイル書き出し, {"未実装"}";
        }
    }

    public class LogWriteProcess
    {
        public static LogWriteProcess Instance { get; } = new LogWriteProcess();
    }
}
