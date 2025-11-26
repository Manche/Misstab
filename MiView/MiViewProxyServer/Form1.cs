using MiViewProxyServer.WebSocket;

namespace MiViewProxyServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebSocketController.Instance.Runner();
        }
    }
}
