#nullable enable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.ClearScript;
using Microsoft.ClearScript.JavaScript;
using Microsoft.ClearScript.V8;
using WolvenKit.App.Helpers;
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

    private readonly WKitUIScripting _wkit;
    private readonly WScriptUIHelper _ui;

    private V8ScriptEngine? _uiEngine;

    public ExtendedScriptService(ILoggerService loggerService, WKitUIScripting wkit) : base(loggerService)
    {
        _wkit = wkit;
        _ui = new WScriptUIHelper(this);

        DeployShippedFiles();
        RefreshUIScripts();
    }

    
    private void DeployShippedFiles()
    {
        
        void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            // Copy those only once per new installation
            if (!File.Exists(sourcePath))
            {
                return;
            }
            if (!File.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            
            //Now Create all of the directories
            foreach (var dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            //Copy all the files & Replaces any files with the same name
            foreach (var newPath in Directory.GetFiles(sourcePath, "*.*",SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
            // Don't copy again until next install
            Directory.Delete(sourcePath, true);
        }
        
        var scriptDir = ISettingsManager.GetWScriptDir();

        var defaultFiles = Directory.GetFiles(@"Resources\Scripts");
        // Overwrite the defaults inside the root directory only if they don't exist
        // we don't want the user to lose any changes
        foreach (var filePath in defaultFiles)
        {
            var fileName = Path.GetFileName(filePath);

            if (!File.Exists($"{scriptDir}/{fileName}") 
                && (fileName.EndsWith("example.wscript") || fileName.StartsWith("onSave")))
            {
                File.Copy(filePath, $"{scriptDir}/{fileName}");
            }
        }

        CopyFilesRecursively(@"Resources\Scripts\Wolvenkit", $"{scriptDir}/Wolvenkit");
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

    public bool OnSaveHook(string ext, ref CR2WFile cr2wFile)
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

            if (TestExecute(scriptFilePath, ref json))
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

    private bool TestExecute(string file, ref string json)
    {
        var engine = base.GetScriptEngine(new Dictionary<string, object> { { "wkit", _wkit } }, ISettingsManager.GetWScriptDir());
        engine.Script.file = json;
        engine.Script.success = false;

        var code = File.ReadAllText(file);

        try
        {
            engine.Execute(new DocumentInfo { Category = ModuleCategory.Standard }, code);
            json = engine.Script.file;
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

        _uiEngine = base.GetScriptEngine(new Dictionary<string, object> { { "ui", _ui }, { "wkit", _wkit } }, ISettingsManager.GetWScriptDir());

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