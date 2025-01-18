using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    /*
     * Collections in C#:
     * Non Generic Collections: ArrayList, HashTable, SortedList, Stack, Queue
     * Generic: List<T>, Dictionary<TKey, TValue>, Queue<T>, Stack<T>, HashSet<T>, SortedList<TKey, TValue>, SortedSet<T>, LinkedList<T> 
     * 
     * Non Generic Collections are not type safe and can store any type of data
     * It is not recommended to use Non Generic Collections
     */
    internal class CollectionsNonGeneric
    {
        static void Main()
        {
            //ArrayList - can store any type of data
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Two");
            arrayList.Add(3.0);
            arrayList.Insert(1, "Three"); //insert at index 1
            arrayList.Remove(3.0); //remove 3.0 value from the list
            arrayList.RemoveAt(0); //remove value at index 0
            Console.WriteLine(arrayList.Contains("Two")); //true
            Console.WriteLine(arrayList.Count); //2
            arrayList.Clear(); //clear the list
            //arrayList iteration using for loop
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            //HashTable - key value pair : It can store any type of key and any type of value
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "One");
            hashTable.Add(2, true);
            hashTable.Add("Three", 3000); //key is string and value is int
            hashTable.Remove(3000); //remove value 3000
            Console.WriteLine(hashTable.Contains(2)); //true - contains key 2
            Console.WriteLine(hashTable.Count); //2
            hashTable.Clear(); //clear the hash table
            //hashTable iteration using foreach loop
            foreach (DictionaryEntry entry in hashTable)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }

            //SortedList - key value pair : sorted by key : It can store same type of key and any type of value
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "One");
            sortedList.Add(2, true);
            sortedList.Add(3, 3000);
            sortedList.Remove(2); //remove value 3000
            Console.WriteLine(sortedList.Contains(2)); //true - contains key 2
            Console.WriteLine(sortedList.Count); //2
            sortedList.Clear(); //clear the sorted list
            //sortedList iteration using foreach loop
            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }

            //Stack - LIFO
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("two");
            stack.Push(3.0);

            stack.Peek(); //3.0 - returns the top element without removing it
            stack.Pop(); //3.0 - removes the top element
            Console.WriteLine(stack.Count);
            stack.Clear(); //clear the stack
            //stack iteration using foreach loop
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Queue - FIFO
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("two");
            queue.Enqueue(3.0);

            queue.Peek(); //1 - returns the top element without removing it
            queue.Dequeue(); //1 - removes the top element
            Console.WriteLine(queue.Count);
            queue.Clear(); //clear the queue
            //queue iteration using foreach loop
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
