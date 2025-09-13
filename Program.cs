

namespace Exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person family = new Person();
            family.Name = "Ericson";
            family.Year = 2020;

            Console.WriteLine($"Hello {family.Name} ,you are born in :{family.Year}");

        }
    }
}
