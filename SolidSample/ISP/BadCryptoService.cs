using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.ISP
{

  public interface ICrypto
  {
    string Decrypt(string cipherText);
    string Encrypt(string plainText);
  }

  // HASH Service
  public class BadCryptoService : ICrypto
  {
    // Decrpyte edemez.
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
