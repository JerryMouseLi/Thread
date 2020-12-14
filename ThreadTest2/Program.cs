using System;
using System.Threading;

namespace ThreadTest2
{
    class ThreadTest2
    {
        static readonly object locker = new object();
        bool done;

        static void Main()
        {
            ThreadTest2 tt = new ThreadTest2();   // Create a common instance
            new Thread(tt.Go).Start();
            tt.Go();
        }

        // Note that Go is now an instance method
        void Go()
        {
            lock (locker)
            {
                if (!done)
                {                  
                  Console.WriteLine("Done");
                  done = true;
                }
            }
        }
    }
}
