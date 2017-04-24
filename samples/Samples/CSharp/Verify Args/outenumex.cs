using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class MyClassOutEnumEx
    {
        private enum EnumType
        {
            None,
            Value1,
            Value2,            
        }

        private void SampleOutEnumEx(EnumType value)
        {
            #region snippet

            #region Validating value argument

            // When it is useful enumeration, do nothing. Otherwise, throw exception.
            switch (value)
            {
                // TODO: Delete "default:" which is redundant, and delete "case" of which are not useful.
                case EnumType.Value1:
                    break;

                default:
                    throw new ArgumentOutOfRangeException("value", "Cannot provide what is not supported enumeration.");

            }
            #endregion

            #endregion
        }
    }
}
