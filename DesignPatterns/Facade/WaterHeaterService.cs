namespace DesignPatterns.Facade
{
    internal class WaterHeaterService
    {
        public void HeatWater()
        {
            Console.WriteLine(new string('_', 20));
            Console.WriteLine("2) Heating water...");
            Console.WriteLine(new string('_', 20));
        }
    }
}
