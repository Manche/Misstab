using Misstab.Common.Notification.Baloon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misstab.Common.Notification.Http
{
    public partial class HttpRequestControlForm : NotificationControlForm
    {
        public HttpRequestControlForm()
        {
            base.Initialize();
        }

        public override void LoadDataToControl(NotificationController Controller)
        {
        }

        public override NotificationController SaveDataToControl(NotificationController Controller)
        {
            return Controller;
        }
    }
}
