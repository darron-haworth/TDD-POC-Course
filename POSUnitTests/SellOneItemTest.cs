using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace POSUnitTests
{
    [TestClass]
    public class SellOneItemTest
    {
        [TestMethod]
        public void ProductFound()
        {
            Assert.AreEqual("$7.95", Display.GetText());
        }
    }
}
