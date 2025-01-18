using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    /*
     * Collections in C#:
     * Non Generic Collections: ArrayList, HashTable, SortedList, Stack, Queue
     * Generic: List<T>, Dictionary<TKey, TValue>, Queue<T>, Stack<T>, HashSet<T>, SortedSet<T>, SortedList<TKey, TValue>, LinkedList<T> 
     * 
     * Generic Collections are type safe and can store only specific type of data
     * It is recommended to use Generic Collections
     */
    internal class CollectionsGeneric
    {
        class GenericProduct
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public GenericProduct(int id, string name, double price)
            {
                Id = id;
                Name = name;
                Price = price;
            }
            //toString method to display object details
            public override string ToString()
            {
                return $"Id: {Id}, Name: {Name}, Price: {Price}";
            }
        }
        static void Main()
        {
            //List<T> - To store elements in a sequence - List of elements - Array Equivalent
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Insert(1, 4); //insert at index 1
            list.Remove(3); //remove 3 value from the list
            list.RemoveAt(0); //remove value at index 0
            Console.WriteLine(list.Contains(2)); //true
            Console.WriteLine(list.Count); //2
            int[] ints1 = list.ToArray(); //convert list to array

            //list iteration using foreach loop
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            //getting a dictionary from this list
            Dictionary<int, int> dict = list.ToDictionary(x => x, x => x * x); //[<1,1>, <2,4>, <3,9>]
            Console.WriteLine(dict[2]); //4
            //sorting list
            list.Sort();
            list.Clear(); //clear the list

            //initialize list with array
            List<int> list2 = new List<int>(new int[] { 1, 2, 3, 4, 5 });
            //initialize list 
            List<int> list3 = new List<int>() { 1, 2, 3, 4, 5 };


            //List of objects
            List<GenericProduct> products = new List<GenericProduct>();
            products.Add(new GenericProduct(1, "Product1", 100.0));
            products.Add(new GenericProduct(2, "Product2", 200.0));
            products.Add(new GenericProduct(3, "Product3", 300.0));
            products.Insert(1, new GenericProduct(4, "Product4", 400.0)); //insert at index 1
            //iteration using for
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i]);
            }
            //sorting list of objects
            products.Sort((x, y) => x.Price.CompareTo(y.Price));
            foreach (GenericProduct product in products)
            {
                Console.WriteLine(product);
            }


            //Dictionary<TKey, TValue> - To store key value pairs - Map Equivalent
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary[4] = "Four"; //add key value pair
            Console.WriteLine(dictionary[2]); //Two - get value for key 2
            Console.WriteLine(dictionary); //true
            //Get key from value
            int key = dictionary.FirstOrDefault(x => x.Value == "Three").Key;

            dictionary.Remove(3); //remove key 3
            Console.WriteLine(dictionary.ContainsKey(2)); //true
            Console.WriteLine(dictionary.Count); //3
            List<int> ints = new List<int>(dictionary.Keys); //get keys
            List<string> strings = new List<string>(dictionary.Values); //get values

            //dictionary iteration using foreach loop
            foreach (KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            //sorting dictionary based on key
            var sortedDict = dictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine(sortedDict);

            dictionary.Clear(); //clear the dictionary


            //Queue<T> - To store elements in a sequence - First In First Out (FIFO) - Queue Equivalent
            //Duplicate elements are allowed
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue()); //1
            Console.WriteLine(queue.Peek()); //2
            Console.WriteLine(queue.Count); //2
            Console.WriteLine(queue.Contains(2)); //true
            Console.WriteLine(queue.Count()); //2 - returns the count of elements in the queue

            //queue iteration using foreach loop - without removing elements
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }

            //sort the queue
            List<int> sortedQueue = queue.OrderBy(x => x).ToList();
            Console.WriteLine(sortedQueue);

            //dequeue all elements - for loop
            for (int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine(queue.Dequeue());
            }

            queue.Clear(); //clear the queue

            Queue<int> queue2 = new Queue<int>(new int[] { 1, 2, 3, 4, 5 }); //initialize queue with array
            //initialize queue with list
            List<int> list4 = new List<int>() { 1, 2, 3, 4, 5 };
            Queue<int> queue3 = new Queue<int>(list4);

            //Stack<T> - To store elements in a sequence - Last In First Out (LIFO) - Stack Equivalent
            //Duplicate elements are allowed
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Peek(); //3 - returns the top element without removing it
            stack.Pop(); //3 - removes the top element
            stack.Count();  //2 - returns the count of elements in the stack

            //stack iteration using foreach loop - without removing elements
            foreach (int i in stack) 
            {
                Console.WriteLine(i);
            }

            //sort the stack
            List<int> sortedStack = stack.OrderBy(x => x).ToList();
            Console.WriteLine(sortedStack);

            //pop all elements - for loop
            for (int i = 0; i < stack.Count; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            stack.Clear(); //clear the stack

            Stack<int> stack2 = new Stack<int>(new int[] { 1, 2, 3, 4, 5 }); //initialize stack with array
            //initialize stack with list
            List<int> list5 = new List<int>() { 1, 2, 3, 4, 5 };
            Stack<int> stack3 = new Stack<int>(list5);

            //HashSet<T> - To store unique elements - Set Equivalent
            //Duplicate elements are not allowed
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);
            //hashSet.Add(1); //duplicate value - will give error
            Console.WriteLine(hashSet.Contains(2)); //true
            Console.WriteLine(hashSet.Count); //3
            hashSet.Remove(3); //remove 3 from hashset
            hashSet.RemoveWhere(x => x > 2); //remove elements greater than 2

            //hashset iteration using foreach loop
            foreach (int i in hashSet)
            {
                Console.WriteLine(i);
            }

            //sort the hashset
            List<int> sortedHashSet = hashSet.OrderBy(x => x).ToList();
            Console.WriteLine(sortedHashSet);

            hashSet.Clear(); //clear the hashset

            HashSet<int> hashSet2 = new HashSet<int>(new int[] { 1, 2, 3, 4, 5 }); //initialize hashset with array

            //SortedSet<T> - To store unique elements in sorted order - Set Equivalent
            //Duplicate elements are not allowed
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(4);
            sortedSet.Add(2);
            sortedSet.Add(3);
            //sortedSet.Add(2); //duplicate value - will give error

            Console.WriteLine(sortedSet.Contains(2)); //true
            Console.WriteLine(sortedSet.Count); //3
            sortedSet.Remove(3); //remove 3 from sortedset

            //sortedset iteration using foreach loop
            foreach (int i in sortedSet)
            {
                Console.WriteLine(i);
            }
            sortedSet.Clear(); //clear the sortedset

            //SortedSet with descending order
            SortedSet<int> sortedSet2 = new SortedSet<int>(new int[] { 1, 2, 3, 4, 5 }, Comparer<int>.Create((x, y) => y.CompareTo(x)));
            sortedSet2.Add(6);
            sortedSet2.Add(7);

            foreach (int i in sortedSet2)
            {
                Console.WriteLine(i);
            }

            //SortedList<TKey, TValue> - To store key value pairs in sorted order - Map Equivalent
            //Duplicate keys are not allowed
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");

            Console.WriteLine(sortedList.ContainsKey(2)); //true
            Console.WriteLine(sortedList.Count); //3
            sortedList.Remove(2); //remove key 2

            sortedList.Clear(); //clear the sortedlist

            //LinkedList<T> - To store elements in a sequence - List Equivalent
            //LinkedList is a doubly linked list
            //Different from List<T> - List is an array based list and LinkedList is a linked list
            //When to use LinkedList - When you need to add or remove elements frequently
            //When not to use LinkedList - When you need to access elements by index

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddFirst(4); //add 4 at the beginning
            linkedList.Remove(3); //remove 3 from linkedlist

            int[] arr = linkedList.ToArray(); //convert linkedlist to array
            Console.WriteLine(linkedList.Contains(2)); //true
            Console.WriteLine(linkedList.Count); //3

            //linkedlist iteration using foreach loop
            foreach (int i in linkedList)
            {
                Console.WriteLine(i);
            }

            //linkedlist iteration using linkedlistnode
            LinkedListNode<int> node = linkedList.First;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }

            linkedList.Clear(); //clear the linkedlist
        }

    }
}
