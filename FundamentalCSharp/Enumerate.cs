using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    internal class Enumerate
    {
        static void Main()
        {
            //IEnumerable - Interface that allows you to iterate over a collection - commonly used - for each loop
            //IEnumerator - Interface that allows you to iterate over a collection - gives you more control
            //IQueryable - Interface that allows you to query a database

            //IEnumerable
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            // IEnumerable in action
            IEnumerable<int> enumerable = numbers;
            foreach (var num in enumerable) // we can use foreach loop to iterate over IEnumerable
            {
                Console.WriteLine(num);
            }

            var numbers2 = new int[] { 10, 20, 30 };
            IEnumerator enumerator = numbers2.GetEnumerator(); // we can use GetEnumerator() method to get IEnumerator

            while (enumerator.MoveNext()) // we can use MoveNext() method to move to the next element
            {
                Console.WriteLine(enumerator.Current);
            }

            // IQueryable
            // IQueryable is used to query a database
            // IQueryable is a generic interface that inherits from IEnumerable
            // To query the in-memory collection, its better to use IEnumerable
        }
    }
}
