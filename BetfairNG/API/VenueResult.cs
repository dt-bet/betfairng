using Newtonsoft.Json;

namespace BetfairNG.API
{
    public class VenueResult
    {
        [JsonProperty(PropertyName = "venue")]
        public string Venue { get; set; }

        [JsonProperty(PropertyName = "marketCount")]
        public int MarketCount { get; set; }
    }
}