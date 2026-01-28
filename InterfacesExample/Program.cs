using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    interface IFather
    {
        void FatherProperty();
    }
    interface IMother
    {
        void MotherProperty();
    }

    class Child : IFather, IMother
    {
        public void FatherProperty()
        {
            Console.WriteLine("Father's property");
        }
        public void MotherProperty()
        {
            Console.WriteLine("Mother's property");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.FatherProperty();
            c.MotherProperty();

            Console.ReadLine();
        }
    }
}
