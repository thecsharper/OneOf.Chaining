﻿using OneOf.Chaining.Examples.Domain;
using OneOf.Chaining.Examples.Domain.Outcomes;

namespace OneOf.Chaining.Examples.Application.Services;

public class WeatherForecastGenerator : IWeatherForecastGenerator
{
    private string[] summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public async Task<OneOf<WeatherReport, Failure>> Generate(WeatherReport report)
    {
        report.Set(summaries[Random.Shared.Next(summaries.Length)], Random.Shared.Next(-20, 55));
        return report;
    }
}

public interface IWeatherForecastGenerator
{
    Task<OneOf<WeatherReport, Failure>> Generate(WeatherReport report);
}