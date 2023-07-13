using System;

namespace Payment
{
    internal class Payment
    {
        private IPaymentSystem _paymentSystem;
        private SystemGenerator _generator;

        public Payment(string systemId)
        {
            _generator = new SystemGenerator();

            _paymentSystem = _generator.GetSystem(systemId);
        }

        public void ShowTransition()
        {
            _paymentSystem.ShowTransition();
        }

        public void ShowResult()
        {
            _paymentSystem.ShowPaymentResult();
        }
    }
}
