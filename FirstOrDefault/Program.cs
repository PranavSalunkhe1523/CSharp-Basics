using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10,20,30, 40 };

            int FirstNumber = numbers.FirstOrDefault();

            Console.WriteLine("firest number is :  " + FirstNumber);
            Console.ReadLine();
        }
    }
}
