using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.App.Services.Themes;

namespace WolvenKit.App.ViewModels.Dialogs;

/// <summary>
/// One color row in the theme editor.
/// </summary>
public partial class ThemeColorEntryViewModel : ObservableObject
{
    public ThemeColorEntryViewModel(ThemeKeyEntry entry, Color inherited, Color current, string? basicName = null)
    {
        Key = entry.Key;
        IsBasic = basicName is not null;
        DisplayName = basicName ?? entry.DisplayName;
        Group = IsBasic ? ThemeEditorViewModel.BasicGroup : entry.Group;
        InheritedColor = inherited;
        Color = current;
    }

    public string Key { get; }

    public string DisplayName { get; }

    public string Group { get; }

    /// <summary>One of the main colors shown in the simple view of the editor.</summary>
    public bool IsBasic { get; }

    /// <summary>Value coming from the base theme (or the WolvenKit defaults).</summary>
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsOverridden))]
    private Color _inheritedColor;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsOverridden))]
    [NotifyPropertyChangedFor(nameof(Hex))]
    private Color _color;

    public bool IsOverridden => Color != InheritedColor;

    public string Hex
    {
        get => ThemeService.ToHex(Color);
        set
        {
            if (ThemeService.TryParseColor(value) is { } color)
            {
                Color = color;
            }
            else
            {
                OnPropertyChanged(); // revert the text box
            }
        }
    }

    [RelayCommand]
    private void Reset() => Color = InheritedColor;
}

/// <summary>
/// Edits a copy of a theme. Built-in themes are never modified: editing one creates a new user theme based on it.
/// </summary>
public partial class ThemeEditorViewModel : ObservableObject
{
    private static readonly Color s_defaultAccentForeground = Colors.White;

    public const string BasicGroup = "Main colors";

    /// <summary>Colors of the simple view, in display order, with names a theme author understands.</summary>
    private static readonly (string Key, string Name)[] s_basicColors =
    [
        ("ContentBackground", "Background"),
        ("ContentBackgroundAlt", "Background 2"),
        ("ContentBackgroundAlt2", "Panels"),
        ("ContentBackgroundAlt3", "Panels, raised"),
        ("ContentBackgroundAlt4", "Hover / selection"),
        ("ContentBackgroundAlt5", "Highlight"),
        ("BorderAlt", "Borders"),
        ("ContentForeground", "Text"),
        ("ForegroundColor", "Text in WolvenKit views"),
        ("BackgroundColor_Control", "Input fields"),
        ("BackgroundColor_Frame_Background", "Frames"),
        ("BackgroundColor_Frame_Active", "Frames, active"),
        ("WolvenKitProjectSource", "Project Explorer: SOURCE"),
        ("WolvenKitProjectSourceShadow", "Project Explorer: SOURCE, dark"),
        ("WolvenKitProjectResources", "Project Explorer: RESOURCES"),
        ("WolvenKitProjectResourcesShadow", "Project Explorer: RESOURCES, dark"),
        ("WolvenKitRedColor", "Red (errors)"),
        ("WolvenKitYellowColor", "Yellow (warnings)"),
        ("WolvenKitGreenColor", "Green (success)"),
        ("WolvenKitPurpleColor", "Purple (debug)"),
        ("WolvenKitCyanColor", "Cyan"),
        ("WolvenKitOrangeColor", "Orange"),
    ];

    private readonly IThemeService _themeService;

    private readonly bool _isInitializing;

    /// <summary>Name of the stored theme this editor overwrites; null for a new theme.</summary>
    private string? _storedName;

    private Color _inheritedAccent;

    /// <summary>Not editable in the UI yet; kept so saving doesn't drop it.</summary>
    private readonly bool? _deriveNeutralColors;
    private Color _inheritedAccentForeground;

