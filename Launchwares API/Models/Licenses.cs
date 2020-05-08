using System.Collections.Generic;
using System.Linq;

using Launchwares_API.Firebase;
using Newtonsoft.Json;

namespace Launchwares_API.Models
{
    public static class Licenses
    {
        public static License GetLicense(string product, string key, string ip)
        {
            var licenses = API.Get<License>("Licenses");

            IEnumerable<License> license = from _license in licenses.Values
                         where _license.IP == ip
                         where _license.Product == product
                         where _license.Key == key
                         select _license;

            return license.FirstOrDefault() ?? null;
        }
    }
    
    [JsonObject]
    public class License
    {
        [JsonProperty("IP")]
        public string IP { get; set; }
        [JsonProperty("Key")]
        public string Key { get; set; }
        [JsonProperty("Product")]
        public string Product { get; set; }
        [JsonProperty("ServerLua")]
        public string ServerLua { get; set; }
        [JsonProperty("ClientLua")]
        public string ClientLua { get; set; }
    }
}