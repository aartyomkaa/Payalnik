using System;

namespace encapsulasion2
{
    public class Warehouse
    {
        private GoodsContainer _container;

        public Warehouse()
        {
            _container = new GoodsContainer();
        }

        public GoodsContainer GetContainer => _container;

        public void Delive(Good good, int amount)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            _container.Add(good, amount);
        }

        public void ShowInformation()
        {
            _container.ShowInformation();
        }
    }
}
