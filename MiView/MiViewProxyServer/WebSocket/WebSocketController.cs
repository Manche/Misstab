using Fleck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MiViewProxyServer.WebSocket
{
    /// <summary>
    /// webｿｹコントローラ
    /// </summary>
    internal class WebSocketController
    {
        /// <summary>
        /// シングルトンインスタンス
        /// </summary>
        public static WebSocketController Instance { get; private set; } = new WebSocketController();
        /// <summary>
        /// リッスン状態
        /// </summary>
        public bool _ListenStatus = false;
        public void ServerRunner()
        {
            var Server = new WebSocketServer("ws//127.0.0.1:38888");
            Server.RestartAfterListenError = true;

            Server.Start(Sock =>
            {
                Sock.OnOpen = () => Console.WriteLine("Open");
            });
        }
    }
}
