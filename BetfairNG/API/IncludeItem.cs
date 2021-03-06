﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BetfairNG.API
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncludeItem
    {
        ALL,
        DEPOSITS_WITHDRAWALS,
        EXCHANGE,
        POKER_ROOM,
    }
}