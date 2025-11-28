using Misstab.Common.TimeLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misstab.Common.Connection.WebSocket.Event
{
    public class DataContainerEventArgs : EventArgs
    {
        public TimeLineContainer? Container { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public DataContainerEventArgs()
        {
        }
    }
}
