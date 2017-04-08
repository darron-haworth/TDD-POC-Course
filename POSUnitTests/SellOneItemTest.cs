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
        public Sale mySale { get; set; }
        public Display myDisplay { get; set; }
        public Dictionary<string,string> myData { get; set; }
        
        [TestInitialize()]
        public void Initialize()
        {
            var pricesByBarcode = new Dictionary<string, string>()
            {
                {"12345678", "$7.95"},
                {"22345678", "$12.50"}
            };
            myDisplay = new Display();
            mySale = new Sale(myDisplay, pricesByBarcode);

        }

        [TestCleanup()]
        public void Cleanup()
        {
        }

        [TestMethod]
        public void ProductFound()
        {
            mySale.OnBarCode("12345678");
            Console.Write(myDisplay.GetText());
            Assert.AreEqual("$7.95", myDisplay.GetText());
        }

        [TestMethod]
        public void AnotherProductFound()
        {
            mySale.OnBarCode("22345678");
            Console.Write(myDisplay.GetText());
            Assert.AreEqual("$12.50", myDisplay.GetText());
        }

        [TestMethod]
        public void ProductNotFound()
        {
            mySale.OnBarCode("5678");
            Console.Write(myDisplay.GetText());
            Assert.AreEqual($"Product not found for barcode: {"5678"}", myDisplay.GetText());
        }

        [TestMethod]
        public void EmptyBarcode()
        {
            mySale.OnBarCode("");
            Console.Write(myDisplay.GetText());
            Assert.AreEqual("Scanning error: no barcode", myDisplay.GetText());
        }

        [TestMethod]
        public void NullBarcode()
        {
            mySale.OnBarCode(null);
            Console.Write(myDisplay.GetText());
            Assert.AreEqual("Null barcode", myDisplay.GetText());
        }
    }
}
