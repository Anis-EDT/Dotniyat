using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Transactione
{
    public class Transaction
    {
        public Guid Number { get; set; }
        public int SourceNumber { get; set; }
        public int TargetNumber { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Direction { get; set; }
        public string State { get; set; }
        public Transaction() { }
        public Transaction(int source, int target, double amount, string state, string direction)
        {
            this.Number = Guid.NewGuid();
            this.SourceNumber = source;
            this.TargetNumber = target;
            this.Amount = amount;
            this.Date = DateTime.Now;
            this.State = state;
            this.Direction = direction;
        }

    }
}
