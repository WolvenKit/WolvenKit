using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.ClearScript;
using Microsoft.ClearScript.JavaScript;
using Microsoft.ClearScript.V8;
using Splat;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Modkit.Scripting;

public class ScriptService : INotifyPropertyChanged
{
    protected readonly ILoggerService? _loggerService;

    private V8ScriptEngine? _mainEngine;
    private bool _isRunning;

    public ScriptService(ILoggerService? loggerService = null) => _loggerService = loggerService ?? Locator.Current.GetService<ILoggerService>();

    public bool IsRunning
    {
        get => _isRunning;
        set => SetField(ref _isRunning, value);
    }

    public async Task ExecuteAsync(string code, Dictionary<string, object>? hostObjects = null, string? searchPath = null)
    {
        if (_mainEngine != null)
        {
            _loggerService?.Warning("Another script is already running");
            return;
        }

        IsRunning = true;

        var sw = new Stopwatch();
        sw.Start();

        DocumentLoader.Default.DiscardCachedDocuments();

        _mainEngine = GetScriptEngine(hostObjects, searchPath);

        try
        {
            await Task.Run(() => _mainEngine.Execute(new DocumentInfo { Category = ModuleCategory.Standard }, code));
        }
        catch (Exception ex)
        {
            _loggerService?.Error(ex);
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

    protected virtual V8ScriptEngine GetScriptEngine(Dictionary<string, object>? hostObjects = null, string? searchPath = null)
    {
        var engine = new V8ScriptEngine();

        engine.AddHostObject("logger", _loggerService);
        if (hostObjects != null)
        {
            foreach (var kvp in hostObjects)
            {
                engine.AddHostObject(kvp.Key, kvp.Value);
            }
        }

        if (!string.IsNullOrEmpty(searchPath))
        {
            engine.DocumentSettings.AccessFlags = DocumentAccessFlags.EnableFileLoading;
            engine.DocumentSettings.SearchPath = searchPath;
        }

        return engine;
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }

        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}