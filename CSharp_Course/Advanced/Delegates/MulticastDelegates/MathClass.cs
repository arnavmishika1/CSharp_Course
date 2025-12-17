using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Advanced.Delegates.MulticastDelegates
{
    public delegate void MathDelegate(int num1, int num2);
    public class MathClass
    {
        // static methods
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Sum of {x} and {y} is {x + y}");
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine($"Substraction of {x} and {y} is {x - y}");
        }
        //Non-Static methods
        public void Mul(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is {x * y}");
        }
        public void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is {x / y}");
        }
    }

    /*
    public class Program
    {
        public static void Main()
        {
            MathClass obj = new();

            MathDelegate del1 = new MathDelegate(MathClass.Add);
            MathDelegate del2 = new MathDelegate(MathClass.Sub);
            MathDelegate del3 = new MathDelegate(obj.Mul);
            MathDelegate del4 = new MathDelegate(obj.Div);

            //In this example del5 is a multicast delegate. 
            //We can use +(plus) operator to chain delegates together and 
            //-(minus) operator to remove a delegate.
            MathDelegate del5 = del1 + del2 + del3 + del4;

            Delegate[] invocationList = del5.GetInvocationList();
            Console.WriteLine("Invocation List: ");
            foreach(var item in invocationList)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine();
            Console.WriteLine("Invoking multicast delegate");
            del5(20, 5);

            Console.WriteLine();
            Console.WriteLine("Invoking multicast delegate after removing one delegate");
            del5 -= del2;
            del5(22, 7);

            Console.ReadKey();
        }
    }
    */
}
