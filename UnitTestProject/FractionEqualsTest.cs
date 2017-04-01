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
            Assert.IsTrue(new Fraction(3, 5).equals(new Fraction(3,5)));
        }
    }
}
