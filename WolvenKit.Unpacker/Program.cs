using System.CommandLine;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using System.Diagnostics;

namespace WolvenKit.Unpacker;

public class Program
{
    public static async Task<int> Main(string[] args)
    {
        var wolvenKitExePathOption = new Option<string>(
            aliases: new[] { "--wolvenkit-exe-path" },
            description: "Path to the WolvenKit.exe to be overwritten.") { IsRequired = true };

        var unzippedPathOption = new Option<string>(
            aliases: new[] { "--unzipped-path" },
            description: "Path to the unzipped WolvenKit.exe to be copied from.") { IsRequired = true };

        var rootCommand = new RootCommand
        {
            wolvenKitExePathOption,
            unzippedPathOption
        };

        var wolvenKitArgs = GetRemainingArgs(args);
        rootCommand.SetHandler(
            (wolvenKitExePath, unzippedPath) =>
                UpdateWolvenKitExe(wolvenKitExePath, unzippedPath, wolvenKitArgs),
            wolvenKitExePathOption,
            unzippedPathOption);

        var builder = new CommandLineBuilder(rootCommand).UseDefaults();

        var parser = builder.Build();
        return await parser.InvokeAsync(args);
    }

    private static async Task UpdateWolvenKitExe(string wolvenKitExePath, string unzippedPath, string wolvenKitArgs)
    {
        while (IsProcessRunningByPath(wolvenKitExePath))
        {
            await Task.Delay(100);
        }

        MoveDirectoryWithOverwrite(unzippedPath, Path.GetDirectoryName(wolvenKitExePath)!);
        Process.Start(new ProcessStartInfo(wolvenKitExePath, wolvenKitArgs));
        Environment.Exit(0);
    }

    private static bool IsProcessRunningByPath(string path) => Process.GetProcessesByName(Path.GetFileNameWithoutExtension(path)).Any();

    private static void MoveDirectoryWithOverwrite(string source, string destination)
    {
        if (!Directory.Exists(source))
        {
            throw new DirectoryNotFoundException($"Source directory '{source}' does not exist or could not be found.");
        }

        foreach (var file in Directory.GetFiles(source, "*", SearchOption.AllDirectories))
        {
            var destFile = Path.Combine(destination, Path.GetFileName(file));

            Directory.CreateDirectory(Path.GetDirectoryName(destFile)!);
            File.Move(file, destFile, true);
        }
        Directory.Delete(source, true);
    }

    private static string GetRemainingArgs(string[] args)
    {
        var remainingArgs = new List<string>();

        for (var i = 0; i < args.Length; i++)
        {
            if (args[i] is "--wolvenkit-exe-path" or "--unzipped-path")
            {
                i++; // Skip the option's value
                continue;
            }

            remainingArgs.Add(args[i]);
        }

        return string.Join(' ', remainingArgs);
    }
}
