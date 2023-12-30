using System;
using System.IO;
using System.Text.RegularExpressions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.Modkit.Scripting;

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

    public string Content { get; private set; } = string.Empty;

    private DateTime _lastModified = DateTime.MinValue;

    public bool Reload(ILoggerService? loggerService)
    {
        var lastModified = File.GetLastWriteTimeUtc(Path);
        if (_lastModified >= lastModified)
        {
            return true;
        }
        _lastModified = lastModified;

        foreach (var line in File.ReadAllLines(Path))
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

                    default:
                        break;
                }
            }
        }

        if (Type == ScriptType.Hook && string.IsNullOrEmpty(HookExtension))
        {
            loggerService?.Error($"Could not load \"{Path}\". Field \"hook_extension\" is not set");
            return false;
        }

        Content = File.ReadAllText(Path);

        return true;
    }

    [GeneratedRegex("^// @([^\\s]+) (.*)$")]
    private static partial Regex InfoHeaderRegex();
}

public enum ScriptType
{
    General,
    Hook,
    Lib,
    Ui
}