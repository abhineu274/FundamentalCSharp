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
        }
    }
}
