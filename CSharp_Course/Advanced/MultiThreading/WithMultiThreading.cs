using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Advanced.MultiThreading
{
    public class WithMultiThreading
    {
        public static void Method1()
        {
            Console.WriteLine($"Method1 started using {Thread.CurrentThread.Name}");
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method1 {i}");
            }
            Console.WriteLine($"Method1 ended using {Thread.CurrentThread.Name}");
        }
        public static void Method2()
        {
            Console.WriteLine($"Method2 started using {Thread.CurrentThread.Name}");
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method2 {i}");
                if(i == 3)
                {
                    Console.WriteLine("Database operation started...");
                    Thread.Sleep(10000);
                    Console.WriteLine("Database operation ended");
                }
            }
            Console.WriteLine($"Method2 ended using {Thread.CurrentThread.Name}");
        }
        public static void Method3()
        {
            Console.WriteLine($"Method3 started using {Thread.CurrentThread.Name}");
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Method3 {i}");
            }
            Console.WriteLine($"Method3 ended using {Thread.CurrentThread.Name}");
        }
        /*
        public static void Main()
        {
            Console.WriteLine("Main thread started");

            //Creating Threads
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };

            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main thread ended");
            Console.ReadKey();
        }
        */
    }
}
