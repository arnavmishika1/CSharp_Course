using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Constructors.PrivateConstructor
{
    // The constructor whose accessibility is private is known as a private constructor. When a class contains a private constructor then we cannot create an object for the class outside of the class. So, private constructors are used to create an object for the class within the same class. Generally, private constructors are used in the Remoting concept.
    internal class PrivateConstructor
    {
        private PrivateConstructor()
        {
            Console.WriteLine("This is private constructor");
        }
    }
}
