using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.OCP
{


  public class PaymentManager:BasePaymentService
  {
    BasePaymentService _paymentService;

    public PaymentManager(BasePaymentService basePaymentService)
    {
       _paymentService = basePaymentService;
    }

    public override PaymentStatus Pay(decimal paymentAmount)
    {
      return _paymentService.Pay(paymentAmount);
    }
  }
}
