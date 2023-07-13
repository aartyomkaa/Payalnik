using System;

namespace Payment
{
    internal class WebMoney : IPaymentSystem
    {
        private string _identification = "WebMoney";

        public string GetIdentification() => _identification;

        public void ShowTransition()
        {
            Console.WriteLine("Вызов API WebMoney...");
        }

        public void ShowPaymentResult()
        {
            Console.WriteLine($"Проверка платежа через {_identification}...");
        }
    }
}
