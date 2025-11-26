using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.OOPs.PartialClasses
{
    public partial class PartialEmployee
    {
        // partial method implementation
        partial void PartialMethod()
        {
            Console.WriteLine("Partial method invoked");
        }
        public partial int PartialMethod2()
        {
            Console.WriteLine("hi");
            return 10;
        }
    }
}
