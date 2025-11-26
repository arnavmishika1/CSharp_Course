using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Constructors.PrivateConstructor
{
    public sealed class SingletonDesignPatternExample
    {
        private static int counter = 0;
        private static SingletonDesignPatternExample instance = null;
        private static readonly object InstanceLock = new object();

        public static SingletonDesignPatternExample GetSingletonInstance()
        {
            lock (InstanceLock)
            {
                if(instance == null)
                {
                    instance = new SingletonDesignPatternExample();
                }
                return instance;
            }
        }
        private SingletonDesignPatternExample()
        {
            counter++;
            Console.WriteLine($"Singleton Constructor Executed {counter} Time");
        }
        public void SomeMethod(string Message)
        {
            Console.WriteLine($"Some Method Called : {Message}");
        }
    }

    /*
    class Program
    {
        static void Main(string[] args)
        {
            SingletonDesignPatternExample fromPlace1 = SingletonDesignPatternExample.GetSingletonInstance();
            fromPlace1.SomeMethod("From Place 1");
            SingletonDesignPatternExample fromPlace2 = SingletonDesignPatternExample.GetSingletonInstance();
            fromPlace2.SomeMethod("From Place 2");
            Console.ReadKey();
        }
    }
    */
}
