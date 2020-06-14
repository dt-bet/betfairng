using Newtonsoft.Json;
using System.Text;

namespace BetfairNG.API
{
    public class MarketOnCloseOrder
    {
        [JsonProperty(PropertyName = "size")]
        public double Size { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                        .AppendFormat("Size={0}", Size)
                        .ToString();
        }
    }
}