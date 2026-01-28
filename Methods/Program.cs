using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void SayHello()
        {
            Console.WriteLine("Hello, Welcome to C# Method!");
        }

        static void AddNumber(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("sum of a+b: " + sum);
        }
        static void Main(string[] args)
        {
            SayHello();
            AddNumber(24, 26);
        }
    }
}
