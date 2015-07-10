using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class Menu
    {
        [JsonProperty(PropertyName = "menu_name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "currency_symbol")]
        public string CurrencySymbol { get; set; }
        [JsonProperty(PropertyName = "sections")]
        public Section[] Sections { get; set; }
    }

    public class Section
    {
        [JsonProperty(PropertyName = "section_name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "subsections")]
        public Subsection[] Subsections { get; set; }
    }

    public class Subsection
    {
        [JsonProperty(PropertyName = "subsection_name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "contents")]
        public MenuContent[] Contents { get; set; }
    }

    public class MenuContent
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }

        [JsonProperty(PropertyName = "option_groups")]
        public MenuOptionGroup[] OptionGroups { get; set; }
    }

    public class MenuOptionGroup
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "description")]
        public MenuOption[] Options { get; set; }
    }

    public class MenuOption
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public string Price { get; set; }
    }
}