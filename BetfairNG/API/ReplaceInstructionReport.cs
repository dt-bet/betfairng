﻿using Newtonsoft.Json;

namespace BetfairNG.API
{
    public class ReplaceInstructionReport
    {
        [JsonProperty(PropertyName = "status")]
        public InstructionReportStatus Status { get; set; }

        [JsonProperty(PropertyName = "errorCode")]
        public InstructionReportErrorCode ErrorCode { get; set; }

        [JsonProperty(PropertyName = "cancelInstructionReport")]
        public CancelInstructionReport CancelInstructionReport { get; set; }

        [JsonProperty(PropertyName = "placeInstructionReport")]
        public PlaceInstructionReport PlaceInstructionReport { get; set; }
    }
}