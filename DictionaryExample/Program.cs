using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Pranav");
            students.Add(2, "Rahul");
            students.Add(3, "Karan");

            foreach(KeyValuePair<int, string> item in students)
            {
                Console.WriteLine("Roll No: " + item.Key + " Name: "+item.Value);
            }
            Console.ReadLine();
        }
    }
}
