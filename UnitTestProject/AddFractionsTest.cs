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
            Assert.IsTrue(new Fraction(0).Equals(new Fraction(0).Plus(new Fraction(0))));
        }

        [TestMethod]
        public void nonZeroPlusZero()
        {
            Assert.IsTrue(new Fraction(5).Equals(new Fraction(5).Plus(new Fraction(0))));
        }

        [TestMethod]
        public void zeroPlusNonZero()
        {
            Assert.IsTrue(new Fraction(3).Equals(new Fraction(0).Plus(new Fraction(3))));
        }

        [TestMethod]
        public void nonZeroPlusNonZero()
        {
            Assert.IsTrue(new Fraction(5).Plus(new Fraction(8)).Equals(new Fraction(13)));
        }

        [TestMethod]
        public void negativeNonZeroPlusZero()
        {
            Assert.IsTrue(new Fraction(-3).Equals(new Fraction(-3).Plus(new Fraction(0))));
        }

        [TestMethod]
        public void zeroPlusNegativeNotZero()
        {
            Assert.IsTrue(new Fraction(-3).Equals(new Fraction(0).Plus(new Fraction(-3))));
        }

        [TestMethod]
        public void nonTrivialButCommonDenominator()
        {
            Assert.IsTrue(new Fraction(4, 5).Equals(new Fraction(1, 5).Plus(new Fraction(3, 5))));
        }
    }
}
