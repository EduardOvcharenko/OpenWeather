using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OpenWeather.Models
{
    public class Coord
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }
        [JsonProperty("lon")]
        public string Lon { get; set; }
    }
}