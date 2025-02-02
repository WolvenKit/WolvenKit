using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Text.RegularExpressions;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;

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

    public HookType HookType { get; private set; } = HookType.None;
    public ImmutableList<string> HookExtensions { get; private set; } = ImmutableList<string>.Empty;
    public int HookPriority { get; private set; } = 100;

    public string? Version { get; private set; }
    public string? Author { get; private set; }
    public string? Description { get; private set; }
    public string? Usage { get; private set; }

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

        var blockType = BlockType.None;
        var blockLines = new List<string>();

        foreach (var line in File.ReadAllLines(Path))
        {
            if (!line.StartsWith("//"))
            {
                SaveBlock();
                break;
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
                            if (Type == ScriptType.Hook)
                            {
                                HookType = HookType.Global;
                            }
                        }
                        else
                        {
                            loggerService?.Error($"[WScript] Could not load \"{Path}\". Field \"type\" is invalid \"{match.Groups[2].Value}\"");
                            return false;
                        }
                        break;

                    case "hook_type":
                    case "hook_types":
                        Type = ScriptType.Hook;
                        HookType = HookType.None;

                        foreach (var part in match.Groups[2].Value.Split(','))
                        {
                            if (!Enum.TryParse<HookType>(part, true, out var type))
                            {
                                loggerService?.Error($"[WScript] \"{Name}\" contains an unknown hook type \"{part}\"");
                                continue;
                            }

                            HookType |= type;
                        }

                        break;

                    case "hook_extension":
                    case "hook_extensions":
                        var hookExtensions = new List<string>();
                        foreach (var part in match.Groups[2].Value.Split(','))
                        {
                            if (part != "global" && 
                                !Enum.TryParse<ERedExtension>(part, true, out _) &&
                                !Enum.TryParse<ERawFileFormat>(part, true, out _))
                            {
                                loggerService?.Error($"[WScript] \"{Name}\" contains an unknown hook extension \"{part}\"");
                                continue;
                            }

                            if (part == "global")
                            {
                                hookExtensions = ["global"];
                                break;
                            }

                            hookExtensions.Add(part.ToLower());
                        }
                        HookExtensions = ImmutableList.Create(hookExtensions.ToArray());
                        break;

                    case "hook_priority":
                        if (!int.TryParse(match.Groups[2].Value, out var priority))
                        {
                            loggerService?.Error($"[WScript] \"{Name}\" contains an invalid hook priority \"{match.Groups[2].Value}\". Value needs to be an integer");
                            continue;
                        }
                        HookPriority = priority;
                        break;

                    case "description":
                        blockType = BlockType.Description;
                        break;

                    case "usage":
                        blockType = BlockType.Usage;
                        break;

                    default:
                        loggerService?.Debug($"[WScript] \"{Name}\" contains an unknown tag \"{match.Groups[1].Value}\"");
                        break;
                }
            }

            if (blockType != BlockType.None)
            {
                blockLines.Add(line[2..].Trim());
            }
        }

        if (Type == ScriptType.Hook && HookType != HookType.None)
        {
            if (HookExtensions.Count == 0)
            {
                loggerService?.Error($"[WScript] Could not load \"{Path}\". Field \"hook_extension(s)\" is not set");
                return false;
            }
        }

        Content = File.ReadAllText(Path);

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
    }

    public bool IsHookExtensionSupported(string? extension)
    {
        if (HookExtensions[0] == "global")
        {
            return true;
        }

        if (string.IsNullOrWhiteSpace(extension))
        {
            return false;
        }

        extension = extension.ToLower();
        if (extension.Length > 0 && extension[0] == '.')
        {
            extension = extension[1..];
        }

        return HookExtensions.Contains(extension);
    }

    [GeneratedRegex("^// @([^\\s]+)\\s?([^\\s]*)$")]
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

[Flags]
public enum HookType
{
    None = 0x00,

    Save = 0x01,
    Export = 0x02,
    PreImport = 0x04,
    ImportJson = 0x08,

    ParseError = 0x8000,

    Global = Save | Export | PreImport | ImportJson | ParseError
}