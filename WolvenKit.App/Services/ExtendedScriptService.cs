using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ClearScript;
using Microsoft.ClearScript.JavaScript;
using Microsoft.ClearScript.V8;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.Common.Conversion;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using ScriptFile = WolvenKit.Modkit.Scripting.ScriptFile;

namespace WolvenKit.App.Services;

public partial class ExtendedScriptService : ScriptService
{
    private const string NoHook = "NO_HOOK";

    private readonly Dictionary<string, List<ScriptEntry>> _uiScripts = new();
    private readonly Dictionary<string, IScriptableControl> _uiControls = new();

    private readonly WKitUIScripting _wkit;
    private readonly WScriptUIHelper _ui;
    private readonly ISettingsManager _settingsManager;

    private V8ScriptEngine? _uiEngine;

    public Dictionary<string, object> DefaultHostObject { get; }

    public ExtendedScriptService(ILoggerService loggerService, WKitUIScripting wkit, ISettingsManager settingsManager) : base(loggerService)
    {
        _wkit = wkit;
        _ui = new WScriptUIHelper(this);
        _settingsManager = settingsManager;

        DefaultHostObject = new() { { "wkit", _wkit } };

        RefreshUIScripts();
    }

    public async Task ExecuteAsync(string code) => await ExecuteAsync(code, DefaultHostObject);

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

    public IList<ScriptFile> GetScripts()
    {
        var result = GetScripts(ISettingsManager.GetWScriptDir());

        foreach (var scriptFile in GetScripts(@"Resources\Scripts"))
        {
            if (result.All(x => x.Name != scriptFile.Name))
            {
                result.Add(scriptFile);
            }
        }

        return result;
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

    public bool OnSaveHook(string extStr, ref CR2WFile cr2wFile)
    {
        if (string.IsNullOrEmpty(extStr))
        {
            throw new ArgumentNullException(nameof(extStr));
        }

        if (extStr[0] == '.')
        {
            extStr = extStr.Substring(1);
        }

        _settingsManager.ScriptStatus ??= new();

        ScriptFile? script = null;
        foreach (var scriptFile in GetScripts())
        {
            if (scriptFile.Type != ScriptType.Hook)
            {
                continue;
            }

            if (scriptFile.HookExtension != "global"/* && scriptFile.HookExtension != extStr*/)
            {
                continue;
            }

            if (_settingsManager.ScriptStatus.TryGetValue(scriptFile.Path, out var enabled) && !enabled)
            {
                continue;
            }

            script = scriptFile;
            break;
        }

        if (script != null)
        {
            var dto = new RedFileDto(cr2wFile);

            var (success, json) = OnSaveExecute(script.Path, extStr, RedJsonSerializer.Serialize(dto));
            if (success == Enums.EBOOL.UNINITIALZED)
            {
                return true;
            }

            if (success == Enums.EBOOL.TRUE)
            {
                if (!RedJsonSerializer.TryDeserialize(json, out RedFileDto? newDto) || newDto?.Data == null)
                {
                    _loggerService.Error("Couldn't deserialize return value");
                    return false;
                }

                cr2wFile = newDto.Data;

                return true;
            }

            return false;
        }

        return true;
    }

    private (Enums.EBOOL, string) OnSaveExecute(string scriptFilePath, string extStr, string json)
    {
        var result = HookExecute(scriptFilePath, "onSave", scriptObj => scriptObj.onSave(extStr, json));

        if ((bool)result[NoHook])
        {
            return (Enums.EBOOL.UNINITIALZED, "");
        }

        if (!result.TryGetValue("success", out var successObj) || successObj is not bool success)
        {
            _loggerService.Error($"onSave: Missing \"success\" (bool) return value");
            return (Enums.EBOOL.UNINITIALZED, "");
        }

        if (!result.TryGetValue("file", out var fileObj) || fileObj is not string file)
        {
            _loggerService.Error($"onSave: Missing \"file\" (string) return value");
            return (Enums.EBOOL.UNINITIALZED, "");
        }


        if (success)
        {
            return (Enums.EBOOL.TRUE, file);
        }

        return (Enums.EBOOL.FALSE, "");
    }

    private Dictionary<string, object> HookExecute(string scriptFilePath, string function, Func<dynamic, dynamic?> action)
    {
        var engine = GetScriptEngine(DefaultHostObject);

        var code = File.ReadAllText(scriptFilePath);

        var result = new Dictionary<string, object>
        {
            { NoHook, false }
        };
        try
        {
            engine.Execute(new DocumentInfo { Category = ModuleCategory.Standard }, code);

            var found = ((ScriptObject)engine.Script).PropertyNames.Any(propertyName => propertyName == function);
            if (!found)
            {
                result[NoHook] = true;
                return result;
            }

            var tmp = action(engine.Script);
            if (tmp != null)
            {
                foreach (var propertyName in tmp.PropertyNames)
                {
                    result.Add(propertyName, tmp[propertyName]);
                }
            }
        }
        catch (ScriptEngineException ex1)
        {
            _loggerService.Error($"{ex1.ErrorDetails}\r\nin {scriptFilePath}");
        }
        catch (Exception ex2)
        {
            _loggerService.Error(ex2);
        }

        return result;
    }

    public void RefreshUIScripts()
    {
        UnloadScripts();

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
                _uiEngine.Execute(code);
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
                _uiEngine.Execute(code);
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

    protected override V8ScriptEngine GetScriptEngine(Dictionary<string, object>? hostObjects = null, List<string>? searchPaths = null)
    {
        searchPaths ??= new List<string> { ISettingsManager.GetWScriptDir(), Path.GetFullPath(@"Resources\Scripts") };

        var engine = base.GetScriptEngine(hostObjects, searchPaths);

        engine.AddHostType(typeof(WMessageBoxImage));
        engine.AddHostType(typeof(WMessageBoxButtons));
        engine.AddHostType(typeof(WMessageBoxResult));

        return engine;
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