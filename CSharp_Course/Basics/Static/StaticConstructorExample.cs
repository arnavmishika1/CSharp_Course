using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Static
{
    internal class StaticConstructorExample
    {
        //Static Constructor
        //Executed only once
        //First block of code to be executed inside a class
        //Before Main Method body start executing, this constructor will execute
        static StaticConstructorExample()
        {
            Console.WriteLine("Static Constructor is Called");
        }
        //Non-Static Constructor
        //Executed once per object
        //When we create an instance, this constructor will execute
        public StaticConstructorExample()
        {
            Console.WriteLine("Non-Static Constructor is Called");
        }
        //Program Execution will start from the Main method
        //But before executing the Main method body, it will
        //execute the static constructor

        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Execution Start");
            StaticConstructorExample obj1 = new StaticConstructorExample();
            StaticConstructorExample obj2 = new StaticConstructorExample();
            Console.WriteLine("Main Method Execution End");
            Console.ReadLine();
        }
        */
    }
}
