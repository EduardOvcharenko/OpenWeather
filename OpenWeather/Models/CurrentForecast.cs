using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenWeather.Models
{
    public class CurrentForecast
    {
        public Coord Coord { get; set; }
        public Weather[] Weather { get; set; }
        public string Base { get; set; }
        public Main Main { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public Rain Rain { get; set; }
        public string Dt  { get; set; }
        public Sys Sys { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Cod { get; set; }

    }
}