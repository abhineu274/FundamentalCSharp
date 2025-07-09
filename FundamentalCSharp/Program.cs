namespace School // This is a namespace
{
    internal class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        
        public Student(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }

        public Student() { }
        public void Display()
        {
            Console.WriteLine("Name : {0}, RollNo : {1}", Name, RollNo);
        }
    }
    internal class Program
    {
        static void AddFive(ref int number) //ref
        {
            number += 5; // This method modifies the original variable
        }

        static void GetValues(out int x, out int y) //out
        {
            x = 5; // This method initializes the out parameters
            y = 10;
        }

        static void PrintNumber(in int number) //in
        {
            Console.WriteLine("The number is: " + number); // This method reads the value without modifying it
        }

        public static IEnumerable<int> GetEvenNumbers(int[] input) // Using yield to return even numbers from an array
        {
            foreach (var num in input)
            {
                if (num % 2 == 0)
                    yield return num; //instead of creating an array or list, we yield each even number one by one, so no need to create an array to return all even numbers at once
            }
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Hello World!"); //To display a message on the console
            string str = Console.ReadLine(); //To read a line from the console
            int num = Convert.ToInt32(str); //To convert a string to an integer
            double d = Convert.ToDouble(Console.ReadLine()); //To convert a string to a double
            Console.WriteLine("You entered : " + num); //To display a message on the console
            Console.WriteLine($"{num} - {Math.Pow(num, 2)}");

            /*
             * Convert.ToInt32() - Converts the specified string representation of a number to an equivalent 32-bit signed integer
             * Convert.ToInt64() - Converts the specified string representation of a number to an equivalent 64-bit signed integer
             * Convert.ToDouble() - Converts the specified string representation of a number to an equivalent double-precision floating-point number
             * 
             */

            //Ref, Out, In
            int myNumber = 10;
            AddFive(ref myNumber);
            Console.WriteLine(myNumber); // Output: 15

            int x, y; // Uninitialized
            GetValues(out x, out y);
            Console.WriteLine(x); // 5
            Console.WriteLine(y); // 10

            int myValue = 42;
            PrintNumber(in myValue); // OK

            //yield
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> evens = GetEvenNumbers(numbers);
            foreach (var n in evens)
            {
                Console.WriteLine(n);
            }
        }
    }
}


/*
 * Tutorials Flow:
 * Variables, Data Types and Constants
 * Type Casting - Boxing/Unboxing
 * Operators
 * Conditional Statements
 * Loops
 * Jump Statements
 * 
 * Class, Object and Namespace
 * Constructors
 * Inheritance
 * Method Overriding and Overloading
 * Access Modifiers
 * Properties
 * Static Class, static variables, static methods
 * Abstract Class
 * Interfaces
 * Exception Handling
 * Arrays
 * Boxing Unboxing
 * Collections
 * Extension Methods
 * Enums
 * Indexers
 * Delegates
 * Generic Delegates - Action, Func, Predicate
 * Multithreading
 * Async await
 * 
 * 
 * Linq
 * Multithreading Async Tasks
 * MultithreadingLock
 * MultithreadingMutex
 * MultithreadingTasks
 * 
 * 
 */




/*
 * Without yield :
public IEnumerable<int> GetNumbers()
{
    List<int> numbers = new List<int>();
    for (int i = 0; i < 5; i++)
    {
        numbers.Add(i);
    }
    return numbers;
}

With yield :
Same output — but no need to allocate List<int>.
And elements are produced one at a time.

public IEnumerable<int> GetNumbers()
{
    for (int i = 0; i < 5; i++)
    {
        yield return i; // This will return each number one by one
    }
}

Real life use case:
public IEnumerable<int> GetEvenNumbers(int[] input)
{
    foreach (var num in input)
    {
        if (num % 2 == 0)
            yield return num;
    }
}

*/