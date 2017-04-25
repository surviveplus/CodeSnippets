using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    #region snippet

    /// <summary>
    /// EventHandler&lt;T&gt; に対する拡張メソッドを定義する静的クラスです。
    /// </summary>
    public static class EventHandlerExtensions
    {
        /// <summary>
        /// イベントを発生させます。
        /// </summary>
        /// <param name="me">拡張メソッドを追加する元の型のオブジェクトです。</param>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains the event data.</param>
        public static void Raise<T>(this EventHandler<T> me, object sender, T e) where T : EventArgs{
            if (me != null) me(sender, e);
        } // end function
    } // end class

    #endregion
}
