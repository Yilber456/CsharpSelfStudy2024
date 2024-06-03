using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumExample
{
    public class BankAccountConstructor
    {
        private decimal balance;

        public BankAccountConstructor(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
