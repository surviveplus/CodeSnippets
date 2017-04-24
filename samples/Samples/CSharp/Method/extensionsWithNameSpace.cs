using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region snippet

namespace NameSpace{

    /// <summary>
    /// Static class which is defined extension methods.
    /// </summary>
    public static class MyExtensions{

        /// <summary>
        /// Do something, and return something.
        /// </summary>
        /// <param name="me">The instance of the type which is added this extension method.</param>
        /// <param name="arg1">Set something.</param>
        /// <returns>
        /// Returns true if succeeded; otherwise returns false.
        /// </returns>
        public static bool Execute(this String me, string arg1){
            if (me == null) throw new ArgumentNullException("me");

            throw new NotImplementedException();
        } // end function
    } // end class
} // end namespace

#endregion
