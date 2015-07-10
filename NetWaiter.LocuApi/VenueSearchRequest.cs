using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class VenueSearchRequest
    {
        [JsonProperty(PropertyName = "api_key")]
        public string ApiKey { get; private set; }
        [JsonProperty(PropertyName = "fields")]
        public string[] Fields { get; set; }
        [JsonProperty(PropertyName = "offset")]
        public int? Offset { get; set; }
        [JsonProperty(PropertyName = "results_key")]
        public string ResultsKey { get; set; }
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }
        [JsonProperty(PropertyName = "venue_queries")]
        public Venue[] VenueQueries { get; set; }
        [JsonProperty(PropertyName = "menu_item_queries")]
        public MenuItem[] MenuItemsQueries { get; set; }

        internal VenueSearchRequest(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new NoNullAllowedException("ApiKey is required");
            }
            ApiKey = apiKey;
        }
    }
}