    public ThemeEditorViewModel(IThemeService themeService, ThemeDto source)
    {
        _themeService = themeService;
        _isInitializing = true;
        _deriveNeutralColors = source.IsBuiltIn ? null : source.DeriveNeutralColors;

        IsNewTheme = source.IsBuiltIn;
        SourceName = source.Name;

        if (source.IsBuiltIn)
        {
            Name = themeService.GetUniqueName($"{source.Name} (copy)");
            BasedOn = source.Name;
        }
        else
        {
            _storedName = source.Name;
            Name = source.Name;
            BasedOn = source.BasedOn ?? IThemeService.DefaultThemeName;
            Author = source.Author;
            Description = source.Description;
        }

        var baseTheme = GetBaseTheme();
        _inheritedAccent = baseTheme is null ? IThemeService.DefaultAccent : themeService.ResolveAccent(baseTheme);
        _inheritedAccentForeground = (baseTheme is null ? null : themeService.ResolveAccentForeground(baseTheme)) ?? s_defaultAccentForeground;

        var ownAccent = source.IsBuiltIn ? null : ThemeService.TryParseColor(source.Accent);
        var ownAccentForeground = source.IsBuiltIn ? null : ThemeService.TryParseColor(source.AccentForeground);
        Accent = ownAccent ?? _inheritedAccent;
        AccentForeground = ownAccentForeground ?? _inheritedAccentForeground;

        var basicOrder = s_basicColors.Select((b, i) => (b.Key, b.Name, i)).ToDictionary(b => b.Key, b => (b.Name, Index: b.i), StringComparer.Ordinal);

        // main colors first, so their group is shown on top
        foreach (var entry in themeService.Catalog.Entries
                     .OrderBy(e => basicOrder.TryGetValue(e.Key, out var b) ? b.Index : int.MaxValue))
        {
            if (themeService.GetDefaultColor(entry.Key) is not { } defaultColor)
            {
                continue; // resource does not exist in this build
            }

            var inherited = baseTheme is null ? defaultColor : themeService.ResolveColor(baseTheme, entry.Key) ?? defaultColor;
            var own = !source.IsBuiltIn && source.Colors.TryGetValue(entry.Key, out var hex) ? ThemeService.TryParseColor(hex) : null;

            var vm = new ThemeColorEntryViewModel(entry, inherited, own ?? inherited,
                basicOrder.TryGetValue(entry.Key, out var basic) ? basic.Name : null);
            vm.PropertyChanged += OnEntryChanged;
            Entries.Add(vm);
        }

        // ordered like the theme lists: default theme first
        BaseThemeNames = themeService.Themes
            .Where(t => !IsSelfOrDescendant(t))
            .Select(t => t.Name)
            .ToList();

        _isInitializing = false;
        UpdateContrastWarning();
    }

    public event EventHandler? PaletteChanged;

    public ObservableCollection<ThemeColorEntryViewModel> Entries { get; } = [];

    public IReadOnlyList<string> BaseThemeNames { get; }

    /// <summary>true when the editor was opened on a built-in theme and will create a copy.</summary>
    public bool IsNewTheme { get; private set; }

    public string SourceName { get; }

