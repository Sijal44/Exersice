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

            Person family = new Person();
            family.Name = "Ericson";
            family.Year = 2020; 

            Student student = new Student();    
            student.Name = "John";

            Teacher teacher = new Teacher();
            teacher.SchoolName = "Handelsakademin";
            teacher.Age = 35;
            teacher.StudentID = "S12345";

            Console.WriteLine($"Hello {student.Name}");
            Console.WriteLine($"Mr {family.Name} ,you are born in :{family.Year}");
            Console.WriteLine("Welcome to the school");

            teacher.Display();



        }
    }
}
