using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Misstab.Common.AnalyzeData.Format.Misskey.v2025
{
    public class NoteUpdatedInfo
    {
        public static NoteUpdatedInfo Get(JsonNode Input) { return new NoteUpdatedInfo() { Node = Input }; }
        public JsonNode? Node { get; set; }
        public JsonNode? Body { get { return Node?["body"]; } }
        public JsonNode? Type { get { return Body?["type"]; } }
        public JsonNode? Id { get { return Body?["id"]; } }
    }
}
