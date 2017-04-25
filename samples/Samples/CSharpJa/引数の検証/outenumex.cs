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

            #region 引数 value の検証

            // 使用できる値は何もしません。使用できない値は例外をスローします。
            switch (value)
            {
                // TODO: 重複する default: と、使用できない値の case を削除します。
                case EnumType.Value1:
                    break;

                default:
                    throw new ArgumentOutOfRangeException("value", "サポートされていない値を指定することは出来ません。");

            }
            #endregion

            #endregion
        }
    }
}
