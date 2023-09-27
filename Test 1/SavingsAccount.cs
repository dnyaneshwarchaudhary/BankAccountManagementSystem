using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    public class SavingsAccount : Account
    {
        double savings_interest;

        public SavingsAccount()
        {
            this.savings_interest = 0;

        }
        public SavingsAccount(int accn, string aname, double balance, double savings_interest) : base(accn,aname,balance)
        {
            this.savings_interest = Account.rate_of_interest + this.savings_interest;

        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Savings Interest is : " + this.savings_interest);

        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the Savings Interest Rate : ");
            this.savings_interest = Convert.ToDouble(Console.ReadLine());

        }

        public override void CalculateBalance()
        {
            double new_balance;
            new_balance = this.balance * (100 + savings_interest) / 100;
            Console.WriteLine("The Saving Balance is : " + new_balance);
        }
        public override string ToString()
        {
            string result = base.ToString();
            result += "Savings Account Interest is : " + this.savings_interest;
            return result;
        }

    }
}
