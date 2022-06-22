using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSample.SRP
{
  public class Cart
  {
    public List<CartLine> cartLines = new List<CartLine>(); 
    
    public decimal TotalPrice
    {
      get
      {
        return this.cartLines.Sum(x=> x.Quantity * x.UnitPrice);
      }
    }
  }

  public class CartLine
  {
    public int Quantity { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }


  }


  public class OrderService
  {

    /// <summary>
    /// Ödeme alındıktan sonraki siparişin submit olması süreci.
    /// </summary>
    /// <param name="cart"></param>
    /// <param name="customerNumber"></param>
    public void SubmitOrder(Cart cart, string customerNumber)
    {
       // Sipariş numarası oluşturmak (Sipariş bilgilerini kayıt altında tutulmasını sağlayacak verilern veri tabanına girilmesi ilgisi ile ilgileniyor)

      // 10 haneli sipariş kodu 18 haneye çıkarmam lazım

       // Sipariş ile ilgili Kargo girişi yapmak (Kargo servisini ilgilendiriyor) -- İrsaliye kesme işlemi
       // UPS,MNG ve Yurtiçi

       // Sipariş ile ilgili mail,sms kullanıcıya atmak (Bilgilendirme) (SMS Vodafone,Turcell)
       // Fatura kesme (E-Arşiv fatura) (LOGO, SPA geçtim)


    }


  }
}
