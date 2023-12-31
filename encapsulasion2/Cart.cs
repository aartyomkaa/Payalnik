﻿using System;

namespace encapsulasion2
{
    public class Cart
    {
        private GoodsContainer _container;
        private Shop _shop;
        private Dictionary<Good, int> _order;

        public Cart(Warehouse warehouse, Shop shop) 
        {
            _shop = shop ?? throw new ArgumentNullException(nameof(shop));

            if (warehouse == null)
                throw new ArgumentNullException(nameof(warehouse));

            _container = warehouse.GetContainer;
            _order = new Dictionary<Good, int>();
        }

        public void Add(Good good, int amount)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            if (_container.HaveGoods(good, amount))
            {
                if (_order.ContainsKey(good))
                    _order[good] += amount;
                else
                    _order.Add(good, amount);
            }
            else
            {
                throw new InvalidOperationException("dont have enough goods in warehouse");
            }
        }

        public void ShowOrder()
        {
            if (_order.Count == 0)
                throw new InvalidOperationException();

            foreach (var good in _order)
            {
                Console.WriteLine($"{good.Key.Name} - {good.Value}");
                Console.WriteLine();
            }
        }

        public Shop Order()
        {
            if (_order.Count == 0)
                throw new InvalidOperationException();

            foreach (var good in _order)
            {
                _container.RemoveOrder(good.Key, good.Value);
            }

            return _shop;
        }
    }
}
