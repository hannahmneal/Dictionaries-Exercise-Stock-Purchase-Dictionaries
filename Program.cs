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

                While there are potentially many ways to iterate data and populate the stockReport Dictionary with the correct data, there are two particular ways of doing it that I like. They are OPTION 1 and OPTION 2 below.
             */

            //===========================   OPTION 1    ================================================================================
            // This uses two iterations to obtain the stock report data.
            // The first iteration is purchase in purchases;
            //  - There are 8 "objects" in purchases; i.e., purchases is a list of dictionaries and there are 8 dictionaries at indexes [0]-[7]
            //  - purchase is the "object" at a specific index; i.e., [0]: {[GM, 230.21]}
            //  - This iteration looks to the purchases list and iterates each dictionary in the list based on its index
            // The second iteration is stock in purchase
            //  - An example of what "purchase" is based on the first iteration: purchase: [0]: {[GM, 230.21]}
            //  - This second iteration returns the dictionary itself, without the index; it goes deeper into the List of Dictionaries
            //  - The value of "stock" at the end of the iteration will be something like: stock: {[GM, 230.21]}



            //==============================    BEGIN ITERATION BLOCK   ================================================================

            foreach (Dictionary<string, double> purchase in purchases)

            /*
                "purchases" is the list containing ALL { {"stockAcronym", stockValue} } dictionaries
                "purchase" is simply one of those dictionaries
                "For each dictionary item in the list..."
            */
            {
                foreach (KeyValuePair<string, double> stock in purchase)
                /*
                    Before this line runs, the value of "stock" is: {[, 0]}, or, stock.Key: null, stock.Value: 0
                    After this line runs, the value of "stock" is: {[GM, 230.21]}
                 */
                {

                    /*
                        Does the full company name key already exist in the `stockReport`?
                        If it does, update the total valuation

                        If not, add the new key and set its value.
                        You have the value of "GE", so how can you look in
                        the value of "GE" in the `stocks` dictionary
                        to get the value of "General Electric"?
                    */
                    string stockCompanyFullName = stockCompanies[stock.Key];
                    /*
                        This is the same as stockCompanies["GM"], where "GM" is the value of stock on purchase; it's looking for a match to stock in purchase in stockCompanies.
                     */

                    if (stockReport.ContainsKey(stockCompanyFullName))
                    /*
                        ContainsKey is FINDING a Key; it has a built-in .Find()
                     */
                    {
                        (stockReport[stockCompanies[stock.Key]]) += (stock.Value);

                    } else {
                        stockReport.Add(stockCompanies[stock.Key], stock.Value);
                    }
                }
            }
            //============================  END OF ITERATION BLOCK  ===================================================================

            foreach (KeyValuePair<string, double> item in stockReport)
            {
                Console.WriteLine($"The stock is {item.Key} and the value is {item.Value}");
                };

            //===========================   OPTION 2    ================================================================================
            // This option iterates three times, then uses an if/else statement to populate the stock report.
            // It is the same as the first option until the third iteration of stockItem in stockCompanies. 
            //  - stockItem is each Dictionary item in stockCompanies: stockItem: {[GM, General Motors]}
            // Then, the Key of stockItem is compared to the key of stock. For both, it should be the same stock abbreviation (e.g., "GM")
            // If so, check whether the stockReport contains this key.
            // If it does not (it shouldn't at this point), for each of the stock abbreviations that are a match, reassign stockItem.Key to stockItem.Value

            //==========================================================================================================================

            // foreach (Dictionary<string, double> purchase in purchases)

            // /*
            //     "purchases" is the list containing ALL { {"stockAcronym", stockValue} } dictionaries
            //     "purchase" is simply one of those dictionaries
            //     "For each dictionary item in the list..."
            // */
            // {
            //     foreach (KeyValuePair<string, double> stock in purchase)
            //     // Before this line runs, the value of "stock" is: {[, 0]}, or, stock.Key: null, stock.Value: 0
            //     // After this line runs, the value of "stock" is: {[GM, 230.21]}
            //     {
            //         foreach (KeyValuePair<string, string> stockItem in stockCompanies)
            //         {
            //             if (stockItem.Key == stock.Key)
            //             {
            //                 if (stockReport.ContainsKey(stock.Key))
            //                 {

            //                     /*
            //                     This is the part that's giving me problems!!!


            //                     // stockReport[stockItem.Key] += stock.Value;
            //                     (stockReport[stock.Key]) += (stockItem.Value);
            //                      */
            //                 }
            //                 else
            //                 {
            //                     stockReport.Add(stock.Key, stock.Value);
            //                 }

            //             }
            //         }

            //     }
            // }

            // // foreach (KeyValuePair<string, double> item in stockReport)
            // // {
            // //     Console.WriteLine($"The stock is {item.Key} and the value is {item.Value}");
            // // };







            //==========================================================================================================================
        }
    }
}
