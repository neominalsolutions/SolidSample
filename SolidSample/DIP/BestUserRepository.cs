using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.DIP
{
  public interface ILogger
  {
    void Log(string message);
  }

  public class DatabaseLogger : ILogger
  {
    public void Log(string message)
    {
      throw new NotImplementedException();
    }
  }

  public class XmlLogger : ILogger
  {
    public void Log(string message)
    {
      throw new NotImplementedException();
    }
  }

  public class TextLogger : ILogger
  {
    public void Log(string message)
    {
      throw new NotImplementedException();
    }
  }



  public class BestUserRepository
  {
    private readonly List<ILogger> _loggers;
    private readonly ILogger _logger;

    /// <summary>
    /// Delete işlemi için bu constructor kullan XmlLogger gönder.
    /// </summary>
    /// <param name="logger"></param>
    public BestUserRepository(ILogger logger)
    {
      _logger = logger;
    }

    public BestUserRepository(List<ILogger> loggers)
    {
      _loggers = loggers;
    }

    public void Create(User user)
    {
      // Dbye user insert ettik

      foreach (var logger in _loggers)
      {
        if(logger is FileLogger || logger is DatabaseLogger)
        {
          logger.Log("");
        }
      }

    }

    public void Delete(int id)
    {
      if(_loggers.Any(x=> x.GetType() != typeof(XmlLogger))){
        throw new Exception("KVKK kapsamında xml kayıt at");
      }

      _loggers.ForEach(logger =>
      {
        logger.Log("");
 
      });

    }

  }
}
