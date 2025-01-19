using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    //Extension method - extends the functionality of existing class without modifying it
    //allows us to add functionality to existing class without modifying it
    //Extension method is a static method of a static class - first parameter of the method should be of the type that is being extended
    //Extension method should be in the same namespace as the class being extended
    //this keyword is used to refer to the current instance of the class - similar to this keyword in java
    public static class StringExtension
    {
        public static char FirstChar(this string s) //this keyword is used to extend the string class
        {
            return s[0];
        }

        public static int CountWords(this string s)
        {
            return s.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }


    internal class ExtensionMethod
    {
        static void Main()
        {
            string str = "Hello World, How you doing?";
            Console.WriteLine(str.FirstChar());
            Console.WriteLine(str.CountWords());
        }
    }

    /*Real life used case -
     * 
    public static class DateExtensions
    {
        public static string ToPSTMidnightUtcString(this DateTime date)
        {
            return PST Date Midnight's Equivalent Utc Time
        }
    }
    */
}
