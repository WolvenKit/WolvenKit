using Microsoft.ClearScript.V8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.ClearScript;
using Microsoft.ClearScript.JavaScript;
using WolvenKit.Core.Interfaces;
using System.Threading;

namespace WolvenKit.Modkit.Scripting;

public class ScriptService : INotifyPropertyChanged
{
    private readonly ILoggerService _loggerService;

    private V8ScriptEngine _mainEngine;
    private bool _isRunning;

    public ScriptService(ILoggerService loggerService)
    {
        _loggerService = loggerService;
    }

    public bool IsRunning
    {
        get => _isRunning;
        set => SetField(ref _isRunning, value);
    }

    public async Task ExecuteAsync(string code, Dictionary<string, object> hostObjects, string searchPath = null)
    {
        if (_mainEngine != null)
        {
            _loggerService.Warning("Another script is already running");
            return;
        }

        IsRunning = true;

        var sw = new Stopwatch();
        sw.Start();

        DocumentLoader.Default.DiscardCachedDocuments();

        _mainEngine = new V8ScriptEngine();

        if (!string.IsNullOrEmpty(searchPath))
        {
            _mainEngine.DocumentSettings.AccessFlags = DocumentAccessFlags.EnableFileLoading;
            _mainEngine.DocumentSettings.SearchPath = searchPath;
        }

        _mainEngine.AddHostType(typeof(Thread));
        _mainEngine.AddHostType(typeof(Task));
        _mainEngine.AddHostType(typeof(JavaScriptExtensions));

        _mainEngine.AddHostObject("logger", _loggerService);
        foreach (var kvp in hostObjects)
        {
            _mainEngine.AddHostObject(kvp.Key, kvp.Value);
        }

        try
        {
            await Task.Run(() => _mainEngine.Execute(new DocumentInfo { Category = ModuleCategory.Standard }, code));
        }
        catch (Exception ex)
        {
            _loggerService.Error(ex);
        }

        if (_mainEngine != null)
        {
            _mainEngine.Dispose();
            _mainEngine = null;
        }

        IsRunning = false;
        
        sw.Stop();
        _loggerService.Info($"Execution time: {sw.Elapsed}");
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

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }

    #endregion
}