using System.IO;
using System.Text.RegularExpressions;

namespace WolvenKit.Modkit.Scripting;

public partial class ScriptFile
{
    public ScriptFile(string path)
    {
        Path = path;

        GetInfo();
    }

    public string Path { get; }
    public string Name { get; private set; } = null!;

    public ScriptType Type { get; private set; }
    public string? HookExtension { get; private set; }

    public string? Version { get; private set; }
    public string? Author { get; private set; }

    private void GetInfo()
    {
        Name = System.IO.Path.GetFileNameWithoutExtension(Path);

        Type = ScriptType.General;
        if (Name.StartsWith("ui_"))
        {
            Type = ScriptType.Ui;
        }

        var hookMatch = HookRegex().Match(Name);
        if (hookMatch.Success)
        {
            Type = ScriptType.Hook;
            HookExtension = hookMatch.Groups[1].Value;
        }

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

                    default:
                        break;
                }
            }
        }
    }

    [GeneratedRegex("^hook_(.*)$")]
    private static partial Regex HookRegex();

    [GeneratedRegex("^// @([^\\s]+) (.*)$")]
    private static partial Regex InfoHeaderRegex();
}

public enum ScriptType
{
    General,
    Hook,
    Ui
}