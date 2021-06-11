using System;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp6
{
    class Program
    {
        static void Go(object num)
        {
            int n = (int)num;
            if (n <= 0)
                return;
            Thread t = new Thread(Go);
            t.Name = "Thread" + n;
            t.Start(n - 1);
            Console.WriteLine(t.Name);
        }
        private static void Main(string[] args)
        {
            Go(10);
            Console.ReadKey();
        }
    }
}
