using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Delegates
{
    public delegate void CallbackMethodHandler(string message);
    public class DelegateAsParameter
    {
        public void CallbackMethod(string message)
        {
            Console.WriteLine("Callback method Executed!");
            Console.WriteLine($"Hello {message}, Good Afternoon!");
        }
        public void SomeTask(CallbackMethodHandler del)
        {
            Console.WriteLine("Some task Executing...");
            del("Pranaya");
        }
    }

    /*
    public class Program
    {
        public static void Main(string[] args)
        {
            DelegateAsParameter obj = new();
            CallbackMethodHandler del1 = new CallbackMethodHandler(obj.CallbackMethod);
            obj.SomeTask(del1);
        }
    }
    */
}
