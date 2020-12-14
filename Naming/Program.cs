using System;
using System.Threading;

namespace Naming
{
    class Program
    {
        class ThreadNaming
        {
            static void Main()
            {
                Thread.CurrentThread.Name = "main";
                Thread worker = new Thread(Go);
                worker.Name = "worker";
                worker.Start();
                Go();
            }

            static void Go()
            {
                Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
            }
        }
    }
}
