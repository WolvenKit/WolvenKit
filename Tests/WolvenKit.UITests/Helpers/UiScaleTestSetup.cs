using System;
using System.IO;
using System.Text.Json;

namespace WolvenKit.UITests.Helpers;

/// <summary>
/// Forces WolvenKit's UI scale (settings "Scale UI (%)") for out-of-process UI tests.
/// High scale values enlarge chrome enough that ribbon / tree action buttons can be
/// clipped or off-screen, which makes FlaUI interaction flaky.
/// </summary>
public static class UiScaleTestSetup
{
    public const int TestUiScalePercent = 100;

    private static readonly JsonWriterOptions s_writerOptions = new() { Indented = true };

    /// <summary>
    /// Writes <see cref="TestUiScalePercent"/> into AppData <c>config.json</c> if needed.
    /// </summary>
    /// <returns>
    /// Previous <c>UiScale</c> when it differed (so the caller can restore after tests),
    /// or <c>null</c> when no change was made / config was missing.
    /// </returns>
    public static int? ForceTo100Percent()
    {
        var path = GetConfigPath();
        if (!File.Exists(path))
        {
            // UI tests already require a configured install (game path, etc.).
            // With no config file there is nothing safe to patch.
            return null;
        }

        try
        {
            var json = File.ReadAllText(path);
            if (string.IsNullOrWhiteSpace(json))
            {
                return null;
            }

            using var doc = JsonDocument.Parse(json);
            int? previous = null;
            var hasUiScale = false;

            if (doc.RootElement.TryGetProperty("UiScale", out var uiScaleProp)
                && uiScaleProp.ValueKind == JsonValueKind.Number
                && uiScaleProp.TryGetInt32(out var current))
            {
                hasUiScale = true;
                if (current == TestUiScalePercent)
                {
                    return null;
                }

                previous = current;
            }

            using var stream = new MemoryStream();
            using (var writer = new Utf8JsonWriter(stream, s_writerOptions))
            {
                writer.WriteStartObject();
                foreach (var prop in doc.RootElement.EnumerateObject())
                {
                    if (prop.NameEquals("UiScale"))
                    {
                        writer.WriteNumber("UiScale", TestUiScalePercent);
                    }
                    else
                    {
                        prop.WriteTo(writer);
                    }
                }

                if (!hasUiScale)
                {
                    writer.WriteNumber("UiScale", TestUiScalePercent);
                }

                writer.WriteEndObject();
            }

            File.WriteAllBytes(path, stream.ToArray());
            return previous ?? 0;
        }
        catch
        {
            // Best effort — tests should still attempt to run.
            return null;
        }
    }

    /// <summary>
    /// Restores a previously recorded <c>UiScale</c> value after the app has exited.
    /// </summary>
    public static void Restore(int? previousUiScale)
    {
        if (previousUiScale is null)
        {
            return;
        }

        var path = GetConfigPath();
        if (!File.Exists(path))
        {
            return;
        }

        try
        {
            var json = File.ReadAllText(path);
            if (string.IsNullOrWhiteSpace(json))
            {
                return;
            }

            using var doc = JsonDocument.Parse(json);
            using var stream = new MemoryStream();
            using (var writer = new Utf8JsonWriter(stream, s_writerOptions))
            {
                writer.WriteStartObject();
                var wrote = false;
                foreach (var prop in doc.RootElement.EnumerateObject())
                {
                    if (prop.NameEquals("UiScale"))
                    {
                        writer.WriteNumber("UiScale", previousUiScale.Value);
                        wrote = true;
                    }
                    else
                    {
                        prop.WriteTo(writer);
                    }
                }

                if (!wrote)
                {
                    writer.WriteNumber("UiScale", previousUiScale.Value);
                }

                writer.WriteEndObject();
            }

            File.WriteAllBytes(path, stream.ToArray());
        }
        catch
        {
            // best effort
        }
    }

    private static string GetConfigPath() =>
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "REDModding",
            "WolvenKit",
            "config.json");
}
