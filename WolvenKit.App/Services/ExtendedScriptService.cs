using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.ClearScript;
using Microsoft.ClearScript.V8;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;

namespace WolvenKit.Functionality.Services;

public class ExtendedScriptService : ScriptService
{
    private readonly Dictionary<string, List<ScriptEntry>> _uiScripts = new();
    private readonly Dictionary<string, IScriptableControl> _uiControls = new();

    private V8ScriptEngine? _uiEngine;

    public ExtendedScriptService(ILoggerService loggerService) : base(loggerService) => RefreshUIScripts();

    public void RegisterControl(IScriptableControl scriptableControl)
    {
        if (_uiControls.ContainsKey(scriptableControl.ScriptingName))
        {
            if (_uiControls[scriptableControl.ScriptingName].Equals(scriptableControl))
            {
                return;
            }

            throw new ArgumentException($"An control with the ScriptingName of {scriptableControl.ScriptingName} is already registered");
        }

        _uiControls.Add(scriptableControl.ScriptingName, scriptableControl);

        if (_uiScripts.TryGetValue(scriptableControl.ScriptingName, out var lst))
        {
            scriptableControl.AddScriptedElements(lst);
        }
    }

    public void UnRegisterControl(IScriptableControl scriptableControl)
    {
        scriptableControl.RemoveScriptedElements();

        _uiControls.Remove(scriptableControl.ScriptingName);
    }

    public List<ScriptEntry> GetScripts(UIElement caller, string name)
    {
        if (_uiScripts.TryGetValue(name, out var lst))
        {
            return lst;
        }

        return new List<ScriptEntry>();
    }

    private void UnloadScripts()
    {
        foreach (var (name, scriptableControl) in _uiControls)
        {
            scriptableControl.RemoveScriptedElements();
        }

        if (_uiEngine != null)
        {
            _uiScripts.Clear();

            _uiEngine.Dispose();
            _uiEngine = null;
        }
    }

    public void RefreshUIScripts()
    {
        UnloadScripts();

        _uiEngine = GetUIScriptEngine();

        foreach (var file in Directory.GetFiles(ISettingsManager.GetWScriptDir(), "*.wscript"))
        {
            var fileName = Path.GetFileName(file);
            if (!fileName.StartsWith("ui_"))
            {
                continue;
            }

            var code = File.ReadAllText(file);

            try
            {
                _uiEngine.Execute(code);
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
            }
        }

        if (_uiEngine.Script is ScriptObject so)
        {
            var item = so.GetProperty("items");
            if (item is List<ScriptEntry> entries)
            {
                foreach (var scriptEntry in entries)
                {
                    if (!_uiScripts.ContainsKey(scriptEntry.Target))
                    {
                        _uiScripts.Add(scriptEntry.Target, new List<ScriptEntry>());
                    }
                    _uiScripts[scriptEntry.Target].Add(scriptEntry);
                }
            }
        }

        foreach (var (name, scriptableControl) in _uiControls)
        {
            if (_uiScripts.TryGetValue(scriptableControl.ScriptingName, out var lst))
            {
                scriptableControl.AddScriptedElements(lst);
            }
        }
    }

    protected virtual V8ScriptEngine GetUIScriptEngine(Dictionary<string, object>? hostObjects = null, string? searchPath = null)
    {
        var engine = base.GetScriptEngine(hostObjects, searchPath);

        engine.AddHostObject("host", new HostFunctions());
        engine.AddHostType("ScriptEntry", typeof(ScriptEntry));
        engine.AddHostObject("items", new List<ScriptEntry>());

        return engine;
    }
}

public class ScriptEntry
{
    private readonly ScriptObject _function;

    public string Target { get; }
    public string Name { get; }


    public ScriptEntry(string target, string name, ScriptObject function)
    {
        Target = target;
        Name = name;
        _function = function;
    }

    public async void Execute() => await Task.Run(() => _function.Invoke(false));
}