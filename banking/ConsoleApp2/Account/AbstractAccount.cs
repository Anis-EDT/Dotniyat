using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ConsoleApp2.Client;
using ConsoleApp2.Transactione;



namespace ConsoleApp2.Account
{
     public abstract class AbstractAccount<TTransaction> : IAccount<TTransaction> , IEquatable<TTransaction> , IComparable<TTransaction>
     where TTransaction : Transaction

    {
        public double Balance { get; set; }
        public Guid Number { get; set; }
        public DateTime CreationDate { get; set; }
        public string State { get; set; }
        public List<AbstractAccount<TTransaction>> Owner { get; set; }
        public virtual double Ratio { get; set; }
        public IEnumerable<TTransaction> Transactions { get; set; }

        public AbstractAccount(double balance, int number, string state)
        {
            this.Balance = balance;
            this.Number = number;
            this.CreationDate = DateTime.Now;
            this.State = state;
            this.Owner = new List<AbstractAccount<TTransaction>>();
            this.Transactions = new Collection<TTransaction>();
        }
        public void Debit(double amount)
        {
            throw new NotImplementedException();
        }

        public void Credit(double amount)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public bool Equals(TTransaction other)
        {
            return (other as TTransaction)?.Number == Number;
        }
        public static bool operator ==(AbstractAccount<TTransaction> b1, AbstractAccount<TTransaction> b2)
        {
            if (null == b1)
                return (null == b2);

            return b1.Equals(b2);
        }

        public static bool operator !=(AbstractAccount<TTransaction> b1, AbstractAccount<TTransaction> b2)
        {
            return !(b1 == b2);
        }

     
        public int CompareTo(TTransaction other)
        {
            throw new NotImplementedException();
        }
    }
}
