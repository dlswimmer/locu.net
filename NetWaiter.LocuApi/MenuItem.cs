using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class MenuItem
    {
        [JsonProperty(PropertyName = "menu_name")]
        public string MenuName { get; set; }
        [JsonProperty(PropertyName = "section_name")]
        public string SectionName { get; set; }
        [JsonProperty(PropertyName = "subsection_name")]
        public string SubsectionName { get; set; }
        [JsonProperty(PropertyName = "section_text")]
        public string SectionText { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "currency_symbol")]
        public string CurrencySymbol { get; set; }
        [JsonProperty(PropertyName = "photos")]
        public string[] Photos { get; set; }
    }
}