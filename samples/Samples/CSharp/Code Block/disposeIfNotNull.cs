using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class MyClass
    {

        private IDisposable disposableMember;


        private void SampleDisposeIfNotNull()
        {

            #region snippets

            if (this.disposableMember != null){
                this.disposableMember.Dispose();
                this.disposableMember = null;
            } // end if

            #endregion
        }
    }
}
