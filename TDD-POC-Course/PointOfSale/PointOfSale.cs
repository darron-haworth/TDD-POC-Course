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
                if(string.IsNullOrEmpty(barcode))
                {
                    displayEmptyBarcodeMessage(barcode);
                    return;
                } else if(barcode == string.Empty)
                {
                    ThisDisplay.SetText("Scanning error: no barcode");
                }
            }

            
            var priceAsText = FindPrice(barcode);

            if (string.IsNullOrEmpty(priceAsText))
            {
                displayProductNotFoundMessage(barcode);
            }
            else
            {
                DisplayPrice(priceAsText);
            }
        }

        private void DisplayPrice(string priceAsText)
        {
            ThisDisplay.SetText(priceAsText);
        }
        private string FindPrice(string barcode)
        {
            if(PricesByBarcode.ContainsKey(barcode))
            {
                return PricesByBarcode[barcode];
            }
            return "";
        }

        private void displayProductNotFoundMessage(string barcode)
        {
            ThisDisplay.SetText($"Product not found for barcode: {barcode}");
        }

        private void displayEmptyBarcodeMessage(string barcode)
        {
            ThisDisplay.SetText(barcode == null ? "Null barcode" : "Scanning error: no barcode");
        }
    }
}
