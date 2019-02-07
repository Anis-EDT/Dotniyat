using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ConsoleApp2.Account;
using ConsoleApp2.Transactione;

namespace ConsoleApp2.Client
{
    public abstract class AbstractClient<TAccount>
    {
        public string name { get; set; }
        public int cin { get; set; }
        public List<TAccount> Accounts { get; set; }

        public AbstractClient(string name, int cin)
        {
            this.name = name;
            this.cin = cin;
            List<TAccount> Accounts = new List<TAccount>();

        }

        public static implicit operator AbstractClient<TAccount>(List<AbstractAccount<Transaction>> v)
        {
            throw new NotImplementedException();
        }
    }
}
