using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Modkit.Scripting;

public class SettingsDictionary : Dictionary<string, SettingsEntry>
{
    public SettingsDictionary() { }
    public SettingsDictionary(Dictionary<string, SettingsEntry> dictionary) : base(dictionary) { }

    public string ToJson()
    {
        var dict = new Dictionary<string, object?>();
        foreach (var (_,entry) in this)
        {
            dict.Add(entry.Name, entry.Value);
        }
        return JsonSerializer.Serialize(dict);
    }
}

public class SettingsEntry(string name, Type type, object? value)
{
    public string Name { get; init; } = name;
    public Type Type { get; init; } = type;
    public Type InnerType => Type.GenericTypeArguments[0];
    public object? Value { get; set; } = value;
}

public partial class ScriptFile
{
    public ScriptFile(string path)
    {
        Path = path;
        Name = System.IO.Path.GetFileNameWithoutExtension(path);
    }

    public string Path { get; }
    public string Name { get; }

    public ScriptType Type { get; private set; } = ScriptType.General;
    public string? HookExtension { get; private set; }

    public string? Version { get; private set; }
    public string? Author { get; private set; }
    public string? Description { get; private set; }
    public string? Usage { get; private set; }
    public SettingsDictionary Settings { get; } = new();

    public string[] Lines { get; private set; } = [];
    public string Content => string.Join(Environment.NewLine, Lines);

    private DateTime _lastModified = DateTime.MinValue;

