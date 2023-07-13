using System;

namespace Payment
{
    internal interface IPaymentSystem
    {
        public string GetIdentification();

        public void ShowTransition();

        public void ShowPaymentResult();
    }
}
