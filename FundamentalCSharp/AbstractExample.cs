using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    //A class which we are not going to instantiate and only meant for other classes to inherit from it is called an abstract class
    internal abstract class DomAnimal 
    {
        public string Species { get; set; } //can contain non-abstract members

        public DomAnimal() { }
        public DomAnimal(string name) //abstract class can have constructors
        {
            Species = name;
        }
        public abstract void MakeSound(); //abstract method is a method without the body
        public void Eat() //abstract class can have non abstract methods
        {
            Console.WriteLine("Animal eats");
        }
    }

    internal class Dog : DomAnimal //derived class
    {
        public Dog() { }
        public Dog(string name) : base(name) { }
        public override void MakeSound() //we have to override the abstract method...neeed to use override keyword
        {
            Console.WriteLine("Dog barks");
        }
        public void WiggleTail()
        {
            Console.WriteLine(base.Species); // we can access the base class properties using base keyword
            Console.WriteLine("Dog wiggles tail");
        }
    }
    internal class AbstractExample
    {
        static void Main()
        {
            DomAnimal dog = new Dog("German Shephard"); //parent class reference being used to point to derived class
            dog.MakeSound();
            dog.Eat();
            Console.WriteLine("Species : {0}", dog.Species);
            //dog.WiggleTail(); //this will give error as parent class reference cannot access child class specific methods

            Dog dog1 = new Dog("Rottweiler");
            dog1.WiggleTail(); //this will work
            Console.WriteLine("Species : {0}", dog1.Species);

        }
    }


/* Real Life Example
namespace LogRetention
    {
        public abstract class CognitiveSearchLogs
        {
            public CognitiveSearchLogs(AppSettings appsettings, ILogger logger, Stopwatch timer)
            {
            }
            public async Task<int> RemoveCognitiveSearchLogs(int batchSize)
            {
                var count = 0;
                SearchOptions options = GetSearchOptions();
                count = await StartCognitiveSearchRemovalNewAsync(options);
                return count;
            }

            protected abstract SearchOptions GetSearchOptions();

            private async Task<int> StartCognitiveSearchRemovalNewAsync(SearchOptions searchOptions)
            {
            }
        }
    }
*/

}
