using Misstab.Common.Connection.WebSocket;
using Misstab.Common.TimeLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misstab.ScreenForms.Controls.Combo
{
    public class CmbVisibility
    {
        public TimeLineContainer.PROTECTED_STATUS TLKind { get; set; }
        public string Display { get { return TimeLineContainer.Protected_Disp[TLKind]; } }

        public CmbVisibility(TimeLineContainer.PROTECTED_STATUS Kind)
        {
            TLKind = Kind;
        }

        public override string ToString()
        {
            return Display;
        }
    }
}
