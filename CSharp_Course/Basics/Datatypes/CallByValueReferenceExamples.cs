using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Datatypes
{
    internal class CallByValueReferenceExamples
    {
        // UpdateValue method is called, variable a value is copied to variable b, so changing variable b does not change variable a.
        private static void UpdateValue(int b)
        {
            b = 20;
        }
        public void CallByValueWithValueType()
        {
            int a = 10;
            UpdateValue(a);
            Console.WriteLine(a);
        }

        // When we assign Emp1 to Emp2, the reference of the object memory location that Emp1 is holding is copied to Emp2. Now we have two copies of reference, but they both point to the same memory location. So, changing the Name property’s value will change the object’s value in memory, which we have references in Emp1 and Emp2. So, “Smith” will be printed on the console for both references.
        private static void UpdateName(Employee Emp2)
        {
            Emp2 = null;
        }
        public void CallByValueWithReferenceType()
        {
            Employee emp1 = new Employee();
            emp1.EmployeeId = 1;
            emp1.EmployeeName = "James";

            //Employee emp2 = emp1;
            //emp1.EmployeeName = "Smith";
            UpdateName(emp1);

            Console.WriteLine($"Emp1 Name = {emp1.EmployeeName}");
            //Console.WriteLine($"Emp2 Name = {emp2.EmployeeName}");
        }

        public static void UpdateValueByRef(ref int b)
        {
            b = 20;
        }
        public void CallByReferenceWithValueType()
        {
            int a = 10;
            UpdateValueByRef(ref a);
            Console.WriteLine(a);
        }

        private static void UpdateNameByRef(ref Employee Emp2)
        {
            Emp2 = null;
        }
        public void CallByReferenceWithReferenceType()
        {
            Employee emp1 = new Employee();
            emp1.EmployeeId = 1;
            emp1.EmployeeName = "James";

            //Employee emp2 = emp1;
            //emp1.EmployeeName = "Smith";
            UpdateNameByRef(ref emp1);

            Console.WriteLine($"Emp1 Name = {emp1.EmployeeName}"); // Will raise a compile time error
            //Console.WriteLine($"Emp2 Name = {emp2.EmployeeName}");
        }
    }

    public class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
    }
}
