using System;

namespace encapsulasion2
{
    public class Warehouse
    {
        private readonly List<Cell> _cells;

        public Warehouse()
        {
            _cells = new List<Cell>();
        }

        public void Delive(Good good, int amount)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            var newCell = new Cell(good, amount);

            int cellIndex = _cells.FindIndex(cell => cell.Good == good);

            if (cellIndex == -1)
                _cells.Add(newCell);
            else
                _cells[cellIndex].Merge(newCell);
        }

        public bool HaveGoods(Good good, int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            foreach (var cell in _cells)
            {
                if (cell.Good == good && cell.Amount >= amount)
                    return true;
            }

            return false;
        }

        public void TransferCart(Good good, int amount)
        {
            if (good == null)
                throw new ArgumentNullException(nameof(good));

            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            foreach (var cell in _cells)
            {
                if (cell.Good == good && cell.Amount >= amount)
                    cell.RemoveOrder(amount);
            }
        }

        public void ShowInformation()
        {
            if (_cells.Count == 0)
                throw new InvalidOperationException();

            foreach (var cell in _cells)
            {
                cell.ShowInformation();
                Console.WriteLine();
            }
        }
    }
}
