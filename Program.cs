using System;
using System.Collections.Generic;

namespace practice_stock_purchase_dictionaries
{
    class StockPurchases
    {
        static void Main(string[] args)
        {

            // Create a simple dictionary with ticker symbols and company names in the Main method.

            Dictionary<string, string> stockCompanies = new Dictionary<string, string>() {
                {"GM", "General Motors"},
                {"CAT", "Caterpillar"},
                {"GE", "General Electric"},
                {"GPS", "Gap Inc."}
            };

            // "purchases" is a list to hold stock purchases by an investor; It contains dictionaries.

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            // // Add some purchases

            purchases.Add(new Dictionary<string, double>() { { "GM", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 580.98 } });

            purchases.Add(new Dictionary<string, double>() { { "CAT", 1034.58 } });
            purchases.Add(new Dictionary<string, double>() { { "CAT", 3679.39 } });

            purchases.Add(new Dictionary<string, double>() { { "GE", 47.32 } });
            purchases.Add(new Dictionary<string, double>() { { "GE", 109.98 } });

            purchases.Add(new Dictionary<string, double>() { { "GPS", 4098.38 } });
            purchases.Add(new Dictionary<string, double>() { { "GPS", 4854.13 } });

            /*
                Define a new Dictionary to hold the aggregated purchase information.
                    - The key should be a string that is the full company name.
                    - The value will be the total valuation of each stock
            */

            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            /*
                Iterate over the purchases and record the valuation for each stock.
                Find the value in stocks and match it with the key in purchases (which contains dictionaries)
             */

            foreach (Dictionary<string, double> purchase in purchases)

            /*
                "purchases" is the list containing ALL { {"stockAcronym", stockValue} } dictionaries
                "purchase" is simply one of those dictionaries
                "For each dictionary item in the list..."
            */

            {
                foreach (KeyValuePair<string, double> stock in purchase)
                {

                    // string GM = stockCompanies["GM"];
                    // string CAT = stockCompanies["CAT"];
                    // string GE = stockCompanies["GE"];
                    // string GPS = stockCompanies["GPS"];

                    /*
                        Does the full company name key already exist in the `stockReport`?
                        If it does, update the total valuation

                        If not, add the new key and set its value.
                        You have the value of "GE", so how can you look in
                        the value of "GE" in the `stocks` dictionary
                        to get the value of "General Electric"?
                    */
                    string stockCompanyFullName = stockCompanies[stock.Key];
                    // this is the same as stockCompanies["GM"], where "GM" is the value of stock on purchase; it's looking for a match to stock in purchase in stockCompanies.

                    if (stockReport.ContainsKey(stockCompanyFullName))
                    //ContainsKey is FINDING a Key; it has a built-in .Find()
                    {

                        (stockReport[stockCompanies[stock.Key]]) += (stock.Value);

                    } else {
                        stockReport.Add(stockCompanies[stock.Key], stock.Value);
                    }
                }
                foreach (KeyValuePair<string, double> item in stockReport)
                {
                    Console.WriteLine($"The stock is {item.Key} and the value is {item.Value}");
                    };
            }
            // Console.WriteLine($"stockReport: {stockReport}");



        }
    }
}
