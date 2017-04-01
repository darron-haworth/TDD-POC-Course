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

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction Plus(Fraction newFraction)
        {
            var thisDenom = this.Denominator;
            var thatDenom = newFraction.Denominator;
            var retFraction = new Fraction(this.Numerator + newFraction.Numerator, thisDenom);
            return retFraction;
        }

    }
}
