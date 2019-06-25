using Newtonsoft.Json;

namespace OpenWeather.Models
{
    public class Clouds
    {
        [JsonProperty("all")]
        public string All { get; set; }
    }
}