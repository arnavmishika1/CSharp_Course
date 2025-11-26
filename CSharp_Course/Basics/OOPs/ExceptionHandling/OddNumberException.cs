using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.OOPs.ExceptionHandling
{
    public class OddNumberException : Exception
    {
        public OddNumberException() { }
        public OddNumberException(string message)
            :base(message)
        { }
        public OddNumberException(string message, Exception inner)
            :base(message, inner)
        { }

        //public override string Message
        //{
        //    get
        //    {
        //        return "Divisor cannot be a Odd Number";
        //    }
        //}

        public override string HelpLink
        {
            get
            {
                return "For help: https://dotnettutorials.net/lesson/create-custom-exception-csharp/";
            }
        }
    }

    /*
    public class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            try
            {
                Console.Write("Enter first num: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second num: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 % 2 > 0)
                {
                    // Option 1:
                    // OddNumberException one = new OddNumberException();
                    // throw one;
                    // Option 2:
                    throw new OddNumberException("Odd number exception occured inside the main method");
                }
                result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            catch (OddNumberException one)
            {
                Console.WriteLine($"Message: {one.Message}");
                Console.WriteLine($"Help Link: {one.HelpLink}");
                Console.WriteLine($"Source: {one.Source}");
                Console.WriteLine($"Stack Trace: {one.StackTrace}");
            }
            Console.WriteLine("End of the program");
            Console.ReadKey();
        }
    }
    */
}
