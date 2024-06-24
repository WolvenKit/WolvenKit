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
        _hookService.RegisterOnImportFromJson(OnImportFromJson);
        _hookService.RegisterOnParsingError(OnParsingError);
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

        if (script == null)
        {
            return true;
        }

        var dto = new RedFileDto(cr2wFile) { Header = { ArchiveFileName = filePath } };

        var (success, json) = OnSaveExecute(script, extStr, RedJsonSerializer.Serialize(dto));
        switch (success)
        {
            case Enums.EBOOL.UNINITIALZED:
                return true;
            case Enums.EBOOL.TRUE:
            {
                if (!RedJsonSerializer.TryDeserialize(json, out RedFileDto? newDto) || newDto?.Data == null)
                {
                    _loggerService.Error("Couldn't deserialize return value");
                    return false;
                }

                cr2wFile = newDto.Data;

                return true;
            }

            case Enums.EBOOL.FALSE:
            default:
                return false;
        }
    }

    public void RunFileValidation(string filePath, ref CR2WFile cr2wFile) => OnSaveHook(filePath, ref cr2wFile);

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

    private void OnImportFromJson(ref string jsonText)
    {
        foreach (var scriptFile in GetScripts())
        {
            if (scriptFile.HookExtension == "global")
            {
                var (status, newJsonText) = OnImportFromJsonExecute(scriptFile, jsonText);
                if (status == Enums.EBOOL.TRUE)
                {
                    jsonText = newJsonText!;
                }
            }
        }
    }

    private (Enums.EBOOL, string?) OnImportFromJsonExecute(ScriptFile scriptFile, string jsonText)
    {
        var result = HookExecute(scriptFile, "onImportFromJson", scriptObj => scriptObj.onImportFromJson(jsonText));

        if ((bool)result[NoHook])
        {
            return (Enums.EBOOL.UNINITIALZED, null);
        }

        if (!result.TryGetValue("jsonText", out var newJsonText) || newJsonText is not string)
        {
            _loggerService.Error($"onSave: Missing \"jsonText\" (string) return value");
            return (Enums.EBOOL.UNINITIALZED, null);
        }

        return (Enums.EBOOL.TRUE, (string)newJsonText);
    }

    private bool OnParsingError(ParsingErrorEventArgs eventData)
    {
        foreach (var scriptFile in GetScripts())
        {
            if (scriptFile.HookExtension == "global")
            {
                var status = OnParsingErrorExecute(scriptFile, eventData);
                if (status == Enums.EBOOL.TRUE)
                {
                    return true;
                }
            }
        }

        return false;
    }

    private record InvalidRTTIEventArgsWrapper(string PropertyName, string ExpectedType, CVariant Value);
    private record InvalidEnumValueEventArgsWrapper(string EnumType, string StringValue);

    private Enums.EBOOL OnParsingErrorExecute(ScriptFile scriptFile, ParsingErrorEventArgs eventData)
    {
        var jsonText = SerializeArgs();
        if (jsonText == null)
        {
            return Enums.EBOOL.UNINITIALZED;
        }

        var result = HookExecute(scriptFile, "onParsingError", scriptObj => scriptObj.onParsingError(jsonText));

        if ((bool)result[NoHook])
        {
            return Enums.EBOOL.UNINITIALZED;
        }

        if (!result.TryGetValue("isPatched", out var isPatchedObj) || isPatchedObj is not bool isPatched)
        {
            _loggerService.Error($"onSave: Missing \"isPatched\" (string) return value");
            return Enums.EBOOL.UNINITIALZED;
        }

        if (!result.TryGetValue("jsonText", out var newJsonText) || newJsonText is not string newJsonTextStr)
        {
            _loggerService.Error($"onSave: Missing \"jsonText\" (string) return value");
            return Enums.EBOOL.UNINITIALZED;
        }

        if (isPatched && DeserializeArgs(newJsonTextStr))
        {
            return Enums.EBOOL.TRUE;
        }

        return Enums.EBOOL.FALSE;

        string? SerializeArgs()
        {
            if (eventData is InvalidRTTIEventArgs invalidRtti)
            {
                var wrapper = new InvalidRTTIEventArgsWrapper(invalidRtti.PropertyName, invalidRtti.ExpectedType, new CVariant { Value = invalidRtti.Value });
                return RedJsonSerializer.Serialize(wrapper);
            }

            if (eventData is InvalidEnumValueEventArgs invalidEnum)
            {
                var wrapper = new InvalidEnumValueEventArgsWrapper(RedReflection.GetEnumRedName(invalidEnum.EnumType), invalidEnum.StringValue);
                return RedJsonSerializer.Serialize(wrapper);
            }

            return null;
        }

        bool DeserializeArgs(string json)
        {
            if (eventData is InvalidRTTIEventArgs invalidRtti)
            {
                var wrapper = RedJsonSerializer.Deserialize<InvalidRTTIEventArgsWrapper>(json);
                if (wrapper != null)
                {
                    invalidRtti.Value = wrapper.Value.Value;
                    return true;
                }
            }

            if (eventData is InvalidEnumValueEventArgs invalidEnum)
            {
                var wrapper = RedJsonSerializer.Deserialize<InvalidEnumValueEventArgsWrapper>(json);
                if (wrapper != null && Enum.TryParse(invalidEnum.EnumType, wrapper.StringValue, out var value))
                {
                    invalidEnum.Value = (Enum?)value;
                    return true;
                }
            }

            return false;
        }
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

        var code = scriptFile.Content;

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