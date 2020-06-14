using Newtonsoft.Json;
using System.Collections.Generic;

namespace BetfairNG.API
{
    public class AccountStatementReport
    {
        [JsonProperty(PropertyName = "accountStatement")]
        public IList<StatementItem> AccountStatement { get; set; }

        [JsonProperty(PropertyName = "moreAvailable")]
        public bool MoreAvailable { get; set; }
    }
}