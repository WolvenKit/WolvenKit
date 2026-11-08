using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Windows;
using System.Windows.Media;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Services.Themes;

/// <inheritdoc />
public sealed partial class ThemeService : IThemeService
{
    private const string BuiltInResourcePrefix = "WolvenKit.App.Resources.Themes.Builtin.";
    private const string MigratedThemeName = "Custom (migrated accent)";

    /// <summary>MahApps accent keys and the alpha used for each of them.</summary>
    private static readonly (string Key, byte Alpha)[] s_mahAppsAccentKeys =
    [
        ("MahApps.Colors.Accent", 0xFF),
        ("MahApps.Colors.Accent2", 0xCC),
        ("MahApps.Colors.Accent3", 0x99),
        ("MahApps.Colors.Accent4", 0x66),
        ("MahApps.Colors.Highlight", 0xFF),
        ("MahApps.Brushes.Accent", 0xFF),
        ("MahApps.Brushes.Accent2", 0xCC),
        ("MahApps.Brushes.Accent3", 0x99),
        ("MahApps.Brushes.Accent4", 0x66),
        ("MahApps.Brushes.Highlight", 0xFF),
    ];

    private static readonly JsonSerializerOptions s_options = new()
    {
        WriteIndented = true,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    };

    private readonly ISettingsManager _settingsManager;
    private readonly ILoggerService _loggerService;

    private readonly List<ThemeDto> _builtInThemes = [];
    private readonly List<ThemeDto> _userThemes = [];

    /// <summary>Default value of every known key, captured before the first theme is applied.</summary>
    private readonly Dictionary<string, Color> _defaults = new(StringComparer.Ordinal);

    /// <summary>true if the default resource is a Brush, false if it is a Color.</summary>
    private readonly Dictionary<string, bool> _isBrush = new(StringComparer.Ordinal);

    private ResourceDictionary? _appliedDictionary;
    private bool _isInitialized;
    private string? _currentName;

    public ThemeService(ISettingsManager settingsManager, ILoggerService loggerService)
    {
        _settingsManager = settingsManager;
        _loggerService = loggerService;
        try
        {
            Catalog = ThemeKeyCatalog.LoadEmbedded();
        }
        catch (Exception ex)
        {
            // without the key catalog themes only change the accent; WolvenKit must still start
            _loggerService.Error($"Could not load the theme key catalog: {ex.Message}");
            Catalog = new ThemeKeyCatalog();
        }

        _settingsManager.PropertyChanged += (_, e) =>
        {
            if (_isInitialized && e.PropertyName == nameof(ISettingsManager.ActiveTheme))
            {
                OnActiveThemeSettingChanged();
            }
        };
    }

    public ThemeKeyCatalog Catalog { get; }

    private string? _userThemesDirectory;

    /// <summary>Folder with the user's theme files. Settable for tests.</summary>
    public string UserThemesDirectory
    {
        get => _userThemesDirectory ??= IThemeService.GetUserThemesDir();
        set => _userThemesDirectory = value;
    }

    /// <summary>Sets the default (pre-theme) color of a key. Normally captured from the WPF resources; used by tests.</summary>
    internal void SetDefaultColor(string key, Color color, bool isBrush = true)
    {
        _defaults[key] = color;
        _isBrush[key] = isBrush;
    }

    public IReadOnlyList<ThemeDto> Themes =>
        _builtInThemes.OrderByDescending(t => t.IsDefault)
            .ThenBy(t => t.Name, StringComparer.OrdinalIgnoreCase)
            .Concat(_userThemes.OrderBy(t => t.Name, StringComparer.OrdinalIgnoreCase))
            .ToList();

    public ThemeDto Current =>
        Find(_currentName) ?? Find(IThemeService.DefaultThemeName) ?? s_fallbackTheme;

    /// <summary>Used if even the built-in themes could not be loaded: no overrides = stock WolvenKit look.</summary>
    private static readonly ThemeDto s_fallbackTheme = new() { Name = IThemeService.DefaultThemeName, IsBuiltIn = true };

    public event EventHandler? ThemesChanged;

    public event EventHandler? CurrentThemeChanging;

