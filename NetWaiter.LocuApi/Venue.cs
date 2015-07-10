using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Venue
    {
        public Venue()
        {
            MenusWrapper = new ConditionWrapper<Menu[]>();
        }
        [JsonProperty(PropertyName = "locu_id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "short_name")]
        public string ShortName { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "website_url")]
        public string WebsiteUrl { get; set; }
        [JsonProperty(PropertyName = "menu_url")]
        public string MenuUrl { get; set; }

        [JsonProperty(PropertyName = "menus")]
        [JsonConverter(typeof(ConditionConverter<Menu[]>))]
        internal ConditionWrapper<Menu[]> MenusWrapper { get; set; }
        public Menu[] Menus
        {
            get { return MenusWrapper.Item; }
            set { MenusWrapper.Item = value; }
        }
        public Condition MenusCondition
        {
            get { return MenusWrapper.Condition; }
            set { MenusWrapper.Condition = value; }
        }

        [JsonProperty(PropertyName = "menu_items")]
        public MenuItem[] MenuItems { get; set; }
        [JsonProperty(PropertyName = "open_hours")]
        public Dictionary<string, string[]> OpenHours { get; set; }
        [JsonProperty(PropertyName = "external")]
        public Dictionary<string, ExternalId> ExternalIds { get; set; }
        [JsonProperty(PropertyName = "redirected_from")]
        public string RedirectedFrom { get; set; }
        [JsonProperty(PropertyName = "categories")]
        public Category[] Categories { get; set; }
        [JsonProperty(PropertyName = "location")]
        public Location Location { get; set; }
        [JsonProperty(PropertyName = "contact")]
        public Contact Contact { get; set; }
        [JsonProperty(PropertyName = "locu")]
        public Locu Locu { get; set; }
        [JsonProperty(PropertyName = "delivery")]
        public Delivery Delivery { get; set; }
        [JsonProperty(PropertyName = "extended")]
        public Extended Extended { get; set; }
        [JsonProperty(PropertyName = "media")]
        public Media Media { get; set; }

        public bool ShouldSerializeMenusCondition()
        {
            return Menus == null;
        }
    }
}
