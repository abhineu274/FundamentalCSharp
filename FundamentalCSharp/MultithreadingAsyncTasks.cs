using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    //Thread is a low level construct, while Task is an abstraction over a thread
    /*
     * Async Task is a non blocking Task. If you have a time consuming Task, you can make it asynchronous using the async keyword
     * So that you can move furthur and don't have to wait for the Task to complete
     * That task will run in the background and you can do other work
     * Task can be multi-threaded or single threaded
     */
    internal class MultithreadingAsyncTasks
    {
        public static int PrintA() //normal method 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("PrintA: " + i);
            }
            Thread.Sleep(5000);
            return 1;
        }

        public static async Task<int> PrintB() //async method with Task<int> return type 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("PrintB: " + i);
            }
            await Task.Delay(5000);
            return 2;
        }

        static async Task Main()
        {
            int taskA = PrintA();
            Console.WriteLine("outside of printA");
            Console.WriteLine("result of taskA: " + taskA);
            //Output - PrintA 0,1,2,3,4,<5 seconds delay> outside of printA, result of taskA: 1

            Task<int> taskB = PrintB(); //taskB is a Task<int> type
            Console.WriteLine("outside of printB");
            await taskB; //wait for the task to complete - "await is don't wait?"
            //"Wait for this task to finish, but don't block the current thread. Resume execution here when the task is done."
            Console.WriteLine("result of taskB: " + taskB.Result); //taskB.Result will give the result of the task
            //Output - PrintB 0,1,2,3,4 outside of printB, <5 seconds delay> result of taskB: 2
            //So, this will not wait for the task to complete and will move furthur
        }
    }
}
