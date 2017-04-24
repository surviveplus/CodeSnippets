using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    #region snippet

    /// <summary>
    /// Static class which is defined extension methods for EventHandler&lt;T&gt;.
    /// </summary>
    public static class EventHandlerExtensions
    {
        /// <summary>
        /// Raise the event.
        /// </summary>
        /// <param name="me">The instance of the type which is added this extension method.</param>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An System.EventArgs that contains the event data.</param>
        public static void Raise<T>(this EventHandler<T> me, object sender, T e) where T : EventArgs{
            if (me != null) me(sender, e);
        } // end function
    } // end class

    #endregion
}
