using System;
using System.Threading;

namespace CreateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "t1";
            Thread t1 = new Thread(() => Console.WriteLine(text));

            text = "t2";
            Thread t2 = new Thread(() => Console.WriteLine(text));

            t1.Start();
            t2.Start();
        }
    }
}
