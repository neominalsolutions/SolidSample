using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.ISP
{
  // Şifreleyici bir interface oluşturmamız istendi.
  public interface ICryptor:IEncryptor,IDecryptor
  {
    ///// <summary>
    ///// Gönderilen bir düz metni şifreler.
    ///// </summary>
    ///// <param name="plainText"></param>
    ///// <returns></returns>
    //string Encrypt(string plainText);

    ///// <summary>
    ///// Şifrelenmiş bir metni çözer.
    ///// </summary>
    ///// <param name="cipherText"></param>
    ///// <returns></returns>
    //string Decrypt(string cipherText);
  }
}
