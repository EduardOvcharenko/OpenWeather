using System;
using Newtonsoft.Json;

namespace OpenWeather.Models
{
    public class ForecastItem
    {
        [JsonProperty("dt")]
        public string Dt { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("dt_txt")]
        public DateTime DtTxt { get; set; }
    }
}