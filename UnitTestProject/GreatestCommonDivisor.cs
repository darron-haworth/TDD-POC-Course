using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_POC_Course;

// ReSharper disable All

namespace UnitTestProject
{
    [TestClass]
    public class GreatestCommonDivisor
    {
        [TestMethod]
        public void oneAndOne()
        {
            Assert.AreEqual(1, NumberTheory.GreatestCommonDenominator(1, 2));
            Assert.AreEqual(2, NumberTheory.GreatestCommonDenominator(2, 2));
            Assert.AreEqual(1, NumberTheory.GreatestCommonDenominator(-1, 1));
        }

        [TestMethod]
        public void relativelyPrime()
        {
            Assert.AreEqual(1, NumberTheory.GreatestCommonDenominator(2, 3));
            Assert.AreEqual(1, NumberTheory.GreatestCommonDenominator(4, 7));
            Assert.AreEqual(1, NumberTheory.GreatestCommonDenominator(-2, -3));
        }

        [TestMethod]
        public void oneIsMultipleOfTheOther()
        {
            Assert.AreEqual(3, NumberTheory.GreatestCommonDenominator(3, 9));
            Assert.AreEqual(5, NumberTheory.GreatestCommonDenominator(5, 30));
        }

        [TestMethod]
        public void commonFactor()
        {
            Assert.AreEqual(2, NumberTheory.GreatestCommonDenominator(6, 8));
            Assert.AreEqual(7, NumberTheory.GreatestCommonDenominator(49, 315));
            Assert.AreEqual(4, NumberTheory.GreatestCommonDenominator(-24, 28));
            Assert.AreEqual(4, NumberTheory.GreatestCommonDenominator(24, -28));
        }

    }
}
