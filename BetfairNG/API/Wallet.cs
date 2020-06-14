﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BetfairNG.API
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Wallet
    {
        UK,
        AUSTRALIAN,
    }
}