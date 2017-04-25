using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    #region 

    /// <summary>
    /// Object 型に対する拡張メソッドを定義する静的クラスです。
    /// </summary>
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// インスタンス自身を要素として1つだけ返す列挙子を返します。
        /// </summary>
        /// <typeparam name="T">要素の型</typeparam>
        /// <param name="me">拡張メソッドを追加する元の型のオブジェクトです。null 参照 (Visual Basic では Nothing) を指定した時は、空の列挙子を返します。</param>
        /// <returns>インスタンス自身を要素として1つだけ返す列挙子を返します。</returns>
        /// <remarks>
        /// <para>次のサンプルコードを実行すると、list は IEnumerable&lt;int&gt; となります。</para>
        /// <code>
        /// int a = 0;
        /// var list = a.Singleton();
        /// </code>
        /// </remarks>
        public static IEnumerable<T> Singleton<T>(this T me){

            if (me != null){
                yield return me;
            } // end if

        } // end function
    } // end class

    #endregion
}

