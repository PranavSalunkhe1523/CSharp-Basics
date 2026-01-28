using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileHandlingExampleRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\Users\\Csharp\\source\\repos\\FileHandlingExample\\FileHandlingExample\\bin\\Debug\\sample.txt";

            string content = File.ReadAllText(path);
            Console.WriteLine(content);
            Console.ReadLine();
        }
    }
}
