using System;
using System.Collections.Generic;
using System.Text;

namespace BetfairNG.Helper
{
    /// <summary>
    /// http://autobettingbot.com/2011/08/betfair-minimum-bet-size-for-sp-lay-bets/
    /// </summary>
    public class StakeHelper
    {
        public const decimal MinBetStake = 10m;

        public static decimal GetStakeMinimum(string currency)
        {


            switch (currency)
            {
                case ("EUR"):
                case ("GBP"):
                case ("ZAR"):
                case ("JPY"):
                case ("DZD"):
                case ("ARP"):
                case ("ATS"):
                case ("BSD"):
                case ("BBD"):
                case ("BEF"):
                case ("BMD"):
                case ("BRR"):
                case ("BGL"):
                case ("CLP"):
                    return 2.0m;
                case ("USD"):
                    return 4.0m;
                case ("AUD"):
                case ("CAS"):
                case ("SGD"):
                    return 6.0m;
                case ("HKD"):
                    return 25.0m;
                case ("DKK"):
                case ("NOK"):
                case ("SEK"):
                    return 30.0m;
                default:
                    return 2.0m;
            }
        }




        /// <summary>
        /// https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/placeOrders#placeOrders-CurrencyParameterscurrency
        /// Ability to place lower minimum stakes at larger prices
        /// In order to allow customers to bet to smaller stakes on longer-priced selections, an extra property has been added to our Currency Parameters – “Min Bet Payout”. 
        /// As currently LIMIT bets where the backer’s stake is at and above the ‘Min Bet Size’ for the currency concerned(£2 for GBP) are valid.In addition, bets below this value are valid if the payout of the bet would be equal to or greater than the value of ‘Min Bet Payout’ - £10 for GBP.For example, a bet of £1 @ 10, or 10p @ 100 or 1p @ 1000 are all valid as they all target a payout of £10 or more.
        /// N.B 
        /// * This functionality is available to "orderType: LIMIT" bets only.
        /// * Please note: This function is only enabled for UK & International customers and not .it, .es, .dk and .se jurisdictions.
        /// </summary>
        /// 
        public static decimal GetStakeMinimum(string currency, decimal odds)
        {
            var min = GetStakeMinimum(currency);

            if (min == 2m)
            {
                decimal size = MinBetStake / odds;

                return size < 2m ? size : min;

            }
            return min;
        }
    }
}
