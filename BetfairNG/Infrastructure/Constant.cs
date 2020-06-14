namespace BetfairNG
{
    public class Constant
    {
        /// <summary>
        /// The limit of results that can be retrieved. Exceeding this value will lead to an error being returned.
        /// </summary>
        public static readonly int MaxResults = 1000;



        /// <summary>
        /// Market Data Request Limits
        /// Although you can request multiple markets from , and , there are limits on the amount listMarketBook listMarketCatalogue listMarketProfitandLoss
        /// of data requested in one request.
        /// If you exceed the maximum weighting of 200 points, the API will return a TOO_MUCH_DATA error.
        /// </summary>
        public static readonly int MaxCost = 200;
    }
}