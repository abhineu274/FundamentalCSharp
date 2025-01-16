using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    internal class Student
    {
        //convention is to use PascalCase for properties and camelCase for private fields
        public string FirstName { get; set; } // Property with a getter and setter
        public string LastName { get; } = "Jagtap" ; // read only property

        private int age; 
        public int Age
        {
            get { return age; }
            set //setter with validation
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age should be greater than 0");
                }

            }

        }
    }
    internal class Properties
    {
        static void Main()
        {
                Student student = new Student();
                student.FirstName = "John";
                student.Age = 20;
                Console.WriteLine("First Name : {0}, Last Name : {1}, Age : {2}", student.FirstName, student.LastName, student.Age);
            }
    }
}
