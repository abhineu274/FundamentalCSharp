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
