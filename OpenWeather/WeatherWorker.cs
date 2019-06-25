using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;
using OpenWeather.Models;

namespace OpenWeather
{
    public static class WeatherWorker
    {
        public static Weather GetWeather(string cityName)
        {
            string url = @"api.openweathermap.org/data/2.5/weather?q=" + cityName;

            Weather placeResponse = JsonConvert.DeserializeObject<Weather>(new WebClient().DownloadString(url));

            return placeResponse;
        }
    }
}