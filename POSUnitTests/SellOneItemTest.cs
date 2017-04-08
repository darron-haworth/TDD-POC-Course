using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_POC_Course.PointOfSale;

namespace POSUnitTests
{
    [TestClass]
    public class SellOneItemTest
    {
        [TestMethod]
        public void ProductFound()
        {
            Sale.OnBarCode("12345678");
            Assert.AreEqual("$7.95", Display.GetText());
        }

        [TestMethod]
        public void AnotherProductFound()
        {
            Sale.OnBarCode("22345678");
            Assert.AreEqual("$12.50", Display.GetText());
        }
    }
}
