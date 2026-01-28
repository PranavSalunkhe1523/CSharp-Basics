using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass_Obj
{
    class Student
    {
        public string Name;
        public int Age;

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Pranav";
            s1.Age = 22;
            s1.Display();

            Console.WriteLine();
            
        }
    }
}