﻿using System;
using System.Threading;

namespace QueueUserWorkItem
{
    class Program
    {
        static void Main()
        {
            ThreadPool.QueueUserWorkItem(Go);
            ThreadPool.QueueUserWorkItem(Go, 123);
            Console.ReadLine();
        }
        static void Go(object data)   // data will be null with the first call.
        {
            Console.WriteLine("Hello from the thread pool! " + data);
        }
    }
}
