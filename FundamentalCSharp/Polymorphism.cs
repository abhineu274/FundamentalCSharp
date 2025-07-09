using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    internal class MethodOverload
    {
        //same method name with (only) different number or type of parameters (return type does not matter or is not a factor here)
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum of two integers : {0}", a + b);
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine("Sum of three integers : {0}", a + b + c);
        }
        //public int Add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}
    }

    internal class Shape
    {
        // method in the base class
        public void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }
    }

    internal class Circle : Shape
    {
        //overriden in the derived class
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    internal class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
        internal class Polymorphism
    {
        static void Main()
        {
            MethodOverload methodOverload = new MethodOverload();
            methodOverload.Add(10, 20);
            methodOverload.Add(10, 20, 30);

                //This is method overriding
                Shape shape = new Shape();
                shape.Draw(); //Drawing Shape
                Circle circle = new Circle();
                circle.Draw(); //Drawing Circle
                Shape circle2 = new Circle(); //this is runtime polymorphism
                circle2.Draw(); //Drawing Circle
                Rectangle rectangle = new Rectangle();
                rectangle.Draw(); //Drawing Rectangle
            }
    }
}
