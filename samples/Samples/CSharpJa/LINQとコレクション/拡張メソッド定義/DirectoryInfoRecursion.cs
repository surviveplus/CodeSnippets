using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    #region snippet

    /// <summary>
    /// System.IO.DirectoryInfo に対する拡張メソッドを定義する静的クラスです。
    /// </summary>
    public static partial class DirectoryInfoExtensions{
        /// <summary>
        /// 指定されたフォルダとサブフォルダについて、指定された処理を再帰的に実行します。
        /// </summary>
        /// <param name="me">拡張メソッドを追加する元の型のオブジェクトです。</param>
        /// <param name="act">フォルダに対して実行する処理を指定します。</param>
        public static void Recursion(this System.IO.DirectoryInfo me, Action<System.IO.DirectoryInfo> act){
            if (me == null) throw new ArgumentNullException("me");
            if (act == null) throw new ArgumentNullException("act");

            act(me);

            foreach (var d in me.GetDirectories()){
                d.Recursion(act);
            } // next d

        } // end function
    } // end class

    #endregion
}
