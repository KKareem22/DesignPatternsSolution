using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Classes
{
    internal class PaymentAdapter : IPaymentServices
    {
        private readonly ExternalPaymentGateway gateway;

        public PaymentAdapter(ExternalPaymentGateway gateway)
        {
            this.gateway = gateway;
        }
        public void Pay(decimal amount)
        {
            gateway.ProcessPayment((double)amount);
        }
    }
}
