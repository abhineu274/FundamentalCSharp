using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    //Delegates - a type safe function pointer
    /*
     * Action<T> - represents a method that takes a single parameter and does not return a value
     * Func<T, TResult> - represents a method that takes a single parameter and returns a value
     * Predicate<T> - represents a method that takes a single parameter and returns a boolean value
     */
    internal class DelegatesGeneric
    {
        public static void Greeter(string message, Action<string> greetHandler) //We are getting the method as an argument from the caller
        {
            greetHandler(message); //we are just invoking the method
        }

        public static void Print(int a)
        {
            Console.WriteLine(a);
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
        static void Main()
        {
            Action<int> action = Print;
            action(10);
            Action<int> action7 = (int a) => Console.WriteLine(a); //lambda expression - Action function takes only one parameter and does not return a value
            action7(20);

            Func<int, int> func = (int a) => a * a; //lambda expression - Func function takes only one parameter and returns a value
            Console.WriteLine(func(10));

            Func<int, int, int> func1 = Sum; //Func function takes multiple parameters and returns a value - Here last int in the declaration represents the return type
            Console.WriteLine(func1(10, 20));

            Predicate<int> predicate = IsEven; 
            Console.WriteLine(predicate(10));

            Predicate<int> predicate1 = (int a) => a % 2 != 0; //lambda expression
            Console.WriteLine(predicate1(11));

            Action<string> action1 = (string message) => Console.WriteLine(message); //lambda expression
            Greeter("Hello", action1);

            Greeter("Hello", Console.WriteLine); //Action delegate - concise way to represent the above code

            //concise ways 
            Func<int, int> func2 = (a) => a * a * a;
            Console.WriteLine(func2(10));
            Predicate<int> predicate2 = a => a % 2 == 0;
            Console.WriteLine(predicate2(10));
            Action<string> action2 = message => Console.WriteLine(message);
            Greeter("Hello World!", action2);




            // Delegates with Collections
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Predicate<int> predicate3 = a => a % 2 == 0;
            numbers.FindAll(predicate3).ForEach(Console.WriteLine);

            Func<int, int> func3 = a => a * a;
            numbers.Select(func3).ToList().ForEach(Console.WriteLine);

            Action<int> action3 = a => Console.WriteLine(a);
            numbers.ForEach(action3);

            numbers.Where(a => a % 2 == 0).ToList().ForEach(Console.WriteLine); //Where and other functions also use delegates like predicate and others underneath
        }

    }
}
