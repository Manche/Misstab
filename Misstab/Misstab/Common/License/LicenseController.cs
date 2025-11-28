using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misstab.Common.License
{
    /// <summary>
    /// ライセンスコントローラ
    /// </summary>
    public class LicenseController
    {
        public static LicenseController Instance { get; } = new LicenseController();

        /// <summary>
        /// 適用プラン
        /// </summary>
        public enum PAYMENT_PLAN
        {
            /// <summary>
            /// 開発者
            /// </summary>
            DEVELOP = -9999,

            /// <summary>
            /// 未指定
            /// </summary>
            None = 0,

            /// <summary>
            /// 通常
            /// </summary>
            NORMAL,

            /// <summary>
            /// 支払ずみ
            /// </summary>
            PAYED,
        }
        public PAYMENT_PLAN _Plan { get; set; } = PAYMENT_PLAN.None;
    }
}
