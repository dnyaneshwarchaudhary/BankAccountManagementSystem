using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1  
{
    public class CurrentAccount : Account
    {
        public double current_charges;
        public CurrentAccount()
        {
            this.current_charges = 0;
        }
           
        public CurrentAccount(int a, string name, double balance, double current_charges) : base(a,name, balance )
        {

            this.current_charges = this.balance - current_charges;

        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Current Charges are : " + this.current_charges);
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the Current Account Charges : ");
            this.current_charges = Convert.ToDouble(Console.ReadLine());
        }

        public override void CalculateBalance()
        {
            double new_balance;
          
            new_balance = this.balance - current_charges;
            Console.WriteLine("The Current Balance is : " + new_balance);

        }
        public override string ToString()
        {
            string result = base.ToString();
            result += "Current Account Charges is : " + this.current_charges;
            return result;
        }

    }
}
