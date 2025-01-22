using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    /*
     * What is Mutex in C#?
     * Mutex is a synchronization primitive that is used to protect shared resources between multiple threads
     * Mutex is used to prevent conflicts between threads
     * Lock vs Mutex
     * Lock is used to lock the resources that are shared between multiple threads
     * Mutex is used to protect shared resources between multiple threads
     * Lock - Prefered when you need thread synchronization in a single process. It is faster than Mutex
     * Mutex - Prefered when you need synchronization between multiple processes. It is slower than Lock
    */
    internal class MultithreadingMutex
    {
        private static readonly Mutex Mutex = new Mutex(); //create a mutex object
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                /*
                Task.Factory.StartNew(() => //this will create a new thread/task
                {
                    Mutex.WaitOne(); //This will lock the resource. If a thread is writing to the file, then the other threads have to wait
                    //If we do not use Mutex, then the threads will try to write to the file at the same time and it will throw an exception
                    File.AppendAllText(@"C:\Learning\test.txt", "Hello World");
                    Thread.Sleep(1000); //sleep for 1 second, when this thread is sleeping, the other threads will execute and it will try to write to the same file
                    File.AppendAllText(@"C:\Learning\test.txt", "Bye World");
                    Mutex.ReleaseMutex(); //This will release the mutex so that the other threads can write to the file
                });
                */

                Task.Factory.StartNew(() => //this will create a new thread/task
                {
                    if (Mutex.WaitOne(4000)) //The thread will wait for 4 seconds to acquire the mutex. If it is not acquired, then it will return false
                    {
                        try
                        {
                            File.AppendAllText(@"C:\Learning\test.txt", "Hello World");
                            //Thread.Sleep(1000);
                            Thread.Sleep(5000); //sleep for 5 seconds, when this thread is sleeping, the other threads will execute and it will try to write to the same file
                            //but since the next thread can only wait for 4 seconds, it will not be able to acquire the mutex and it will return false
                            File.AppendAllText(@"C:\Learning\test.txt", "Bye World");
                        }
                        finally
                        {
                            Mutex.ReleaseMutex();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Mutex is not acquired");
                    }
                });

            }
            //Think of a common resource like a washroom or something. If a person is using the washroom, then the other person has to wait
            Console.ReadKey(); //this will prevent the console from closing until a key is pressed
        }
    }
}
