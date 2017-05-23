using Bittrex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BittrexApiCaller
{
    class Program
    {
        static void Main(string[] args)
        {
            var exchangeContext = new ExchangeContext();
            exchangeContext.ApiKey = "";
            exchangeContext.Secret = "";
            exchangeContext.QuoteCurrency = "BTC";
            exchangeContext.Simulate = true;

            var exchange = new Exchange();
            exchange.Initialise(exchangeContext);

            var results = exchange.GetOrderBook("PIVX", OrderBookType.Both, 50);
            foreach (var result in results.buy)
            {
                Console.WriteLine(result.Rate + ": " + result.Quantity);
            }

            Console.ReadLine();
        }
    }
}
