using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_POC_Course
{
    public class Fraction
    {

        public int Numerator { get; set; }
        public int Denominator { get; set; }

           

        public  Fraction(int intValue)
        {
            Numerator = intValue;
            Denominator = 1;
        }

        public Fraction Plus(Fraction fraction)
        {
            var retFraction = new Fraction(fraction.Numerator);
            return retFraction;
        }

    }
}
