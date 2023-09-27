using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter the Bank Accounts Size : ");
            int bankSize = Convert.ToInt32(Console.ReadLine());
            BankAccount Bank = new BankAccount(bankSize);

            Console.Write("Enter account type (Savings/Current): ");
            string accType = Console.ReadLine();

            Bank.AddAccount(accType);
            //Bank.DisplayAllAcounts();

            int acc;
            Console.WriteLine("Enter the Acc to search : ");
            acc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Account " + Bank.SearchAccount(acc));
            
        }
    }
}
