namespace DesignPatterns.Strategy
{
    internal class TrainNavigate : INavigationStrategy
    {
        public void Navigate()
        {
            Console.WriteLine("Train Tracks");
        }
    }
}
