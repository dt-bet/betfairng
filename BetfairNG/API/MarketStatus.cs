using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BetfairNG.API
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarketStatus
    {
        INACTIVE, OPEN, SUSPENDED, CLOSED
    }
}