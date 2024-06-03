using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Can access balance through normal method
            BankAccountConstructor account = new BankAccountConstructor(100);
            Console.WriteLine(account.GetBalance());

            // Can access balance through the Balance property
            BankAccountProperties account2 = new BankAccountProperties();
            account2.Balance = 100;
            Console.WriteLine(account2.Balance);

            // Can access balance through the Get and Set methods
            BankAccountMethods account3 = new BankAccountMethods();
            account3.SetBalance(100);
            Console.WriteLine(account3.GetBalance());
        }
    }
}
