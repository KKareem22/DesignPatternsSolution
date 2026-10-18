namespace DesignPatterns.Strategy
{
    internal class CarNavigate : INavigationStrategy
    {
        public void Navigate()
        {
            Console.WriteLine("By Car");
        }
    }
}
