using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class ExternalId
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        [JsonProperty(PropertyName = "mobile_url")]
        public string MobileUrl { get; set; }
    }
}