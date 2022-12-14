using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    internal class CreditCard
    {
        string number;
        int cash;
        public CreditCard(string number, int cash)
        {
            this.number = number;
            this.cash = cash;
        }
        public int AddCash(int sum)
        {
            cash += sum;
            return 0;
        }
       public int GetCash(int sum)
        {
            cash -= sum;
            return 0;
        }
        public override string ToString()
        {
            return "Credit card number: " + number + " Cash on card: " + cash.ToString();
        }
    }
}
