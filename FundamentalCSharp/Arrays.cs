using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
    internal class Arrays
    {
        static void Main()
        {
            int[] arr = new int[10];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int[] arr2 = { 1, 2, 3, 4, 5 };
            foreach (int a in arr2)
            {
                Console.WriteLine(a);
            }

            int[,] arr3 = new int[2, 2]; // 2D array declaration in c# as oppsed to [2][2] in java
            arr3[0, 0] = 1;
            arr3[0, 1] = 2;
            arr3[1, 0] = 3;
            arr3[1, 1] = 4;
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.WriteLine(arr3[i, j]);
                }
            }

            Console.WriteLine(arr3.GetLength(0)); // 2 - number of rows
            Console.WriteLine(arr3.GetLength(1)); // 2 - number of columns

            int[,,] arr4 = // 3D array declaration in c# as oppsed to [2][2][2] in java
            {
                { 
                    { 1, 2 }, 
                    { 3, 4 } 
                }, 
                { 
                    { 5, 6 }, 
                    { 7, 8 }
                }
            };

            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4.GetLength(1); j++)
                {
                    for (int k = 0; k < arr4.GetLength(2); k++)
                    {
                        Console.WriteLine(arr4[i, j, k]);
                    }
                }
            }

            int[] arr5 = { 5, 7, 4, 6, 2 };
            Console.WriteLine(arr5.Length);
            Console.WriteLine(arr5.Rank); // Rank is the number of dimensions in the array
            Array.Sort(arr5); //sorts the array
            Array.Reverse(arr5); //reverses the array
            Array.ForEach(arr5, Console.WriteLine); //prints the array
            Console.WriteLine(Array.IndexOf(arr5, 4)); //returns the index of the element in the array
            Console.WriteLine(Array.Exists(arr5, element => element == 4)); //returns true if the element exists in the array
            Console.WriteLine(Array.Find(arr5, element => element == 4)); //returns the element if it exists in the array
            Console.WriteLine(Array.FindIndex(arr5, element => element == 4)); //returns the index of the element if it exists in the array
            Console.WriteLine(Array.TrueForAll(arr5, element => element > 0)); //returns true if all the elements in the array are greater than 0
            Array.Clear(arr5, 0, arr5.Length); //clears the array

            int[] arr6 = new int[5];
            arr5.CopyTo(arr6, 0); //copies the elements of arr5 to arr6, here 0 is index of arr6 where the copying starts

            arr5.DistinctBy(element => element); //returns the distinct elements in the array
            arr5.Except(arr6); //returns the elements in arr5 that are not in arr6
            arr5.ToList(); //converts the array to a list
            /*arr5.ToDictionary(element => element, element => element);*/ 
            //converts the array to a dictionary with key and value as the element
            arr5.Sum(); //returns the sum of the elements in the array
            arr5.Max(); //returns the maximum element in the array
            arr5.Min(); //returns the minimum element in the array
            arr5.Average(); //returns the average of the elements in the array
            arr5.Concat(arr6); //concatenates arr5 and arr6
            //There are lot of methods like this - Concat, Union, Intersect, Except, Distinct, Reverse, ToList, ToDictionary, Sum, Max, Min, Average, Aggregate, All,
            //Any, Contains, Count, ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault, Skip, SkipWhile, Take,
            //TakeWhile, ToArray, ToLookup, ToHashSet, ToList, ToDictionary, ToImmutableDictionary, ToImmutableList, ToImmutableQueue, ToImmutableStack, ToImmutableHashSet,
            //ToLookup, ToSortedList, ToSortedDictionary, ToSortedSet, ToHashSet, ToList, ToDictionary


            Product[] products = new Product[3];
            products[0] = new Product(1, "Product1", 400);
            products[1] = new Product(2, "Product2", 200);
            products[2] = new Product(3, "Product3", 300);
            foreach (Product p in products)
            {
                Console.WriteLine(p.Id + " " + p.Name + " " + p.Price);
            }

            //sorting product array based on price
            Array.Sort(products, (p1, p2) => p1.Price.CompareTo(p2.Price)); //sorts the array based on price in ascending order
            Array.Sort(products, (p1, p2) => p2.Price.CompareTo(p1.Price)); //sorts the array based on price in descending order

            Array.ForEach(products, p => Console.WriteLine(p.Id + " " + p.Name + " " + p.Price)); //prints the array




        }
    }
}
