namespace DesignPatterns.Strategy
{
    internal class WalkingNavigate : INavigationStrategy
    {
        public void Navigate()
        {
            Console.WriteLine("Walking Road");
        }
    }
}
