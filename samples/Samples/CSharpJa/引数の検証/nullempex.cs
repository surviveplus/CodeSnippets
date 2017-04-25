using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp
{
    partial class MyClass
    {
        public void SampleNullEmpEx(string value)
        {
            #region snippet

            if (string.IsNullOrEmpty(value)) throw new ArgumentException("value に Empty 文字、および null 参照 (Visual Basic の場合は Nothing) を指定することは出来ません。", "value");

            #endregion
        }
    }
}
