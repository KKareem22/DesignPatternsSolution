namespace DesignPatterns.Decorators
{
    internal class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override decimal GetCost() => _coffee.GetCost() + 10m;



        public override string GetDescription() => $"{_coffee.GetDescription()} + Milk";

    }
}
