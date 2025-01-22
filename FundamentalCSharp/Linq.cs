using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    //There are two types of Linq queries - 
    //1. Query Syntax
    //2. Method Syntax
    //Query Syntax is similar to SQL queries
    //Method Syntax is similar to method chaining

    class LinqStudent
    {
        public string Name { get; set; }
        public List<string> Subjects { get; set; }
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
    }

    internal class Linq
    {
        static void Main()
        {
            //Method Syntax
            List<int> list = new List<int>() { 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 4 };
            List<int> listEmpty = new List<int>();

            var distinctList = list.Distinct(); //Distinct() is a method in Linq that returns distinct elements from a list
            var evenNums = list.Where(x => x % 2 == 0); //Where() is a method in Linq that filters elements based on a condition
            var sortedList = list.OrderBy(x => x); //OrderBy() is a method in Linq that sorts elements in ascending order
            var descendingList = list.OrderByDescending(x => x); //OrderByDescending() is a method in Linq that sorts elements in descending order
            var firstElement = list.First(); //First() is a method in Linq that returns the first element in a list

            var first = list.FirstOrDefault(); //FirstOrDefault() is a method in Linq that returns the first element in a list or a default value if the list is empty
            var last = list.LastOrDefault(); //LastOrDefault() is a method in Linq that returns the last element in a list or a default value if the list is empty

            var LastElement = list.Last(); //Last() is a method in Linq that returns the last element in a list
            var count = list.Count(); //Count() is a method in Linq that returns the number of elements in a list
            var sum = list.Sum(); //Sum() is a method in Linq that returns the sum of elements in a list
            var average = list.Average(); //Average() is a method in Linq that returns the average of elements in a list
            var max = list.Max(); //Max() is a method in Linq that returns the maximum element in a list
            var min = list.Min(); //Min() is a method in Linq that returns the minimum element in a list

            var any = list.Any(x => x % 5 == 0); //Any() is a method in Linq that returns true if there are any elements in a list
            var all = list.All(x => x > 2); //All() is a method in Linq that returns true if all elements in a list satisfy a condition

            //Take and Skip
            var take = list.Take(5); //Take() is a method in Linq that returns the first n elements from a list
            var skip = list.Skip(5); //Skip() is a method in Linq that skips the first n elements from a list

            foreach (var item in take)
            {
                Console.WriteLine(item);
            }
            foreach (var item in skip)
            {
                Console.WriteLine(item);
            }

            //Zip
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<char> list2 = new List<char>() { 'a', 'b', 'c', 'd', 'e' };
            var zippedList = list1.Zip(list2, (x, y) => x + " " + y); //Zip() is a method in Linq that combines two lists into one based on a condition
            //x - element from list1, y - element from list2

            foreach (var item in zippedList)
            {
                Console.WriteLine(item);
            }

            //aggregate
            var aggregate = list.Aggregate((accum, num) => accum + num); //Aggregate() is a method in Linq that performs an operation on all elements in a list
            Console.WriteLine(aggregate);

            //Select Many

            var students = new List<LinqStudent>
            {
            new LinqStudent { Name = "Alice", Subjects = new List<string> { "Math", "Science" } },
            new LinqStudent { Name = "Bob", Subjects = new List<string> { "English", "History" } },
            new LinqStudent { Name = "Charlie", Subjects = new List<string> { "Math", "Art", "History" } }
            };

            var subjects = students.SelectMany(x => x.Subjects).Distinct(); //SelectMany() is a method in Linq that flattens a list of lists into a single list

            foreach (var subject in subjects)
            {
                Console.WriteLine(subject);
            }


            //Query Syntax
            var evenNumbers = from num in list
                              where num % 2 == 0
                              select num;
            Console.WriteLine(evenNumbers);

            //Join
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Alice" },
                new Customer { Id = 2, Name = "Bob" },
                new Customer { Id = 3, Name = "Charlie" }
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, CustomerId = 1, ProductName = "Laptop" },
                new Order { Id = 2, CustomerId = 2, ProductName = "Mobile" },
                new Order { Id = 3, CustomerId = 1, ProductName = "Tablet" },
                new Order { Id = 4, CustomerId = 3, ProductName = "Desktop" }
            };

            var customerOrders = from customer in customers
                                 join order in orders on customer.Id equals order.CustomerId
                                 select new
                                 {
                                     CustomerName = customer.Name,
                                     Product = order.ProductName
                                 };

            foreach (var item in customerOrders)
            {
                Console.WriteLine(item.CustomerName + " - " + item.Product);
            }

            //IQueryable - used for querying data from a database
            //Deferred Execution - Linq queries are executed only when the result is needed
            IQueryable<int> queryableList = list.AsQueryable(); //AsQueryable() is a method in Linq that converts a list to an IQueryable

        }
    }
}