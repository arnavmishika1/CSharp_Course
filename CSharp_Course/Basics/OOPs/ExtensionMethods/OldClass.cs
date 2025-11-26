using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.OOPs.ExtensionMethods
{
    public class OldClass
    {
        // Now our requirement is to add three new methods to the class OldClass. For some reason, let us assume the source code is not available to us or we don’t have access to the source to edit.
        public int x = 100;
        public void Test1()
        {
            Console.WriteLine("Method One: " + this.x);
        }
        public void Test2()
        {
            Console.WriteLine("Method Two: " + this.x);
        }
    }
}

// 1. Extension methods must be defined only under the static class. If you check our NewClass, then you will see that the NewClass is a static class.
// 2. We already discussed that Static Class in C# contains only Static Members. As an extension method is defined under a static class, it means the extension method should be created as a static method whereas once the method is bound with another class, the method changes into non-static. Now, if you check the methods in NewClass, then you will see that all three methods are declared as static only.
// 3. The first parameter of an extension method is known as the binding parameter which should be the name of the class to which the method has to be bound and the binding parameter should be prefixed with this As here we are creating these extension methods to extend the functionality of OldClass, so, you can check the first parameter of all these methods are going to be OldClass which is also prefixed with this keyword.
// 4. An extension method can have only one binding parameter and that should be defined in the first place on the parameter list.
// 5. If required, an extension method can be defined with normal parameters also starting from the second place of the parameter list. If you check the Test3 method, we have passed the second parameter as int and while calling this method we also need to pass one integer value.