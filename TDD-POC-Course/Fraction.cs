using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_POC_Course
{
    [SuppressMessage("ReSharper", "ConvertToAutoProperty")]
    public class Fraction
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public int Numerator => _numerator;

        public int Denominator => _denominator;


        public  Fraction(int intValue)
        {
            _numerator = intValue;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
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
