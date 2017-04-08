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
            Console.Write(Display.GetText());
            Assert.AreEqual("$7.95", Display.GetText());
        }

        [TestMethod]
        public void AnotherProductFound()
        {
            Sale.OnBarCode("22345678");
            Console.Write(Display.GetText());
            Assert.AreEqual("$12.50", Display.GetText());
        }

        [TestMethod]
        public void ProductNotFound()
        {
            var barcode = "5678";
            Sale.OnBarCode(barcode);
            Console.Write(Display.GetText());
            Assert.AreEqual($"Product not found for barcode: {barcode}", Display.GetText());
        }

        [TestMethod]
        public void EmptyBarcode()
        {
            var barcode = "";
            Sale.OnBarCode(barcode);
            Console.Write(Display.GetText());
            Assert.AreEqual("Scanning error: no barcode", Display.GetText());
        }
    }
}
