using MiView.Common.Connection.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiView.Common.TimeLine.Event
{
    public class DataGridTimeLineAddedEvent : EventArgs
    {
        public bool IsAdded { get; set; } = false;
        public bool IsOrigin {  get; set; } = false;
        public TimeLineContainer? Container { get; set; }
        public DataGridTimeLine? DataGridTimeLine { get; set; }
        public int RowIndex { get; set; }
        public WebSocketManager? WebSocketManager { get; set; }
    }

    public class DataGridTimeLineUpdateEvent : EventArgs
    {
        public enum EventType
        {
            NONE,
            DELETE,
            UPDATE,
            REACTED,
        }
        public EventType EventKind { get; set; } = EventType.NONE;

        public int RowIndex { get; set; }
    }
}
