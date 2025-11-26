using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Constructors.CopyConstructor
{
    // If we want to create multiple instances with the same values then we need to use the copy constructor in C#, in a copy constructor the constructor takes the same class as a parameter to it.
    /*
    class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor obj1 = new CopyConstructor(10);
            obj1.Display();
            Console.ReadKey();
        }
    }
    */
    public class CopyConstructor
    {
        int x;
        public CopyConstructor(int i)
        {
            x = i;
        }
        public CopyConstructor(CopyConstructor obj)
        {
            x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine($"Value of X = {x}");
        }
    }
}
