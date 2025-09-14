using Exersice;
using System;
using static Exersice.Account;
using static Exersice.Account.CreditAccount;

namespace Exersice
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreditAccount credit = new CreditAccount();
            credit.Deposit();

            SavingsAccount savings = new SavingsAccount();
            savings.Deposit();

        }
    }
}