    public event EventHandler? CurrentThemeChanged;

    private readonly List<WeakReference<IThemeAware>> _listeners = [];

    public void Register(IThemeAware listener)
    {
        lock (_listeners)
        {
            _listeners.RemoveAll(r => !r.TryGetTarget(out _));
            _listeners.Add(new WeakReference<IThemeAware>(listener));
        }
    }

    private void NotifyListeners()
    {
        IThemeAware[] alive;
        lock (_listeners)
        {
            _listeners.RemoveAll(r => !r.TryGetTarget(out _));
            alive = [.. _listeners.Select(r => r.TryGetTarget(out var l) ? l : null).OfType<IThemeAware>()];
        }

        foreach (var listener in alive)
        {
            try
            {
                listener.OnThemeChanged();
            }
            catch (Exception ex)
            {
                _loggerService.Error($"Themes: {listener.GetType().Name} failed to update: {ex.Message}");
            }
        }
    }

    #region lifecycle

    public void Initialize()
    {
        if (_isInitialized)
        {
            return;
        }

        CaptureDefaults();
        InitializeLivePatching();
        LoadBuiltInThemes();
        LoadUserThemes();
        MigrateLegacyAccent();

        if (Find(_settingsManager.ActiveTheme) is null)
        {
            if (!string.IsNullOrEmpty(_settingsManager.ActiveTheme))
            {
                _loggerService.Warning($"Theme \"{_settingsManager.ActiveTheme}\" not found, using \"{IThemeService.DefaultThemeName}\".");
            }
            _settingsManager.ActiveTheme = IThemeService.DefaultThemeName;
        }

        _currentName = _settingsManager.ActiveTheme;

        // Safe mode: hold Shift while WolvenKit starts to use the default theme for this session
        // (e.g. when a custom theme made the UI unreadable). The saved choice is not changed.
        if (IsShiftHeld())
        {
            _loggerService.Warning($"Shift held at startup: using \"{IThemeService.DefaultThemeName}\" instead of \"{_currentName}\" for this session.");
            _currentName = IThemeService.DefaultThemeName;
        }

        try
        {
            ApplyResources(Current);
        }
        catch (Exception ex)
        {
            // a theme that breaks while being applied: fall back to the stock look (restores patched values)
            _loggerService.Error($"Theme \"{Current.Name}\" could not be applied, using \"{IThemeService.DefaultThemeName}\": {ex.Message}");
            _currentName = IThemeService.DefaultThemeName;
            ApplyResources(Current);
        }

        _isInitialized = true;
        _loggerService.Info($"Theme \"{Current.Name}\" applied.");
    }

    private static bool IsShiftHeld()
    {
        // No WPF app (unit tests): skip, so the result does not depend on the real keyboard
        // and no InputManager is created on a test thread.
        if (Application.Current is null)
        {
            return false;
        }
        try
        {
            return (System.Windows.Input.Keyboard.Modifiers & System.Windows.Input.ModifierKeys.Shift) != 0;
        }
        catch (InvalidOperationException)
        {
            return false; // not on the UI thread
        }
    }

    private void CaptureDefaults()
    {
        var app = Application.Current;
        if (app is null)
        {
            return;
        }

        var keys = Catalog.Entries.Select(e => e.Key)
            .Concat(Catalog.Entries.SelectMany(e => e.DerivedBrushes ?? []))
            .Concat(s_mahAppsAccentKeys.Select(k => k.Key));

        foreach (var key in keys)
        {
            object? resource;
            try
            {
                resource = app.TryFindResource(key);
            }
            catch (Exception ex)
            {
                // A broken resource in a dictionary (e.g. a Brush assigned to a Color) throws on first use.
                _loggerService.Debug($"Themes: resource {key} can't be created and is not themeable: {ex.Message}");
                continue;
            }

            switch (resource)
            {
                case Color color:
                    _defaults[key] = color;
                    _isBrush[key] = false;
                    break;
                case SolidColorBrush brush:
                    _defaults[key] = brush.Color;
                    _isBrush[key] = true;
                    break;
                default:
                    // Missing, or not a solid color (gradient etc.) — such keys are not themeable.
                    break;
            }
        }

        var missing = Catalog.Entries.Count(e => !_defaults.ContainsKey(e.Key));
        if (missing > 0)
        {
            _loggerService.Debug($"Themes: {missing} catalog keys have no solid color resource and will be ignored.");
        }
    }

