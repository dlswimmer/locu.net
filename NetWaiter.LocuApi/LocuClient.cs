using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NetWaiter.LocuApi
{
    public class LocuClient
    {
        private const string Url = "https://api.locu.com/v2/venue/search";
        public LocuClient(string apiKey)
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new NoNullAllowedException("ApiKey is required.");
            }
            ApiKey = apiKey;
        }

        private string ApiKey { get; set; }

        public VenueSearchRequest CreateRequest()
        {
            return new VenueSearchRequest(ApiKey);
        }

        public VenueSearchResponse Search(VenueSearchRequest searchRequest)
        {
            if (searchRequest == null)
            {
                throw new NoNullAllowedException("A valid search request is required.");
            }
            var request = WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/json";

            var data = JsonConvert.SerializeObject(searchRequest, new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});
            using (var stream = request.GetRequestStream())
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write(data);
                }
            }

            var response = request.GetResponse();
            using (var stream = response.GetResponseStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    return JsonConvert.DeserializeObject<VenueSearchResponse>(reader.ReadToEnd());
                }
            }
        }

        public async Task<VenueSearchResponse> SearchAsync(VenueSearchRequest searchRequest)
        {
            if (searchRequest == null)
            {
                throw new NoNullAllowedException("A valid search request is required.");
            }
            var request = WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/json";

            var data = JsonConvert.SerializeObject(searchRequest);
            using (var stream = await request.GetRequestStreamAsync())
            {
                using (var writer = new StreamWriter(stream))
                {
                    await writer.WriteAsync(data);
                }
            }

            request.ContentLength = data.Length;
            var response = await request.GetResponseAsync();
            using (var stream = response.GetResponseStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    return JsonConvert.DeserializeObject<VenueSearchResponse>(reader.ReadToEnd());
                }
            }
        }
    }
}
