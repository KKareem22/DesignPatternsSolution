namespace DesignPatterns.Strategy
{
    internal class NavigationService
    {
        private readonly INavigationStrategy strategy;

        public NavigationService(INavigationStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void Start()
        {
            strategy.Navigate();
        }
    }
}
