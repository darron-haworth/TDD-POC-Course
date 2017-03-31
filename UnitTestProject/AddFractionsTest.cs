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
    }
}
