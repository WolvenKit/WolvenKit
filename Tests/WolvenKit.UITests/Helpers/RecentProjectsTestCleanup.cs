using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace WolvenKit.UITests.Helpers;

/// <summary>
/// Removes test projects from the Welcome page recent/pinned list
/// (<c>recentItems.json</c> under WolvenKit app data).
/// UI tests launch WolvenKit.exe out-of-process, so cleanup edits the on-disk
/// app-data files directly after the process exits.
/// </summary>
public static class RecentProjectsTestCleanup
{
    private static readonly JsonSerializerOptions s_jsonOptions = new()
    {
        WriteIndented = true,
        PropertyNameCaseInsensitive = true,
    };

    /// <summary>
    /// Drops any recent/pinned entries whose project path is under
    /// <paramref name="projectRootOrFile"/>, and clears
    /// <c>LastUsedProjectPath</c> in config when it matches.
    /// </summary>
    public static void RemoveProjectsUnder(string projectRootOrFile)
    {
        if (string.IsNullOrWhiteSpace(projectRootOrFile))
        {
            return;
        }

        try
        {
            var root = Path.GetFullPath(projectRootOrFile);
            RemoveFromRecentItems(root);
            ClearLastUsedProjectPathIfUnder(root);
        }
        catch
        {
            // best effort — cleanup must not fail the test run
        }
    }

    private static string GetAppDataDir() =>
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "REDModding",
            "WolvenKit");

    private static void RemoveFromRecentItems(string root)
    {
        var path = Path.Combine(GetAppDataDir(), "recentItems.json");
        if (!File.Exists(path))
        {
            return;
        }

        var json = File.ReadAllText(path);
        if (string.IsNullOrWhiteSpace(json))
        {
            return;
        }

        var items = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json, s_jsonOptions);
        if (items is null || items.Count == 0)
        {
            return;
        }

        var keysToRemove = items.Keys
            .Where(key => IsPathUnderRoot(key, root))
            .ToList();

        if (keysToRemove.Count == 0)
        {
            return;
        }

        foreach (var key in keysToRemove)
        {
            items.Remove(key);
        }

        File.WriteAllText(path, JsonSerializer.Serialize(items, s_jsonOptions));
    }

    private static void ClearLastUsedProjectPathIfUnder(string root)
    {
        var path = Path.Combine(GetAppDataDir(), "config.json");
        if (!File.Exists(path))
        {
            return;
        }

        var json = File.ReadAllText(path);
        if (string.IsNullOrWhiteSpace(json))
        {
            return;
        }

        using var doc = JsonDocument.Parse(json);
        if (!doc.RootElement.TryGetProperty("LastUsedProjectPath", out var lastUsedProp)
            || lastUsedProp.ValueKind != JsonValueKind.String)
        {
            return;
        }

        var lastUsed = lastUsedProp.GetString();
        if (string.IsNullOrEmpty(lastUsed) || !IsPathUnderRoot(lastUsed, root))
        {
            return;
        }

        using var stream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true }))
        {
            writer.WriteStartObject();
            foreach (var prop in doc.RootElement.EnumerateObject())
            {
                if (prop.NameEquals("LastUsedProjectPath"))
                {
                    writer.WriteNull("LastUsedProjectPath");
                }
                else
                {
                    prop.WriteTo(writer);
                }
            }

            writer.WriteEndObject();
        }

        File.WriteAllBytes(path, stream.ToArray());
    }

    private static bool IsPathUnderRoot(string candidate, string root)
    {
        try
        {
            var fullCandidate = Path.GetFullPath(candidate);
            var fullRoot = Path.GetFullPath(root);

            if (string.Equals(fullCandidate, fullRoot, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            var rootPrefix = fullRoot.TrimEnd(
                Path.DirectorySeparatorChar,
                Path.AltDirectorySeparatorChar)
                + Path.DirectorySeparatorChar;

            return fullCandidate.StartsWith(rootPrefix, StringComparison.OrdinalIgnoreCase);
        }
        catch
        {
            return false;
        }
    }
}
