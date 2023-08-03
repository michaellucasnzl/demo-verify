namespace app;

public class HourlyWeatherData
{
    public List<DateTime> Time { get; set; }
    public List<double> Temperature_2m { get; set; }
}

public class DailyWeatherData
{
    public List<DateTime> Time { get; set; }
    public List<DateTime> Sunrise { get; set; }
    public List<DateTime> Sunset { get; set; }
}

public class WeatherResponse
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double Generationtime_ms { get; set; }
    public int Utc_offset_seconds { get; set; }
    public string Timezone { get; set; }
    public string Timezone_abbreviation { get; set; }
    public double Elevation { get; set; }
    public HourlyWeatherData Hourly { get; set; }
    public DailyWeatherData Daily { get; set; }
}