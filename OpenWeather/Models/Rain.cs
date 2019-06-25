using Newtonsoft.Json;

namespace OpenWeather.Models
{
    public class Rain
    {
        [JsonProperty("3H")]
        public string ThreeHours { get; set; }
    }
}