using MisstabProxyServer.WebSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisstabProxyServer.ScreenForms
{
    public partial class WebSocketControlForm : Form
    {
        public WebSocketControlForm()
        {
            InitializeComponent();

            WebSocketController.Instance.ServerRunner();
        }
    }
}
