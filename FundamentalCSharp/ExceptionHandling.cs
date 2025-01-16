using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalCSharp
{
    class CustomException : Exception //custom exception class
    {
        public CustomException(string message) : base(message) { }
    }
    internal class ExceptionHandling
    {
        static void Main()
        {
            int a = 10;
            //int b = 0;
            int b = 1;
            try //try block is used to enclose the code that might throw an exception
            {
                int result = a / b;
                if( a / 5 == b)
                {
                    throw new Exception("Division Exception");
                }
                if( a / 10 == b )
                {
                    throw new CustomException("Custom Exception");
                }
                Console.WriteLine("Result : {0}", result);
            }
            catch (DivideByZeroException ex) //catch block for specific exception type
            {
                Console.WriteLine("Exception : {0}", ex.Message);
            }
            catch (Exception exc) when (exc.Message.Contains("Division")) //filtering exceptions
            {
                Console.WriteLine("Division Exception : {0}", exc.Message);
            }
            catch (Exception ex) //catch block for all other exceptions - generic excpetion type
            {
                Console.WriteLine("Exception : {0}", ex.Message);
            }
            finally //finally block will always execute
            {
                Console.WriteLine("Finally block");
            }
        }
    }
}
