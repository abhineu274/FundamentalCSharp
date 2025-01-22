namespace School // This is a namespace
{
    internal class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        
        public Student(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }

        public Student() { }
        public void Display()
        {
            Console.WriteLine("Name : {0}, RollNo : {1}", Name, RollNo);
        }
    }
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello World!"); //To display a message on the console
            string str = Console.ReadLine(); //To read a line from the console
            int num = Convert.ToInt32(str); //To convert a string to an integer
            double d = Convert.ToDouble(Console.ReadLine()); //To convert a string to a double
            Console.WriteLine("You entered : " + num); //To display a message on the console
            Console.WriteLine($"{num} - {Math.Pow(num, 2)}");

            /*
             * Convert.ToInt32() - Converts the specified string representation of a number to an equivalent 32-bit signed integer
             * Convert.ToInt64() - Converts the specified string representation of a number to an equivalent 64-bit signed integer
             * Convert.ToDouble() - Converts the specified string representation of a number to an equivalent double-precision floating-point number
             * 
             */
        }
    }
}
