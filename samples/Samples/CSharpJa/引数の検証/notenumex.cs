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

            // TODO: この引数の検証方法は推奨されません。代わりに outenumex を使用します。危険性を理解して使用する場合は、このコメントを削除します。
            if (System.Enum.IsDefined(typeof(EnumType), value) == false) throw new ArgumentOutOfRangeException("value", "EnumType 型として定義されていない値を指定することは出来ません。");

            #endregion
        }
    }
}
