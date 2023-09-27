using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    public abstract class Account
    {
        public int acc_no;
        public string aname;
        protected double balance;
        public static double isbn_no;
        public static double rate_of_interest;

        public Account()
        {

            this.acc_no = 0;
            this.aname = null;
            this.balance = 0;
            isbn_no = 123;
            rate_of_interest = 5;
            
        }

        public Account(int accn, string aname, double balance)
        {

            this.acc_no = accn;
            this.aname = aname;
            this.balance = balance;

        }

        public virtual void Display()
        {
            Console.WriteLine("Account Number is : " + this.acc_no);
            Console.WriteLine("Account Name is : " + this.aname);
            Console.WriteLine("Account Balance is : " + this.balance);

        }



        public virtual void Accept()
        {
            Console.WriteLine("Enter the Account Number : ");
            this.acc_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Account Name : ");
            this.aname = Console.ReadLine();
            Console.WriteLine("Enter the Account Balance : ");
            this.balance = Convert.ToDouble(Console.ReadLine());

        }

      
        public abstract void CalculateBalance();

        public override string ToString()
        {
            
            string result = base.ToString();
            result += "Account Number is : " + this.acc_no + "\n Account Name is : " + this.aname + "\n Account Balance is : " + this.balance;
            return result;
        }

    }
}
