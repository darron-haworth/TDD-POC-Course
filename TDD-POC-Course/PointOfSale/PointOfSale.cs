using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
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

    public class Sale
    {
        public Sale(Dictionary<string, string> pricesByBarcode )
        {
            PricesByBarcode = pricesByBarcode;
        }
        public static Dictionary<string, string> PricesByBarcode { get; set; }
        public void OnBarCode(string barcode)
        {
            if (string.IsNullOrEmpty(barcode))
            {
                Display.SetText(barcode == null ? "Null barcode" : "Scanning error: no barcode");
                return;
            }

            Display.SetText(PricesByBarcode.ContainsKey(barcode)
            ? PricesByBarcode[barcode]
            : $"Product not found for barcode: {barcode}");

        }
    }
}
