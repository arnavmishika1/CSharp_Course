using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Recursion
{
    internal class RecursionExamples
    {
        private void f1(int n)
        {
            if(n > 0)
            {
                Console.Write($"{n}");
                f1(n - 1);
            }
        }
        public void PrintReverseCounting()
        {
            int x = 3;
            f1(x);
        }

        private void f2(int n)
        {
            if(n > 0)
            {
                f2(n - 1);
                Console.Write($"{n}");
            }
        }
        public void PrintCounting()
        {
            int x = 3;
            f2(x);
        }

    }
}
