using System;

namespace encapsulasion2
{
    public class Shop
    {
        private Warehouse _warehouse;

        public string Paylink => "6969";

        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse));
        }

        public Cart Cart()
        {
            return new Cart(_warehouse, this);
        }
    }
}
