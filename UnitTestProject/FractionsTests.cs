using System;
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
            var fractions = new Fractions();
            //Act
            var result = fractions.AddFractions(1, 2);


            //Assert
            Assert.IsTrue((result == 3));
        }
    }
}
