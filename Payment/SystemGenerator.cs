using System;

namespace Payment
{
    internal class SystemGenerator
    {
        private IPaymentSystem[] _paymentSystems;

        public SystemGenerator()
        {
            _paymentSystems = Create();
        }

        public IPaymentSystem GetSystem(string systemId)
        {
            foreach (var system in _paymentSystems)
            {
                if (system.GetIdentification() == systemId)
                {
                    return system;
                }
            }

            throw new InvalidOperationException();
        }

        private static IPaymentSystem[] Create()
        {
            return new IPaymentSystem[] { new Qiwi(), new WebMoney(), new Card() };
        }
    }
}
