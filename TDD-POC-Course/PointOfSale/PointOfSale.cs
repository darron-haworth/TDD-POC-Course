using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_POC_Course.PointOfSale
{
    public static class Display
    {
        private static string _displayText;
        public static string GetText()
        {
            return _displayText;
        }

        public static void SetText(string displayText)
        {
            _displayText = displayText;
        }
    }

    public static class Sale
    {
        public static void OnBarCode(string barcode)
        {

            var pricesByBarcode = new Dictionary<string, string>()
            {
                {"12345678", "$7.95"},
                {"22345678", "$12.50"}
            };

            if (string.IsNullOrEmpty(barcode))
            {
                Display.SetText(barcode == null ? "Null barcode" : "Scanning error: no barcode");
            }
            else
            {
                Display.SetText(pricesByBarcode.ContainsKey(barcode)
                ? pricesByBarcode[barcode]
                : $"Product not found for barcode: {barcode}");
            }
        }
    }
}
