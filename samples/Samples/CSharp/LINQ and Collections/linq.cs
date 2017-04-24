using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class MyClass
    {
        public void SampleLinq()
        {
            IEnumerable<object> items = new object[] {};

            #region snippet

            var result =
                from item in items
                select item;

            #endregion
        }
    }
}
