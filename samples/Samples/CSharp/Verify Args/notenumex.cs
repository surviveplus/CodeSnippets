using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class MyClassNotEnumEx
    {
        private enum EnumType {
            None
        }

        private void SampleNotEnumEx(EnumType value)
        {
            #region snippet

            // TODO: This validating arguments isn't recommended. Use outenumex instead. After due consideration of dangers, delete this comment to use it.
            if (System.Enum.IsDefined(typeof(EnumType), value) == false) throw new ArgumentOutOfRangeException("value", "Cannot provide what is not defined EnumType enumeration.");

            #endregion
        }
    }
}
