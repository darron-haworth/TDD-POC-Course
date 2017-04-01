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
            var sum = new Fraction(0).Plus(new Fraction(0));
 
            Assert.IsTrue(sum.Numerator  == 0);
        }

        [TestMethod]
        public void nonZeroPlusZero()
        {
            var sum = new Fraction(5).Plus(new Fraction(0));

            Assert.IsTrue(sum.Numerator == 5);
        }

        [TestMethod]
        public void zeroPlusNonZero()
        {
            var sum = new Fraction(0).Plus(new Fraction(3));

            Assert.IsTrue(sum.Numerator == 3);
        }

        [TestMethod]
        public void nonZeroPlusNonZero()
        {
            var sum = new Fraction(5).Plus(new Fraction(8));

            Assert.IsTrue(sum.Numerator == 13);
        }

        [TestMethod]
        public void negativeNonZeroPlusZero()
        {
            var sum = new Fraction(-3).Plus(new Fraction(0));

            Assert.IsTrue(sum.Numerator == -3);
        }

        [TestMethod]
        public void zeroPlusNegativeNotZero()
        {
            var sum = new Fraction(0).Plus(new Fraction(-3));

            Assert.IsTrue(sum.Numerator == -3);
        }

        [TestMethod]
        public void nonTrivialButCommonDenominator()
        {
            var sum = new Fraction(1, 5).Plus(new Fraction(3, 5));

            Assert.IsTrue(sum.Numerator == 4 && sum.Denominator == 5);
        }


    }
}
