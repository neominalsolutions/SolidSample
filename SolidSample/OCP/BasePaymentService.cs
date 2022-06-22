using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.OCP
{
  public enum OrderStatus
  {
    Shipped = 102,
    WaitingForRequest = 1,
    Ordered = 104,
  }

  public abstract class BasePaymentService
  {
   public abstract PaymentStatus Pay(decimal paymentAmount);

  }
}
