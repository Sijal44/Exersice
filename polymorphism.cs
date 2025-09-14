using System;

namespace Exersice
{
    //huvudclass
    public class Human
    {
    public string SchoolName;
    public int Age;
        public virtual void Display()
        {
            Console.WriteLine($"School Name: {SchoolName}, Age: {Age}");
        }
    }
    //subclass
    public class Teacher : Human
    {
        public string StudentID;
        public override void Display()
        {
           Console.WriteLine($"School Name: {SchoolName}, Age: {Age}, Student ID: {StudentID}");
        }
    }
}
