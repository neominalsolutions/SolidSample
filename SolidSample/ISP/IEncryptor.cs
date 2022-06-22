using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.ISP
{
  public interface IEncryptor
  {
    string Encrypt(string plainText);
  }
}
