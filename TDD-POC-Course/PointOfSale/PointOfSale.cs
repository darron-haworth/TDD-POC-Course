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
            Display.SetText("$7.95");   
        }
    }
}
