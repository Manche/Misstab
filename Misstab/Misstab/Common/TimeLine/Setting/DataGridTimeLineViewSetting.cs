using Misstab.Common.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misstab.Common.TimeLine.Setting
{
    public class DataGridTimeLineViewSetting
    {
        public int MaxTimeLineItemCount { get; set; } = SettingTimeLineConst.MAX_TIMELINE_COUNT;

        public Color ForeColorReplayed { get { return ColorTranslator.FromHtml("#"+ _ForeColorReplayedRaw); } }
        public string _ForeColorReplayedRaw { get; set; } = $"{Color.Orange.R:X2}{Color.Orange.G:X2}{Color.Orange.B:X2}";
        public Color ForeColorPostPublic { get { return ColorTranslator.FromHtml("#" + _ForeColorPostPublic); } }
        public string _ForeColorPostPublic { get; set; } = $"{Color.Black.R:X2}{Color.Black.G:X2}{Color.Black.B:X2}";
        public Color ForeColorPostHome { get { return ColorTranslator.FromHtml("#" + _ForeColorPostHome); } }
        public string _ForeColorPostHome { get; set; } = $"{Color.Blue.R:X2}{Color.Blue.G:X2}{Color.Blue.B:X2}";
        public Color ForeColorPostDirect { get { return ColorTranslator.FromHtml("#" + _ForeColorPostDirect); } }
        public string _ForeColorPostDirect { get; set; } = $"{Color.Red.R:X2}{Color.Red.G:X2}{Color.Red.B:X2}";
        public Color ForeColorPostFollower { get { return ColorTranslator.FromHtml("#" + _ForeColorPostFollower); } }
        public string _ForeColorPostFollower { get; set; } = $"{Color.Purple.R:X2}{Color.Purple.G:X2}{Color.Purple.B:X2}";
        public Color ForeColorPostRenote { get { return ColorTranslator.FromHtml("#" + _ForeColorPostRenote); } }
        public string _ForeColorPostRenote { get; set; } = $"{Color.Green.R:X2}{Color.Green.G:X2}{Color.Green.B:X2}";
        public Color ForeColorPostIsLocal { get { return ColorTranslator.FromHtml("#" + _ForeColorPostIsLocal); } }
        public string _ForeColorPostIsLocal { get; set; } = $"{Color.Red.R:X2}{Color.Red.G:X2}{Color.Red.B:X2}";
        public Color ForeColorPostIsUnion { get { return ColorTranslator.FromHtml("#" + _ForeColorPostIsUnion); } }
        public string _ForeColorPostIsUnion { get; set; } = $"{Color.Green.R:X2}{Color.Green.G:X2}{Color.Green.B:X2}";
        public Color ForeColorPostIsChannel { get { return ColorTranslator.FromHtml("#" + _ForeColorPostIsChannel); } }
        public string _ForeColorPostIsChannel { get; set; } = $"{Color.Green.R:X2}{Color.Green.G:X2}{Color.Green.B:X2}";

        public Color BackColorPostIsRenote { get { return ColorTranslator.FromHtml("#" + _BackColorPostIsRenote); } }
        public string _BackColorPostIsRenote { get; set; } = $"{Color.LightGreen.R:X2}{Color.LightGreen.G:X2}{Color.LightGreen.B:X2}";
        public Color BackColorPostIsReplayed { get { return ColorTranslator.FromHtml("#" + _BackColorPostIsReplayed); } }
        public string _BackColorPostIsReplayed { get; set; } = $"{Color.Beige.R:X2}{Color.Beige.G:X2}{Color.Beige.B:X2}";
        public Color BackColorPostIsCW { get { return ColorTranslator.FromHtml("#" + _BackColorPostIsCW); } }
        public string _BackColorPostIsCW { get; set; } = $"{Color.LightGray.R:X2}{Color.LightGray.G:X2}{Color.LightGray.B:X2}";
    }
}
