using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    #region snippet

    /// <summary>
    /// IEnumerable&lt;T&gt; に対する拡張メソッドを定義する静的クラスです。
    /// </summary>
    public static partial class IEnumerableExtensions
    {
        /// <summary>
        /// 反復処理を実行し、列挙子をそのまま返します。
        /// </summary>
        /// <param name="me">拡張メソッドを追加する元の型のオブジェクトです。</param>
        /// <param name="action">要素に対して実行する反復処理を指定します。</param>
        /// <returns>
        /// 列挙子をそのまま返します。
        /// </returns>
        /// <exception cref="ArgumentNullException">null 参照 (Visual Basic では Nothing) を指定した時</exception>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> me, Action<T> action){
            if (me == null) throw new ArgumentNullException("me");
            if (action == null) throw new ArgumentNullException("action");

            if (action != null){
                foreach (var item in me){
                    action(item);
                }// next item
            } // end if

            return me;
        } // end function
    } // end class

    #endregion
}
