using BetfairNG;
using BetfairNG.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetfairNG
{
    public class APICostHelper
    {
        public static int GetTotalCost(int size, int typeCodes, HashSet<MarketProjection> marketProjections) => marketProjections.Sum(m => GetCost(m)) * size * typeCodes;

        public static int GetSize(int size, HashSet<PriceData> priceProjections) => GetCost(priceProjections) * size;

        public static int GetCost(PriceProjection priceProjection)
        {
            // TODO Actually more complicated.
            return GetCost(priceProjection.PriceData);
        }

        private static int GetCost(ISet<PriceData> priceProjections)
        {
            if (priceProjections.Any() == false)
            {
                return GetCost(default(PriceData));
            }

            int cost = 0;
            if (priceProjections.Contains(PriceData.EX_BEST_OFFERS) && priceProjections.Contains(PriceData.EX_TRADED))
            {
                priceProjections.Remove(PriceData.EX_BEST_OFFERS);
                priceProjections.Remove(PriceData.EX_TRADED);
                cost += 20;
            }
            if (priceProjections.Contains(PriceData.EX_ALL_OFFERS) && priceProjections.Contains(PriceData.EX_TRADED))
            {
                priceProjections.Remove(PriceData.EX_ALL_OFFERS);
                priceProjections.Remove(PriceData.EX_TRADED);
                cost += 32;
            }

            return cost + priceProjections.Sum(GetCost);
        }

        /// <summary>
        /// listMarketCatalogue
        /// MarketProjection Weight
        /// MARKET_DESCRIPTION 1
        /// RUNNER_DESCRIPTION 0
        /// EVENT 0
        /// EVENT_TYPE 0
        /// COMPETITION 0
        /// RUNNER_METADATA 1
        /// MARKET_START_TIME 0
        /// </summary>
        /// <param name="marketProjection"></param>
        /// <returns></returns>
        public static int GetCost(MarketProjection marketProjection)
        {
            switch (marketProjection)
            {
                case MarketProjection.MARKET_DESCRIPTION:
                    return 1;

                case MarketProjection.RUNNER_DESCRIPTION:
                    return 0;

                case MarketProjection.EVENT:
                    return 0;

                case MarketProjection.EVENT_TYPE:
                    return 0;

                case MarketProjection.COMPETITION:
                    return 0;

                case MarketProjection.RUNNER_METADATA:
                    return 1;

                case MarketProjection.MARKET_START_TIME:
                    return 0;

                default:
                    throw new Exception($"MarketProjection, {marketProjection}, not accounted for.");
            }
        }

        /// </summary>
        /// <param name="marketProjection"></param>
        /// <returns></returns>
        public static int GetCost(PriceData priceData)
        {
            switch (priceData)
            {
                case PriceData.SP_AVAILABLE:
                    return 3;

                case PriceData.SP_TRADED:
                    return 7;

                case PriceData.EX_BEST_OFFERS:
                    return 5;

                case PriceData.EX_ALL_OFFERS:
                    return 17;

                case PriceData.EX_TRADED:
                    return 17;

                default:
                    return 2;
            }
        }
    }
}
