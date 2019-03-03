using System;
using System.Collections.Generic;

namespace practice_stock_purchase_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary<string, int> toysSold = new Dictionary<string, int>() {
            //     {"Hot Wheels", 344}
            // };
            // int HotWheels = toysSold["Hot Wheels"];
            // Console.WriteLine(HotWheels);
//==============================================================================================================

            // Instructions:
            // A block of publicly traded stock has a variety of attributes, we'll look at a few of them. A stock has a ticker symbol and a company name. Create a simple dictionary with ticker symbols and company names in the Main method.

//==============================================================================================================

            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("GE", "General Electric");
            stocks.Add("AMD", "Advanced Micro Devices Inc.");
            stocks.Add("BAC", "Bank of America Corp");
            stocks.Add("GPS", "Gap Inc.");



        }
    }
}
