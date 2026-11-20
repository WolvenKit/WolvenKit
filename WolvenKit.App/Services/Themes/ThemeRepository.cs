using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Services.Themes;

/// <summary>
/// Reads and writes theme files: the built-in themes embedded in WolvenKit.App and the user's
/// <c>.json</c> themes. Contains no theme logic (names, inheritance, active theme): that is <see cref="IThemeService"/>.
/// </summary>
public interface IThemeRepository
{
    /// <summary>Folder with the user's theme files.</summary>
    string UserThemesDirectory { get; }

    /// <summary>Built-in themes, with <see cref="ThemeDto.IsBuiltIn"/> set. Broken resources are logged and skipped.</summary>
    IReadOnlyList<ThemeDto> LoadBuiltIn();

    /// <summary>Themes in <see cref="UserThemesDirectory"/>, with <see cref="ThemeDto.FilePath"/> set. Broken files are logged and skipped.</summary>
    IReadOnlyList<ThemeDto> LoadUserThemes();

    /// <summary>Reads a theme file (e.g. for import).</summary>
    /// <exception cref="InvalidDataException">The file is empty or uses a newer format.</exception>
    ThemeDto Read(string path);

    /// <summary>Writes a user theme to <see cref="UserThemesDirectory"/>, named after the theme. Returns the path.</summary>
    string Save(ThemeDto theme);

    /// <summary>Writes a theme to the given path (export, or updating an existing user theme file).</summary>
    void Write(ThemeDto theme, string path);

    /// <summary>Deletes a theme file if it exists.</summary>
    void Delete(string path);
}

/// <inheritdoc />
public sealed class ThemeRepository : IThemeRepository
{
    private const string BuiltInResourcePrefix = "WolvenKit.App.Resources.Themes.Builtin.";

    private static readonly JsonSerializerOptions s_options = new()
    {
        WriteIndented = true,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    private readonly ILoggerService _loggerService;
    private string? _userThemesDirectory;

    public ThemeRepository(ILoggerService loggerService) => _loggerService = loggerService;

    /// <summary>Uses <paramref name="userThemesDirectory"/> instead of the AppData folder (tests).</summary>
    public ThemeRepository(ILoggerService loggerService, string userThemesDirectory) : this(loggerService) =>
        _userThemesDirectory = userThemesDirectory;

    public string UserThemesDirectory => _userThemesDirectory ??= IThemeService.GetUserThemesDir();

    public IReadOnlyList<ThemeDto> LoadBuiltIn()
    {
        var themes = new List<ThemeDto>();
        var assembly = Assembly.GetExecutingAssembly();
        foreach (var resourceName in assembly.GetManifestResourceNames().Where(n => n.StartsWith(BuiltInResourcePrefix, StringComparison.Ordinal)))
        {
            try
            {
                using var stream = assembly.GetManifestResourceStream(resourceName);
                if (stream is null)
                {
                    continue;
                }
                var theme = JsonSerializer.Deserialize<ThemeDto>(stream, s_options);
                if (theme is null || string.IsNullOrWhiteSpace(theme.Name))
                {
                    continue;
                }
                theme.IsBuiltIn = true;
                theme.FilePath = null;
                themes.Add(theme);
            }
            catch (Exception ex)
            {
                _loggerService.Error($"Could not load built-in theme {resourceName}: {ex.Message}");
            }
        }
        return themes;
    }

    public IReadOnlyList<ThemeDto> LoadUserThemes()
    {
        var themes = new List<ThemeDto>();
        foreach (var file in Directory.EnumerateFiles(UserThemesDirectory, "*.json"))
        {
            try
            {
                var theme = Read(file);
                theme.FilePath = file;
                themes.Add(theme);
            }
            catch (Exception ex)
            {
                _loggerService.Error($"Could not load theme {file}: {ex.Message}");
            }
        }
        return themes;
    }

    public ThemeDto Read(string path)
    {
        var theme = JsonSerializer.Deserialize<ThemeDto>(File.ReadAllText(path), s_options)
                    ?? throw new InvalidDataException("Empty theme file.");
        if (theme.FormatVersion > ThemeDto.CurrentFormatVersion)
        {
            throw new InvalidDataException($"Theme format {theme.FormatVersion} is newer than supported ({ThemeDto.CurrentFormatVersion}).");
        }
        if (string.IsNullOrWhiteSpace(theme.Name))
        {
            theme.Name = Path.GetFileNameWithoutExtension(path);
        }
        // "colors": null in a hand-written file
        theme.Colors = theme.Colors is null
            ? new Dictionary<string, string>(StringComparer.Ordinal)
            : new Dictionary<string, string>(theme.Colors, StringComparer.Ordinal);
        return theme;
    }

    public string Save(ThemeDto theme)
    {
        var path = Path.Combine(UserThemesDirectory, ToFileName(theme.Name));
        theme.FormatVersion = ThemeDto.CurrentFormatVersion;
        Write(theme, path);
        return path;
    }

    public void Write(ThemeDto theme, string path) =>
        File.WriteAllText(path, JsonSerializer.Serialize(theme, s_options));

    public void Delete(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }

    private static string ToFileName(string name)
    {
        var invalid = Path.GetInvalidFileNameChars();
        var safe = new string(name.Select(c => invalid.Contains(c) ? '_' : c).ToArray());
        return safe + ".json";
    }
}
