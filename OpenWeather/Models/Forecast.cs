using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace OpenWeather.Models
{
    public class Forecast
    {
        [JsonProperty("cod")]
        public string Cod { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("cnt")]
        public string Cnt { get; set; }

        [JsonProperty("list")]
        public ForecastItem[] Items { get; set; }

    }
}