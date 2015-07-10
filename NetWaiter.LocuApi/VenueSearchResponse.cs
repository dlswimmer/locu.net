using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class VenueSearchResponse
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
        [JsonProperty(PropertyName = "http_status")]
        public string HttpStatus { get; set; }
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
        [JsonProperty(PropertyName = "next_results_key")]
        public string NextResultsKey { get; set; }
        [JsonProperty(PropertyName = "venues")]
        public Venue[] Venues { get; set; }
    }
}