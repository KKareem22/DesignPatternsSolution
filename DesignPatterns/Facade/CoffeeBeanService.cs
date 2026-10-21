namespace DesignPatterns.Facade
{
    internal class CoffeeBeanService
    {
        public void PrepareCoffeeBeans()
        {
            Console.WriteLine(new string('_', 20));
            Console.WriteLine("1) Preparing coffee beans...");
            Console.WriteLine(new string('_', 20));
        }
    }
}
