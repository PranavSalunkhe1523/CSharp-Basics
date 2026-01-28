using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Person // Parent class
    {
        public string Name;

        public void shownName()
        {
            Console.WriteLine("Name: " + Name);
        }
    }
    class Student : Person  // Child class
    {
        public int RollNo;

        public void ShowRollNo()
        {
            Console.WriteLine("Roll No: " + RollNo);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Pranav";
            s1.RollNo = 101;
            s1.shownName();
            s1.ShowRollNo();

            Console.ReadLine();
        }
    }
}
