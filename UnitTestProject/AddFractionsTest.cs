using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_POC_Course;

namespace UnitTestProject
{
    [TestClass]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class AddFractionsTest
    {
        [TestMethod]
        public void zeroPlusZero()
        {
            Assert.AreEqual(new Fraction(0), new Fraction(0).Plus(new Fraction(0)));
        }

        [TestMethod]
        public void nonZeroPlusZero()
        {
            Assert.AreEqual(new Fraction(5), new Fraction(5).Plus(new Fraction(0)));
        }

        [TestMethod]
        public void zeroPlusNonZero()
        {
            Assert.AreEqual(new Fraction(3), new Fraction(0).Plus(new Fraction(3)));
        }

        [TestMethod]
        public void nonZeroPlusNonZero()
        {
            Assert.AreEqual(new Fraction(5).Plus(new Fraction(8)), new Fraction(13));
        }

        [TestMethod]
        public void negativeNonZeroPlusZero()
        {
            Assert.AreEqual(new Fraction(-3), new Fraction(-3).Plus(new Fraction(0)));
        }

        [TestMethod]
        public void zeroPlusNegativeNotZero()
        {
            Assert.AreEqual(new Fraction(-3), new Fraction(0).Plus(new Fraction(-3)));
        }

        [TestMethod]
        public void nonTrivialButCommonDenominator()
        {
            Assert.AreEqual(new Fraction(4, 5), new Fraction(1, 5).Plus(new Fraction(3, 5)));
        }

        [TestMethod]
        public void differentDenominators()
        {
            Assert.AreEqual(new Fraction(1, 2).Plus(new Fraction(1, 3)), new Fraction(5, 6));
        }

        [TestMethod]
        public void reduceResultToWholeNumber()
        {
            Assert.AreEqual(new Fraction(1), new Fraction(1,3).Plus(new Fraction(2, 3)));
        }

        [TestMethod]
        public void onDenominatorIsAMultipleOfTheOther()
        {
            Assert.AreEqual(new Fraction(11, 8), new Fraction(3, 4).Plus(new Fraction(5, 8)));
        }

        [TestMethod]
        public void commonFactorInDenominators()
        {
            Assert.AreEqual(new Fraction(11, 18), new Fraction(1, 6).Plus(new Fraction(4, 9)));
        }

        [TestMethod]
        public void reducedResultEvenWhenDenominatorsAreTheSame()
        {
            Assert.AreEqual(new Fraction(3, 2), new Fraction(3, 4).Plus(new Fraction(3, 4)));
        }

        [TestMethod]
        public void negativeFractionAndReducing1()
        {
            Assert.AreEqual(new Fraction(1, 2), new Fraction(-1, 4).Plus(new Fraction(3, 4)));
        }

        [TestMethod]
        public void negativeFractionAndReducing2()
        {
            Assert.AreEqual(new Fraction(-1, 8), new Fraction(3, 8).Plus(new Fraction(-1, 2)));
        }

        [TestMethod]
        public void negativeFractionAndReducing3()
        {
            Assert.AreEqual(new Fraction(1, 2), new Fraction(1, -4).Plus(new Fraction(-3, -4)));
        }
    }
}
