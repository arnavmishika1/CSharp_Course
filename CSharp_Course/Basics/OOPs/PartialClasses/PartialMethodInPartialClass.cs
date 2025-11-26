using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.OOPs.PartialClasses
{
    public partial class PartialEmployee
    {
        // Declaration of the partial method.
        partial void PartialMethod();
        public partial int PartialMethod2();
        // A public method calling the partial method
        public void PublicMethod()
        {
            Console.WriteLine("Public method invoked");
            PartialMethod();
        }
    }
}
