using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BetfairNG.API
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RunnerStatus
    {
        ACTIVE, WINNER, LOSER, PLACED, REMOVED_VACANT, REMOVED, HIDDEN
    }
}