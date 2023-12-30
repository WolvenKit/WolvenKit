using System;
using System.IO;
using System.Text.RegularExpressions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Modkit.Scripting;

public partial class ScriptFile
{
    private ScriptFile()
    {
    }

    public string Path { get; private set; } = null!;
    public string Name { get; private set; } = null!;

    public ScriptType Type { get; private set; } = ScriptType.General;
    public string? HookExtension { get; private set; }

    public string? Version { get; private set; }
    public string? Author { get; private set; }

    private DateTime _lastModified = DateTime.MinValue;
    private string _content = string.Empty;

    public string GetContent()
    {
        var localLastModified = File.GetLastWriteTimeUtc(Path);
        if (_lastModified >= localLastModified)
        {
            return _content;
        }

        _content = File.ReadAllText(Path);
        _lastModified = localLastModified;

        return _content;
    }

    [GeneratedRegex("^// @([^\\s]+) (.*)$")]
    private static partial Regex InfoHeaderRegex();

    public static ScriptFile? Load(string path, ILoggerService loggerService)
    {
        var result = new ScriptFile
        {
            Path = path,
            Name = System.IO.Path.GetFileNameWithoutExtension(path)
        };

        foreach (var line in File.ReadAllLines(result.Path))
        {
            if (!line.StartsWith("//"))
            {
                break;
            }

            var match = InfoHeaderRegex().Match(line);
            if (match.Success)
            {
                switch (match.Groups[1].Value)
                {
                    case "version":
                        result.Version = match.Groups[2].Value;
                        break;

                    case "author":
                        result.Author = match.Groups[2].Value;
                        break;

                    case "type":
                        if (Enum.TryParse<ScriptType>(match.Groups[2].Value, true, out var scriptType))
                        {
                            result.Type = scriptType;
                        }
                        else
                        {
                            loggerService.Error($"Could not load \"{result.Path}\". Field \"type\" is invalid \"{match.Groups[2].Value}\"");
                            return null;
                        }
                        break;

                    case "hook_extension":
                        result.HookExtension = match.Groups[2].Value;
                        break;

                    default:
                        break;
                }
            }
        }

        if (result.Type == ScriptType.Hook && string.IsNullOrEmpty(result.HookExtension))
        {
            loggerService.Error($"Could not load \"{result.Path}\". Field \"hook_extension\" is not set");
            return null;
        }

        return result;
    }
}

public enum ScriptType
{
    General,
    Hook,
    Lib,
    Ui
}