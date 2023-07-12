using System;

namespace encapsulasion2
{
    public class GoodsContainer
    {
        private readonly Dictionary<Good, int> _goods = new Dictionary<Good, int>();

        public void Add(Good good, int amount)
        {
            if (good == null)
                throw new ArgumentNullException();
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            if (_goods.ContainsKey(good))
                _goods[good] += amount;
            else
                _goods.Add(good, amount);
        }

        public void ShowInformation()
        {
            if (_goods.Count == 0)
                throw new InvalidOperationException();

            foreach (var good in _goods)
            {
                Console.WriteLine($"{good.Key.Name} - {good.Value}");
            }
        }

        public bool HaveGoods(Good good, int amount)
        {
            if (_goods.ContainsKey(good) && _goods[good] >= amount)
                return true;

            return false;
        }

        public void RemoveOrder(Good good, int amount)
        {
            if (_goods.ContainsKey(good) == false)
                throw new InvalidOperationException(nameof(good));

            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            _goods[good] -= amount;
        }
    }
}