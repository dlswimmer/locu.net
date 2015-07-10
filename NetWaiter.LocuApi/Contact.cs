using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class Contact
    {
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }
        [JsonProperty(PropertyName = "fax")]
        public string Fax { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "phones")]
        public Dictionary<string, string> Phones { get; set; }
        [JsonProperty(PropertyName = "faxes")]
        public Dictionary<string, string> Faxes { get; set; }
        [JsonProperty(PropertyName = "emails")]
        public Dictionary<string, string> Emails { get; set; }
        [JsonProperty(PropertyName = "business_owner")]
        public string BusinessOwner { get; set; }
    }
}