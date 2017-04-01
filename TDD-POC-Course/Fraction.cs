using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable All

namespace TDD_POC_Course
{
    [SuppressMessage("ReSharper", "ConvertToAutoProperty")]
    public class Fraction
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public int Numerator => _numerator;

        public int Denominator => _denominator;


        public Fraction(int numerator, int denominator = 1)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction Plus(Fraction newFraction)
        {
            var retFraction = new Fraction(this.Numerator + newFraction.Numerator, this.Denominator);
            return retFraction;
        }

        public Boolean equals(object otherFraction)
        {
            if (otherFraction.GetType() == typeof (Fraction))
            {
                var fractionToCompare = (Fraction)otherFraction;
                return Numerator == fractionToCompare.Numerator &&
                       Denominator == fractionToCompare.Denominator;

            }
            return false;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
