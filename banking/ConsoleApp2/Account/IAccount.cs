using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Account
{
    interface IAccount<TTransaction>
    {
        void Debit(double amount);
        void Credit(double amount);
    }
}
