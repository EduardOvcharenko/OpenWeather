using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Configuration;
using System.Web.Mvc;
using Newtonsoft.Json;
using OpenWeather.Models;

namespace OpenWeather.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string cityName)
        {
            var forecastValues = ForecastWeather(cityName);

            ViewBag.Forecast = ForecastWeather(cityName);
            ViewBag.DataPoints = JsonConvert.SerializeObject(ChartValues(forecastValues).Take(10));

            return View();
        }

        public List<ChartPoint> ChartValues(Forecast forecastValues)
        {
            List<ChartPoint> chartPoints = new List<ChartPoint>();
           
            if (forecastValues != null)
            {
                foreach (var forecastItem in forecastValues.Items)
                {
                        var label = forecastItem.DtTxt.ToShortTimeString();
                        chartPoints.Add(new ChartPoint((int)forecastItem.Main.Temp,label));
                }
            }
            return chartPoints;
        }   

        public Forecast ForecastWeather(string cityName)
        {
            Forecast response;
            var url = string.Format("http://api.openweathermap.org/data/2.5/forecast?appid={0}&q={1}&units=metric",
                WebConfigurationManager.AppSettings["OpenWeatherApiKey"], cityName);
            try
            {
                var result = new WebClient().DownloadString(url);
                response = JsonConvert.DeserializeObject<Forecast>(result);
            }
            catch (Exception e)
            {
                response = null;
            }
            return response;
        }
    }
}