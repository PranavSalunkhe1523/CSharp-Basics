using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    abstract class Shape
    {
        public abstract void Draw();
    }
    class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");

        }
    }
     class Reactangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a reactangle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Circle();
            Shape s2 = new Reactangle();

            s1.Draw();
            s2.Draw();

            Console.ReadLine();
        }
    }
}
