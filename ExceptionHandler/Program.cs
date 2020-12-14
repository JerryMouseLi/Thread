using System;
using System.Threading;

namespace ExceptionHandler
{
    class Program
    {
        public static void Main()
        {
            try
            {
                new Thread(Go).Start();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                // We'll never get here!
                Console.WriteLine("Exception!");
            }
        }

        static void Go() { throw null; }   // Throws a NullReferenceException

        static void GoCatch()
        {
            try
            {
                // ...
                throw null;    // The NullReferenceException will get caught below
                               // ...
            }
            catch (Exception ex)
            {
                // Typically log the exception, and/or signal another thread
                // that we've come unstuck
                // ...
                Console.WriteLine("exception.");
            }
        }


    }
}
