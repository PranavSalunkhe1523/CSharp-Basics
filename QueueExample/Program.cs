using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            foreach(int i in queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(queue.Dequeue());

            Console.ReadLine();
        }
    }
}
