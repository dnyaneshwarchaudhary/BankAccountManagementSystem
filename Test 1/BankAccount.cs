using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    internal class BankAccount
    {
        Account[] account;

        public BankAccount(int size)
        {

            account = new Account[size];


        }

        public void DisplayAllAcounts()
        {
           int length = account.Length;

             for (int i = 0; i < length; i++)
            {
                account[i].Display();
            }
        
        }

        public void AddAccount(string acc_type)
        {
            for (int i = 0; i < account.Length; i++)
            {
                if (account[i] == null)
                {
                    if (acc_type == "Savings")
                    {
                        account[i] = new SavingsAccount();
                    }
                    else if (acc_type == "Current")
                    {
                        account[i] = new CurrentAccount();
                    }

                    account[i].Accept();

                    break;
                }
            }

        }

        public string SearchAccount(int acc_no)
        {
            string ans;
            for (int i = 0;i < account.Length;i++)
            {
                if (account[i].acc_no == acc_no)
                {
                    ans = "found";
                    return ans;
                }
            }
            ans = "Not found";
            return ans;
        }


    }
}
