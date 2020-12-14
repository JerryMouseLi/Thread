using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolTPL
{
    class Program
    {
        static void Main()    // The Task class is in System.Threading.Tasks
        {
            var task=Task.Factory.StartNew(Go);
            Console.WriteLine("main");
            try
            { task.Wait(); }                                   
             catch (Exception e)
            {
                Console.WriteLine("exception!");
            }
            Console.WriteLine(task.Result);
            Console.ReadLine();
        }
        static string Go()
        {
            if (Thread.CurrentThread.IsThreadPoolThread)
            { Console.WriteLine("Hello from the thread pool!"); }
            else { Console.WriteLine("Hello just from the thread!"); }
            throw null;
            return "task complete!";
        }
    }
}
