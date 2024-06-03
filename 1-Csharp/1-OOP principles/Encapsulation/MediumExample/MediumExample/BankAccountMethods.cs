using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumExample
{
    public class BankAccountMethods
    {
        private decimal balance;

        public decimal GetBalance()
        {
            return balance;
        }

        public void SetBalance(decimal value)
        {
            balance = value;
        }
    }
}
