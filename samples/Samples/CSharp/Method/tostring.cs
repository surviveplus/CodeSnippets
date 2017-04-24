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
		/// Returns a string that represents the current object.
		/// </summary>
		/// <returns>A string that represents the current object.</returns>
		public override string ToString(){

            // Output all properties as like anonymous types ToString method.

            // A lambda expression to format its name and value.
            Func<string, object, string> formmat = (name, value) =>
            {
                if (value == null)
                {
                    return name + " = null reference (Nothing in Visual Basic)";
                }
                else
                {
                    return name + " = " + value.ToString();
                } // end if;
            };

            // Find and output its public properties.
            var nameAndValues =
                from p in this.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                select formmat(p.Name, p.GetValue(this));

            return "{ " + string.Join(", ", nameAndValues) + " }";
        } // end function 

        #endregion
    }
}
