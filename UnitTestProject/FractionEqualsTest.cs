using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_POC_Course;

namespace UnitTestProject
{
    [TestClass]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class FractionEqualsTest
    {
        [TestMethod]
        public void sameNumeratorAndDenominator()
        {
            Assert.IsTrue(new Fraction(3, 5).Equals(new Fraction(3,5)));
        }

        [TestMethod]
        public void differentNumerators()
        {
            Assert.IsFalse(new Fraction(2, 5).Equals(new Fraction(1, 5)));
        }

        [TestMethod]
        public void differentDenominators()
        {
            Assert.IsFalse(new Fraction(2, 5).Equals(new Fraction(1, 8)));
        }

        [TestMethod] public void wholeNumberEqualsSameFraction()
        {
            Assert.IsTrue(new Fraction(5).Equals(new Fraction(5, 1)));
        }

        [TestMethod]
        public void wholeNumbersNotEqualToDifferentWholeNumber()
        {
            Assert.IsFalse(new Fraction(5).Equals(new Fraction(6)));
        }

        [TestMethod]
        public void negativeDenominator()
        {
            Assert.AreEqual(new Fraction(1, 2), new Fraction(-1, -2));
        }

        [TestMethod]
        public void negativeDenominatorReversed()
        {
            Assert.AreEqual(new Fraction(-1, 2), new Fraction(1, -2));
        }

    }
}
