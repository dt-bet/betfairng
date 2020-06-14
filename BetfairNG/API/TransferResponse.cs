using Newtonsoft.Json;

namespace BetfairNG.API
{
    public class TransferResponse
    {
        [JsonProperty(PropertyName = "transactionId")]
        public string TransactionId { get; set; }
    }
}