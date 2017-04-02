using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_POC_Course;

// ReSharper disable All

namespace UnitTestProject
{
    [TestClass]
    public class ReduceFractionTest
    {
        [TestMethod]
        public void alreadyInLowestTerms()
        {
            Assert.AreEqual(new Fraction(3,4), new Fraction(3, 4));
        }

        [TestMethod]
        public void reduceToNotWholeNumber()
        {
            Assert.AreEqual(new Fraction(6, 8), new Fraction(3, 4));
        }

        [TestMethod]
        public void reduceToWholeNumber()
        {
            Assert.AreEqual(new Fraction(6), new Fraction(24, 4));
        }

        [TestMethod]
        public void reduceToZero()
        {
            Assert.AreEqual(new Fraction(0), new Fraction(0, 5465321));
        }

    }
}
