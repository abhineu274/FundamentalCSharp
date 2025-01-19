using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    //It is a technique of executing to perform multiple operations simultaneously
    //Your tasks are divided into subtasks/thread and they are executed simultaneously

    /*
     * So, basically - a single core of a cpu can execute only one thread at a time
     * so, if you are executing a task that takes a long time to execute, then the other tasks will have to wait
     * this will waste the cpu cycles and make the application slow
     * To fix this, we can divide the task into subtasks and execute them simultaneously with the help of multithreading
     * So, if a thread is waiting for some operation to complete, then the other threads can execute their tasks
     * Think of a ticket counter - if there is only line, then the other people have to wait for their turn even if there is some issue with the current person
     * But if there are multiple lines, then people from other lines can be served
     * This is how multithreading works on a high level
     */
    internal class Multithreading
    {
        static void Print1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Print1: " + i);
                if(i == 5)
                {
                    Console.WriteLine("Print1 is going to sleep");
                    Thread.Sleep(500); //sleep for 5 seconds
                    Console.WriteLine("Print1 is awake");
                }
            }
        }

        static void Print2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Print2: " + i);
            }
        }

        static void Main()
        {
            //calling the methods normally
            Print1(); //this will execute first
            Print2(); //this will execute after Print1

            //Multithreading
            //To execute the above methods simultaneously, we can use threads
            Console.WriteLine("Multithreading");
            Thread t1 = new Thread(Print1);
            Thread t2 = new Thread(Print2);
            t1.Start();
            t2.Start();
        }
    }
}

/*
 *     
      public static void Main(string[] args)        //AMIEE Main method
    { 
        Activity.DefaultIdFormat = ActivityIdFormat.W3C;

        CreateHostBuilder(args).Build().Run();
    }
*/
