using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Datatypes
{
    internal class TypeCastingExamples
    {
      // Type Casting or Type Conversion in C# is the process to change one data type value into another data type.
        // The Type Conversion is only possible if both the data types are compatible with each other else we will get compile time error saying cannot implicitly convert one type to another type.
        // Note: In implicit type conversion, the smaller types are converted to larger data types and hence, there is no loss of data during the conversion.
        public void ImplicitTypeCasting()
        {
            int numInt = 1500;
            //Get type of numInt
            Type numIntType = numInt.GetType();
            // Implicit Conversion
            double numDouble = numInt;
            //Get type of numDouble
            Type numDoubleType = numDouble.GetType();
            // Value Before Conversion
            Console.WriteLine($"numInt value: {numInt}");
            Console.WriteLine($"numInt Type: {numIntType}");
            Console.WriteLine($"Int Size: {sizeof(int)} Bytes");
            // Value After Conversion
            Console.WriteLine($"numDouble value: {numDouble}");
            Console.WriteLine($"numDouble Type: {numDoubleType}");
            Console.WriteLine($"double Size: {sizeof(double)} Bytes");
            Console.ReadKey();
        }

        // Explicit Conversion or Explicit Type Casting in C# is done by using the Cast operator. It includes the conversion of larger data types to smaller data types. In the case of Explicit Conversion or Explicit Type Casting. there is a chance of data loss or the conversion might not be succeeded for some reason. This is an unsafe type of conversion.
        public void ExplicitTypeCasting()
        {
            double numDouble = 1.23;
            //Here, (int) is a cast expression that explicitly converts
            int numInt = (int)numDouble;
            // Value Before Conversion
            Console.WriteLine("Original double Value: " + numDouble);
            // Value After Conversion
            Console.WriteLine("Converted int Value: " + numInt);
        }

        public void ExplicitTypeCastingWithDataLoss()
        {
            int IntNum1 = 100;
            byte ByteNum1 = (byte)IntNum1; // Explicit Type Casting
            // Printing the Original Value and Converted Value
            Console.WriteLine($"Original Value:{IntNum1} and Converted Value:{ByteNum1}");
            int IntNum2 = 500;
            byte ByteNum2 = (byte)IntNum2; // Explicit Type Casting
            // Printing the Original Value and Converted Value
            Console.WriteLine($"Original Value:{IntNum2} and Converted Value:{ByteNum2}");
        }
        
        public void ExplicitTypeCastingForString()
        {
            string str = "100";
            //int i1 = (int)str; // this will raise a compile time error.
            int i1 = Convert.ToInt32(str); //Converting string to Integer
            double d = 123.45;
            int i2 = Convert.ToInt32(d); //Converting double to Integer
            float fl = 45.678F;
            string str2 = Convert.ToString(fl); //Converting float to string
            Console.WriteLine($"Original value str: {str} and Converted Value i1:{i1}");
            Console.WriteLine($"Original value d: {d} and Converted Value i2:{i2}");
            Console.WriteLine($"Original value f: {fl} and Converted Value str2:{str2}");
        }
    }
}
