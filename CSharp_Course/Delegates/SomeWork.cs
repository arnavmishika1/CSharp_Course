using System.Reflection;

namespace CSharp_Course.Delegates
{
    public delegate void DoSomeWorkHandler(string message);
    public class SomeWork
    {
        public void DoSomeWork(string message)
        {
            Console.WriteLine("DoSomeWork Executed!");
            Console.WriteLine($"Hello {message}, Morning");
        }
    }
    /*
    public class Program
    {
        public static void Main(string[] args)
        {
            SomeWork obj = new();
            DoSomeWorkHandler del1 = new(obj.DoSomeWork);

            MethodInfo method = del1.Method;
            object target = del1.Target;
            Delegate[] invocationList = del1.GetInvocationList();

            Console.WriteLine($"Method property: {method}");
            Console.WriteLine($"Target property: {target}");

            foreach(var item in invocationList)
            {
                Console.WriteLine($"Invocation list: {item}");
            }

            Console.ReadKey();
        }
    }
    */
}
