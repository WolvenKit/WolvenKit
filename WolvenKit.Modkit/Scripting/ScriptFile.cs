using System;
using System.Collections.Generic;
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

                    default:
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