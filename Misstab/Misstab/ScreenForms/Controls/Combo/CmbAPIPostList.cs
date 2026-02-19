using Misstab.Common.Connection.VersionInfo;
using Misstab.Common.Connection.WebSocket;
using Misstab.Common.Connection.WebSocket.Misskey.v2025;
using Misstab.Common.TimeLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misstab.ScreenForms.Controls.Combo
{
    internal class CmbAPIPostList
    {
        private int _InternalKey { get; set; }
        public int InternalKey { get { return _InternalKey; } }
        private string _Host { get; set; }
        public string Host { get { return _Host; } }

        // あとでhostとversioninfo以外消すかも
        private string? _APIKey { get; set; }
        public string? APIKey { get { return _APIKey; } }

        private CSoftwareVersionInfo _VersionInfo { get; set; }
        public CSoftwareVersionInfo VersionInfo { get { return _VersionInfo; } }
        public CmbAPIPostList(int k, WebSocketManager c)
        {
            this._InternalKey = k;

            this._Host = c._HostDefinition;
            this._VersionInfo = c.SoftwareVersion;
            this._APIKey = c.APIKey;
        }
        public override string ToString()
        {
            return Host + "/" + VersionInfo;
        }
    }
}
