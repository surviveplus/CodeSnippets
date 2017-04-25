using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Implements_Interface
{
    public class DispoaseSampleClass : IDisposable
    {
        #region snippet

        #region IDisposable メンバー

        /// <summary>
        /// アンマネージ リソースの解放およびリセットに関連付けられているアプリケーション定義のタスクを実行します。
        /// </summary>
        public void Dispose(){
            this.Dispose(true);
            GC.SuppressFinalize(this);
        } // end sub

        /// <summary>
        /// インスタンスを解放します。
        /// </summary>
        ~DispoaseSampleClass(){
            this.Dispose(false);
        }

        /// <summary>
        /// 重複する呼び出しを検出するために使用されるバッキングフィールドです。
        /// </summary>
        private bool disposedValue = false;

        /// <summary>
        /// インスタンスが使用しているアンマネージオブジェクト、およびマネージオブジェクトを解放します。
        /// </summary>
        /// <param name="disposing">マネージオブジェクトを明示的に解放する時は True を指定します。それ以外は False を指定します。</param>
        protected virtual void Dispose(bool disposing){

            if (this.disposedValue == false){
                if (disposing){
                    // TODO: マネージ オブジェクトを解放します。
                } // end if

                // TODO: アンマネージ オブジェクトを解放します。
            } // end if

            this.disposedValue = true;
        } // end sub

        #endregion

        #endregion
    }
}
