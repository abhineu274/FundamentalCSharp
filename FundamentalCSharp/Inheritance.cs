using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    internal class Employee
    {
        public string Name { get; set; }
        public int EmpId { get; set; }
        public Employee(string name, int empId)
        {
            Name = name;
            EmpId = empId;
        }
        public Employee() { }
        public void Display()
        {
            Console.WriteLine("Name : {0}, EmpId : {1}", Name, EmpId);
        }
    }

    internal class Manager : Employee //Inheritance
    {
        public string Department { get; set; }
        public Manager(string name, int empId, string department) : base(name, empId) //base keyword is used to call the base class constructor
        {
            Department = department;
        }
        public Manager() { }
        public void Display()
        {
            Console.WriteLine("Name : {0}, EmpId : {1}, Department : {2}", Name, EmpId, Department);
        }
    }
    internal class Inheritance
    {
        static void Main(String[] args)
        {
            Employee emp = new Employee("Jane", 100);
            emp.Display();
            Manager manager = new Manager("John", 101, "HR");
            manager.Display();
        }
    }
}


/*
 * Access Modifiers:
 * Public - accessible from anywhere
 * Private - accessible only within the class
 * Protected - accessible within the class and its derived classes
 * Internal - accessible within the same assembly
 * Protected Internal - accessible within the same assembly and derived classes
 * Private Protected - accessible within the same class and derived classes, but not accessible from outside the class
 * file level - accessible within the same file
 * 
 * 
 * *Interfaces have only public and protected access modifiers, no private or internal access modifiers.
 * 
 *  
 * Types of Inheritance:
 * 1. Single Inheritance - A class inherits from one base class.
 * 2. Multiple Inheritance - A class inherits from multiple base classes (not supported in C# directly, but can be achieved using interfaces).
 * 3. Multilevel Inheritance - A class inherits from a base class, which in turn inherits from another base class.
 * 4. Hierarchical Inheritance - Multiple classes inherit from a single base class.
 * 5. Hybrid Inheritance - A combination of two or more types of inheritance (not supported in C# directly, but can be achieved using interfaces).
 * 
 * 
 * Inheritance important keywords:
 * abstract - used to declare a class that cannot be instantiated and can only be inherited.
 * abstract method - a method without a body that must be implemented in derived classes.
 * abstract class can have constructors, properties, and methods, but cannot be instantiated directly.
 * abstract class can have concrete methods (methods with a body) and abstract methods (methods without a body).
 * 
 * override - to overide an abstract method in a derived class, we use the override keyword.
 * 
 * virtual - used to declare a method that can be overridden in derived classes.
 * virtual method can have a body and can be overridden in derived classes using the override keyword.
 * virtual keyword is declared in abstract class or base class, and it allows derived classes to provide their own implementation of the method.
 * 
 * a overriden method can be virtual or abstract
 * abstract vs virtual - it is mandatory to override an abstract method in a derived class, while it is optional to override a virtual method in a derived class.
 * 
 * 
 * sealed - used to declare a class that cannot be inherited from.
 * 
 */
