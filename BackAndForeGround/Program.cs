using System;
using System.Threading;

namespace BackAndForeGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread worker = new Thread(() => Console.ReadLine());
            if (args.Length > 0) worker.IsBackground = true;
            worker.Name = "backThread";
            worker.Start();
            Console.WriteLine("finish!");
        }
    }
}