    public string Title => IsNewTheme ? $"New theme based on \"{SourceName}\"" : $"Edit theme \"{_storedName}\"";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ValidationError))]
    private string _name = "";

    [ObservableProperty]
    private string? _author;

    [ObservableProperty]
    private string? _description;

    [ObservableProperty]
    private string _basedOn = IThemeService.DefaultThemeName;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsAccentOverridden))]
    private Color _accent;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsAccentForegroundOverridden))]
    private Color _accentForeground;

    /// <summary>Also apply the edited palette to the whole application while editing.</summary>
    [ObservableProperty]
    private bool _previewInApp;

    [ObservableProperty]
    private string? _filterText;

    [ObservableProperty]
    private bool _showOnlyOverridden;

    /// <summary>Show all colors, not only the main ones.</summary>
    [ObservableProperty]
    private bool _showAdvanced;

    [ObservableProperty]
    private bool _isDirty;

    public bool IsAccentOverridden => Accent != _inheritedAccent;

    public bool IsAccentForegroundOverridden => AccentForeground != _inheritedAccentForeground;

    public int OverriddenCount => Entries.Count(e => e.IsOverridden);

    /// <summary>Text/background pairs that are hard to read (WCAG contrast ratio), or null.</summary>
    [ObservableProperty]
    private string? _contrastWarning;

    /// <summary>(label, text color key, background color key, minimum ratio)</summary>
    private static readonly (string Label, string Foreground, string Background, double Minimum)[] s_contrastPairs =
    [
        ("text on background", "ContentForeground", "ContentBackground", 4.5),
        ("text on panels", "ForegroundColor", "ContentBackgroundAlt2", 4.5),
        ("text on controls", "ForegroundColor", "BackgroundColor_Control", 4.5),
    ];

    private void UpdateContrastWarning()
    {
        var colors = Entries.ToDictionary(e => e.Key, e => e.Color, StringComparer.Ordinal);
        var problems = new List<string>();

        foreach (var (label, foreground, background, minimum) in s_contrastPairs)
        {
            if (colors.TryGetValue(foreground, out var fg) && colors.TryGetValue(background, out var bg)
                && ContrastRatio(fg, bg) is var ratio && ratio < minimum)
            {
                problems.Add($"{label} {ratio:0.0}:1");
            }
        }

        var accentRatio = ContrastRatio(AccentForeground, Accent);
        if (accentRatio < 3.0)
        {
            problems.Add($"text on accent {accentRatio:0.0}:1");
        }

        ContrastWarning = problems.Count == 0
            ? null
            : $"Low contrast: {string.Join(", ", problems)} (recommended: 4.5:1 for text, 3:1 on accent).";
    }

    /// <summary>WCAG 2 contrast ratio of two opaque colors (1 … 21).</summary>
    public static double ContrastRatio(Color a, Color b)
    {
        var la = RelativeLuminance(a);
        var lb = RelativeLuminance(b);
        return (Math.Max(la, lb) + 0.05) / (Math.Min(la, lb) + 0.05);

        static double RelativeLuminance(Color c) =>
            (0.2126 * Channel(c.R)) + (0.7152 * Channel(c.G)) + (0.0722 * Channel(c.B));

        static double Channel(byte value)
        {
            var v = value / 255.0;
            return v <= 0.03928 ? v / 12.92 : Math.Pow((v + 0.055) / 1.055, 2.4);
        }
    }

    public string? ValidationError
    {
        get
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return "Enter a theme name.";
            }
            var existing = _themeService.Find(Name.Trim());
            if (existing is not null && !string.Equals(existing.Name, _storedName, StringComparison.OrdinalIgnoreCase))
            {
                return existing.IsBuiltIn
                    ? $"\"{existing.Name}\" is a built-in theme name."
                    : $"A theme named \"{existing.Name}\" already exists.";
            }
            return null;
        }
    }

    public bool Matches(ThemeColorEntryViewModel entry)
    {
        if (ShowOnlyOverridden && !entry.IsOverridden)
        {
            return false;
        }
        if (string.IsNullOrWhiteSpace(FilterText))
        {
            // simple view: main colors, plus anything this theme already changes
            return ShowAdvanced || entry.IsBasic || entry.IsOverridden;
        }
        var filter = FilterText.Trim();
        return entry.DisplayName.Contains(filter, StringComparison.OrdinalIgnoreCase)
               || entry.Key.Contains(filter, StringComparison.OrdinalIgnoreCase)
               || entry.Group.Contains(filter, StringComparison.OrdinalIgnoreCase)
               || entry.Hex.Contains(filter, StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>The edited theme as it would be saved: only values that differ from the base theme.</summary>
    public ThemeDto BuildDefinition() => new()
    {
        Name = Name.Trim(),
        Author = string.IsNullOrWhiteSpace(Author) ? null : Author.Trim(),
        Description = string.IsNullOrWhiteSpace(Description) ? null : Description.Trim(),
        BasedOn = BasedOn,
        Accent = IsAccentOverridden ? ThemeService.ToHex(Accent) : null,
        AccentForeground = IsAccentForegroundOverridden ? ThemeService.ToHex(AccentForeground) : null,
        DeriveNeutralColors = _deriveNeutralColors,
        Colors = Entries.Where(e => e.IsOverridden)
            .ToDictionary(e => e.Key, e => ThemeService.ToHex(e.Color), StringComparer.Ordinal)
    };

    /// <summary>Saves the theme and returns the stored definition.</summary>
    public ThemeDto Save()
    {
        if (ValidationError is { } error)
        {
            throw new InvalidOperationException(error);
        }

        var saved = _themeService.Save(BuildDefinition(), _storedName);
        _storedName = saved.Name;
        IsNewTheme = false;
        IsDirty = false;
        OnPropertyChanged(nameof(Title));
        return saved;
    }

    [RelayCommand]
    private void ResetAll()
    {
        foreach (var entry in Entries)
        {
            entry.Color = entry.InheritedColor;
        }
        Accent = _inheritedAccent;
        AccentForeground = _inheritedAccentForeground;
    }

    [RelayCommand]
    private void ResetAccent() => Accent = _inheritedAccent;

    [RelayCommand]
    private void ResetAccentForeground() => AccentForeground = _inheritedAccentForeground;

    partial void OnBasedOnChanged(string value)
    {
        if (_isInitializing)
        {
            return;
        }

        var baseTheme = GetBaseTheme();

        var newAccent = baseTheme is null ? IThemeService.DefaultAccent : _themeService.ResolveAccent(baseTheme);
        var newAccentForeground = (baseTheme is null ? null : _themeService.ResolveAccentForeground(baseTheme)) ?? s_defaultAccentForeground;
        var accentWasOverridden = IsAccentOverridden;
        var accentForegroundWasOverridden = IsAccentForegroundOverridden;
        _inheritedAccent = newAccent;
        _inheritedAccentForeground = newAccentForeground;
        if (!accentWasOverridden)
        {
            Accent = newAccent;
        }
        if (!accentForegroundWasOverridden)
        {
            AccentForeground = newAccentForeground;
        }
        OnPropertyChanged(nameof(IsAccentOverridden));
        OnPropertyChanged(nameof(IsAccentForegroundOverridden));

        foreach (var entry in Entries)
        {
            var wasOverridden = entry.IsOverridden;
            var inherited = (baseTheme is null ? null : _themeService.ResolveColor(baseTheme, entry.Key))
                            ?? _themeService.GetDefaultColor(entry.Key)
                            ?? entry.InheritedColor;
            entry.InheritedColor = inherited;
            if (!wasOverridden)
            {
                entry.Color = inherited;
            }
        }

        RaisePaletteChanged();
    }

    partial void OnAccentChanged(Color value) => RaisePaletteChanged();

    partial void OnAccentForegroundChanged(Color value) => RaisePaletteChanged();

    partial void OnNameChanged(string value) => MarkDirty();

    partial void OnAuthorChanged(string? value) => MarkDirty();

    partial void OnDescriptionChanged(string? value) => MarkDirty();

    private void MarkDirty()
    {
        if (!_isInitializing)
        {
            IsDirty = true;
        }
    }

    private void OnEntryChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(ThemeColorEntryViewModel.Color))
        {
            RaisePaletteChanged();
        }
    }

    private void RaisePaletteChanged()
    {
        if (_isInitializing)
        {
            return;
        }

        IsDirty = true;
        OnPropertyChanged(nameof(OverriddenCount));
        UpdateContrastWarning();
        PaletteChanged?.Invoke(this, EventArgs.Empty);
    }

    private ThemeDto? GetBaseTheme() => _themeService.Find(BasedOn);

    /// <summary>A theme can't be based on itself or on a theme that inherits from it.</summary>
    private bool IsSelfOrDescendant(ThemeDto theme)
    {
        if (_storedName is null)
        {
            return false;
        }
        var visited = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        for (var t = theme; t is not null && visited.Add(t.Name); t = _themeService.Find(t.BasedOn))
        {
            if (string.Equals(t.Name, _storedName, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }
}
