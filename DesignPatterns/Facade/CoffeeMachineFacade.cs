namespace DesignPatterns.Facade
{
    internal class CoffeeMachineFacade
    {
        private readonly CoffeeBeanService beans;
        private readonly WaterHeaterService water;
        private readonly CoffeeMakerService maker;

        public CoffeeMachineFacade()
        {
            beans = new CoffeeBeanService();
            water = new WaterHeaterService();
            maker = new CoffeeMakerService();
        }

        public void MakeCoffee()
        {
            beans.PrepareCoffeeBeans();
            water.HeatWater();
            maker.BrewCoffee();
            Console.WriteLine(new string('_', 20));
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("Coffee is ready!");
            Console.ResetColor();
            Console.WriteLine(new string('_', 20));

        }

    }
}
