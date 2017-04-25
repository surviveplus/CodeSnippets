using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class MyClass
    {
        public void SampleNullEx(object value)
        {
            #region snippet

            if (value == null) throw new ArgumentNullException("value");

            #endregion
        }
    }
}
