using System;
using Microsoft.Extensions.DependencyInjection;

namespace WolvenKit;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddLazyTransient<T>(this IServiceCollection services) where T : class
    {
        services.AddTransient(typeof(Lazy<T>), serviceProvider =>
        {
            return new Lazy<T>(() => ActivatorUtilities.CreateInstance<T>(serviceProvider));
        });

        return services;
    }
}
