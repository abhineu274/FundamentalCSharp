using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    //Delegates - a type safe function pointer
    //Delegates are used to pass methods as arguments to other methods
    //Delegates are used to define callback methods

    //Delegates are types, which holds the reference of a method or multiple methods
    //Delegates are useful to achieve callback mechanism in c#
    //Callback mechanism - a method is called when a particular event occurs/ triggering a method when a particular event occurs manually

    //Step 1: Define a delegate
    public delegate int SumDelegate(int a, int b);
    internal class Delegates
    {
        //Step 2: Create a method that matches the signature of the delegate
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static void PrintSum(int a, int b, SumDelegate sumDelegate)
        {
            var sum = sumDelegate(a, b);
            Console.WriteLine(sum);
        }
        static void Main()
        {
            //Step 3: Create an instance of the delegate and pass the method as an argument or assign the method to the delegate
            SumDelegate sumDelegate = Sum;
            PrintSum(10, 20, sumDelegate);

            SumDelegate sumDelegate1 = new SumDelegate(Sum); //another way to create an instance of the delegate
            PrintSum(20, 30, sumDelegate1);

            //Anonymous method - a method without a name
            SumDelegate sumDelegate2 = delegate (int a, int b)      //without using the delegate type declared above or the Sum method
            {
                return a + b;
            };

            PrintSum(30, 40, sumDelegate2);

            //Lambda expression - a concise way to represent an anonymous method
            SumDelegate sumDelegate3 = (int a, int b) => a + b;     //without using the delegate type declared above or the Sum method
            PrintSum(40, 50, sumDelegate3);
        }
    }
}

/*
using System;

namespace DelegateExample
{
    // Declare a delegate
    public delegate void Notify(string message);

    class Program
    {
        // Method matching delegate signature
        public static void SendMessage(string msg)
        {
            Console.WriteLine("Message: " + msg);
        }

        static void Main()
        {
            // Assign method to delegate
            Notify notify = SendMessage;

            // Invoke delegate
            notify("Hello Delegate!");
        }
    }
}

 */
