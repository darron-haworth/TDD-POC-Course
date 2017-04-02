using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_POC_Course
{
    public class NumberTheory
    {
        public static int GreatestCommonDenominator(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % t;
                a = t;
            }
            return Math.Abs(a);
        }
    }
}
