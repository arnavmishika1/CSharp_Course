using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.AnonymousMethods
{
    public class LambdaExpressionExample
    {
        public delegate string GreetingDelegate(string msg);

        /*
        public static void Main()
        {
            GreetingDelegate del1 = (name) =>
            {
                return $"Hello {name}, Good morning!";
            };

            string GreetMsg = del1.Invoke("Sonu");
            Console.WriteLine(GreetMsg);
            Console.ReadKey();
        }
        */
    }
}
