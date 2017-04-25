using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class MyClassPropG
    {
        #region snippet

        /// <summary>
        /// NewProperty プロパティのバッキングフィールドです。
        /// </summary>
        private String valueOfNewProperty;

        /// <summary>
        /// 値を取得します。
        /// </summary>
        public String NewProperty{
            get{
                return this.valueOfNewProperty;
            } // end get
        } // end property

        #endregion
    }
}
