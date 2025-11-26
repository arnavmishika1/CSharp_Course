using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Delegates.MulticastDelegates
{
    public delegate void RectangleDelegate(double width, double height);
    public class MulticastDelegateExamples
    {
        public void GetAreaOfRectangle(double width, double height)
        {
            Console.WriteLine($"Area is: {width * height}");
        }
        public void GetParameterOfRectangle(double width, double height)
        {
            Console.WriteLine($"Parameter is: {2 * (width + height)}");
        }
    }
    /*
    public class Program
    {
        public static void Main()
        {
            MulticastDelegateExamples obj = new();
            //obj.GetAreaOfRectangle(23.45, 67.89);
            //obj.GetParameterOfRectangle(23.45, 67.89);

            RectangleDelegate del1 = new RectangleDelegate(obj.GetAreaOfRectangle);
            // RectangleDelegate del1 = rect.GetArea;
            // binding a method with delegate object
            // In this example del1 is a multicast delegate. 
            // You use += operator to chain delegates together.
            del1 += obj.GetParameterOfRectangle;

            Delegate[] invocationList = del1.GetInvocationList();
            Console.WriteLine("Invocaton List: ");
            foreach(var item in invocationList)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate:");
            del1(23.45, 67.89);
            //rectDelegate.Invoke(13.45, 76.89);


            Console.WriteLine();
            Console.WriteLine("Invoking Multicast Delegate After Removing one Pipeline:");
            //Removing a method from delegate object
            del1 -= obj.GetParameterOfRectangle;
            del1.Invoke(13.45, 76.89);

            Console.ReadKey();
        }
    }
    */
}
