using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class MyClass
    {
        #region snippet

        /// <summary>
        /// NewProperty プロパティのバッキングフィールドです。
        /// </summary>
        private String valueOfNewProperty;

        /// <summary>
        /// 値を取得または設定します。
        /// </summary>
        public String NewProperty{
            get{
                return this.valueOfNewProperty;
            } // end get
            set{
                this.valueOfNewProperty = value;
            } // end set
        } // end property

        #endregion
    }
}
