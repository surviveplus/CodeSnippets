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

            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Cannot provide white-space characters, the empty string or a null reference (Nothing in Visual Basic) to value.", "value");

            #endregion
        }
    }
}
