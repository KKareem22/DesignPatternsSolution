namespace DesignPatterns.Adapter.Classes
{
    internal class ExternalPaymentGateway
    {
        public void ProcessPayment(double total)
        {
            Console.WriteLine($"Payment processed: {total}");
        }
    }
}
