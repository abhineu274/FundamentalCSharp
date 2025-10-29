using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    /*
     * StringBuilder is a mutable sequence of characters
     * Performance is better than String when concatenating multiple strings/ modifying strings
     * Present in System.Text namespace
     * While solving DSA problems, use StringBuilder for string manipulation
     */
    internal class StringBuilderrr
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" World");
            sb.Append("!");
            Console.WriteLine(sb); //Hello World!
            Console.WriteLine(sb.Length); //13 - length of the string
            sb[0] = 'N'; //-> Nope - StringBuilder does not support indexing for modification

            Console.WriteLine(sb[0]); //H - accessing the character at index 0

            sb.Insert(5, "C# "); //Inserts a string at the specified index
            Console.WriteLine(sb); //Hello C# World!

            sb.Remove(5, 3); //Removes a substring from the specified index - 3 characters from index 5
            Console.WriteLine(sb); //Hello World!

            sb.Replace("World", "C#"); //Replaces a substring with another string
            Console.WriteLine(sb); //Hello C#!

            sb.Clear(); //Clears the contents of the StringBuilder
            Console.WriteLine(sb); //Empty string

            string str = sb.ToString(); //Converts the StringBuilder to a string
            Console.WriteLine(str); //Empty string

            string str2 = "Hello World!";
            StringBuilder sb2 = new StringBuilder(str2); //Initializes the StringBuilder with a string
            Console.WriteLine(sb2); //Hello World!

            //Default capacity of StringBuilder is 16. It doubles the capacity when the limit is reached
            StringBuilder sb3 = new StringBuilder(100); //Initializes the StringBuilder with a capacity of 100
            Console.WriteLine(sb3.Capacity); //100

            //String builder is not thread-safe. Use lock if you are using StringBuilder in a multi-threaded environment
            //String builder's performance is better than String overall.
        }
    }
}
