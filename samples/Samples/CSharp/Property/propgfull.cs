using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class MyClassPropG
    {
        #region snippet

        /// <summary>
        /// Backing field of NewProperty property.
        /// </summary>
        private String valueOfNewProperty;

        /// <summary>
        /// Gets the value of something.
        /// </summary>
        public String NewProperty
        {
            get
            {
                return this.valueOfNewProperty;
            } // end get
        } // end property

        #endregion
    }
}
