using Misstab.Common.Connection.WebSocket.Event;
using Misstab.Common.Connection.WebSocket.Structures;
using Misstab.Common.TimeLine;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Misstab.Common.Connection.WebSocket.Misskey.v2025
{
    internal class WebSocketTimeLineHome : WebSocketTimeLineCommon
    {
        /// <summary>
        /// 接続識別子
        /// </summary>
        protected override ConnectMainBody _WebSocketConnectionObj
        {
            get { return new ConnectMainBody() { channel = "homeTimeline", id = "hoge" }; }
        }
        /// <summary>
        /// タイムライン種類
        /// </summary>
        protected override TimeLineBasic.ConnectTimeLineKind _TLKind
        {
            set; get;
        } = TimeLineBasic.ConnectTimeLineKind.Home;
    }

    internal class WebSocketTimeLineSocial : WebSocketTimeLineCommon
    {
        /// <summary>
        /// 接続識別子
        /// </summary>
        protected override ConnectMainBody _WebSocketConnectionObj
        {
            get { return new ConnectMainBody() { channel = "hybridTimeline", id = "hoge" }; }
        }
        /// <summary>
        /// タイムライン種類
        /// </summary>
        protected override TimeLineBasic.ConnectTimeLineKind _TLKind
        {
            set; get;
        } = TimeLineBasic.ConnectTimeLineKind.Social;
    }


    internal class WebSocketTimeLineGlobal : WebSocketTimeLineCommon
    {
        /// <summary>
        /// 接続識別子
        /// </summary>
        protected override ConnectMainBody _WebSocketConnectionObj
        {
            get { return new ConnectMainBody() { channel = "globalTimeline", id = "hoge" }; }
        }
        /// <summary>
        /// タイムライン種類
        /// </summary>
        protected override TimeLineBasic.ConnectTimeLineKind _TLKind
        {
            set; get;
        } = TimeLineBasic.ConnectTimeLineKind.Global;
    }


    internal class WebSocketTimeLineLocal : WebSocketTimeLineCommon
    {
        /// <summary>
        /// 接続識別子
        /// </summary>
        protected override ConnectMainBody _WebSocketConnectionObj
        {
            get { return new ConnectMainBody() { channel = "localTimeline", id = "hoge" }; }
        }
        /// <summary>
        /// タイムライン種類
        /// </summary>
        protected override TimeLineBasic.ConnectTimeLineKind _TLKind
        {
            set; get;
        } = TimeLineBasic.ConnectTimeLineKind.Local;
    }

    internal class WebSocketTimeLineNoteSubScribe : WebSocketTimeLineCommon
    {
        public string Type { get; set; } = string.Empty;
        public string BodyId { get; set; } = string.Empty;
    }
}
