using DesignPatterns.Abstract_Factory;
using DesignPatterns.Abstract_Factory.Mobile;
using DesignPatterns.Abstract_Factory.Web;
using DesignPatterns.Adapter.Classes;
using DesignPatterns.Adapter.Interfaces;
using DesignPatterns.Bridge;
using DesignPatterns.Builder;
using DesignPatterns.Composite;
using DesignPatterns.Decorators;
using DesignPatterns.Facade;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creational Design Pattterns

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

            #endregion

            #region Structural Design Patterns
            #region Adapter Pattern
            //var gateway = new ExternalPaymentGateway();
            //IPaymentServices payment = new PaymentAdapter(gateway);
            //var order = new OrderServices(payment);
            //order.Checkout(1500m);


            #endregion
            #region Facade Pattern
            //var coffeeMachine=new CoffeeMachineFacade();
            //coffeeMachine.MakeCoffee();


            #region Explanation
            /*Facade pattern simplifies the interface for complex subsystems,
                 * making it easier to use and understand. In this example, 
                 * the CoffeeMachineFacade class provides a simple method to make coffee, 
                 * hiding the complexity of the underlying services like CoffeeBeanService, WaterHeaterService, and CoffeeMakerService.
                */
            #endregion

            #endregion
            #region Decorators
            //// Decorator pattern allows behavior to be added to individual objects,
            //ICoffee coffee = new SimpleCoffee();
            //coffee.Display();
            //// Adding milk to the coffee using the MilkDecorator
            //coffee = new MilkDecorator(coffee);
            //coffee.Display();
            //// Adding caramel to the coffee using the CaramelDecorator
            //coffee = new CaramelDecorator(coffee);
            //coffee.Display();



            #endregion
            #region Composite Pattern
            //// Create individual files
            //IFileSystemComponent file01 = new FileItem("Report1.pdf");
            //IFileSystemComponent file02 = new FileItem("Photo01.png");
            //IFileSystemComponent file03 = new FileItem("Notes.txt");
            //// Create a subfolder
            //var imageFolder = new Folder("Images");
            //imageFolder.Add(file02);
            //// Create the root folder
            //var rootFolder = new Folder("MyDocument");
            //rootFolder.Add(file01);
            //rootFolder.Add(imageFolder);
            //rootFolder.Add(file03);

            //rootFolder.Display();

            //Console.ReadKey();



            #endregion
            #region Bridge Pattern
            //Notification basicEmail = new BasicNotification(new EmailSender());
            //basicEmail.Notify("Your order has been confirmed.");
            //Console.WriteLine(new string('/',20));
            //Notification urgentSMS = new UrgentNotification(new SMSSender());
            //urgentSMS.Notify("Your booking starts in 10 minutes.");
            //Console.WriteLine(new string('/',20));
            //Notification urgentEmail = new UrgentNotification(new EmailSender());
            //urgentEmail.Notify("Your payment needs attention.");

            #endregion



            #endregion



            #region Behavioral Design Patterns

            #endregion
        }
    }
}
