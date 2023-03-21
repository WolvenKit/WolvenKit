#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.ClearScript;
using Microsoft.ClearScript.V8;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;

namespace WolvenKit.App.Services;

public class ExtendedScriptService : ScriptService
{
    private readonly Dictionary<string, List<ScriptEntry>> _uiScripts = new();
    private readonly Dictionary<string, IScriptableControl> _uiControls = new();

    private readonly Dictionary<string, object> _hostObjects = new();

    private V8ScriptEngine? _uiEngine;

    public ExtendedScriptService(ILoggerService loggerService) : base(loggerService)
    {
        _hostObjects.Add("ui", new UIHelper(this));

        RefreshUIScripts();
    }

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

        _uiEngine = base.GetScriptEngine(_hostObjects);

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
            catch (ScriptEngineException ex1)
            {
                _loggerService?.Error(ex1.ErrorDetails);
            }
            catch (Exception ex2)
            {
                _loggerService?.Error(ex2);
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

    public class UIHelper
    {
        private readonly ExtendedScriptService _extendedScriptService;

        public UIHelper(ExtendedScriptService extendedScriptService) => _extendedScriptService = extendedScriptService;

        public ScriptEntry AddMenuItem(string target, string name) => AddMenuItem(target, name, null, null);

        public ScriptEntry AddMenuItem(string target, string name, ScriptObject onClick) => AddMenuItem(target, name, onClick, null);

        public ScriptEntry AddMenuItem(string target, string name, ScriptObject? onClick, params object?[]? args)
        {
            var scriptEntry = new ScriptEntry(name, onClick, args);
        
            if (!_extendedScriptService._uiScripts.ContainsKey(target))
            {
                _extendedScriptService._uiScripts.Add(target, new List<ScriptEntry>());
            }
            _extendedScriptService._uiScripts[target].Add(scriptEntry);

            return scriptEntry;
        }

        public ScriptEntry AddMenuItem(ScriptEntry target, string name, ScriptObject? onClick = null, params object?[]? args)
        {
            var scriptEntry = new ScriptEntry(name, onClick, args);
            target.Children.Add(scriptEntry);
            return scriptEntry;
        }
    }
}

public class ScriptEntry
{
    private readonly ScriptObject? _function;
    private readonly object?[]? _args;

    public string Name { get; }
    public List<ScriptEntry> Children { get; set; } = new();

    public bool HasFunction => _function != null;

    public ScriptEntry(string name, ScriptObject? function, params object?[]? args)
    {
        Name = name;

        _function = function;
        _args = args;
    }

    public async void Execute() => await Task.Run(() => _function?.Invoke(false, _args));
}