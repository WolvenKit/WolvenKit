using Microsoft.ClearScript.V8;
using System;
using System.Collections.Generic;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Modkit.Scripting;

public class ScriptService
{
    private readonly ILoggerService _loggerService;

    public ScriptService(ILoggerService loggerService)
    {
        _loggerService = loggerService;
    }

    public void Execute(string code) => Execute(code, new Dictionary<string, object> {{"wkit", new WKitScripting(_loggerService)}});

    public void Execute(string code, Dictionary<string, object> hostObjects)
    {
        using (var engine = new V8ScriptEngine())
        {
            foreach (var kvp in hostObjects)
            {
                engine.AddHostObject(kvp.Key, kvp.Value);
            }

            try
            {
                engine.Execute(code);
            }
            catch (Exception)
            {
                _loggerService.Error("Fatal error while executing script");
            }
        }
    }
}