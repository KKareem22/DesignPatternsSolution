namespace DesignPatterns.Factory
{
    internal class PaymentService
    {
        public void Checkout(decimal amount,PaymentType paymentMethod)
        {
            IPayment payment=PaymentFactory.Create(paymentMethod);
            payment.Pay(amount);
        }
    }
}
