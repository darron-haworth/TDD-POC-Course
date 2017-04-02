﻿using System;
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
            var signOfDenominator = denominator < 0 ? -1 : 1;
            var gcd = NumberTheory.GreatestCommonDenominator(numerator, denominator) * signOfDenominator;
            _numerator = numerator / gcd;
            _denominator = denominator / gcd;
        }

        public Fraction Plus(Fraction that)
        {
            if ( this._denominator != that.Denominator)
            {
                var newNum = this._numerator * that.Denominator + that.Numerator * this._denominator;
                var newDenom = this._denominator * that.Denominator;
                var retFraction = new Fraction(newNum, newDenom);
                return retFraction;
            }
            else
            {
                return new Fraction(Numerator + that.Numerator, Denominator);
            }
        }

        public override bool Equals(object otherFraction)
        {
            if (otherFraction.GetType() == typeof (Fraction))
            {
                var fractionToCompare = (Fraction)otherFraction;
                return Numerator == fractionToCompare.Numerator &&
                       Denominator == fractionToCompare.Denominator;

            }
            return false;
        }

        public override int GetHashCode()
        {
            return Numerator*19 + Denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
