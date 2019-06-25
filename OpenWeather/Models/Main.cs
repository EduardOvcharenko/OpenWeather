using Newtonsoft.Json;

namespace OpenWeather.Models
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }

        [JsonProperty("pressure")]
        public string Pressure { get; set; }

        [JsonProperty("humidity")]
        public string Humidity { get; set; }

        [JsonProperty("temp_min")]
        public string TempMin { get; set; }

        [JsonProperty("temp_max")]
        public string TempMax { get; set; }

    }
}