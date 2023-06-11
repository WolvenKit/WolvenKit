using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.ClearScript;
using Microsoft.ClearScript.JavaScript;
using Microsoft.ClearScript.V8;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Services;

public partial class AppScriptService
{
    private const string NoHook = "NO_HOOK";

    private void RegisterHooks()
    {
        // _hookService.RegisterOnExport(OnExportHook);
        if (_hookService is AppHookService appHookService)
        {
            appHookService.RegisterOnSave(OnSaveHook);
        }
    }

    private bool OnSaveHook(string extStr, ref CR2WFile cr2wFile)
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

    private object? OnExportHook(Stream cr2WStream, string relPath, GlobalExportArgs settings, DirectoryInfo rawOutDir, ECookedFileFormat[]? forcebuffers)
    {
        foreach (var scriptFile in GetScripts())
        {
            if (scriptFile.HookExtension == "global")
            {
                //OnExportExecute(scriptFile.Path, filePath, args);
            }
        }

        return null;
    }

    private void OnExportExecute(string scriptFilePath, string exportFilePath, GlobalExportArgs args)
    {
        var result = HookExecute(scriptFilePath, "onExport", scriptObj => scriptObj.onExport(exportFilePath, SerializeExportArgs(args)));
    }

    public void OnPreImportHook(string filePath, GlobalImportArgs args)
    {
        foreach (var scriptFile in GetScripts())
        {
            if (scriptFile.HookExtension == "global")
            {
                OnPreImportExecute(scriptFile.Path, filePath, args);
            }
        }
    }

    private void OnPreImportExecute(string scriptFilePath, string exportFilePath, GlobalImportArgs args)
    {
        var dict = new Dictionary<string, ImportArgs>();
        foreach (var type in args.GetTypes())
        {
            dict.Add(type.Name[..^10], args.Get(type));
        }
        var tmp = JsonSerializer.Serialize(dict, new JsonSerializerOptions { Converters = { new ImportExportArgsConverter() } });

        var result = HookExecute(scriptFilePath, "onPreImport", scriptObj => scriptObj.onPreImport(exportFilePath, tmp));
    }

    public void OnPostImportHook(string filePath, GlobalImportArgs args)
    {
        foreach (var scriptFile in GetScripts())
        {
            if (scriptFile.HookExtension == "global")
            {
                OnPostImportExecute(scriptFile.Path, filePath, args);
            }
        }
    }

    private void OnPostImportExecute(string scriptFilePath, string exportFilePath, GlobalImportArgs args)
    {
        var result = HookExecute(scriptFilePath, "onPostImport", scriptObj => scriptObj.onPostImport(exportFilePath, args));
    }

    private string SerializeExportArgs(GlobalExportArgs args)
    {
        var dict = new Dictionary<string, ImportExportArgs>();
        foreach (var type in args.GetTypes())
        {
            dict.Add(type.Name[..^10], args.Get(type));
        }
        return JsonSerializer.Serialize(dict, new JsonSerializerOptions { Converters = { new ImportExportArgsConverter() } });
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
}