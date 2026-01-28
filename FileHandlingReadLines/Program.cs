using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingReadLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path= @"D:\Users\Csharp\source\repos\FileHandlingExample\FileHandlingExample\bin\Debug\sample.txt";

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