    public bool Reload(ILoggerService? loggerService)
    {
        var lastModified = File.GetLastWriteTimeUtc(Path);
        if (_lastModified >= lastModified)
        {
            return true;
        }
        _lastModified = lastModified;

        var blockType = BlockType.None;
        var blockLines = new List<string>();

        Lines = File.ReadAllLines(Path);
        for (var i = 0; i < Lines.Length; i++)
        {
            var line = Lines[i];

            if (!line.StartsWith("//"))
            {
                SaveBlock();
                continue;
            }

            var match = InfoHeaderRegex().Match(line);
            if (match.Success)
            {
                SaveBlock();

                switch (match.Groups[1].Value)
                {
                    case "version":
                        Version = match.Groups[2].Value;
                        break;

                    case "author":
                        Author = match.Groups[2].Value;
                        break;

                    case "type":
                        if (Enum.TryParse<ScriptType>(match.Groups[2].Value, true, out var scriptType))
                        {
                            Type = scriptType;
                        }
                        else
                        {
                            loggerService?.Error($"Could not load \"{Path}\". Field \"type\" is invalid \"{match.Groups[2].Value}\"");
                            return false;
                        }
                        break;

                    case "hook_extension":
                        HookExtension = match.Groups[2].Value;
                        break;

                    case "description":
                        blockType = BlockType.Description;
                        break;

                    case "usage":
                        blockType = BlockType.Usage;
                        break;

                    case "setting":
                        ParseSetting(match.Groups[2].Value);
                        break;
                }
            }

            if (blockType != BlockType.None)
            {
                blockLines.Add(line[2..].Trim());
            }
        }

        if (Type == ScriptType.Hook && string.IsNullOrEmpty(HookExtension))
        {
            loggerService?.Error($"Could not load \"{Path}\". Field \"hook_extension\" is not set");
            return false;
        }

        return true;

        void SaveBlock()
        {
            if (blockType == BlockType.None)
            {
                return;
            }

            blockLines.RemoveAt(0);
            if (string.IsNullOrWhiteSpace(blockLines[^1]))
            {
                blockLines.RemoveAt(blockLines.Count - 1);
            }

            if (blockType == BlockType.Description)
            {
                Description = string.Join(Environment.NewLine, blockLines);
            }

            if (blockType == BlockType.Usage)
            {
                Usage = string.Join(Environment.NewLine, blockLines);
            }

            blockLines.Clear();
            blockType = BlockType.None;
        }

        void ParseSetting(string line)
        {
            var parts = line.Split(':');

            if (parts.Length < 2)
            {
                loggerService?.Warning($"Invalid setting definition: \"{line}\". Should be: \"name:type(:default)\"");
                return;
            }

            var name = parts[0].Trim();
            if (Settings.ContainsKey(name))
            {
                loggerService?.Warning($"A setting with the name \"{name}\" has already be defined");
                return;
            }

            var typeStr = parts[1].Trim();

            SettingsEntry? entry = null;
            switch (typeStr)
            {
                case "int":
                {
                    var defaultValue = default(int);
                    if (parts.Length > 2)
                    {
                        if (!int.TryParse(parts[2].Trim(), out defaultValue))
                        {
                            loggerService?.Warning($"Invalid default value for setting \"{name}\". Should be an integer");
                            return;
                        }
                    }

                    entry = new SettingsEntry(name, typeof(int), defaultValue);
                    break;
                }

                case "int[]":
                {
                    var defaultValue = new List<int>();
                    if (parts.Length > 2)
                    {
                        var values = parts[2].Split(',');
                        var array = new List<int>();
                        foreach (var strVal in values)
                        {
                            if (!int.TryParse(strVal.Trim(), out var val))
                            {
                                loggerService?.Warning($"Invalid default value for setting \"{name}\". Should be an integer array");
                                return;
                            }

                            array.Add(val);
                        }

                        defaultValue = array;
                    }

                    entry = new SettingsEntry(name, typeof(List<int>), defaultValue);
                    break;
                }

                case "double":
                {
                    var defaultValue = default(double);
                    if (parts.Length > 2)
                    {
                        if (!double.TryParse(parts[2].Trim(), CultureInfo.InvariantCulture, out defaultValue))
                        {
                            loggerService?.Warning($"Invalid default value for setting \"{name}\". Should be a double");
                            return;
                        }
                    }

                    entry = new SettingsEntry(name, typeof(double), defaultValue);
                    break;
                }

                case "double[]":
                {
                    var defaultValue = new List<double>();
                    if (parts.Length > 2)
                    {
                        var values = parts[2].Split(',');
                        var array = new List<double>();
                        foreach (var strVal in values)
                        {
                            if (!double.TryParse(strVal.Trim(), CultureInfo.InvariantCulture, out var val))
                            {
                                loggerService?.Warning($"Invalid default value for setting \"{name}\". Should be an integer array");
                                return;
                            }

                            array.Add(val);
                        }

                        defaultValue = array;
                    }

                    entry = new SettingsEntry(name, typeof(List<double>), defaultValue);
                    break;
                }

                case "string":
                {
                    var defaultValue = string.Empty;
                    if (parts.Length > 2)
                    {
                        defaultValue = parts[2].Trim();
                    }

                    entry = new SettingsEntry(name, typeof(string), defaultValue);
                    break;
                }

                case "string[]":
                {
                    var defaultValue = new List<string>();
                    if (parts.Length > 2)
                    {
                        var array = new List<string>();

                        var tmpStr = "";
                        var newVal = false;
                        var escape = false;
                        for (var i = 0; i < parts[2].Length; i++)
                        {
                            var c = parts[2][i];

                            if (escape)
                            {
                                if (c == '"')
                                {
                                    tmpStr += c;
                                }
                                else
                                {
                                    tmpStr += $"\\{c}";
                                }

                                escape = false;
                                continue;
                            }

                            if (c == '\\')
                            {
                                escape = true;
                                continue;
                            }

                            if (c == '"')
                            {
                                if (!newVal)
                                {
                                    newVal = true;
                                }
                                else
                                {
                                    array.Add(tmpStr);
                                    tmpStr = "";

                                    newVal = false;
                                }

                                continue;
                            }

                            if (!newVal)
                            {
                                if (c != ',')
                                {
                                    loggerService?.Warning($"Invalid default value for setting \"{name}\"");
                                    return;
                                }
                                continue;
                            }

                            tmpStr += c;
                        }

                        defaultValue = array;
                    }

                    entry = new SettingsEntry(name, typeof(List<string>), defaultValue);
                    break;
                }

                case "bool":
                {
                    var defaultValue = default(bool);
                    if (parts.Length > 2)
                    {
                        if (!bool.TryParse(parts[2].Trim(), out defaultValue))
                        {
                            loggerService?.Warning($"Invalid default value for setting \"{name}\". Should be a bool");
                            return;
                        }
                    }

                    entry = new SettingsEntry(name, typeof(bool), defaultValue);
                    break;
                }

                case "bool[]":
                {
                    var defaultValue = new List<bool>();
                    if (parts.Length > 2)
                    {
                        var values = parts[2].Split(',');
                        var array = new List<bool>();
                        foreach (var strVal in values)
                        {
                            if (!bool.TryParse(strVal.Trim(), out var val))
                            {
                                loggerService?.Warning($"Invalid default value for setting \"{name}\". Should be an integer array");
                                return;
                            }

                            array.Add(val);
                        }

                        defaultValue = array;
                    }

                    entry = new SettingsEntry(name, typeof(List<bool>), defaultValue);
                    break;
                }
            }

            if (entry != null)
            {
                Settings[name] = entry;
            }
        }
    }

    [GeneratedRegex("^//\\s*@([^\\s]+)\\s*(.*)$")]
    private static partial Regex InfoHeaderRegex();

    private enum BlockType
    {
        None,
        Description,
        Usage
    }
}

public enum ScriptType
{
    General,
    Hook,
    Lib,
    Ui
}