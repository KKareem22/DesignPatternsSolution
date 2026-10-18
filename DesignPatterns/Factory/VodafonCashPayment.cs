namespace DesignPatterns.Factory
{
    internal class VodafonCashPayment:IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Vodafon Cash.");
        }
    }
}
