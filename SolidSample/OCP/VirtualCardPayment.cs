using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.OCP
{
  public class VirtualCardPayment : BasePaymentService
  {
    public string CustomerNumber { get; private set; }

    public VirtualCardPayment(string customerNumber)
    {
      this.CustomerNumber = customerNumber;
    }
    public override PaymentStatus Pay(decimal paymentAmount)
    {
      Console.WriteLine("Sanal kart ile alışveriş yapıldı");
      return PaymentStatus.OK;
    }
  }

}
