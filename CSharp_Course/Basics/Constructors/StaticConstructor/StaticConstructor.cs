using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp_Course.Basics.Constructors.StaticConstructor
{
    // Points To Remember About Static Constructor in C#:
    //  1.There can be only one static constructor in a class.
    //  2.It can’t be called explicitly, it is always called implicitly.
    //  3.The static constructor should be without any parameters.
    //  4.It can only access the static members of the class.
    //  5.There should not be any access specifiers in the static constructor definition.
    //  6.If a class is static then we cannot create the object for the static class.
    //  7.It is called automatically to initialize the static members.
    //  8.Static constructor will be invoked only once i.e.at the time of class loading.
    public class StaticConstructor
    {
        int i;
        static int j;
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor Executed!");
            j = 100;
            //i = 100; // cannot initilize non-static members
        }
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Exceution Started...");
            Console.ReadKey();
        }
        */
    }
}