    private void LoadBuiltInThemes()
    {
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
                _builtInThemes.Add(theme);
            }
            catch (Exception ex)
            {
                _loggerService.Error($"Could not load built-in theme {resourceName}: {ex.Message}");
            }
        }

        if (_builtInThemes.All(t => t.Name != IThemeService.DefaultThemeName))
        {
            _builtInThemes.Add(new ThemeDto { Name = IThemeService.DefaultThemeName, IsBuiltIn = true });
        }
    }

    private void LoadUserThemes()
    {
        _userThemes.Clear();
        foreach (var file in Directory.EnumerateFiles(UserThemesDirectory, "*.json"))
        {
            try
            {
                var theme = ReadThemeFile(file);
                if (Find(theme.Name) is not null)
                {
                    _loggerService.Warning($"Theme \"{theme.Name}\" from {file} is ignored: a theme with this name already exists.");
                    continue;
                }
                theme.FilePath = file;
                _userThemes.Add(theme);
            }
            catch (Exception ex)
            {
                _loggerService.Error($"Could not load theme {file}: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Before themes existed only the accent color was configurable.
    /// Turn a non-default accent into a user theme so nobody loses their color.
    /// </summary>
    private void MigrateLegacyAccent()
    {
        if (!string.IsNullOrEmpty(_settingsManager.ActiveTheme))
        {
            return;
        }

        var accent = TryParseColor(_settingsManager.ThemeAccentString);
        if (accent is null || accent.Value == IThemeService.DefaultAccent)
        {
            return;
        }

        var theme = Find(MigratedThemeName) ?? Save(new ThemeDto
        {
            Name = MigratedThemeName,
            BasedOn = IThemeService.DefaultThemeName,
            Description = "Created from the \"Theme Accent\" setting of an older WolvenKit version.",
            Accent = ToHex(accent.Value)
        });

        _settingsManager.ActiveTheme = theme.Name;
        _loggerService.Info($"Theme accent {_settingsManager.ThemeAccentString} migrated to theme \"{theme.Name}\".");
    }

    private void OnActiveThemeSettingChanged()
    {
        var name = _settingsManager.ActiveTheme;
        if (string.Equals(name, _currentName, StringComparison.Ordinal))
        {
            return;
        }
        if (Find(name) is null)
        {
            _loggerService.Warning($"Theme \"{name}\" not found.");
            return;
        }

        _currentName = name;
        ApplyCurrentDeferred();
    }

    /// <summary>
    /// Announces the change, then applies the current theme at background priority, so that a notification
    /// raised in <see cref="CurrentThemeChanging"/> is rendered before the UI thread is busy.
    /// Without a running application (tests) everything happens right away.
    /// </summary>
    private void ApplyCurrentDeferred()
    {
        CurrentThemeChanging?.Invoke(this, EventArgs.Empty);

        void Apply()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            ApplyResources(Current);
            _loggerService.Debug($"Themes: resources of \"{Current.Name}\" written in {watch.ElapsedMilliseconds} ms.");
            CurrentThemeChanged?.Invoke(this, EventArgs.Empty);
            NotifyListeners(); // already on the UI thread here
        }

        if (Application.Current?.Dispatcher is { } dispatcher)
        {
            dispatcher.BeginInvoke(System.Windows.Threading.DispatcherPriority.Background, (Action)Apply);
        }
        else
        {
            Apply();
        }
    }

    #endregion

    #region query

    public ThemeDto? Find(string? name) =>
        string.IsNullOrEmpty(name)
            ? null
            : _builtInThemes.FirstOrDefault(t => string.Equals(t.Name, name, StringComparison.OrdinalIgnoreCase))
              ?? _userThemes.FirstOrDefault(t => string.Equals(t.Name, name, StringComparison.OrdinalIgnoreCase));

    public Color? GetDefaultColor(string key) => _defaults.TryGetValue(key, out var color) ? color : null;

    /// <summary>Root-first list: [base of base, base, theme]. Guards against cycles.</summary>
    private List<ThemeDto> GetChain(ThemeDto theme)
    {
        var chain = new List<ThemeDto>();
        var visited = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        for (var t = theme; t is not null && visited.Add(t.Name); t = Find(t.BasedOn))
        {
            chain.Insert(0, t);
        }
        return chain;
    }

    public IReadOnlyDictionary<string, Color> ResolveOverrides(ThemeDto theme)
    {
        var result = new Dictionary<string, Color>(StringComparer.Ordinal);
        foreach (var t in GetChain(theme))
        {
            foreach (var (key, value) in t.Colors)
            {
                if (TryParseColor(value) is { } color)
                {
                    result[key] = color;
                }
                else
                {
                    _loggerService.Warning($"Theme \"{t.Name}\": invalid color \"{value}\" for {key}.");
                }
            }
        }
        return result;
    }

    public Color? ResolveColor(ThemeDto theme, string key) =>
        ResolveOverrides(theme).TryGetValue(key, out var color) ? color : GetDefaultColor(key);

    public Color ResolveAccent(ThemeDto theme) =>
        GetChain(theme).Select(t => TryParseColor(t.Accent)).LastOrDefault(c => c is not null)
        ?? IThemeService.DefaultAccent;

    public Color? ResolveAccentForeground(ThemeDto theme) =>
        GetChain(theme).Select(t => TryParseColor(t.AccentForeground)).LastOrDefault(c => c is not null);

    #endregion

    #region resources

    public ResourceDictionary CreateResourceDictionary(ThemeDto theme, bool complete = false)
    {
        var dictionary = new ResourceDictionary();

        // includes derived, linked (HandyControl) and accent-derived keys
        var overrides = BuildColorMap(theme);
        IEnumerable<KeyValuePair<string, Color>> palette = complete
            ? Catalog.Entries
                .Where(e => _defaults.ContainsKey(e.Key))
                .Select(e => new KeyValuePair<string, Color>(e.Key, overrides.TryGetValue(e.Key, out var c) ? c : _defaults[e.Key]))
            : overrides;

        foreach (var (key, color) in palette)
        {
            // Keys patched in their own dictionaries don't need the overlay.
            if (complete || !IsPatchedAtSource(key))
            {
                AddResource(dictionary, key, color);
            }
            foreach (var derived in Catalog.Find(key)?.DerivedBrushes ?? [])
            {
                if (complete || !IsPatchedAtSource(derived))
                {
                    AddResource(dictionary, derived, color);
                }
            }
        }

        var accent = ResolveAccent(theme);
        if (complete || accent != IThemeService.DefaultAccent)
        {
            foreach (var (key, alpha) in s_mahAppsAccentKeys)
            {
                if (complete || !IsPatchedAtSource(key))
                {
                    AddResource(dictionary, key, Color.FromArgb(alpha, accent.R, accent.G, accent.B));
                }
            }
        }

        return dictionary;
    }

    private void AddResource(ResourceDictionary dictionary, string key, Color color)
    {
        if (!_isBrush.TryGetValue(key, out var isBrush))
        {
            // unknown key: there is nothing to override
            return;
        }

        if (isBrush)
        {
            var brush = new SolidColorBrush(color);
            brush.Freeze();
            dictionary[key] = brush;
        }
        else
        {
            dictionary[key] = color;
        }
    }

    public void ApplyResources(ThemeDto theme)
    {
        var app = Application.Current;
        if (app is null)
        {
            return;
        }

        // 1) replace the values in the dictionaries that define them (reaches StaticResource lookups made later)
        ScanAll();
        PatchSources(theme);

        // 2) dictionary on top for keys that were not found in any scanned dictionary
        var dictionary = CreateResourceDictionary(theme);
        var merged = app.Resources.MergedDictionaries;

        if (_appliedDictionary is not null)
        {
            merged.Remove(_appliedDictionary);
        }

        // last merged dictionary wins the lookup
        merged.Add(dictionary);
        _appliedDictionary = dictionary;
    }

    public int Refresh()
    {
        var found = ScanAll();
        PatchSources(Current);
        EnsureResourcesOnTop();
        return found;
    }

    public void EnsureResourcesOnTop()
    {
        var merged = Application.Current?.Resources.MergedDictionaries;
        if (merged is null || _appliedDictionary is null || merged.LastOrDefault() == _appliedDictionary)
        {
            return;
        }
        merged.Remove(_appliedDictionary);
        merged.Add(_appliedDictionary);
    }

    #endregion

    #region persistence

    public void SetActive(string name)
    {
        if (Find(name) is not { } theme)
        {
            throw new ArgumentException($"Theme \"{name}\" not found.", nameof(name));
        }
        _settingsManager.ActiveTheme = theme.Name;
    }

    public string GetUniqueName(string baseName)
    {
        baseName = string.IsNullOrWhiteSpace(baseName) ? "My theme" : baseName.Trim();
        if (Find(baseName) is null)
        {
            return baseName;
        }
        for (var i = 2; ; i++)
        {
            var candidate = $"{baseName} {i}";
            if (Find(candidate) is null)
            {
                return candidate;
            }
        }
    }

    public ThemeDto Duplicate(ThemeDto source, string newName)
    {
        var copy = source.Clone();
        copy.Name = GetUniqueName(newName);
        copy.IsBuiltIn = false;
        copy.FilePath = null;

        // A copy of a built-in theme inherits from it, so later fixes of the built-in theme are picked up.
        if (source.IsBuiltIn)
        {
            copy.BasedOn = source.Name;
            copy.Colors.Clear();
            copy.Accent = null;
            copy.AccentForeground = null;
        }

        return Save(copy);
    }

    public ThemeDto Save(ThemeDto theme, string? previousName = null)
    {
        if (theme.IsBuiltIn)
        {
            throw new InvalidOperationException("Built-in themes can't be modified. Duplicate the theme first.");
        }
        if (string.IsNullOrWhiteSpace(theme.Name))
        {
            throw new ArgumentException("Theme name is empty.", nameof(theme));
        }

        theme.Name = theme.Name.Trim();
        previousName ??= theme.Name;

        var existing = Find(theme.Name);
        var previous = _userThemes.FirstOrDefault(t => string.Equals(t.Name, previousName, StringComparison.OrdinalIgnoreCase));
        if (existing is not null && existing != previous)
        {
            throw new InvalidOperationException($"A theme named \"{theme.Name}\" already exists.");
        }
        if (string.Equals(theme.BasedOn, theme.Name, StringComparison.OrdinalIgnoreCase))
        {
            theme.BasedOn = null;
        }

        var path = Path.Combine(UserThemesDirectory, ToFileName(theme.Name));
        theme.FormatVersion = ThemeDto.CurrentFormatVersion;
        File.WriteAllText(path, JsonSerializer.Serialize(theme, s_options));

        if (previous is not null)
        {
            _userThemes.Remove(previous);
            if (previous.FilePath is not null
                && !string.Equals(previous.FilePath, path, StringComparison.OrdinalIgnoreCase)
                && File.Exists(previous.FilePath))
            {
                File.Delete(previous.FilePath);
            }
            RenameReferences(previous.Name, theme.Name);
        }

        var saved = theme.Clone();
        saved.FilePath = path;
        saved.IsBuiltIn = false;
        _userThemes.Add(saved);

        ThemesChanged?.Invoke(this, EventArgs.Empty);

        var isCurrent = string.Equals(_currentName, saved.Name, StringComparison.OrdinalIgnoreCase)
                        || GetChain(Current).Any(t => string.Equals(t.Name, saved.Name, StringComparison.OrdinalIgnoreCase));
        if (_isInitialized && isCurrent)
        {
            _currentName = Current.Name;
            ApplyCurrentDeferred();
        }

        return saved;
    }

    /// <summary>Keeps the active theme and BasedOn links pointing at a renamed theme.</summary>
    private void RenameReferences(string oldName, string newName)
    {
        if (string.Equals(oldName, newName, StringComparison.Ordinal))
        {
            return;
        }

        if (string.Equals(_currentName, oldName, StringComparison.OrdinalIgnoreCase))
        {
            _currentName = newName;
            _settingsManager.ActiveTheme = newName;
        }

        foreach (var child in _userThemes.Where(t => string.Equals(t.BasedOn, oldName, StringComparison.OrdinalIgnoreCase)).ToList())
        {
            child.BasedOn = newName;
            if (child.FilePath is not null)
            {
                File.WriteAllText(child.FilePath, JsonSerializer.Serialize(child, s_options));
            }
        }
    }

    public void Delete(ThemeDto theme)
    {
        if (theme.IsBuiltIn)
        {
            throw new InvalidOperationException("Built-in themes can't be deleted.");
        }

        var stored = _userThemes.FirstOrDefault(t => string.Equals(t.Name, theme.Name, StringComparison.OrdinalIgnoreCase));
        if (stored is null)
        {
            return;
        }

        // Children keep working: they inherit what the deleted theme inherited.
        foreach (var child in _userThemes.Where(t => string.Equals(t.BasedOn, stored.Name, StringComparison.OrdinalIgnoreCase)).ToList())
        {
            var flattened = Flatten(child);
            child.BasedOn = stored.BasedOn;
            child.Colors = flattened.Colors;
            child.Accent = flattened.Accent;
            child.AccentForeground = flattened.AccentForeground;
            if (child.FilePath is not null)
            {
                File.WriteAllText(child.FilePath, JsonSerializer.Serialize(child, s_options));
            }
        }

        _userThemes.Remove(stored);
        if (stored.FilePath is not null && File.Exists(stored.FilePath))
        {
            File.Delete(stored.FilePath);
        }

        ThemesChanged?.Invoke(this, EventArgs.Empty);

        if (string.Equals(_currentName, stored.Name, StringComparison.OrdinalIgnoreCase))
        {
            _settingsManager.ActiveTheme = stored.BasedOn is not null && Find(stored.BasedOn) is not null
                ? stored.BasedOn
                : IThemeService.DefaultThemeName;
        }
    }

    public ThemeDto Import(string path)
    {
        var theme = ReadThemeFile(path);
        theme.Name = GetUniqueName(theme.Name);
        theme.IsBuiltIn = false;
        theme.FilePath = null;
        if (theme.BasedOn is not null && Find(theme.BasedOn) is null)
        {
            _loggerService.Warning($"Imported theme \"{theme.Name}\" is based on unknown theme \"{theme.BasedOn}\"; using the defaults instead.");
            theme.BasedOn = null;
        }
        return Save(theme);
    }

    public void Export(ThemeDto theme, string path, bool flatten)
    {
        var data = flatten ? Flatten(theme) : theme.Clone();
        File.WriteAllText(path, JsonSerializer.Serialize(data, s_options));
    }

    /// <summary>A copy that contains all inherited overrides and no BasedOn.</summary>
    private ThemeDto Flatten(ThemeDto theme)
    {
        var flat = theme.Clone();
        flat.BasedOn = null;
        flat.Colors = ResolveOverrides(theme).ToDictionary(kv => kv.Key, kv => ToHex(kv.Value), StringComparer.Ordinal);

        var accent = ResolveAccent(theme);
        flat.Accent = accent == IThemeService.DefaultAccent ? null : ToHex(accent);
        flat.AccentForeground = ResolveAccentForeground(theme) is { } fg ? ToHex(fg) : null;
        return flat;
    }

    private static ThemeDto ReadThemeFile(string path)
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

    #endregion

    #region helpers

    private static string ToFileName(string name)
    {
        var invalid = Path.GetInvalidFileNameChars();
        var safe = new string(name.Select(c => invalid.Contains(c) ? '_' : c).ToArray());
        return safe + ".json";
    }

    public static string ToHex(Color color) =>
        color.A == 0xFF
            ? $"#{color.R:X2}{color.G:X2}{color.B:X2}"
            : $"#{color.A:X2}{color.R:X2}{color.G:X2}{color.B:X2}";

    public static Color? TryParseColor(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }
        try
        {
            return ColorConverter.ConvertFromString(value.Trim()) is Color color ? color : null;
        }
        catch (FormatException)
        {
            return null;
        }
    }

    #endregion
}
