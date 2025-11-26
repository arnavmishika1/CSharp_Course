using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.OOPs.SealedClasses
{
    class Parent
    {
        public virtual void Show() { }
    }
    class Child : Parent
    {
        public sealed override void Show() { }
    }
    class GrandChild : Child
    {
        //'GrandChild.Show()': cannot override inherited member 'Child.Show()' because it is sealed
        //public override void Show() { }
    }
}
