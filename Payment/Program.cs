using System;

namespace Payment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orderForm = new OrderForm();
            var paymentHandler = new PaymentHandler();

            var systemId = orderForm.ShowForm();

            var payment = new Payment(systemId);

            payment.ShowTransition();

            paymentHandler.ShowPaymentResult(systemId, payment);
        }
    }
}