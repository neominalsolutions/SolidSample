using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.OCP
{
  public class CreditCardPayment : BasePaymentService
  {
    public string CardOwner { get; private set; }
    public string CreditCardNumber { get; private set; }
    public string Thru { get; private set; }
    public string Cvv { get; private set; }


    public CreditCardPayment(string cardOwner,string creditCardNumber,string thru,string cvv)
    {
      this.CardOwner = cardOwner;
      this.CreditCardNumber = creditCardNumber;
      this.Thru = thru;
      this.Cvv = cvv;
    }

    public override PaymentStatus Pay(decimal paymentAmount)
    {
      Console.WriteLine("Kredi Kartı ile ödeme alındı");
      return PaymentStatus.OK;
    }
  }
}
