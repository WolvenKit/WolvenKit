using Splat;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Helpers;

public static class LoggerHelper
{
    public static ILoggerService GetUnsafe() => Locator.Current.GetService<ILoggerService>().NotNull();
}