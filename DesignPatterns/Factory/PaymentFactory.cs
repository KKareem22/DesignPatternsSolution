namespace DesignPatterns.Factory
{
    internal static class PaymentFactory
    {
         
        public static IPayment Create(PaymentType paymentMethod)
        {
            if (paymentMethod == PaymentType.VodafonCash)
                return new VodafonCashPayment();
            else if (paymentMethod == PaymentType.CreaditCard)
                return new CreditCardPayment();
            else
                throw new Exception("Invaild Payment Method");
        }
    }
}
