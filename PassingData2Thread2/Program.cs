using System;
using System.Threading;

namespace PassingData2Thread2
{
    class Program
    {
        static void Main()
        {
            Thread t = new Thread(Print);
            t.Start("Hello from t!");
        }

        static void Print(object messageObj)
        {
            string message = (string)messageObj;   // We need to cast here
            Console.WriteLine(message);
        }
    }
}
