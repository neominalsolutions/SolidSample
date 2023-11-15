using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.DIP
{
  public class User
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }

  }

  public class DbLogger
  {
    public void Log(string message)
    {
      // databasede bir logTable tutuyor
      Console.WriteLine("Tabloya kayıt aldı" + message);
    }
  }

  public class XMLLogger
  {
    public void Log(string message)
    {
      Console.WriteLine("Log xml file" + message);
    }
  }

  public class FileLogger
  {
    public void Log(string message)
    {
      Console.WriteLine("c://file.log.txt:" +message);
    }
  }

  // üst seviye sınıf UserRepository
  // üst seviye bir sınıf iş yaparken ekstradan üst seviye sınıfın kendi dışındaki işini üstlenen sınfa ise altseviye sınıf.
  // arkadaş artık loglar file logger ile değil dblogger ile altılacak.
  // hem filelogger hemde db logger kullanıcak.
  // xml logger da delete işlemleri için kullanılsın. KVKK kapsamında bir kayıt silindiğinde xml bir datayı E-devlete export etmemiz gerekiyor.
  // 2 somut örnek yani instance alınan 2 nesne birbirne referans almış. Böyle bir durumda DIP ters harekt etmiş oluyoruz.
  // Bu bağımlıktan kurtulmak için üst seviye nesnenin kullanacağı sınıflar bir arayüz yada bir base (abstract) sınıf vasıtası ile haberleşmelidir.
  public class BadDependecyInversion
  {
    //BadDependecyInversion sınfı FileLogger,DbLogger, XMLLogger instancelarının yönetiminden sorumlu hale geldi. Esnek bir yaklaşımı kaybetti. Tighyt Coupled bir sınıf. 
    private FileLogger flogger = new FileLogger();
    private DbLogger dblogger = new DbLogger();
    private XMLLogger XMLLogger= new XMLLogger();

    public void Create(User user)
    {
      // Dbye user insert ettik
      flogger.Log($"{user.Name} {user.SurName}");
      dblogger.Log("");
    }

    public void Delete(int id)
    {
      flogger.Log($"");
      dblogger.Log("");
      XMLLogger.Log("");
    }

    public void Update(User user)
    {
      dblogger.Log("");
    }
  }
}
