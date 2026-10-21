namespace DesignPatterns.Facade
{
    internal class CoffeeMakerService
    {
        public void BrewCoffee()
        {
            Console.WriteLine(new string('_', 20));
            Console.WriteLine("3) Brewing coffee...");
            Console.WriteLine(new string('_', 20));
        }
    }
}
