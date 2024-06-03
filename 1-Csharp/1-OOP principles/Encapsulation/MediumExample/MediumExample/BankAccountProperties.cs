using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumExample
{
    public class BankAccountProperties
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
