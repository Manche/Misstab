using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misstab.Common.TimeLine.Stastics
{
    public class TimeLineStastics
    {
        /// <summary>
        /// タブ識別値
        /// </summary>
        public string? TabDefinition { get; set; }
        /// <summary>
        /// タブ名
        /// </summary>
        public string? TabName {  get; set; }
        /// <summary>
        /// 最終更新日時
        /// </summary>
        public DateTime? LatestUpdate { get; set; } = DateTime.MinValue;

        /// <summary>
        /// ノート数
        /// </summary>
        public int NoteCount { get; set; } = 0;
        /// <summary>
        /// 内部ノート数
        /// </summary>
        public int AllNoteCount { get; set; } = 0;
        public DateTime LatestPostUpdate {  get; set; } = DateTime.MinValue;
        public int MemorySize { get; set; } = 0;
    }
}
