using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 40, 52, 73, 65, 11 };
            var sorted = numbers.OrderBy(n => n);

            var sortedDesc = numbers.OrderByDescending(n => n);

            Console.WriteLine("Ascending Order");
            foreach (int n in sorted)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("descending order");

            foreach (int n in sortedDesc)
            {
                Console.WriteLine(n); 
            }
            Console.ReadLine();
        }
    }
}
