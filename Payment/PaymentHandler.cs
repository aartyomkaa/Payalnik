using System;

namespace Payment
{
    internal class PaymentHandler
    {
        public void ShowPaymentResult(string systemId, Payment payment)
        {
            Console.WriteLine($"Вы оплатили с помощью {systemId}");

            payment.ShowResult();

            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}