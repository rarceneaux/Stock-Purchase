using System;
using System.Collections.Generic;

namespace Stock_Purchase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Too Big To Fail");

            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GDDY", "Go Daddy");
            stocks.Add("BA", "Boeing");
            stocks.Add("UBER", "Uber");

         List<(string ticker, int shares, double price)> buys = new List<(string, int, double)>();
            buys.Add(("GDDY", 500, 48.21));
            buys.Add(("BA", 500, 166.21));
            buys.Add(("GDDY", 500, 50.21));


            Dictionary<string, int> totalStockOwnedInfo = new Dictionary<string, int>();

            stocks.


        }
    }
}
