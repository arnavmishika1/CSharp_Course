using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Recursion
{
    internal class FactorialOfANumber
    {
        private static int factorial(int number)
        {
            if(number == 1)
            {
                return (1); /* exiting condition */
            }
            else
            {
                return (number * factorial(number - 1));
            }
        }
        public void FactialOfNum()
        {
            int x = 6;
            Console.WriteLine($"the factorial of {x} is {factorial(x)}");
        }
    }
}
