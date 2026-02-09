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

        public Color ForeColorReplayed { get; set; } = Color.Orange;
        public Color ForeColorPostPublic { get; set; } = Color.Black;
        public Color ForeColorPostHome { get; set; } = Color.Blue;
        public Color ForeColorPostDirect { get; set; } = Color.Red;
        public Color ForeColorPostFollower { get; set; } = Color.Purple;
        public Color ForeColorPostRenote { get; set; } = Color.Green;
        public Color ForeColorPostIsLocal { get; set; } = Color.Red;
        public Color ForeColorPostIsUnion { get; set; } = Color.Green;
        public Color ForeColorPostIsChannel { get; set; } = Color.Green;

        public Color BackColorPostIsRenote { get; set; } = Color.LightGreen;
        public Color BackColorPostIsReplayed { get; set; } = Color.Beige;
        public Color BackColorPostIsCW { get; set; } = Color.LightGray;
    }
}
