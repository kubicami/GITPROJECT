namespace BlazorApp1.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC = 150;

        public int TemperatureF => 9001;

        public string? Summary { get; set; }
    }
}