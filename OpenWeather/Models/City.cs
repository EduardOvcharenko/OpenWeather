namespace OpenWeather.Models
{
    public class City
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Coord Coord { get; set; }
        public string Country { get; set; }
    }
}