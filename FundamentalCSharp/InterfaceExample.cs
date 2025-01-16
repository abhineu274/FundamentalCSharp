using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    interface IShape //interface - by default public access spec
    {
        //interface can have Properties, constants and methods. Interfaces can't have normal fields
        //normally we use it for methods and properties
        const double PI = 3.14; //constant
        double Radius { get; set; } //Property
        double Area { get; } //Property
        void Draw(); //method
    }

    class NewCircle : IShape //implementing an interface. We have to define all the properties of the interface in derived class 
    {
        public double Radius { get; set; }
        public double Area => IShape.PI * Radius * Radius; //implementing the property of the interface

        public void Draw()
        {
            Console.WriteLine($"Drawing Circle - {Radius} {Area}");
        }

        public void Display()
        {
            Console.WriteLine("Displaying Circle");
        }
    }

    interface A
    {
        void Display() => Console.WriteLine("Display A");
    }
    interface B
    {
        void Display() => Console.WriteLine("Display B"); //new feature in C# 8.0 
        //now interfaces can also have default implementation of methods
    }

    class C : A, B //we can achieve multiple inheritance using interfaces
    {
        public void Display()
        {
            Console.WriteLine("Displaying C");
        }
    }

    class D: A, B
    {
        //public void Display() //if we don't implement the Display method, we will 'not' get error anymore
    }

    class InterfaceExample //by default internal spec
    {
        static void Main()
        {
            IShape shape = new NewCircle();
            shape.Radius = 10;
            shape.Draw();

            NewCircle circle = new NewCircle();
            circle.Radius = 5;
            circle.Draw();

            A a = new C();
            a.Display(); //Displaying C

            C c = new C();
            c.Display(); //Displaying C

            A a2 = new D();
            a2.Display(); //Display A - This will not give any error as refernce of A is being used where we have a Default implementation in interface A

            D d = new D();
            //d.Display(); - This will give an error as the Display method is not implemented in the class D
        }
    }
}

/*
 * Real world use case - public class ReceiptsCommandDataAccess : DataAccessBase, IReceiptsCommandDataAccess
 */
