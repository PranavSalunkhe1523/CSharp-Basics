using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    class Employee
    {
        public int Id;
        public string Name;

        //Constructor
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Employee ID: " + Id);
            Console.WriteLine("Employee Name: " + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee s1 = new Employee(101,"Vivek");
            s1.ShowDetails();
            Console.ReadLine();

        }
    }
}
