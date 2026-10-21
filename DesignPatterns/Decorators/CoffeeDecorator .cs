namespace DesignPatterns.Decorators
{
    internal abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee _coffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public void Display()
        {
            Console.WriteLine($"Description: {GetDescription()}");
            Console.WriteLine($"Cost: {GetCost()}");
            Console.WriteLine(new string('*', 20));
        }

        public abstract decimal GetCost();
        

        public abstract string GetDescription();
        
    }
}
