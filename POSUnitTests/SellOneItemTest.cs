using System;
using System.Collections.Generic;
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
            var pricesByBarcode = new Dictionary<string, string>()
            {
                {"12345678", "$7.95"}
            };

            var testSale = new Sale(pricesByBarcode);
            testSale.OnBarCode("12345678");
            Console.Write(Display.GetText());
            Assert.AreEqual("$7.95", Display.GetText());
        }

        [TestMethod]
        public void AnotherProductFound()
        {
            var pricesByBarcode = new Dictionary<string, string>()
            {
                {"22345678", "$12.50"}
            };

            var testSale = new Sale(pricesByBarcode);
            testSale.OnBarCode("22345678");
            Console.Write(Display.GetText());
            Assert.AreEqual("$12.50", Display.GetText());
        }

        [TestMethod]
        public void ProductNotFound()
        {
            var pricesByBarcode = new Dictionary<string, string>()
            {
                {"12345678", "$7.95"}
            };

            var testSale = new Sale(pricesByBarcode);
            testSale.OnBarCode("5678");
            Console.Write(Display.GetText());
            Assert.AreEqual($"Product not found for barcode: {"5678"}", Display.GetText());
        }

        [TestMethod]
        public void EmptyBarcode()
        {
            var testSale = new Sale(null);
            testSale.OnBarCode("");
            Console.Write(Display.GetText());
            Assert.AreEqual("Scanning error: no barcode", Display.GetText());
        }

        [TestMethod]
        public void NullBarcode()
        {
            
            var testSale = new Sale(null);
            testSale.OnBarCode(null);
            Console.Write(Display.GetText());
            Assert.AreEqual("Null barcode", Display.GetText());
        }
    }
}
