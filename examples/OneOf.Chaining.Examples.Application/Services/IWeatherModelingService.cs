﻿using OneOf.Chaining.Examples.Application.Orchestration;
using OneOf.Chaining.Examples.Domain.Outcomes;

namespace OneOf.Chaining.Examples.Application.Services;

public interface IWeatherModelingService
{
    Task<OneOf<CollectedWeatherDataDetails, Failure>> Submit(CollectedWeatherDataDetails details);
}