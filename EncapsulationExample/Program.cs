using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    class bankAccount
    {
        private int Balance;

        public void SetBalance(int amount)
        {
            Balance = amount;
        }
        public int GetBalance()
        {
            return Balance;
        }
    }
   
    internal class Program
    {
        static void Main(string[] args)
        {
            bankAccount acc = new bankAccount();

            acc.SetBalance(5000);
            Console.WriteLine("Balance: " + acc.GetBalance());

            Console.ReadLine();
        }
    }
}
