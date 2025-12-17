using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Advanced.MultiThreading
{
    public class WithoutMultiThreading
    {
        public static void Method1()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method1: {i}");
            }
        }
        public static void Method2()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method2: {i}");
                if(i == 3)
                {
                    Console.WriteLine("Performing the database operation started!");
                    // Sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Performing the database operation completed!");
                }
            }
        }
        public static void Method3()
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method3: {i}");
            }
        }

        /*
        public static void Main()
        {
            Method1();
            Method2();
            Method3();
            Console.ReadKey();
        }
        */
    }
}
