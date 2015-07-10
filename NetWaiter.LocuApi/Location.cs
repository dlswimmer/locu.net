using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class Location
    {
        [JsonProperty(PropertyName = "address1")]
        public string Address1 { get; set; }
        [JsonProperty(PropertyName = "address2")]
        public string Address2 { get; set; }
        [JsonProperty(PropertyName = "address3")]
        public string Address3 { get; set; }
        [JsonProperty(PropertyName = "locality")]
        public string Locality { get; set; }
        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; }
        [JsonProperty(PropertyName = "postal_code")]
        public string PostalCode { get; set; }
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
        [JsonProperty(PropertyName = "geo")]
        public Geo Geo { get; set; }
    }

    public class Geo
    {
        public string Type { get; set; }
        public float[] Coordinates { get; set; }

        public float Latitude
        {
            get { return Coordinates != null && Coordinates.Length == 2 ? Coordinates[1] : 0; }
        }

        public float Longitude
        {
            get { return Coordinates != null && Coordinates.Length == 2 ? Coordinates[0] : 0; }
        }
    }
}