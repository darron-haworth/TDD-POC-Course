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
            float x = (float)1/(float)2;
            float y = (float)1/(float)2;
            var fractions = new Fractions();
            //Act
            float result = fractions.AddFractions(x, y);


            //Assert
            Assert.IsTrue((result == x/y));
        }
    }
}
