using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class MyClass
    {
        public void SampleRecursionLambda()
        {
            #region snippet

            // Recursion Lambda
            Action<System.IO.DirectoryInfo, Action<System.IO.DirectoryInfo>> recursion = null;
            recursion = (folder, exec) =>
            {
                exec(folder);

                foreach (var item in folder.GetDirectories())
                {
                    recursion(item, exec);
                } // next item
            };

            // Act with Recursion
            var targetFolder = new System.IO.DirectoryInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            recursion(targetFolder, (folder) =>
           {
               Console.WriteLine(folder.FullName);
           });

            #endregion
        }
    }
}
