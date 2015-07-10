using System;
using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class Locu
    {
        [JsonProperty(PropertyName = "owner_controlled")]
        public bool OwnerControlled { get; set; }
        [JsonProperty(PropertyName = "verification_level")]
        public int VerificationLevel { get; set; }
        [JsonProperty(PropertyName = "last_updated_by_owner")]
        public DateTime LastUpdatedByOwner { get; set; }
        [JsonProperty(PropertyName = "last_updated_by_locu")]
        public DateTime LastUpdatedByLocu { get; set; }
        [JsonProperty(PropertyName = "last_updated_listings")]
        public DateTime LastUpdatedListings { get; set; }
        [JsonProperty(PropertyName = "last_updated_menu")]
        public DateTime LastUpdatedMenu { get; set; }
        [JsonProperty(PropertyName = "last_modified")]
        public DateTime LastModified { get; set; }
        [JsonProperty(PropertyName = "added_to_locu")]
        public DateTime AddedToLocu { get; set; }
    }
}