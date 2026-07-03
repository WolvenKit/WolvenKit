using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WolvenKit;

namespace WolvenKit.IntegrationTests.Helpers;

/// <summary>
/// Central place to create a real application host for integration / UI tests.
/// 
/// Instead of manually registering dozens of services (which leads to endless
/// "Unable to resolve service" AggregateExceptions), we start from the real
/// <see cref="GenericHost.CreateHostBuilder"/> and only apply test-specific
/// customizations.
/// </summary>
public static class IntegrationTestHost
{
    /// <summary>
    /// Creates and builds a host using the real application registrations.
    /// </summary>
    /// <param name="configureTestServices">
    /// Optional action to further configure or override services for the specific test.
    /// This runs after the real production registrations.
    /// </param>
    public static IHost Create(Action<IServiceCollection>? configureTestServices = null)
    {
        var builder = GenericHost.CreateHostBuilder();

        if (configureTestServices != null)
        {
            builder.ConfigureServices(configureTestServices);
        }

        return builder.Build();
    }

    /// <summary>
    /// Convenience overload that returns the built <see cref="IServiceProvider"/>
    /// directly (useful when you only need the container and not the full <see cref="IHost"/> lifetime).
    /// </summary>
    public static IServiceProvider CreateServiceProvider(Action<IServiceCollection>? configureTestServices = null)
    {
        return Create(configureTestServices).Services;
    }
}
