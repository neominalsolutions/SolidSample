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


  public class CreditCardPayment : BasePaymentService
  {
    public string CardOwner { get; private set; }
    public string CreditCardNumber { get; private set; }
    public string Thru { get; private set; }
    public string Cvv { get; private set; }


    public CreditCardPayment(string cardOwner, string creditCardNumber, string thru, string cvv)
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


  public class BestPaymentService:BasePaymentService
  {
    BasePaymentService _paymentService;

    public BestPaymentService(BasePaymentService basePaymentService)
    {
       _paymentService = basePaymentService;
    }

    public override PaymentStatus Pay(decimal paymentAmount)
    {
      return _paymentService.Pay(paymentAmount);
    }
  }
}
