using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    internal class BoxingUnboxing
    {
        static void Main()
        {
            int i = 10;
            object obj = i; // boxing - converting value type to reference type
            Console.WriteLine(obj);
            int j = (int)obj; // unboxing - converting reference type to value type
            Console.WriteLine(j);

            //value types - int, float, double, char, bool, struct
            //reference types - class, interface, delegate, object, string
        }
    }
}
