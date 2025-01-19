using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    internal class MultithreadingTasks
    {
        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Number: {i}");
            }
        }

        static async Task Main() //async keyword is used to make the method asynchronous. Also the return type of the method should be Task or Task<T>
        {
            Task task = Task.Run(PrintNumbers);

            Console.WriteLine("Main thread is free to do other work...");
            await task; // Wait for the task to complete

            Parallel.For(0, 5, i => //Parallel.For is used to run the loop in parallel
            {
                Console.WriteLine($"Task {i} running.");
            });
        }
    }
}

/*
 * Task - represents an asynchronous operation
 * Task Methods - 
 * WhenAll - waits for all the tasks to complete
 * When - 
 */

/*Real Life Use Case -
     
    [HttpPost]
    public async Task<IActionResult> GetInbox([FromBody] GetUserInboxQuery query)
    {
        var result = await _mediator.Send(query);
        return Ok(result);
    }

    //In the above code, the GetInbox method is asynchronous. The method is free to do other work while the task is running.
    //The await keyword is used to wait for the task to complete. The method will return the result once the task is completed.

            //Retention related stuff
            Task<int> task1, task2, task3;

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(timeInSeconds));

            int task1Count=0, task2Count=0, task3Count=0;

            task1 = DoTask1(batchSize);
            task2 = DoTask2(batchSize);
            task3 = DoTask3(batchSize);

            do
            {
                await Task.WhenAll(task1, task2, task3); //Wait for all the tasks to complete

                task1Count = task1.Result;
                task2Count = task2.Result;
                task3Count = task3.Result;

                if (task1Count + task2Count + task3Count == 0)
                    break;

                task1 = task1Count > 0 ? DoTask1(batchSize) : Task.FromResult(0);
                task2 = task2Count > 0 ? DoTask2(batchSize) : Task.FromResult(0);
                task3 = task3Count > 0 ? DoTask3(batchSize) : Task.FromResult(0);
            } while (!cancellationTokenSource.IsCancellationRequested);
 */

