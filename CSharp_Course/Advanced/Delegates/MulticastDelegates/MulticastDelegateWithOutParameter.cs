using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Advanced.Delegates.MulticastDelegates
{
    public delegate void OutParameterDelegate(out int value);
    public class MulticastDelegateWithOutParameter
    {
        public void Method1(out int num)
        {
            Console.WriteLine("Method1 is Executed!");
            num = 1;
        }
        public void Method2(out int num)
        {
            Console.WriteLine("Method2 is Executed!");
            num = 2;
        }
    }
    /*
    public class Program
    {
        public static void Main()
        {
            MulticastDelegateWithOutParameter obj = new();
            OutParameterDelegate del = new OutParameterDelegate(obj.Method1);
            del += obj.Method2;

            // The ValueFromOutPutParameter will be 2, initialized by MethodTwo(),
            // as it is the last method in the invocation list.
            int valueFromOutParameter = -1;
            del(out valueFromOutParameter);

            Console.WriteLine($"Returned value: {valueFromOutParameter}");
            Console.ReadKey();
        }
    }
    */
}
