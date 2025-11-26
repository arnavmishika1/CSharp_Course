using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Datatypes
{
    internal class DataTypesExamples
    {
        // method to test performance impact of different data types.
        public void PerfomanceTest()
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            for (int i = 1; i <= 10000000; i++)
            {
                short a = 100;
                short b = 100;
                short c = 100;
            }
            stopwatch1.Stop();
            Console.WriteLine($"Short took {stopwatch1.ElapsedMilliseconds} Ms");

            Stopwatch stopwatch2 = new();
            stopwatch2.Start();
            for (int i = 1; i <= 10000000; i++)
            {
                decimal a = 100;
                decimal b = 100;
                decimal c = 100;
            }
            stopwatch2.Stop();
            Console.WriteLine($"Decimal took: {stopwatch2.ElapsedMilliseconds} Ms");
        }

        public void ChechMinMaxValues()
        {
            Console.WriteLine($"Byte => Minimum Range:{byte.MinValue} and Maximum Range:{byte.MaxValue}");
            Console.WriteLine($"Integer => Minimum Range:{int.MinValue} and Maximum Range:{int.MaxValue}");
            Console.WriteLine($"Float => Minimum Range:{float.MinValue} and Maximum Range:{float.MaxValue}");
            Console.WriteLine($"Long => Minimum Range:{long.MinValue} and Maximum Range:{long.MaxValue}");
            Console.WriteLine($"Double => Minimum Range:{double.MinValue} and Maximum Range:{double.MaxValue}");
            Console.ReadKey();
        }
    }
}
