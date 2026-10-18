using DesignPatterns.Abstract_Factory;
using DesignPatterns.Abstract_Factory.Mobile;
using DesignPatterns.Abstract_Factory.Web;
using DesignPatterns.Adapter.Classes;
using DesignPatterns.Adapter.Interfaces;
using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Singleton Pattern
            //ConfigurationManager.Test();
            //Console.WriteLine("Function01 Stared");
            //Console.WriteLine("Doing Work01");

            //var c01 = ConfigurationManager.Instance;
            //var c02 = ConfigurationManager.Instance;
            //Console.WriteLine(c01==c02);
            //Console.WriteLine(c01.Equals(c02));

            //c01.Name = "Kareem";
            //c02.Name = "Ali";

            //Console.WriteLine($"C01 of Name : {c01.Name}");
            //Console.WriteLine($"C02 of Name : {c02.Name}");


            #endregion
            #region Factory Pattern
            //PaymentService paymentService = new PaymentService();
            //paymentService.Checkout(100, PaymentType.CreaditCard);



            #endregion
            #region Strategy Pattern
            //INavigationStrategy strategy=new WalkingNavigate();
            //NavigationService navigation = new NavigationService(strategy);
            //navigation.Start();
            //navigation = new NavigationService(new TrainNavigate());
            //navigation.Start();

            #endregion
            #region Builder Pattern
            //var employee=new Employee();
            //Console.WriteLine(employee);
            //employee.AddName("Kareem").AddAge(22);
            //Console.WriteLine(employee);
            //employee.AddSalary(17500);
            //Console.WriteLine(employee);
            #endregion
            #region Abstract Factory Pattern
            //var screen=new TouristGuideScreen();
            //var mobileFactory=new MobileUIFactory();
            //screen.RenderScreen(mobileFactory);
            //Console.WriteLine(new string('*',20));

            //var webFactory=new WebUIFactory();
            //screen.RenderScreen(webFactory);



            #endregion

            #region Adapter Pattern
            //var gateway = new ExternalPaymentGateway();
            //IPaymentServices payment = new PaymentAdapter(gateway);
            //var order = new OrderServices(payment);
            //order.Checkout(1500m);


            #endregion


        }
    }
}
