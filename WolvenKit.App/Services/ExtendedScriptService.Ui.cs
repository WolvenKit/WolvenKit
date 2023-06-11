using System;
using System.Collections.Generic;
using Microsoft.ClearScript.JavaScript;
using Microsoft.ClearScript;
using System.IO;
using Microsoft.ClearScript.V8;
using System.Threading.Tasks;

namespace WolvenKit.App.Services;

public partial class ExtendedScriptService
{
    private readonly Dictionary<string, List<ScriptEntry>> _uiScripts = new();
    private readonly Dictionary<string, IScriptableControl> _uiControls = new();

    private readonly WScriptUIHelper _ui;
    private V8ScriptEngine? _uiEngine;

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

    private void UnloadUiScripts()
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
        UnloadUiScripts();

        _uiEngine = GetScriptEngine(new Dictionary<string, object> { { "ui", _ui }, { "wkit", _wkit } });

        var loadedFiles = new List<string>();

        _settingsManager.ScriptStatus ??= new();

        foreach (var scriptFilePath in Directory.GetFiles(ISettingsManager.GetWScriptDir(), "ui_*.wscript"))
        {
            if (_settingsManager.ScriptStatus.TryGetValue(scriptFilePath, out var enabled) && !enabled)
            {
                continue;
            }

            var code = File.ReadAllText(scriptFilePath);

            try
            {
                _uiEngine.Execute(new DocumentInfo { Category = ModuleCategory.Standard }, code);
            }
            catch (ScriptEngineException ex1)
            {
                _loggerService?.Error($"{ex1.ErrorDetails}\r\nin {scriptFilePath}");
            }
            catch (Exception ex2)
            {
                _loggerService?.Error(ex2);
            }

            loadedFiles.Add(Path.GetFileName(scriptFilePath));
        }

        foreach (var scriptFilePath in Directory.GetFiles(@"Resources\Scripts", "ui_*.wscript"))
        {
            if (loadedFiles.Contains(Path.GetFileName(scriptFilePath)))
            {
                continue;
            }

            if (_settingsManager.ScriptStatus.TryGetValue(scriptFilePath, out var enabled) && !enabled)
            {
                continue;
            }

            var code = File.ReadAllText(scriptFilePath);

            try
            {
                _uiEngine.Execute(new DocumentInfo { Category = ModuleCategory.Standard }, code);
            }
            catch (ScriptEngineException ex1)
            {
                _loggerService?.Error($"{ex1.ErrorDetails}\r\nin {scriptFilePath}");
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