using System;

namespace Payment
{
    internal class Qiwi : IPaymentSystem
    {
        private string _identification = "Qiwi";

        public string GetIdentification() => _identification;

        public void ShowTransition()
        {
            Console.WriteLine("Перевод на страницу QIWI...");
        }

        public void ShowPaymentResult()
        {
            Console.WriteLine($"Проверка платежа через {_identification}...");
        }
    }
}
