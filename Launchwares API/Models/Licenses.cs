using System.Collections.Generic;
using System.Linq;

using Launchwares_API.Firebase;
using Launchwares_API.Discord;
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

            return license.FirstOrDefault() ?? NullLicense(ip, product, key);
        }

        public static License NullLicense(string ip, string product, string key)
        {
            Webhook webhook = new Webhook(YOUR WEBHOOK ID HERE, "YOUR WEBHOOK KEY HERE") { 
                Username = "FiveM Licenser by Launchwares",
                IsTTS = false,
                Content = $"{ip} ip address tried to use {product} with {key} key",
                AvatarUrl = "https://cdn.discordapp.com/icons/678196890742947881/22697032b980bfcfabc978b360b11a23.png?size=512"
            };
            _ = webhook.Send();
            return null;
        }
    }
    
    [JsonObject]
    public class License
    {
        [JsonProperty("ip")]
        public string IP { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("product")]
        public string Product { get; set; }
        [JsonProperty("server")]
        public string ServerLua { get; set; }
        [JsonProperty("client")]
        public string ClientLua { get; set; }
    }
}