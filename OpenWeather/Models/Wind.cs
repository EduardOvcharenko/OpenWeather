using Newtonsoft.Json;

namespace OpenWeather.Models
{
    public class Wind
    {
        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("deg")]
        public string Deg { get; set; }
    }
}