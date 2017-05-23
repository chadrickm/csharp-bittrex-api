using Bittrex;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            var exchangeContext = new Bittrex.ExchangeContext();
            exchangeContext.ApiKey = "d30ac07ad78143a39b1fd1073c75a5d9";
            exchangeContext.Secret = "7fee6a6d1e6c4113b6522c74070cfb99";
            exchangeContext.QuoteCurrency = "BTC";
            exchangeContext.Simulate = true;

            var exchange = new Bittrex.Exchange();
            exchange.Initialise(exchangeContext);

            GetOpenOrdersResponse openOrders = exchange.GetOpenOrders("BTC-PIVX");
            foreach (var openOrder in openOrders)
            {

            }
        }
    }
}