using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class MyClass
    {
        public void SampleNullWEx(string value)
        {
            #region snippet

            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("value に 空白文字、空、および null 参照 (Visual Basic の場合は Nothing) を指定することは出来ません。", "value");

            #endregion
        }
    }
}
