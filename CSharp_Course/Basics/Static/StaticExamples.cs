using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Static
{
    internal class StaticExamples
    {
        int x = 100;
        static int y = 200;
        static void Add()
        {
            //This is a static block
            //we can access non static members X with the help of StaticExamples object
            //We can access the static member directly or through class name
            StaticExamples obj = new StaticExamples();
            //Console.WriteLine(obj.x + StaticExamples.y);
            Console.WriteLine("Sum of 100 and 200 is :" + (obj.x + y));
            Console.WriteLine("Sum of 100 and 200 is :" + (obj.x + StaticExamples.y));
        }
        void Mul()
        {
            //This is a Non-Static method
            //we can access static members directly or through class name
            //we can access the non-static members directly or through this keyword
            Console.WriteLine("Multiplication of 100 and 200 is :" + (this.x * StaticExamples.y));
            Console.WriteLine("Multiplication of 100 and 200 is :" + (x * y));
        }

        /*
        static void Main(string[] args)
        {
            // Main method is a static method
            // ADD() method is a static method
            // Statid to Static 
            // we can call the add method directly or through class name
            StaticExamples.Add(); //Calling Add Method using Class Name
            Add(); //Calling Add Method Directly
            // Mul() method is a Non-Static method
            // We can call the non-static method using object only from a static method
            // Static to Non-Static
            StaticExamples obj = new StaticExamples();
            obj.Mul(); //Calling Mul Method using Instance
            Console.ReadLine();
        }
        */
    }
}
