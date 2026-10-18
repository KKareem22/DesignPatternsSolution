using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Classes
{
    internal class OrderServices
    {
        private readonly IPaymentServices payment;

        public OrderServices(IPaymentServices payment)
        {
            this.payment = payment;
        }
        public void Checkout(decimal total)
        {
            payment.Pay(total);
        }
    }
}
