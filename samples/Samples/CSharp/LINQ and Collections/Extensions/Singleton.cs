using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    #region 

    /// <summary>
    /// Static class which is defined extension methods for System.Object.
    /// </summary>
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// Return the IEnumerable&lt;T&gt; which contains only this instance.
        /// </summary>
        /// <typeparam name="T">The type of this instance.</typeparam>
        /// <param name="me">The instance of the type which is added this extension method. Set a null reference (Nothing in Visual Basic), to return empty IEnumerable&lt;T&gt;.</param>
        /// <returns>Return the IEnumerable&lt;T&gt; which contains only this instance.</returns>
        /// <remarks>
        /// <para>In this sample code, list is IEnumerable&lt;int&gt;.</para>
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

