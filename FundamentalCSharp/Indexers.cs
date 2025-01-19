using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    //Indexer - allows objects to be indexed like arrays
    //Indexer is a special type of property that allows a class or structure to be accessed like an array for ex. obj[1], obj[2]
    //Indexer is defined using this keyword
    //Indexer can be overloaded
    //Indexer can be static
    //Why we need them - to access the elements of a class using an index
    class Fruits
    {
        private string[] fruits = new string[5];
        public string this[int index] //indexer
        {
            get
            {
                return fruits[index]; //returning the value at the specified index
            }
            set
            {
                fruits[index] = value; //setting the value at the specified index
            }
        }
    }
    internal class Indexers
    {
        static void Main()
        {
            Fruits fruits = new Fruits();
            fruits[0] = "Apple"; //setting the value using indexer
            fruits[1] = "Banana";
            fruits[2] = "Orange";
            fruits[3] = "Grapes";
            fruits[4] = "Mango";

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(fruits[i]); //getting the value using indexer
            }
        }
        
    }
}
