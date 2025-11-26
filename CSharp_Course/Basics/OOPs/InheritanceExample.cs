using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.OOPs
{
    internal class InheritanceExample
    {

    }

    public class ClassA
    {
        public ClassA()
        {
            Console.WriteLine("Class A constructor is called");
        }
        static ClassA()
        {
            Console.WriteLine("Class A static constructor is called");
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
    public class ClassB : ClassA
    {
        public ClassB()
        {
            Console.WriteLine("Class B constructor is called");
        }
        static ClassB()
        {
            Console.WriteLine("Class B static constructor is called");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }

        /*
        public static void Main()
        {
            //ClassB obj1 = new();
            //obj1.Method1();
            //obj1.Method2();
            //obj1.Method3();

            ClassA p; //p is a variable of class A
            ClassB q = new ClassB(); //q is an instance of Class B 
            //We can initialize a Parent class variable using child class instance as follows
            p = q; //now, p is a reference of parent class created by using child class instance
            //Now you can call members of A class as follows
            p.Method1();
            p.Method2();
            //We cannot call any pure child class members using the reference p
            //p.Method3();
        }
        */
    }
}
