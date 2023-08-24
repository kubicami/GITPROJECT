namespace BlazorApp1.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        // Getting wheather forecast data for nex 5 days
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                WindSpeedM = Random.Shared.Next(0, 10),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)], 
                DewPoint = Random.Shared.Next(-20, 55)
            }).ToArray());
        }
    }
}