using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    #region snippet

    /// <summary>
    /// Static class which is defined extension methods for IEnumerable&lt;T&gt;.
    /// </summary>
    public static partial class IEnumerableExtensions
    {
        /// <summary>
        /// Performs the specified action on each element of the IEnumerable&lt;T&gt;, and return it.
        /// </summary>
        /// <param name="me">The instance of the type which is added this extension method.</param>
        /// <param name="action">The Action&lt;T&gt; delegate to perform on each element of the List&lt;T&gt;.</param>
        /// <returns>
        /// Return the IEnumerable&lt;T&gt;.
        /// </returns>
        /// <exception cref="ArgumentNullException">action is null reference (Nothing in Visual Basic).</exception>
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
