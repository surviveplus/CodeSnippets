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
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを説明する文字列。</returns>
        public override string ToString(){

            // 匿名型の ToString 同様に、各プロパティの内容を全て出力します。

            // 名前と値をフォーマットするラムダ式
            Func<string, object, string> formmat = (name, value) =>{
                if (value == null){
                    return name + " = null 参照 ( Visual Basic の場合は Nothing )";
                }else{
                    return name + " = " + value.ToString();
                } // end if;
            };

            // パブリックメンバーを探して出力します。
            var nameAndValues =
                from p in this.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                select formmat(p.Name, p.GetValue(this));

            return "{ " + string.Join(", ", nameAndValues) + " }";
        } // end function 

        #endregion
    }
}
