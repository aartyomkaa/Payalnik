using System;

namespace encapsulasion2
{
    public class Cell
    {
        public Cell(Good good, int amount) 
        {
            Good = good;
            Amount = amount;
        }

        public Good Good { get; private set; }
        public int Amount { get; private set; }

        public void ShowInformation()
        {
            Console.WriteLine($"{Good.Name} - {Amount}");
        }

        public void RemoveOrder(int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount));

            Amount -= amount;
        }

        public void Merge(Cell newCell)
        {
            if (newCell.Good != Good)
                throw new InvalidOperationException();

            Amount += newCell.Amount;
        }
    }
}
