using System;
using System.Threading;

namespace threading
{
    class Program///This C# program is used to display the priority of the thread. There are various priorities for the thread are Zero, Below Normal, Normal, Above Normal, and Highest are one such. The priority of the current working thread is found by using the priority() function and print the thread.//
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Current Thread Informations**************n");
            Thread t = Thread.CurrentThread;
            t.Name = "Primary_Thread";

            Console.WriteLine("Thread Name: {0}", t.Name);
            Console.WriteLine("Thread Status: {0}", t.IsAlive);
            Console.WriteLine("Priority: {0}", t.Priority);

            Console.ReadKey();
        }

    }
}
///Output:
///Thread Name: PrimaryThread
///Thread Status: True
///Priority: Normal