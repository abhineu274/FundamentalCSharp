using School; //imported the namespace
namespace FundamentalCSharp
{
    internal class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public DateTime dateTime { get; set; }

        public Car(string model, string make, int year, DateTime dateTime) //parameterized constructor
        {
            Model = model;
            Make = make;
            Year = year;
            this.dateTime = dateTime;
        }
        public Car() { } //default constructor
        public void Display()
        {
            Console.WriteLine("Model : {0}, Make : {1}, Year : {2}, Date: {3}", Model, Make, Year, dateTime);
        }

    }
    internal class ClassObjectNamespace
    {
        //static void Main(String []args)
        //{
        //    Car car = new Car("Nexon", "Tata", 2021, DateTime.Now);
        //    car.Display();
        //    Student student = new Student("John", 101); //Student class is from School namespace
        //    student.Display();
        //}
    }
}
