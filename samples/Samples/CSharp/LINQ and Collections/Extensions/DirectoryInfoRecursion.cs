using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    #region snippet

    /// <summary>
    /// Static class which is defined extension methods for System.IO.DirectoryInfo.
    /// </summary>
    public static partial class DirectoryInfoExtensions
    {
        /// <summary>
        /// Do something to a specified folder and children folders with recursion.
        /// </summary>
        /// <param name="me">The instance of the type which is added this extension method.</param>
        /// <param name="act">Set a action to do to a folder.</param>
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
