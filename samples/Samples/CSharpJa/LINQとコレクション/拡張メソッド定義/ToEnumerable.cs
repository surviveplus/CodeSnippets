using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    #region snippet

    /// <summary>
    /// Object 型に対する拡張メソッドを定義する静的クラスです。
    /// </summary>
    public static partial class ObjectExtensions{

        /// <summary>
        /// foreach は可能だが IEnumerable&lt;T&gt; は実装していない クラシック コレクション を反復処理する列挙子を返します。
        /// </summary>
        /// <typeparam name="T">要素の型</typeparam>
        /// <param name="me">拡張メソッドを追加する元の型のオブジェクトです。null 参照 (Visual Basic では Nothing) を指定した時は、空の列挙子を返します。</param>
        /// <returns>
        /// 指定された T型 を反復する列挙子を返します。
        /// </returns>
        public static IEnumerable<T> ToEnumerable<T>(this Object me){
            if (me != null){
                dynamic list = me;

                foreach (T item in list){
                    yield return item;
                } // next item
            } // end if

        } // end function
    } // end class

    #endregion
}
