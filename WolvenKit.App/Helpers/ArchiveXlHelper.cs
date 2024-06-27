using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Splat;
using WolvenKit.App.Services;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Helpers;

/// <summary>
/// This class will resolve ArchiveXL dynamic variant depot paths.
/// They start with an asterisk (*) and contain substitution wildcards (<see cref="s_keysAndValues"/>).  
/// </summary>
public static partial class ArchiveXlHelper
{
    private static readonly Dictionary<string, string[]> s_keysAndValues = new()
    {
        { "{camera}", ["fpp", "tpp"] },
        { "{feet}", ["lifted", "flat", "high_heels", "flat_shoes"] },
        { "{gender}", ["m", "w"] },
        { "arms", ["base_arms", "mantis_blades", "monowire", "projectile_launch"] }, //
        { "{body}", ["base_body"] },
    };

    private static ILoggerService? s_loggerService;
    private static ILoggerService? LoggerService => s_loggerService ??= Locator.Current.GetService<ILoggerService>();

    private static IProjectManager? s_projectManager;
    private static IProjectManager? ProjectManager => s_projectManager ??= Locator.Current.GetService<IProjectManager>();

    private static int CountBraces(string depotPath)
    {
        var openBracesCount = depotPath.Count(c => c == '{');
        var closingBracesCount = depotPath.Count(c => c == '}');
        if (openBracesCount != closingBracesCount)
        {
            throw new Exception("Failed to resolve ArchiveXL substitution, no equal amount of { and }");
        }

        return openBracesCount;
    }

    private static IEnumerable<string> Substitute(string depotPath)
    {
        // Base case: if the string does not contain '{', return the string as the only element in a list
        if (!depotPath.Contains('{'))
        {
            return [depotPath];
        }

        // Find the first key in the string
        var start = depotPath.IndexOf('{');
        var end = depotPath.IndexOf('}');
        var key = depotPath.Substring(start, end - start + 1);

        // If the key is not in the dictionary, throw an exception
        if (!s_keysAndValues.TryGetValue(key, out var substitutionList))
        {
            throw new Exception($"Key {key} not found in dictionary");
        }

        // For each value of this key, replace the key in the string with the value and recursively call the function
        var results = new List<string>();
        foreach (var substitution in substitutionList)
        {
            var newPath = depotPath.Replace(key, substitution);
            results.AddRange(Substitute(newPath));
        }

        // Return the combined results
        return results;
    }

    /// <summary>
    /// Returns any existing depot path, or null. If no substitution is used, it will still check for the file's existence
    /// and return null if it can't be found. 
    /// </summary>
    public static string? GetFirstExistingPath(string? depotPath)
    {
        if (depotPath is null || ProjectManager?.ActiveProject?.ModDirectory is not string pathToArchiveFolder
                              || ProjectManager?.ActiveProject?.FileDirectory is not string pathToGameFiles)
        {
            return null;
        }

        return ResolveDynamicPaths(depotPath).FirstOrDefault((f) =>
            File.Exists(Path.Combine(pathToArchiveFolder, f)) || File.Exists(Path.Combine(pathToGameFiles, f)));
    }

    /// <summary>
    /// Returns a list with all potential substitutions. If the path doesn't enable substitution, the list will have one element.
    /// To get _any_ existing depot path, use <see cref="GetFirstExistingPath(string?)"/> instead.
    /// </summary>
    public static IEnumerable<string> ResolveDynamicPaths(string depotPath)
    {
        if (!depotPath.StartsWith('*'))
        {
            return [depotPath];
        }

        depotPath = depotPath[1..];

        var braceCount = 0;
        try
        {
            braceCount = CountBraces(depotPath);
        }
        catch (Exception err)
        {
            LoggerService?.Error(err.Message);
        }

        if (braceCount == 0)
        {
            return [depotPath];
        }

        return Substitute(depotPath);
    }
}