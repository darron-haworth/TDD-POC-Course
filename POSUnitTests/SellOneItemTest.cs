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
        
        
        [TestInitialize()]
        public void Initialize()
        {
        }

        [TestCleanup()]
        public void Cleanup()
        {
        }

        [TestMethod]
        public void ProductFound()
        {
            var thisDisplay = new Display();
            var pricesByBarcode = new Dictionary<string, string>()
            {
                {"12345678", "$7.95"}
            };

            var testSale = new Sale(thisDisplay, pricesByBarcode);
            testSale.OnBarCode("12345678");
            Console.Write(thisDisplay.GetText());
            Assert.AreEqual("$7.95", thisDisplay.GetText());
        }

        [TestMethod]
        public void AnotherProductFound()
        {
            var thisDisplay = new Display();
            var pricesByBarcode = new Dictionary<string, string>()
            {
                {"22345678", "$12.50"}
            };

            var testSale = new Sale(thisDisplay, pricesByBarcode);
            testSale.OnBarCode("22345678");
            Console.Write(thisDisplay.GetText());
            Assert.AreEqual("$12.50", thisDisplay.GetText());
        }

        [TestMethod]
        public void ProductNotFound()
        {
            var pricesByBarcode = new Dictionary<string, string>()
            {
                {"12345678", "$7.95"}
            };
            var thisDisplay = new Display();
            var testSale = new Sale(thisDisplay, pricesByBarcode);
            testSale.OnBarCode("5678");
            Console.Write(thisDisplay.GetText());
            Assert.AreEqual($"Product not found for barcode: {"5678"}", thisDisplay.GetText());
        }

        [TestMethod]
        public void EmptyBarcode()
        {
            var thisDisplay = new Display();
            var testSale = new Sale(thisDisplay, null);
            testSale.OnBarCode("");
            Console.Write(thisDisplay.GetText());
            Assert.AreEqual("Scanning error: no barcode", thisDisplay.GetText());
        }

        [TestMethod]
        public void NullBarcode()
        {
           var thisDisplay = new Display();
            var testSale = new Sale(thisDisplay, null);
            testSale.OnBarCode(null);
            Console.Write(thisDisplay.GetText());
            Assert.AreEqual("Null barcode", thisDisplay.GetText());
        }
    }
}
