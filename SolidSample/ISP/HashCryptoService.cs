using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.ISP
{
  public enum HashAlgorithms
  {
    SHA256
  }

  /// <summary>
  /// Hash algoirtmaları sadece şifrelenir. Ve paraola gibi hassas şifreleme işlemleri için kullanılır. KVKK kapsamında şifreler db de hashlenmiş olarak saklanmalıdır.
  /// </summary>
  public class HashCryptoService : IEncryptor
  {
 

    public string Encrypt(string plainText)
    {
      Console.WriteLine($"SHA ile şifrelendi");
      return "Merhaba";
    }
  }
}
