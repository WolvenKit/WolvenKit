using WolvenKit.Core.Interfaces;

namespace WolvenKit.Modkit.Scripting;

public class WKitScripting
{
    private readonly ILoggerService _loggerService;

    public WKitScripting(ILoggerService loggerService)
    {
        _loggerService = loggerService;
    }

    public void Info(string message)
    {
        _loggerService.Info(message);
    }

    public void Error(string message)
    {
        _loggerService.Error(message);
    }
}