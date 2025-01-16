using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    static class MathUtils //static class can only have static members. contain globally accessible fields
    {
        static double PI = 3.14;
        public static int Square(int number)
        {
            return number * number;
        }
    }
        internal class Animal
    {
        int count = 0;
        static int staticCount;   //automatically initiate to 0 or whatever data type's default value is
        public Animal()
        {
            count++;
            staticCount++;
        }
        public static void DisplayStaticCount()
        {
            Console.WriteLine("StaticCount : {0}", staticCount);
        }

        public void DisplayCount()
        {
            Console.WriteLine("Count : {0}", count);
        }
    }
        internal class StaticExample
    {
        static void Main()
        {
            Animal animal1 = new Animal();
            Animal animal2 = new Animal();
            Animal animal3 = new Animal();
            animal3.DisplayCount();
            Animal.DisplayStaticCount();

            Console.WriteLine(MathUtils.Square(5));
        }
    }
}
