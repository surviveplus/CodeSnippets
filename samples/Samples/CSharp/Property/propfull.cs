using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class MyClass
    {
        #region snippet

        /// <summary>
        /// Backing field of NewProperty property.
        /// </summary>
        private String valueOfNewProperty;

        /// <summary>
        /// Gets or sets the value of something.
        /// </summary>
        public String NewProperty{
            get{
                return this.valueOfNewProperty;
            } // end get
            set{
                this.valueOfNewProperty = value;
            } // end set
        } // end property

        #endregion
    }
}
