using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Constructors.Parameterized
{
    // If we want to initialize the object dynamically with the user-given values or if we want to initialize each instance of a class with a different set of values then we need to use the Parameterized Constructor in C#. The advantage is that we can initialize each instance with different values.
    internal class ParameterizedConstructor
    {
        public ParameterizedConstructor(int i)
        {
            Console.WriteLine($"Parameterized Constructor is Called : {i}");
        }
    }
}
