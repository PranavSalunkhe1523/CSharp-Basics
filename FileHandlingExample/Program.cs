using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "sample.txt";
            File.WriteAllText(path, "Hello Pranav");

            Console.WriteLine("Data written to file succfully");

            Console.ReadLine();
        }
    }
}
