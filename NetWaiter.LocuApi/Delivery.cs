using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class Delivery
    {
        [JsonProperty(PropertyName = "will_deliver")]
        public bool WillDeliver { get; set; }
        [JsonProperty(PropertyName = "hours")]
        public Dictionary<string, string[]> Hours { get; set; }
        [JsonProperty(PropertyName = "minimum_order")]
        public decimal MinimumOrder { get; set; }
        [JsonProperty(PropertyName = "areas")]
        public string Areas { get; set; }
    }
}