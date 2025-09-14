using System;

namespace Exersice
{
    //huvudclass Account
    internal class Account
    {
         // En abstrakt klass (kan inte skapas som objekt)
            public abstract class BankAccount
        {
            // Alla klasser som ärver från BankAccount måste implementera Deposit
            //Implementera = att skriva den riktiga koden som uppfyller en plan eller ett krav

            public abstract void Deposit();
        }
        //klass(CreditAccount) som ärver från BankAccount
        public class CreditAccount : BankAccount
        {
            public override void Deposit()
            {
                Console.WriteLine("Deposit to Credit Account");
            }
        }
    }
}
