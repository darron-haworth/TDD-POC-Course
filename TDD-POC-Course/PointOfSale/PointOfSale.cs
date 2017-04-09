using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_POC_Course.PointOfSale
{
    public class Display
    {
        private string _displayText;
        public string GetText()
        {
            return _displayText;
        }

        public void SetText(string displayText)
        {
            _displayText = displayText;
        }
    }

    public class Sale
    {
        public Sale(Display display, Dictionary<string, string> pricesByBarcode)
        {
            PricesByBarcode = pricesByBarcode;
            ThisDisplay = display;
        }
        public Dictionary<string, string> PricesByBarcode { get; set; }
        public Display ThisDisplay { get; set; }
        public void OnBarCode(string barcode)
        {
            if (string.IsNullOrEmpty(barcode))
            {
                displayEmptyBarcodeMessage(barcode);
                return;
            }

            if (PricesByBarcode.ContainsKey(barcode))
            {
                displayPrice(barcode);
            }
            else
            {
                displayProcutNotFoundMessage(barcode);
            }

        }

        private void displayPrice(string barcode)
        {
            ThisDisplay.SetText(PricesByBarcode[barcode]);
        }

        private void displayProcutNotFoundMessage(string barcode)
        {
            ThisDisplay.SetText($"Product not found for barcode: {barcode}");
        }

        private void displayEmptyBarcodeMessage(string barcode)
        {
            ThisDisplay.SetText(barcode == null ? "Null barcode" : "Scanning error: no barcode");
        }
    }
}
