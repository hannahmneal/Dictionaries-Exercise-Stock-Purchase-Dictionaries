using System;
using System.Collections.Generic;

namespace practice_stock_purchase_dictionaries
{
    class StockPurchases
    {
        // I am defining my own custom variable types (Name and Cost) within the StockPurchases class:
        // string Name {get; set; } = "";
        // double Cost {get; set; } = 0.0;
        static void Main(string[] args)
        {
            // Dictionary<string, int> toysSold = new Dictionary<string, int>() {
            //     {"Hot Wheels", 344}
            // };
            // int HotWheels = toysSold["Hot Wheels"];
            // Console.WriteLine(HotWheels);
            //=======================================================================================

            // Instructions:
            // A block of publicly traded stock has a variety of attributes, we'll look at a few of them. A stock has a ticker symbol and a company name. Create a simple dictionary with ticker symbols and company names in the Main method.

            //================================  CODE FROM CHAPTER ============================================

            // A dictionary in C# is like an object in JS

            // Dictionary<string, string> stocks = new Dictionary<string, string>();
            // stocks.Add("GM", "General Motors");
            // stocks.Add("CAT", "Caterpillar");
            // stocks.Add("GE", "General Electric");
            // stocks.Add("GPS", "Gap Inc.");

            //================================  MY CODE ============================================

            Dictionary<string, string> stocks = new Dictionary<string, string>() {
                {"GM", "General Motors"},
                {"CAT", "Caterpillar"},
                {"GE", "General Electric"},
                {"GPS", "Gap Inc."}
            };

            foreach (KeyValuePair<string, string> stock in stocks) {
            // Console.WriteLine($"This is the value of stock: {stock}"); // returns the same Key-Value pairs as the code given in the chapter (lines ~25-31)
            };

            // string GM = stocks["GM"];
            // string CAT = stocks["CAT"];
            // string GE = stocks["GE"];
            // string GPS = stocks["GPS"];

            // if (stocks.ContainsKey("GM") == true) {
            //     Console.WriteLine(stocks["GM"]);
            // };

            // if (stocks.ContainsKey("CAT") == true) {
            //     Console.WriteLine(stocks["CAT"]);
            // };

            // if (stocks.ContainsKey("GE") == true) {
            //     Console.WriteLine(stocks["GE"]);
            // };

            // if (stocks.ContainsKey("GPS") == true) {
            //     Console.WriteLine(stocks["GPS"]);
            // };
//================================  CODE FROM CHAPTER: ============================================

            // A list to hold stock purchases by an investor; The list contains dictionaries. (In JS, this would be: purchases = [ stocks = {...} ]
            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();

            // Add some purchases

            purchases.Add(new Dictionary<string, double>() { { "GM", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 580.98 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 406.34 } });

            purchases.Add(new Dictionary<string, double>() { { "CAT", 1034.58 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 3679.39 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 1309.479 } });

            purchases.Add(new Dictionary<string, double>() { { "GE", 47.32 } });
            purchases.Add(new Dictionary<string, double>() { { "GE", 109.98 } });
            purchases.Add(new Dictionary<string, double>() { { "GE", 1217.53 } });

            purchases.Add(new Dictionary<string, double>() { { "GPS", 4098.38 } });
            purchases.Add(new Dictionary<string, double>() { { "GPS", 4854.13 } });
            purchases.Add(new Dictionary<string, double>() { { "GPS", 498.24 } });



//===============================    MY CODE: =========================================

// ????????
// How can this be used to shorten the list of "purchases.Add()"?
            // Dictionary<string, string> stockObj = new Dictionary<string, string>() {
            //     {"stockAcronym", "Value1A"},
            //     {"stockAcronym", "Value2B"}
            // };

//===============================================================================================

            // Create a total ownership report that computes the total value of each stock that you have purchased. This is the basic relational database join algorithm between two tables.

            // relational database join algorithm ??????????

//===============================================================================================
            /*
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the total valuation of each stock

                // stocks = {K1: V1}        {GM: General Motors}
                // purchases = {K1: V2}     {GM: 230.21}
                // stockReport = {V1: V2}   {General Motors: 230.21}

                From the purchases above, one of the entries
                in this new dictionary will be...
                    {"General Electric", 1217.53}

 Replace the questions marks below with the correct types.
*/
            Dictionary <string, double> stockReport = new Dictionary<string, double>();

            /*
               Iterate over the purchases and record the valuation
               for each stock.
            */
            foreach (Dictionary<string, double> purchase in purchases)
            {
                {
                    foreach (KeyValuePair<string, double> stock in purchase)
                    {
                        // Console.WriteLine(stock);
                        // This logs:
                            // [GM, 230.21]
                            // [GM, 580.98]
                            // [GM, 406.34]
                            // [CAT, 1034.58]
                            // [CAT, 3679.39]
                            // [CAT, 1309.479]
                            // [GE, 47.32]
                            // [GE, 109.98]
                            // [GE, 1217.53]
                            // [GPS, 4098.38]
                            // [GPS, 4854.13]
                            // [GPS, 498.24]

            if (purchase.ContainsKey("GM") == true) {
                Console.WriteLine(stocks["GM"]);
                Console.WriteLine(purchase["GM"]);
            };

            if (purchase.ContainsKey("CAT") == true) {
                Console.WriteLine(stocks["CAT"]);
                Console.WriteLine(purchase["CAT"]);
            };

            if (purchase.ContainsKey("GE") == true) {
                Console.WriteLine(stocks["GE"]);
                Console.WriteLine(purchase["GE"]);
            };

            if (purchase.ContainsKey("GPS") == true) {
                Console.WriteLine(stocks["GPS"]);
                Console.WriteLine(purchase["GPS"]);
            };
//===============================================================================================

                        // Does the full company name key already exist in the `stockReport`?
                        // If it does, update the total valuation

                        /*
                            If not, add the new key and set its value.
                            You have the value of "GE", so how can you look
                            the value of "GE" in the `stocks` dictionary
                            to get the value of "General Electric"?
                        */
//===============================================================================================

                    }
                }
                // Now that the report dictionary is populated, display the final results.
//                 foreach (KeyValuePair <string, double> item in stockReport)
// {
//                     Console.WriteLine($"The position in {item.Key} is worth {item.Value}");
//                 }
            }
        }
    }

}
