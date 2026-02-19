using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Misstab.Common.Connection.REST.Misskey.v2025.API.Notes
{
    public class Notes : MisskeyAPIController
    {
    }

    public class CreateNotes : Notes
    {
        public string? channelId { get; set; }
        public string? cw { get; set; }
        public string[] fileIds { get; set; } = Enumerable.Repeat(string.Empty, 16).ToArray();
        public bool localOnly { get; set; } = false;
        public string[] mediaIds { get; set; } = Enumerable.Repeat(string.Empty, 16).ToArray();
        public bool noExtractEmojis { get; set; } = false;
        public bool noExtractHashTags { get; set; } = false;
        public bool noExtractMentions { get; set; } = false;

        public enum ReactionAcceptances
        {
            NULL,
            LikeOnly,
            LikeOnlyForRemote,
            NonSensitiveOnly,
            NonSensitiveOnlyForLocalLikeOnlyForRemote
        }
        public readonly Dictionary<ReactionAcceptances, string> ReactionAcceptanceName =
            new Dictionary<ReactionAcceptances, string>()
            {
                {ReactionAcceptances.NULL, "null" },
                {ReactionAcceptances.LikeOnly, "LikeOnly" },
                {ReactionAcceptances.LikeOnlyForRemote, "LikeOnlyForRemote" },
                {ReactionAcceptances.NonSensitiveOnly, "NonSensitiveOnly" },
                {ReactionAcceptances.NonSensitiveOnlyForLocalLikeOnlyForRemote, "NonSensitiveOnlyForLocalLikeOnlyForRemote" }
            };
        public string? reactionAcceptance { get; set; }
        public string? renoteId { get; set; }
        public string? replyId { get; set; }
        public string? text { get; set; }
        public enum Visibilities
        {
            Public,
            Home,
            Followers,
            Specified
        }
        public readonly Dictionary<Visibilities, string> VisibilityNames =
            new Dictionary<Visibilities, string>()
            {
                {Visibilities.Public, "Public" },
                {Visibilities.Home, "Home"},
                {Visibilities.Followers, "Followers" },
                {Visibilities.Specified, "Specified" },
            };
        public string? visibility { get; set; } = "public";
        public JsonObject CreateRequestBody(string Text)
        {
            var i = new CreateNotes();
            i.text = Text;

            var j = JsonNode.Parse(JsonSerializer.Serialize(i))?.AsObject();

            List<string> v;
            v = i.fileIds.Distinct().Where(r => !string.IsNullOrEmpty(r)).ToList();
            i.fileIds = v.ToArray();
            v = i.mediaIds.Distinct().Where(r => !string.IsNullOrEmpty(r)).ToList();
            i.mediaIds = v.ToArray();






            v = i.fileIds.Distinct().Where(r => !string.IsNullOrEmpty(r)).ToList();
            if (v.Count == 0)
            {
                j.Remove("fileIds");
            }

            v = i.mediaIds.Distinct().Where(r => !string.IsNullOrEmpty(r)).ToList();
            if (v.Count == 0)
            {
                j.Remove("mediaIds");
            }

            return j;
        }

        public static bool EasyPostNote(string Text, string Host, string APIKey)
        {
            var i = new CreateNotes();
            var Ctl = MisskeyAPIController.CreateInstance(MisskeyAPIConst.API_ENDPOINT.NOTES_CREATE);
            try
            {
                Ctl.Request(Host, APIKey, i.CreateRequestBody(Text));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                return false;
            }
            return Ctl.State == ControllerState.Finish;
        }
    }
}
