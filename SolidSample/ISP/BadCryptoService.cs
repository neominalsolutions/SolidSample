using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.ISP
{
  // Interfacelere fazla sorumlulık vermeyerek bu sorunu çözebiliriz.

  public interface ICrypto
  {
    string Decrypt(string cipherText); // IDecrypt
    string Encrypt(string plainText); // IEncrypt olarak ayırıcağız.
  }

  
  public class BadCryptoService : ICrypto
  {
    // Decrpyte edemez.
    // Problem Hash alogritmaları gereye dönük şifre çözme işlemi gerçekleştiremez fakat ICrypto interface bizi bu duruma zorluyor
    // bu durumda decrypt methodu boşa çıkıyor.
    public string Decrypt(string cipherText)
    {
      throw new NotImplementedException();
    }

    public string Encrypt(string plainText)
    {
      throw new NotImplementedException();
    }
  }


}
