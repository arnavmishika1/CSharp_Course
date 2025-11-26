using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Delegates.MulticastDelegates
{
    public delegate int ReturnTypeDelegate();
    public class DelegateWithReturnType
    {
        public int Method1()
        {
            Console.WriteLine("Method1 is Executed");
            return 1;
        }
        public int Method2()
        {
            Console.WriteLine("Method2 is Executed");
            return 2;
        }
    }

    /*
    public class Program
    {
        public static void Main()
        {
            DelegateWithReturnType obj = new();
            ReturnTypeDelegate del1 = new ReturnTypeDelegate(obj.Method1);
            del1 += obj.Method2;

            // The Value Returned By Delegate will be 2, returned by the Method2(),
            // as it is the last method in the invocation list.
            int valueReturnedByDelegate = del1();
            Console.WriteLine($"Returned Value: {valueReturnedByDelegate}");
            Console.ReadKey();
        }
    }
    */
}
