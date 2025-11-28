using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Misstab.Common.Connection.WebSocket.Structures
{
    /// <summary>
    /// main structure
    /// </summary>
    public class ConnectMain
    {
        public string? type { get; set; }
        public ConnectMainBody? body { get; set; }
    }

    /// <summary>
    /// body
    /// </summary>
    public class ConnectMainBody
    {
        public string? channel { get; set; }
        public string? id { get; set; }
        // public ConnectMainParams? @params { get;set; }
    }

    public class ConnectMainParams
    {
    }
}
