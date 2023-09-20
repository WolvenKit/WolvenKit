using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using Microsoft.ClearScript;
using Microsoft.ClearScript.JavaScript;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.Model;
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
        _hookService.RegisterOnExport(OnExportHook);
        _hookService.RegisterOnPreImport(OnPreImportHook);
        if (_hookService is AppHookService appHookService)
        {
            appHookService.RegisterOnSave(OnSaveHook);
        }
    }

    private bool OnSaveHook(string filePath, ref CR2WFile cr2wFile)
    {
        if (string.IsNullOrEmpty(filePath))
        {
            throw new ArgumentNullException(nameof(filePath));
        }

        var extStr = Path.GetExtension(filePath);
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
            dto.Header.ArchiveFileName = filePath;

            var (success, json) = OnSaveExecute(script, extStr, RedJsonSerializer.Serialize(dto));
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

    private (Enums.EBOOL, string) OnSaveExecute(ScriptFile scriptFile, string extStr, string json)
    {
        var result = HookExecute(scriptFile, "onSave", scriptObj => scriptObj.onSave(extStr, json));

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

    private void OnExportHook(ref FileInfo fileInfo, ref GlobalExportArgs args)
    {
        foreach (var scriptFile in GetScripts())
        {
            if (scriptFile.HookExtension == "global")
            {
                var (status, newArgs) = OnExportExecute(scriptFile, fileInfo, args);
                if (status == Enums.EBOOL.TRUE)
                {
                    args = newArgs!;
                }
            }
        }
    }

    private (Enums.EBOOL, GlobalExportArgs?) OnExportExecute(ScriptFile scriptFile, FileInfo fileInfo, GlobalExportArgs args)
    {
        var jsonArgs = JsonSerializer.Serialize(args, new JsonSerializerOptions { Converters = { new ImportExportArgsConverter() } });
        var result = HookExecute(scriptFile, "onExport", scriptObj => scriptObj.onExport(fileInfo.FullName, jsonArgs));

        if ((bool)result[NoHook])
        {
            return (Enums.EBOOL.UNINITIALZED, null);
        }

        if (!result.TryGetValue("settings", out var settingsObj) || settingsObj is not string settings)
        {
            _loggerService.Error($"onSave: Missing \"settings\" (string) return value");
            return (Enums.EBOOL.UNINITIALZED, null);
        }

        var newSettings = JsonSerializer.Deserialize<GlobalExportArgs>(settings, new JsonSerializerOptions { Converters = { new ImportExportArgsConverter() } });
        if (newSettings != null)
        {
            MergeSettings(args, newSettings);
        }

        return (Enums.EBOOL.TRUE, args);
    }

    public void OnPreImportHook(ref RedRelativePath rawRelative, ref GlobalImportArgs args, ref DirectoryInfo? outDir)
    {
        foreach (var scriptFile in GetScripts())
        {
            if (scriptFile.HookExtension == "global")
            {
                var (status, newArgs) = OnPreImportExecute(scriptFile, rawRelative, args, outDir);
                if (status == Enums.EBOOL.TRUE)
                {
                    args = newArgs!;
                }
            }
        }
    }

    private (Enums.EBOOL, GlobalImportArgs?) OnPreImportExecute(ScriptFile scriptFile, RedRelativePath rawRelative, GlobalImportArgs args, DirectoryInfo? outDir)
    {
        var jsonArgs = JsonSerializer.Serialize(args, new JsonSerializerOptions { Converters = { new ImportExportArgsConverter() } });
        var result = HookExecute(scriptFile, "onPreImport", scriptObj => scriptObj.onPreImport(rawRelative, jsonArgs));

        if ((bool)result[NoHook])
        {
            return (Enums.EBOOL.UNINITIALZED, null);
        }

        if (!result.TryGetValue("settings", out var settingsObj) || settingsObj is not string settings)
        {
            _loggerService.Error($"onSave: Missing \"settings\" (string) return value");
            return (Enums.EBOOL.UNINITIALZED, null);
        }

        var newSettings = JsonSerializer.Deserialize<GlobalImportArgs>(settings, new JsonSerializerOptions { Converters = { new ImportExportArgsConverter() } });
        if (newSettings != null)
        {
            MergeSettings(args, newSettings);
        }

        return (Enums.EBOOL.TRUE, args);
    }

    private void MergeSettings(AbstractGlobalArgs oldSettings, AbstractGlobalArgs newSettings)
    {
        if (newSettings.GetType() != oldSettings.GetType())
        {
            throw new Exception();
        }

        foreach (var type in oldSettings.GetTypes())
        {
            var newTypeSettings = newSettings.Get(type);
            var oldTypeSettings = oldSettings.Get(type);

            foreach (var propertyInfo in oldTypeSettings.GetType().GetProperties())
            {
                if (propertyInfo.GetCustomAttribute<WkitScriptAccess>() == null)
                {
                    continue;
                }

                propertyInfo.SetValue(oldTypeSettings, propertyInfo.GetValue(newTypeSettings));
            }
        }
    }

    private Dictionary<string, object> HookExecute(ScriptFile scriptFile, string function, Func<dynamic, dynamic?> action)
    {
        var engine = GetScriptEngine(DefaultHostObject);

        var code = scriptFile.GetContent();

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
            _loggerService.Error($"{ex1.ErrorDetails}\r\nin {scriptFile.Path}");
        }
        catch (Exception ex2)
        {
            _loggerService.Error(ex2);
        }
        finally
        {
            engine.Dispose();
        }

        return result;
    }
}