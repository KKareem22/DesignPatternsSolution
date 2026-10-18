namespace DesignPatterns.Strategy
{
    internal class BicycleNavigate : INavigationStrategy
    {
        public void Navigate()
        {
            Console.WriteLine("Bicycle Road");
        }
    }

}
