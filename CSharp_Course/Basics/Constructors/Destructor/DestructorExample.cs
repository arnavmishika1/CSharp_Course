using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Constructors.Destructor
{
    public class DestructorExample
    {
        public DestructorExample()
        {
            Console.WriteLine("This is the constructor");
        }
        ~DestructorExample()
        {
            string type = GetType().Name;
            Console.WriteLine($"Object {type} is destroyed!");
        }

        /*
        static void Main(string[] args)
        {
            DestructorExample obj1 = new();
            DestructorExample obj2 = new();

            //Making obj1 and obj2 ready for Garbage Collection
            obj1 = null;
            obj2 = null;
            GC.Collect();
            Console.ReadKey();
        }
        */
    }
}
