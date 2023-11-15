using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.ISP
{
  public interface IDecryptor
  {
    string Decrypt(string cipherText);
  }

  public interface IEncryptor
  {
    string Encrypt(string plainText);
  }

  // Hash alogitmasında sace Encrypte işlemi yapıcaz.
  public class Md5 : IEncryptor
  {
    public string Encrypt(string plainText)
    {
      throw new NotImplementedException();
    }
  }

  // Simetrik algoritmalar hem şifreleme hemde şifre çözme işlemlerini yaptığımız algoritmalardır
  public class Aes : IDecryptor, IEncryptor
  {
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
