using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    public enum weekdays
    {
        Monday, //0
        Tuesday, //1
        Wednesday, //2
        Thursday, //3
        Friday, //4
        Saturday, //5
        Sunday //6
    }
    internal class Enums
    {
        static void Main()
        {
            //Enums - enumeration is a set of named integer constants
            //Enums are strongly typed constants

            Console.WriteLine(weekdays.Monday); //Monday
            Console.WriteLine((int)weekdays.Monday); //0
            Console.WriteLine((int)weekdays.Sunday); //6

        }
    }
}
