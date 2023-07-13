using System;

namespace Payment
{
    internal class Card : IPaymentSystem
    {
        private string _identification = "Card";

        public string GetIdentification() => _identification;

        public void ShowTransition()
        {
            Console.WriteLine("Вызов API банка эмитера карты Card...");
        }

        public void ShowPaymentResult()
        {
            Console.WriteLine($"Проверка платежа через {_identification}...");
        }
    }
}
