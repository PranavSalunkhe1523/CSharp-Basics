using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10,26,54,11,72};

            var result = numbers.Where(n => n > 20);
            foreach(int n in result)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
