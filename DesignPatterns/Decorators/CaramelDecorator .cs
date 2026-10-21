namespace DesignPatterns.Decorators
{
    internal class CaramelDecorator : CoffeeDecorator
    {
        public CaramelDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override decimal GetCost() => _coffee.GetCost() + 15m;


        public override string GetDescription() => $"{_coffee.GetDescription()} + Caramel";

    }
}
