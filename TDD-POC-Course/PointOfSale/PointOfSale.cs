using System;
using System.Collections.Generic;
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
            switch (barcode)
            {
                case "12345678":
                    Display.SetText("$7.95");
                    break;
                case "22345678":
                    Display.SetText("$12.50");
                    break;
                default:
                    Display.SetText("Not Found");
                    break;
            }
        }
    }
}
