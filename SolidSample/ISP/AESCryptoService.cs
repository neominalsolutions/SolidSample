using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.ISP
{
  public enum AESAlgorithms
  {
    AES128,
    AES256,
    AES512
  }
  public class AESCryptoService: IEncryptor,IDecryptor
  {
    private AESAlgorithms _algorithms1;
    public AESCryptoService(AESAlgorithms algorithms)
    {
      _algorithms1 = algorithms;
    }

    public string Decrypt(string cipherText)
    {
      Console.WriteLine($"{_algorithms1.ToString()} ile şifre çözüldü");
      return "Merhaba";
    }

    public string Encrypt(string plainText)
    {
      Console.WriteLine($"{_algorithms1.ToString()} ile şifrelendi");
      return "324234324dsfdsf09035ggfdsf";
    }
  }
}
