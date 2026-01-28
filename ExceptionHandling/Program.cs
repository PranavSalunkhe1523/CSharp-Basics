using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You  entered: " + num);
            }
            catch(Exception e)
            {
                Console.WriteLine("Eorre:Please enter a valid number.");
            }
            Console.ReadLine();
        }
    }
}
