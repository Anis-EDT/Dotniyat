using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2.Transactione;

namespace ConsoleApp2.Account
{
    class Business<TTransactionKey, TTransaction> : AbstractAccount<TTransaction>, IEquatable<TTransaction>, IComparable<TTransaction>
    where TTransaction : Transaction
    {
        public override double Ratio { get; set; } = 0.01;

        public Business(double balance, int number, string state): base(balance, number, state)
        {
        }
    }
}
