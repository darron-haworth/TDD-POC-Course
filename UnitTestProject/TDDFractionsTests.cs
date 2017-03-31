using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using MathExtension;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_POC_Course;

namespace UnitTestProject
{
    [TestClass]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class TDDFractionsTests
    {

        [TestMethod]
        public void CanAddZerosKernel()
        {
            //Arrange
            var x = 0;
            var y = 0;
            var expectedResult = x + y;
            var fractions = new TDDFractions();
            //Act
            var result = fractions.AddFractions(x, y);


            //Assert
            Console.Write("Result: " + result);
            Assert.IsTrue(result.Equals(expectedResult));
        }
        [TestMethod]
        public void CanAddFractions()
        {
            //Arrange
            var x = (Rational) 1/4;
            var y = (Rational) 1/2;
            var expectedResult = x + y;
            var fractions = new TDDFractions();
            //Act
            var result = fractions.AddFractions(x, y);


            //Assert
            Console.Write("Result: " + result);
            Assert.IsTrue(result.Equals(expectedResult));
        }

        [TestMethod]
        public void CanAddWholeNumbers()
        {
            //Arrange
            var x = (Rational)1;
            var y = (Rational)2;
            var expectedResult = x + y;
            var fractions = new TDDFractions();
            //Act
            var result = fractions.AddFractions(x, y);


            //Assert
            Console.Write("Result: " + result);
            Assert.IsTrue(result.Equals(expectedResult));
        }

        [TestMethod]
        public void CanAddWholeNegativeNumbers()
        {
            //Arrange
            var x = (Rational)1;
            var y = ((Rational)2 * -1);
            var expectedResult = x + y;
            var fractions = new TDDFractions();
            //Act
            var result = fractions.AddFractions(x, y);


            //Assert
            Console.Write("Result: " + result);
            Assert.IsTrue(result.Equals(expectedResult));
        }

        [TestMethod]
        public void CanAddNegativeFractionalNumbers()
        {
            //Arrange
            var x = ((Rational)3/4 * -1);
            var y = (Rational)3/8;
            var expectedResult = x + y;
            var fractions = new TDDFractions();
            //Act
            var result = fractions.AddFractions(x, y);


            //Assert
            Console.Write("Result: " + result);
            Assert.IsTrue(result.Equals(expectedResult));
        }

        [TestMethod]
        public void CanAddNegDenomFractionalNumbers()
        {
            //Arrange
            var x = ((Rational) 2 / -3);
            var y = (Rational) 1 / -2;
            var expectedResult = x + y;
            var fractions = new TDDFractions();
            //Act
            var result = fractions.AddFractions(x, y).ToMixedString();


            //Assert
            Console.Write("Result: " + result);
            Assert.IsTrue(result.Equals(expectedResult.ToMixedString()));
        }

    }
}