using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class MyClass
    {
        private object member;

        public object SampleReturnIfNullNew()
        {

            #region snippet

            if (this.member == null){
                this.member = new Object();
            } // end if
            return this.member;

            #endregion
        }
    }
}
