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

        public void SetProductNotFoundMessage(string barcode)
        {
            _displayText = ($"Product not found for barcode: {barcode}");
        }

        public void SetEmptyBarcodeMessage(string barcode)
        {
            _displayText = barcode == null ? "Null barcode" : "Scanning error: no barcode";
        }
    }

    public class Sale
    {
        public Sale(Display display, Catalog catalog)
        {
            ThisCatalog = catalog;
            ThisDisplay = display;
        }

        public Display ThisDisplay { get; set; }
        public Catalog ThisCatalog { get; set; }




        public void OnBarCode(string barcode)
        {
            if (string.IsNullOrEmpty(barcode))
            {
                if (string.IsNullOrEmpty(barcode))
                {
                    ThisDisplay.SetEmptyBarcodeMessage(barcode);
                    return;
                }
                else if (barcode == string.Empty)
                {
                    ThisDisplay.SetText("Scanning error: no barcode");
                }
            }


            var priceAsText = FindPrice(barcode);

            if (string.IsNullOrEmpty(priceAsText))
            {
                ThisDisplay.SetProductNotFoundMessage(barcode);
            }
            else
            {
                ThisDisplay.SetText(priceAsText);
            }
        }

        private string FindPrice(string barcode)
        {
            return ThisCatalog.findPrice(barcode);
        }
    }

    public class Catalog
    {
        private Dictionary<string, string> _pricesByBarcode;

        public Catalog(Dictionary<string, string> pricesByBarcode)
        {
            _pricesByBarcode = pricesByBarcode;
        }
        public Dictionary<string, string> getPricesByBarcode()
        {
            return _pricesByBarcode;
        }

        public string findPrice(string barcode)
        {

            if (_pricesByBarcode.ContainsKey(barcode))
            {
                return _pricesByBarcode[barcode];
            }
            return null;
        }
    }

}
