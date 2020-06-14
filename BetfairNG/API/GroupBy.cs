using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BetfairNG.API
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupBy
    {
        EVENT_TYPE,
        EVENT,
        MARKET,
        SIDE,
        BET,
    }
}