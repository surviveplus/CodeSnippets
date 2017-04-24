using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    #region snippet

    /// <summary>
    /// Static class which is defined extension methods for Object.
    /// </summary>
    public static partial class ObjectExtensions
    {

        /// <summary>
        /// Return the IEnumerable&lt;T&gt; for a classic collection that do not implement IEnumerable&lt;T&gt; but it is possible to be set on foreach.
        /// </summary>
        /// <typeparam name="T">The type of this elements.</typeparam>
        /// <param name="me">The instance of the type which is added this extension method. Set a null reference (Nothing in Visual Basic), to return empty IEnumerable&lt;T&gt;.</param>
        /// <returns>
        /// Return the IEnumerable&lt;T&gt;.
        /// </returns>
        public static IEnumerable<T> ToEnumerable<T>(this Object me)
        {
            if (me != null)
            {
                dynamic list = me;

                foreach (T item in list)
                {
                    yield return item;
                } // next item
            } // end if

        } // end function
    } // end class

    #endregion
}
