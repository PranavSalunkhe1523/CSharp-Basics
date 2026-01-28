using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal make a sound");
        }
    }
    class dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    class Cat: Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat meows");
        }
    }
     internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new dog();
            Animal a2 = new Cat();
            a1.Sound();
            a2.Sound();
            Console.ReadLine();
        }
    }
}
