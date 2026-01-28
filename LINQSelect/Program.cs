using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSelect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =new List<int>() { 10,20,30,40,50};
            var result = numbers.Select(n => n * 2);

            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
