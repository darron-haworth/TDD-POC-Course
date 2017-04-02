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
            Assert.AreEqual(new Fraction(3, 5), new Fraction(3,5));
        }

        [TestMethod]
        public void differentNumerators()
        {
            Assert.AreNotEqual(new Fraction(2, 5), new Fraction(1, 5));
        }

        [TestMethod]
        public void differentDenominators()
        {
            Assert.AreNotEqual(new Fraction(2, 5), new Fraction(1, 8));
        }

        [TestMethod] public void wholeNumberEqualsSameFraction()
        {
            Assert.AreEqual(new Fraction(5), new Fraction(5, 1));
        }

        [TestMethod]
        public void wholeNumbersNotEqualToDifferentWholeNumber()
        {
            Assert.AreNotEqual(new Fraction(5), new Fraction(6));
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
