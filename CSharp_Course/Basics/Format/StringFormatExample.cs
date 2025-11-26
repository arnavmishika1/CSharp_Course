using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Course.Basics.Format
{
    internal class StringFormatExample
    {
        public void ViewStringFormats()
        {
            double val = 1000d / 12.34d;
            Console.WriteLine(val);
            Console.WriteLine(string.Format("{0:0}", val));
            Console.WriteLine(string.Format("{0:0.0}", val));
            Console.WriteLine(string.Format("{0:0.00}", val));
            Console.WriteLine();

            double money = -10D / 3D;

            Console.WriteLine(money);
            Console.WriteLine(string.Format("-$10 / $3 = ${0:00}", money));
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));
            Console.WriteLine();

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-us")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
        }
    }
}
