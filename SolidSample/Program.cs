// See https://aka.ms/new-console-template for more information
using SolidSample.DIP;
using SolidSample.LSP;
using SolidSample.OCP;

Console.WriteLine("Hello, World!");

// OCP aykırı değişime açık gelişime kapalı
var badPayment = new PaymentService("KrediKartı");
badPayment.Pay(1500, "32432432", "324324", "324324", "Ali", null,null);


var badPayment2 = new PaymentService("SanalKart");
badPayment2.Pay(1500,null, null, null, null, "32432432", null);


var credit = new CreditCardPayment("Ali", "12324-342324-324", "12/23", "467");
credit.Pay(1500);

//var m = new PaymentManager(credit);
//var result = m.Pay(1500);


var vm = new VirtualCardPayment(customerNumber: "32324324324");
vm.Pay(1250);
//var m2 = new PaymentManager(vm);
//var result2 = m2.Pay(1250);


List<ILogger> loggers = new List<ILogger>();
loggers.Add(new XmlLogger());
loggers.Add(new DatabaseLogger());
loggers.Add(new TextLogger());

BestUserRepository br = new BestUserRepository(loggers);
br.Create(new User { Id = 1, Name = "ali", SurName = "tan" });
br.Delete(id: 1);

var xmlLogger = new XmlLogger();
BestUserRepository br2 = new BestUserRepository(xmlLogger);
br.Delete(id: 1);

var sq = new SquareShape();
sq.Width = 5;
sq.Height = 5;


var sqB = new BestSquare();
sqB.Length = 5;
sqB.GetPerimeter();

var sqR = new BestRect();
sqR.Length = 5;
sqR.Width = 10;
sqR.GetPerimeter();

Console.ReadKey();

