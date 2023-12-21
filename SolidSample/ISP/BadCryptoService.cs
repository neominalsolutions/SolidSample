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

  
  public class BadCryptoService : ICrypto // HashService
  {
    // Decrpyte edemez.
    // Problem Hash alogritmaları gereye dönük şifre çözme işlemi gerçekleştiremez fakat ICrypto interface bizi bu duruma zorluyor
    // bu durumda decrypt methodu boşa çıkıyor.
    public string Decrypt(string cipherText) // dummy Method hataya müsait bir yapı
    {
      throw new NotImplementedException();
    }

    public string Encrypt(string plainText)
    {
      return "324324A-324dsadaA";
    }
  }


}
