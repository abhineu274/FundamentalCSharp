using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    internal class Stringsss
    {
        /* strings are immutable in c#
         * sequence of unicode characters
         * string is an alias for System.String
         * string is a reference type
         * string interning - string interning is a process of storing only one copy of each distinct string value, which must be immutable
         */
        static void Main()
        {
            string str = "Hello World";
            Console.WriteLine(str);
            Console.WriteLine(str[0]); //H - accessing the character at index 0

            //string methods
            Console.WriteLine(str.Length); //11 - length of the string
            Console.WriteLine(str.ToUpper()); //HELLO WORLD - converts the string to uppercase
            Console.WriteLine(str.ToLower()); //hello world - converts the string to lowercase
            Console.WriteLine(str.Any(x => x == 'z'));//false - checks if the string contains any element that satisfies the condition

            char[] carr = str.ToCharArray(); //converts the string to a character array
            foreach (char c in carr)
            {
                Console.WriteLine(c);
            }
            
            string str2 = str.ToUpper() + " and Hello Heaven!"; //concatenation
            Console.WriteLine(str2);

            //substring
            string substr = str2.Substring(6, 5); //World - substring from index 6 to 5 characters
            Console.WriteLine(substr);

            //split
            string[] words = str2.Split(' '); //splits the string based on the delimiter

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            //join
            string joined = string.Join(" ", words); //joins the elements of the array with the specified delimiter
            Console.WriteLine(joined);

            //format
            string formatted = string.Format("Hello {0} {1}", "World", "and Heaven!"); //formats the string
            Console.WriteLine(formatted);

            //getting unicode value of a character
            char ch = 'A';
            char ch2 = 'b';
            int unicode = ch;
            Console.WriteLine(ch+" "+unicode); //65

            Console.WriteLine(ch+ch2);
            Console.WriteLine((int)ch + (int)ch2);

            //replace
            string strreplace = str2.Replace("Hello", "Hi"); //replaces the specified value with another value
            Console.WriteLine(strreplace);

            //remove
            string strremove = str2.Remove(6, 5); //removes the specified number of characters from the string
            Console.WriteLine(strremove);

            //insert
            string strinsert = str2.Insert(6, "Universe"); //inserts the specified string at the specified index
            Console.WriteLine(strinsert);

            //compare
            string str3 = "Hello World";
            string str4 = "Hello World";
            string str5 = "Oii World, Whatsup!";
            Console.WriteLine(str3 == str4); //true - compares the strings based on the values(unlike == in java)
            Console.WriteLine(string.Compare(str3, str4)); //0 - compares the strings based on the values
            Console.WriteLine(string.CompareOrdinal(str3, str4)); //0 - compares the strings based on the values
            Console.WriteLine(string.Equals(str3, str4)); //true - compares the strings based on the values
            Console.WriteLine(str3.Equals(str4)); //true - compares the strings based on the values
            Console.WriteLine(str4.Equals(str4, StringComparison.OrdinalIgnoreCase)); //true - ignore the case
            Console.WriteLine(str3.CompareTo(str4)); //0 - compares the strings based on the values
            Console.WriteLine(str4.CompareTo(str5)); //-1 - compares the strings based on the values
            Console.WriteLine(str5.CompareTo(str4)); //1 - compares the strings based on the values

            //contains
            Console.WriteLine(str3.Contains("Hello")); //true - checks if the string contains the specified value

            //trim
            string str6 = "    Hello     ";
            Console.WriteLine(str6.Trim()); //Hello - removes the leading and trailing white spaces

            int result = string.Compare("apple", "banana"); //returns -1 => apple comes before banana (lexicographically)
                                                            //apple < banana 

            /*
             * IndexOf() - returns the index of the first occurrence of the specified value
             * StartsWith() - returns true if the string starts with the specified value
             * EndsWith() - returns true if the string ends with the specified value
             * 
             */
            //Modifying the string results in a new string object - hence strings are immutable

            //String vs string
            //String is a class in System namespace and string is an alias for System.String
            //String class provides various methods to manipulate strings

            string s = String.Empty; //String is a class in System namespace
            Console.WriteLine(String.IsNullOrEmpty(s)); //true - checks if the string is null or empty
        }
    }
}
