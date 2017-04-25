using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region snippet

namespace NameSpace{

    /// <summary>
    /// 拡張メソッドを定義する静的クラスです。
    /// </summary>
    public static class MyExtensions{

        /// <summary>
        /// 処理を実行し、結果を取得します。
        /// </summary>
        /// <param name="me">拡張メソッドを追加する元の型のオブジェクトです。</param>
        /// <param name="arg1">値を指定します。</param>
        /// <returns>
        /// 処理に成功したときは True を返します。それ以外は False を返します。
        /// </returns>
        public static bool Execute(this String me, string arg1){
            if (me == null) throw new ArgumentNullException("me");


            throw new NotImplementedException();
        } // end function
    } // end class
} // end namespace

#endregion
