using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_POC_Course;

namespace UnitTestProject
{
    [TestClass]
    public class FractionsTests
    {
        [TestMethod]
        public void CanAddFractions()
        {
            //Arrange
            var x = 0.5;
            var y = 0.5;
            var expectedResult = x + y;
            var fractions = new Fractions();
            //Act
            var result = fractions.AddFractions(x, y);


            //Assert
            Assert.IsTrue(result.Equals(expectedResult));
        }


        [TestMethod]
        public void CanAddWholeNumbers()
        {
            //Arrange
            var x = 5;
            var y = 5;
            var expectedResult = x + y;
            var fractions = new Fractions();
            //Act
            var result = fractions.AddFractions(x, y);


            //Assert
            Assert.IsTrue(result.Equals(expectedResult));
        }


    }
}
