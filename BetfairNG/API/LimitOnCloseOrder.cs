using Newtonsoft.Json;
using System.Text;

namespace BetfairNG.API
{
    public class LimitOnCloseOrder
    {
        [JsonProperty(PropertyName = "size")]
        public double Size { get; set; }

        [JsonProperty(PropertyName = "liability")]
        public double Liability { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                        .AppendFormat("Size={0}", Size)
                        .AppendFormat(" : Liability={0}", Liability)
                        .ToString();
        }
    }
}