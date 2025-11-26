using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiViewProxyServer.WebSocket
{
    internal class WebSocketConnection
    {
        /// <summary>
        /// シングルトンインスタンス
        /// </summary>
        public static WebSocketConnection Instance { get; private set; } = new WebSocketConnection();
    }



    internal class WebSocketConnectionData
    {
        public string URL { get; set; } = string.Empty;
        public string APIKey { get; set; } = string.Empty;
    }
}
