using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.OCP
{
  public enum PaymentStatus
  {
    OK,
    Rejected
  }


  // Kredi Kartı dışında avans hesap üzerinden de ödeme yapılabilir.
  // Sanal Cüzdan bankadaki hesabı üzerinden ödeme yapılabilir.

  // customerNumber sanal cüzdan için müşteri numarası
  // customerAccountNumber avans hesap numarası
  public class BadPaymentService
  {
    private string _paymentType;
    public BadPaymentService(string paymentType)
    {
      _paymentType = paymentType;
    }

    private PaymentStatus PayWithCredit(decimal paymentAmount, string cardNumber, string thru, string cvv, string cardOwner)
    {
      return PaymentStatus.OK;
    }

    private PaymentStatus PayWithVirtualCard(string customerNumber)
    {
      return PaymentStatus.OK;
    }

    private PaymentStatus PayWithAdvanceAccount(string accountNumber)
    {
      return PaymentStatus.OK;
    }

    public PaymentStatus Pay(decimal paymentAmount, string cardNumber, string thru, string cvv, string cardOwner, string customerAccountNumber,string customerNumber)
    {

      if(_paymentType == "KrediKartı")
      {
        PayWithCredit(paymentAmount, cardNumber, thru, cvv, cardOwner);
        // kredi kartı işlemleri
      } else if(_paymentType =="SanalCüzdan")
      {

      }
      else if (_paymentType == "AvansHesap")
      {
        PayWithAdvanceAccount(customerAccountNumber);
      }

      // Kişinin Kredi Kartında bir miktar ödeme alınıyor.

      return PaymentStatus.OK;
    }

  }
}
