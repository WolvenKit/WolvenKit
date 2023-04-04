#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.ClearScript;
using Microsoft.ClearScript.JavaScript;
using Microsoft.ClearScript.V8;
using WolvenKit.Common.Conversion;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W.JSON;

namespace WolvenKit.App.Services;

public partial class ExtendedScriptService : ScriptService
{
    private readonly Dictionary<string, List<ScriptEntry>> _uiScripts = new();
    private readonly Dictionary<string, IScriptableControl> _uiControls = new();

    private readonly Dictionary<string, object> _hostObjects = new();

    private V8ScriptEngine? _uiEngine;

    public ExtendedScriptService(ILoggerService loggerService) : base(loggerService)
    {
        DeployShippedFiles();

        _hostObjects.Add("ui", new WScriptUIHelper(this));

        RefreshUIScripts();
    }

    private void DeployShippedFiles()
    {
        var dir = ISettingsManager.GetWScriptDir();

        CheckFile("Logger");
        CheckFile("onSave_mesh");
        CheckFile("ui_example");

        void CheckFile(string fileName)
        {
            if (!File.Exists($"{dir}/{fileName}.wscript"))
            {
                File.Copy(@$"Resources\Scripts\{fileName}.wscript", $"{dir}/{fileName}.wscript");
            }
        }
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

    public bool OnSaveHook(string ext, CR2WFile cr2wFile)
    {
        if (string.IsNullOrEmpty(ext))
        {
            throw new ArgumentNullException(nameof(ext));
        }

        if (ext[0] == '.')
        {
            ext = ext.Substring(1);
        }

        var scriptFilePath = Path.Combine(ISettingsManager.GetWScriptDir(), $"onSave_{ext}.wscript");
        if (File.Exists(scriptFilePath))
        {
            var dto = new RedFileDto(cr2wFile);
            var json = RedJsonSerializer.Serialize(dto);

            return TestExecute(scriptFilePath, json);
        }

        return true;
    }

    private bool TestExecute(string file, string json)
    {
        var engine = base.GetScriptEngine(null, ISettingsManager.GetWScriptDir());
        engine.Script.file = json;
        engine.Script.success = false;

        var code = File.ReadAllText(file);

        try
        {
            engine.Execute(new DocumentInfo { Category = ModuleCategory.Standard }, code);
        }
        catch (ScriptEngineException ex1)
        {
            _loggerService?.Error($"{ex1.ErrorDetails}\r\nin {file}");
        }
        catch (Exception ex2)
        {
            _loggerService?.Error(ex2);
        }

        return engine.Script.success;
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
                _loggerService?.Error($"{ex1.ErrorDetails}\r\nin {file}");
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