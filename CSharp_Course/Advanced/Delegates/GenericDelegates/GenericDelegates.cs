using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Advanced.Delegates.GenericDelegates
{
    public class GenericDelegates
    {
        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }

        /*
        public static void Main()
        {
            Func<int, float, double, double> del1 = new Func<int, float, double, double>(AddNumber1);
            double Result = del1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(Result);

            Action<int, float, double> del2 = new Action<int, float, double>(AddNumber2);
            del2.Invoke(50, 255.45f, 123.456);

            Predicate<string> del3 = new Predicate<string>(CheckLength);
            bool status = del3("Pranaya");
            Console.WriteLine($"Status: true");

            Console.ReadKey();
        }
        */


        // Generic delegates with Lambda Expressions
        /*
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };
            double Result = obj1.Invoke(100, 125.45f, 456.789);
            Console.WriteLine(Result);
            Action<int, float, double> obj2 = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            obj2.Invoke(50, 255.45f, 123.456);
            Predicate<string> obj3 = new Predicate<string>(CheckLength);
            bool Status = obj3.Invoke("Pranaya");
            Console.WriteLine(Status);
            Console.ReadKey();
        }
        */
    }
}
