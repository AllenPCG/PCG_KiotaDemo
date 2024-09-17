using KiotaDemo.Clients.WeatherApi;
using KiotaDemo.Clients.WeatherApi.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System.Globalization;
using System.Reflection;

namespace KiotaDemo;
internal class Program
{
    static async Task Main(string[] args)
    {
        AnonymousAuthenticationProvider? authProvider = new();
        HttpClientRequestAdapter? adapter = new(authProvider);
        WeatherApiClient? client = new(adapter);

        GridpointForecastGeoJson? hourlyWeather = await client.Gridpoints["TAE"].WithXWithY(84, 86).Forecast.Hourly.GetAsync();

        List<UntypedNode>? periods = hourlyWeather?.Properties?.AdditionalData
            .Where(j => j.Key == "periods")
            .Select(j => j.Value)
            .Cast<UntypedArray>()
            .SelectMany(array => array.GetValue())
            .ToList();

        WriteWeatherToConsole(periods);
    }

    private static void WriteWeatherToConsole(List<UntypedNode>? periods)
    {
        foreach (var period in periods)
        {
            var untypedObject = period as UntypedObject;
            if (untypedObject != null)
            {
                var properties = untypedObject.GetValue();

                if (properties != null)
                {
                    properties.TryGetValue("startTime", out var startTimeNode);
                    var valueField = startTimeNode.GetType().GetField("_value", BindingFlags.NonPublic | BindingFlags.Instance);
                    var startTimeString = valueField.GetValue(startTimeNode) as string;

                    properties.TryGetValue("endTime", out var endTimeNode);
                    valueField = endTimeNode.GetType().GetField("_value", BindingFlags.NonPublic | BindingFlags.Instance);
                    var endTimeString = valueField.GetValue(endTimeNode) as string;

                    properties.TryGetValue("shortForecast", out var shortForecastNode);
                    valueField = shortForecastNode.GetType().GetField("_value", BindingFlags.NonPublic | BindingFlags.Instance);
                    var shortForecastString = valueField.GetValue(shortForecastNode) as string;

                    var startTimeOffset = DateTimeOffset.Parse(startTimeString, CultureInfo.InvariantCulture);
                    var startTime = startTimeOffset.DateTime;

                    var endTimeOffset = DateTimeOffset.Parse(endTimeString, CultureInfo.InvariantCulture);
                    var endTime = endTimeOffset.DateTime;

                    Console.WriteLine($"Period: {startTime:yyyy-MM-dd hh:mm tt} - {endTime:yyyy-MM-dd hh:mm tt}");
                    Console.WriteLine($"Short Forecast: {shortForecastString}");
                    Console.WriteLine();
                }
            }
        }
    }
}
