using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAppend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path= @"D:\Users\Csharp\source\repos\FileHandlingExample\FileHandlingExample\bin\Debug\sample.txt";

            File.AppendAllText(path, "\nThis Line addedd using append.\n What is your name? \n How are yoy?");
            Console.WriteLine("Text Appended Succesfully.");
            Console.ReadLine();
        }
    }
}
