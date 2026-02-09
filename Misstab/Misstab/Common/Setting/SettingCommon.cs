using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misstab.Common.Setting
{
    /// <summary>
    /// 全ての共通設定
    /// </summary>
    public class SettingCommon : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// シングルトン
        /// </summary>
        public static SettingCommon Instance { get; } = new SettingCommon();
        public SettingCommon()
        {
        }

        /// <summary>
        /// 低スペックモード
        /// </summary>
        public bool LowSpecMode { get; set; } = true;
    }
}
