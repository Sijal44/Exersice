

namespace Exersice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person family = new Person();
            family.Name = "Ericson";
            family.Year = 2020; 

           Student student = new Student();    
            student.Name = "John";


            Console.WriteLine($"Hello {student.Name}");
            Console.WriteLine($"Mr {family.Name} ,you are born in :{family.Year}");

        }
    }
}
