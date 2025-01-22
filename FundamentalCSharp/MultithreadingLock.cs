using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    //What is Lock in C#?
    //Lock is a keyword in C# that is used to lock the resources that are shared between multiple threads
    //If a resource is locked by a thread, then the other threads have to wait for the resource to be unlocked
    //This is used to prevent conflicts between threads
    //To avoid race conditions, we can use lock. Race condition is a situation where two or more threads try to modify a shared resource at the same time

    internal class MultithreadingLock
    {
        private static readonly object Lock = new object(); //create a lock object
        static void Main()
        {

            for (int i = 0; i < 5; i++)
            {
                Task.Factory.StartNew(() => //this will create a new thread/task
                {
                    lock (Lock) //This will lock the resource. If a thread is writing to the file, then the other threads have to wait
                    //If we do not use lock, then the threads will try to write to the file at the same time and it will throw an exception
                    {
                        File.AppendAllText(@"C:\Learning\test.txt", "Hello World");
                        Thread.Sleep(1000); //sleep for 1 second, when this thread is sleeping, the other threads will execute and it will try to write to the same file
                        File.AppendAllText(@"C:\Learning\test.txt", "Bye World");
                    }
                });
            }
            //Think of a common resource like a washroom or something. If a person is using the washroom, then the other person has to wait
            Console.ReadKey(); //this will prevent the console from closing until a key is pressed
        }
    }
}
