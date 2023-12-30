using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.ClearScript;
using Microsoft.ClearScript.JavaScript;
using Microsoft.ClearScript.V8;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Modkit.Scripting;

public partial class ScriptService : ObservableObject
{
    private readonly ConcurrentDictionary<string, ScriptFile> _scriptCache = new();

    public const string ScriptExtension = "wscript";

    protected readonly ILoggerService _loggerService;

    private V8ScriptEngine? _mainEngine;

    [ObservableProperty]
    private bool _isRunning;

    public ScriptService(ILoggerService loggerService) => _loggerService = loggerService;

    public async Task ExecuteAsync(string code, Dictionary<string, object>? hostObjects = null, List<string>? searchPaths = null)
    {
        if (_mainEngine != null)
        {
            _loggerService?.Warning("Another script is already running");
            return;
        }

        IsRunning = true;

        var sw = Stopwatch.StartNew();

        _mainEngine = GetScriptEngine(hostObjects, searchPaths);

        try
        {
            await Task.Run(() => _mainEngine.Execute(new DocumentInfo { Category = ModuleCategory.Standard }, code));
        }
        catch (ScriptEngineException ex1)
        {
            _loggerService?.Error(ex1.ErrorDetails);
        }
        catch (Exception ex2)
        {
            _loggerService?.Error(ex2);
        }

        if (_mainEngine != null)
        {
            _mainEngine.Dispose();
            _mainEngine = null;
        }

        IsRunning = false;

        sw.Stop();
        _loggerService?.Info($"Execution time: {sw.Elapsed}");
    }

    public void Stop()
    {
        if (_mainEngine != null)
        {
            _mainEngine.Interrupt();
            _mainEngine.Dispose();
            _mainEngine = null;
        }

        IsRunning = false;
    }

    protected virtual V8ScriptEngine GetScriptEngine(Dictionary<string, object>? hostObjects = null, List<string>? searchPaths = null)
    {
        var engine = new V8ScriptEngine();

        engine.AddHostType(typeof(OpenAs));
        engine.AddHostObject("logger", _loggerService);
        if (hostObjects != null)
        {
            foreach (var kvp in hostObjects)
            {
                engine.AddHostObject(kvp.Key, kvp.Value);
            }
        }

        if (searchPaths != null)
        {
            engine.DocumentSettings.AccessFlags = DocumentAccessFlags.EnableFileLoading;
            engine.DocumentSettings.SearchPath = string.Join(';', searchPaths);
        }

        engine.DocumentSettings.Loader.DiscardCachedDocuments();

        return engine;
    }

    public virtual IList<ScriptFile> GetScripts(string path)
    {
        var result = new List<ScriptFile>();

        if (string.IsNullOrEmpty(path))
        {
            return result;
        }

        if (!Directory.Exists(path))
        {
            return result;
        }

        foreach (var file in Directory.GetFiles(path, $"*.{ScriptExtension}", SearchOption.AllDirectories))
        {
            if (!_scriptCache.TryGetValue(file, out var scriptFile))
            {
                scriptFile = ScriptFile.Load(file, _loggerService);
                if (scriptFile != null)
                {
                    _scriptCache.TryAdd(file, scriptFile);
                }
            }

            if (scriptFile != null)
            {
                result.Add(scriptFile);
            }
        }

        return result;
    }
}