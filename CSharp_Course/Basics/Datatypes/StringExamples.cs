using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Datatypes
{
    internal class StringExamples
    {
        // giving different values to same string variable (Took 4301 ms)
        public void CheckStringImmutable()
        {
            string str = "";
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Loop started!");
            stopwatch.Start();
            for(int i = 0; i <= 30000000; i++)
            {
                str = Guid.NewGuid().ToString();
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended!");
            Console.WriteLine($"Loop execution time in MS: {stopwatch.ElapsedMilliseconds}");
        }

        // giving different values to same integer variable (Took 84 ms)
        public void CheckIntergerMutable()
        {
            int num = 0;
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Loop Start");
            stopwatch.Start();
            for(int i = 0; i < 30000000; i++)
            {
                num += 1;
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended!");
            Console.WriteLine($"Loop execution time in MS: {stopwatch.ElapsedMilliseconds}");
        }

        // String interning, when same value given to a string variable again and again.(79 ms)
        // it will check whether this “DotNet” value is already there in the memory, if yes then it simply uses that memory location else it will create a new memory location. This is nothing but C# string interning.
        public void StringInterning()
        {
            string str = "";
            Stopwatch stopwatch = new();
            Console.WriteLine("Loop start!");
            stopwatch.Start();
            for(int i = 1; i <= 30000000; i++)
            {
                str = "Dotnet";
            }
            stopwatch.Stop();
            Console.WriteLine("Loop ended!");
            Console.WriteLine($"Loop execution time in MS: {stopwatch.ElapsedMilliseconds}");
        }

        // String Builder, very useful and solve the problem for concatenation of string.
        public void StringBuilderForConcatenation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Stopwatch stopwatch = new();
            Console.WriteLine("Loop start!");
            stopwatch.Start();
            for (int i = 1; i <= 30000000; i++)
            {
                stringBuilder.Append("Dotnet Tutorials");
            }
            stopwatch.Stop();
            Console.WriteLine("Loop ended!");
            Console.WriteLine($"Loop execution time in MS: {stopwatch.ElapsedMilliseconds}");
        }
    }
}
