using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class Category
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "str_id")]
        public string Id { get; set; }
    }
}