using Microsoft.ClearScript.V8;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.ClearScript;
using Microsoft.ClearScript.JavaScript;
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

    public void Execute(string code, Dictionary<string, object> hostObjects, string searchPath = null)
    {
        var sw = new Stopwatch();
        sw.Start();

        DocumentLoader.Default.DiscardCachedDocuments();
        using (var engine = new V8ScriptEngine())
        {
            if (!string.IsNullOrEmpty(searchPath))
            {
                engine.DocumentSettings.AccessFlags = DocumentAccessFlags.EnableFileLoading;
                engine.DocumentSettings.SearchPath = searchPath;
            }

            foreach (var kvp in hostObjects)
            {
                engine.AddHostObject(kvp.Key, kvp.Value);
            }

            try
            {
                engine.Execute(new DocumentInfo {Category = ModuleCategory.Standard}, code);
            }
            catch (Exception ex)
            {
                _loggerService.Error(ex);
            }
        }

        sw.Stop();
        _loggerService.Info($"Execution time: {sw.Elapsed}");
    }
}