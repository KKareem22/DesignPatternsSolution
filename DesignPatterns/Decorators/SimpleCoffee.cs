namespace DesignPatterns.Decorators
{
    internal class SimpleCoffee : ICoffee
    {
        public void Display()
        {
            Console.WriteLine($"Description: {GetDescription()}");
            Console.WriteLine($"Cost: {GetCost()}");
            Console.WriteLine(new string('*', 20));
        }

        public decimal GetCost() => 50m;
        

        public string GetDescription() => "Simple Coffee";

    }
}
