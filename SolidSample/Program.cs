// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using SolidSample.DIP;
using SolidSample.LSP;
using SolidSample.OCP;





// OCP Sample

// IF kodlarımız UI içerisinde olucak, gelen Use case isteğine göre hangi sınıftan instance alınacağını bulup ilgili yönlendirmeyi yapıcaz.
// uygulama OPen-Close prensibine uygun ve polimorfik olarak çalışacak.

// Prensetation Sunum katmanı => UI
/*
Console.WriteLine("Ödeme Şeklini giriniz Cash,Credit veya Virtual Wallet");
string paymentType = Console.ReadLine();

BestPaymentService paymentService;

if(paymentType == "Cash")
{
  paymentService = new BestPaymentService(new CachePayment());
  paymentService.Pay(16);
}
else if(paymentType == "Virtual Wallet")
{
  Console.WriteLine("Müşteri Numaranızı giriniz");
  string customerNumber = Console.ReadLine();
  paymentService = new BestPaymentService(new VirtualCardPayment(customerNumber));
  paymentService.Pay(16);
}

*/

/*
// Sample2 
Console.WriteLine("Ne çizmek istersiniz");
string cizilecek = Console.ReadLine();

if(cizilecek == "Kare")
{
  //SquareShape square = new SquareShape();

  //Console.WriteLine("Kenar giriniz");
  //int corner = int.Parse(Console.ReadLine());
  //square.Height = corner;
  //square.Width = corner;
  //double perimeter = square.GetPerimeter();

  
  Console.WriteLine("Kenar giriniz");
  BestSquare bestSquare = new BestSquare();
  bestSquare.Corner = int.Parse(Console.ReadLine());
  double perimeter  = bestSquare.GetPerimeter();

  Console.WriteLine($"çevre {perimeter}");

}
  */


// Best Dependecy Inversion

//BestDependencyInversion bestDependencyInversion = new BestDependencyInversion(new TextLogger());
//bestDependencyInversion.Create(new User());

// IoC ile instance üretimlerini Net Core framework bırakacağız.

var container = new ServiceCollection();
  // interface hangi sınıfın instance'ı ile çalışacağını container register ediyoruz.
  container.AddTransient<ILogger, XmlLogger>();

  var serviceProvider = container.BuildServiceProvider();
  // container tanımlanan register edilen servislerin uygulama genelinde çalışabilmesi için BuildServiceProvider methodunu kullanıyoruz.

  // resolve işlemi container üzerinden service çözümleme işlemi
  var loggerInstance = serviceProvider.GetRequiredService<ILogger>();
  BestDependencyInversion bI = new BestDependencyInversion(loggerInstance);
  bI.Log();










