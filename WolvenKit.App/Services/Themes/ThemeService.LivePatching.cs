using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace WolvenKit.App.Services.Themes;

/// <summary>
/// Replaces theme colors in the resource dictionaries that define them.
/// <para>
/// Brushes in application resources are frozen by WPF on first access, so they can't be recolored in place.
/// And a dictionary merged on top does not reach <c>StaticResource</c> lookups inside other dictionaries
/// (Syncfusion control templates, styles in App.Styles.xaml): those resolve within their own dictionary first.
/// So the value is replaced in the defining dictionary itself. Everything that reads it afterwards — and every
/// <c>DynamicResource</c> consumer — gets the theme color. Elements created earlier keep their old brush
/// until they are recreated (i.e. a restart applies a theme completely).
/// </para>
/// </summary>
public sealed partial class ThemeService
{
    private const string SyncfusionGroup = "Surfaces";

    /// <summary>Original value of each patched (dictionary, key).</summary>
    private readonly ConditionalWeakTable<ResourceDictionary, Dictionary<string, object>> _originalValues = new();

    /// <summary>Dictionaries whose own keys were already scanned.</summary>
    private readonly ConditionalWeakTable<ResourceDictionary, object> _scannedDictionaries = new();

    /// <summary>Dictionary → the dictionary it is merged into (null for Application/Window resources).</summary>
    private readonly ConditionalWeakTable<ResourceDictionary, ResourceDictionary> _parentOf = new();

    /// <summary>
    /// Dictionary → its top-level ancestor (a direct merged child of Application/Window resources).
    /// Writes are batched per top-level dictionary, which is detached while it is modified.
    /// </summary>
    private readonly ConditionalWeakTable<ResourceDictionary, ResourceDictionary> _rootOf = new();

    /// <summary>Read-only dictionary → writable dictionary merged right after it, holding the theme values.</summary>
    private readonly ConditionalWeakTable<ResourceDictionary, ResourceDictionary> _shadowOf = new();

    /// <summary>Shadow dictionaries created by the service (never scanned).</summary>
    private readonly ConditionalWeakTable<ResourceDictionary, object> _shadows = new();

    /// <summary>Resource key → dictionaries that define it.</summary>
    private readonly Dictionary<string, List<WeakReference<ResourceDictionary>>> _sources = new(StringComparer.Ordinal);

    /// <summary>Keys to look for in resource dictionaries.</summary>
    private readonly HashSet<string> _patchKeys = new(StringComparer.Ordinal);

    private int _unpatchable;

    private ThemeDto? _patchedTheme;
    private DispatcherTimer? _rescanTimer;
    private bool _summaryLogged;

    private void InitializeLivePatching()
    {
        foreach (var entry in Catalog.Entries)
        {
            _patchKeys.Add(entry.Key);
            foreach (var derived in entry.DerivedBrushes ?? [])
            {
                _patchKeys.Add(derived);
            }
        }
        foreach (var (key, _) in s_mahAppsAccentKeys)
        {
            _patchKeys.Add(key);
        }
        foreach (var key in s_compositeKeys)
        {
            _patchKeys.Add(key);
        }

        if (Application.Current is null)
        {
            return; // no UI (unit tests)
        }

        // Syncfusion merges the dictionaries of a control type the first time such a control is created.
        // Patch them as soon as new views appear.
        _rescanTimer = new DispatcherTimer(DispatcherPriority.Loaded) { Interval = TimeSpan.FromMilliseconds(50) };
        _rescanTimer.Tick += (_, _) =>
        {
            _rescanTimer.Stop();
            RescanAndPatch();
        };

        EventManager.RegisterClassHandler(typeof(Window), FrameworkElement.LoadedEvent, new RoutedEventHandler(OnElementLoaded));
        EventManager.RegisterClassHandler(typeof(UserControl), FrameworkElement.LoadedEvent, new RoutedEventHandler(OnElementLoaded));
    }

    private void OnElementLoaded(object sender, RoutedEventArgs e)
    {
        // Many views merge their own copy of the HandyControl theme (<hc:ThemeResources/> in
        // UserControl.Resources). Patch those local dictionaries right away; HandyControl styles use
        // DynamicResource, so the view picks the colors up immediately.
        if (_patchedTheme is not null && sender is FrameworkElement element && HasOwnResources(element))
        {
            if (ScanDictionary(element.Resources, null, null, false) > 0)
            {
                PatchSources(_patchedTheme);
            }
        }

        if (_rescanTimer is { IsEnabled: false })
        {
            _rescanTimer.Start();
        }
    }

    /// <summary>
    /// Views and dialogs of WolvenKit itself. FrameworkElement.Resources creates an empty dictionary on first
    /// access, so it is only touched for these (not for every small UserControl like icons).
    /// </summary>
    private static bool HasOwnResources(FrameworkElement element)
    {
        var type = element.GetType();
        return type.Namespace?.StartsWith("WolvenKit.Views", StringComparison.Ordinal) == true
               && (type.Name.EndsWith("View", StringComparison.Ordinal)
                   || type.Name.EndsWith("Dialog", StringComparison.Ordinal)
                   || type.Name.EndsWith("Window", StringComparison.Ordinal))
               && (element.Resources.Count > 0 || element.Resources.MergedDictionaries.Count > 0);
    }

    private void RescanAndPatch()
    {
        var found = ScanAll();
        if (found > 0 && _patchedTheme is not null)
        {
            PatchSources(_patchedTheme);
            if (_summaryLogged)
            {
                _loggerService.Debug($"Themes: patched {found} entries of dictionaries loaded later (controls created before keep old colors until restart).");
            }
        }

        if (!_summaryLogged && Application.Current?.MainWindow is { IsLoaded: true })
        {
            _summaryLogged = true;
            LogPatchSummary();
        }
    }

    private void LogPatchSummary()
    {
        var dictionaries = _sources.Values.SelectMany(l => l).Count();
        var syncfusionKeys = Catalog.Entries.Count(e => e.Group == SyncfusionGroup);
        _loggerService.Debug($"Themes: {_sources.Count} keys found in {dictionaries} dictionary entries ({syncfusionKeys} Syncfusion surface keys). Current theme: \"{Current.Name}\".");

        var missing = Catalog.Entries.Where(e => !_sources.ContainsKey(e.Key)).Select(e => e.Key).OrderBy(k => k).ToList();
        if (missing.Count > 0)
        {
            _loggerService.Debug($"Themes: {missing.Count} catalog keys not found in any dictionary: {string.Join(", ", missing.Take(30))}{(missing.Count > 30 ? ", …" : "")}");
        }
    }

    /// <summary>Walks application and window resources; returns the number of newly found (dictionary, key) pairs.</summary>
    private int ScanAll()
    {
        var app = Application.Current;
        if (app is null)
        {
            return 0;
        }

        var found = ScanDictionary(app.Resources, null, null, false);
        foreach (Window window in app.Windows)
        {
            found += ScanDictionary(window.Resources, null, null, false);
        }
        return found;
    }

    private int ScanDictionary(ResourceDictionary dictionary, ResourceDictionary? parent, ResourceDictionary? root, bool insideSyncfusionBrushes)
    {
        if (ReferenceEquals(dictionary, _appliedDictionary) || _shadows.TryGetValue(dictionary, out _))
        {
            return 0;
        }

        if (parent is not null)
        {
            _parentOf.AddOrUpdate(dictionary, parent);
        }
        if (root is not null)
        {
            _rootOf.AddOrUpdate(dictionary, root);
        }

        var isProvider = IsSyncfusionProvider(dictionary, out var providerName);
        var isSyncfusionBrushes = insideSyncfusionBrushes
                                  || (isProvider && string.Equals(providerName, "Brushes", StringComparison.OrdinalIgnoreCase))
                                  || IsSyncfusionBrushesSource(dictionary);
        var found = 0;

        // Own keys of a dictionary don't change after loading; merged dictionaries do (Syncfusion adds them lazily).
        if (!_scannedDictionaries.TryGetValue(dictionary, out _))
        {
            _scannedDictionaries.Add(dictionary, new object());

            if (isSyncfusionBrushes)
            {
                DiscoverSyncfusionBrushes(dictionary);
            }

            // ResourceDictionary.Contains also looks into merged dictionaries; only own keys are sources.
            foreach (var key in dictionary.Keys.OfType<string>().Where(_patchKeys.Contains).ToList())
            {
                if (Register(dictionary, key))
                {
                    found++;
                }
            }
        }

        foreach (var merged in dictionary.MergedDictionaries.ToList())
        {
            // children of Application/Window resources are the roots of their subtrees
            found += ScanDictionary(merged, dictionary, root ?? merged, isSyncfusionBrushes);
        }

        return found;
    }

    /// <summary>
    /// Syncfusion's ResourceDictionaryProvider (DictionaryName "Brushes" holds the theme brushes).
    /// Its keys are not known at compile time, so they are added to the catalog (group "Surfaces") when found.
    /// </summary>
    private static bool IsSyncfusionProvider(ResourceDictionary dictionary, out string? dictionaryName)
    {
        dictionaryName = null;
        var type = dictionary.GetType();
        if (!type.Name.Contains("ResourceDictionaryProvider", StringComparison.Ordinal))
        {
            return false;
        }
        dictionaryName = type.GetProperty("DictionaryName")?.GetValue(dictionary) as string;
        return true;
    }

    /// <summary>The shared brush dictionary of the Syncfusion theme, e.g. /Syncfusion.Themes.MaterialDark.WPF;component/Common/Brushes.xaml.</summary>
    private static bool IsSyncfusionBrushesSource(ResourceDictionary dictionary)
    {
        var source = dictionary.Source?.OriginalString;
        return source is not null
               && source.Contains("Syncfusion.Themes.", StringComparison.OrdinalIgnoreCase)
               && source.EndsWith("/Common/Brushes.xaml", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsReadOnly(ResourceDictionary dictionary) => ((System.Collections.IDictionary)dictionary).IsReadOnly;

    private void DiscoverSyncfusionBrushes(ResourceDictionary dictionary)
    {
        foreach (var key in dictionary.Keys.OfType<string>().ToList())
        {
            if (_patchKeys.Contains(key) || TryGetValue(dictionary, key) is not SolidColorBrush brush)
            {
                continue;
            }

            _patchKeys.Add(key);
            _defaults.TryAdd(key, new DefaultResource(brush.Color, ThemeKeyKind.Brush));
            Catalog.AddEntry(new ThemeKeyEntry
            {
                Key = key,
                Group = SyncfusionGroup,
                DisplayName = Humanize(key),
                Kind = ThemeKeyKind.Brush
            });
        }
    }

    /// <summary>Remembers that <paramref name="dictionary"/> defines <paramref name="key"/> and its original value.</summary>
    private bool Register(ResourceDictionary dictionary, string key)
    {
        var value = TryGetValue(dictionary, key);
        var isComposite = value is DrawingBrush && s_compositeKeys.Contains(key);
        if (value is null || (value is not (SolidColorBrush or Color) && !isComposite))
        {
            return false; // gradient, style, broken resource, ...
        }

        var originals = _originalValues.GetOrCreateValue(dictionary);
        if (!originals.TryAdd(key, value))
        {
            return false;
        }

        if (!_sources.TryGetValue(key, out var list))
        {
            list = [];
            _sources[key] = list;
        }
        list.Add(new WeakReference<ResourceDictionary>(dictionary));
        return true;
    }

    /// <summary>Resource key → target color for a theme (derived brushes follow their color key).</summary>
    internal Dictionary<string, Color> BuildColorMap(ThemeDto theme)
    {
        var overrides = ResolveOverrides(theme);
        var map = new Dictionary<string, Color>(overrides, StringComparer.Ordinal);

        // variants (dark / translucent / duplicate keys) follow their main color unless the theme sets them
        AddDerivedColors(map);

        foreach (var (key, color) in map.ToList())
        {
            foreach (var derived in Catalog.Find(key)?.DerivedBrushes ?? [])
            {
                map.TryAdd(derived, color);
            }
        }

        // former hardcoded panel colors follow the Syncfusion surfaces
        foreach (var (target, source) in s_surfaceLinks)
        {
            if (map.TryGetValue(source, out var color))
            {
                map.TryAdd(target, color);
            }
        }

        // HandyControl (search bars, default buttons, dialogs) follows the Syncfusion surfaces
        foreach (var (stem, source) in s_handyControlLinks)
        {
            if (map.TryGetValue(source, out var color))
            {
                map.TryAdd(stem + "Color", color);
                map.TryAdd(stem + "Brush", color);
            }
        }

        var accent = ResolveAccent(theme);
        if (accent != IThemeService.DefaultAccent)
        {
            foreach (var (key, alpha) in s_mahAppsAccentKeys)
            {
                map[key] = Color.FromArgb(alpha, accent.R, accent.G, accent.B);
            }

            // explicit theme values win (TryAdd)
            var shadow = Darken(accent, 0.67);
            map.TryAdd("WolvenKitAccent", accent);
            map.TryAdd("WolvenKitAccentShadow", shadow);
            map.TryAdd("WolvenKitStatusBarReady", shadow);
            map.TryAdd("PrimaryColor", accent);
            map.TryAdd("PrimaryBrush", accent);
            map.TryAdd("DarkPrimaryColor", shadow);
            map.TryAdd("DarkPrimaryBrush", shadow);
        }

        if (ResolveAccentForeground(theme) is { } accentForeground)
        {
            map.TryAdd("WolvenKitAccentForeground", accentForeground);
        }

        // text on colored surfaces stays readable when the theme changes the surface but not the text
        foreach (var (target, surface) in s_readableTextLinks)
        {
            if (!map.ContainsKey(target) && map.TryGetValue(surface, out var background))
            {
                var text = map.TryGetValue("ContentForeground", out var fg) ? fg : GetDefaultColor("ContentForeground") ?? Colors.White;
                var readable = ContrastRatio(Colors.White, background) >= ContrastRatio(text, background) ? Colors.White : text;
                map[target] = readable;
                foreach (var derived in Catalog.Find(target)?.DerivedBrushes ?? [])
                {
                    map.TryAdd(derived, readable);
                }
            }
        }

        return map;
    }

    /// <summary>Main color key → keys derived from it (dark, translucent and duplicate variants).</summary>
    private static readonly (string Target, string Source, Func<Color, Color> Derive)[] s_derivedColors =
    [
        // duplicates
        ("ForegroundColor", "ContentForeground", c => c),
        ("BackgroundColor_Frame_Background", "ContentBackgroundAlt", c => c),
        ("BackgroundColor_Frame_Active", "ContentBackgroundAlt2", c => c),
        ("WolvenKitSeparator", "BorderAlt", c => c),
        ("WolvenKitSearchBorder", "BorderAlt", c => c),
        ("WolvenKitButtonBorder", "BorderAlt", c => c),
        ("WolvenKitButtonBackground", "ContentBackgroundAlt3", c => c),
        ("WolvenKitListSelection", "ContentBackgroundAlt5", c => c),
        ("WolvenKitActionText", "WolvenKitYellowColor", c => c),
        ("WolvenKitFolderColor", "WolvenKitTanColor", c => c),
        ("WolvenKitProjectIconYellow", "WolvenKitYellowColor", c => c),
        ("WolvenKitProjectIconCyan", "WolvenKitCyanColor", c => c),
        ("WolvenKitProjectIconRed", "WolvenKitRedColor", c => c),
        ("WolvenKitProjectIconPurple", "WolvenKitPurpleColor", c => c),
        ("WolvenKitProjectIconTan", "WolvenKitTanColor", c => c),

        // dark variants
        ("WolvenKitRedShadowColor", "WolvenKitRedColor", c => Darken(c, 0.67)),
        ("WolvenKitGreenShadowColor", "WolvenKitGreenColor", c => Darken(c, 0.67)),
        ("WolvenKitCyanShadowColor", "WolvenKitCyanColor", c => Darken(c, 0.6)),
        ("WolvenKitYellowShadowColor", "WolvenKitYellowColor", c => Darken(c, 0.67)),
        ("WolvenKitOrangeShadowColor", "WolvenKitOrangeColor", c => Darken(c, 0.55)),
        ("WolvenKitProjectSourceShadow", "WolvenKitProjectSource", c => Darken(c, 0.67)),
        ("WolvenKitProjectResourcesShadow", "WolvenKitProjectResources", c => Darken(c, 0.67)),

        // translucent variants (after the dark variants they are based on)
        ("WolvenKitRedShadow50Color", "WolvenKitRedShadowColor", c => WithAlpha(c, 0x7F)),
        ("WolvenKitRedShadow25Color", "WolvenKitRedShadowColor", c => WithAlpha(Darken(c, 0.55), 0x7F)),
        ("WolvenKitCyanShadow50Color", "WolvenKitCyanShadowColor", c => WithAlpha(c, 0x7F)),
        ("WolvenKitCyanShadow25Color", "WolvenKitCyanShadowColor", c => WithAlpha(Darken(c, 0.55), 0x7F)),
        ("WolvenKitYellowShadow50Color", "WolvenKitYellowShadowColor", c => WithAlpha(c, 0x7F)),
        ("WolvenKitYellowShadow25Color", "WolvenKitYellowShadowColor", c => WithAlpha(Darken(c, 0.55), 0x7F)),
        ("WolvenKitCyan50", "WolvenKitCyanColor", c => WithAlpha(c, 0x7F)),
        ("WolvenKitTan50", "WolvenKitTanColor", c => WithAlpha(c, 0x7F)),
    ];

    /// <summary>Text key → the colored surface it is drawn on.</summary>
    private static readonly (string Target, string Surface)[] s_readableTextLinks =
    [
        ("WolvenKitAccentShadowForeground", "WolvenKitAccentShadow"),
        ("WolvenKitPanelHeaderSelectedForeground", "WolvenKitPanelHeaderSelected"),
    ];

    /// <summary>The key another key follows when a theme does not set it (shown in the theme editor), or null.</summary>
    public static string? GetLinkedSource(string key) =>
        s_derivedColors.FirstOrDefault(d => d.Target == key).Source
        ?? s_readableTextLinks.FirstOrDefault(d => d.Target == key).Surface
        ?? s_surfaceLinks.FirstOrDefault(d => d.Target == key).Source;

    /// <summary>Adds the derived variants of every main color the map contains (explicit values win).</summary>
    private static void AddDerivedColors(Dictionary<string, Color> map)
    {
        foreach (var (target, source, derive) in s_derivedColors)
        {
            if (map.TryGetValue(source, out var color))
            {
                map.TryAdd(target, derive(color));
            }
        }
    }

    private static Color WithAlpha(Color color, byte alpha) => Color.FromArgb(alpha, color.R, color.G, color.B);

    /// <summary>WCAG 2 contrast ratio of two colors (1 … 21), alpha ignored.</summary>
    internal static double ContrastRatio(Color a, Color b)
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

    /// <summary>
    /// Maps neutral (gray) colors into the theme's palette. Anchors are the gray default colors the theme
    /// sets explicitly (e.g. ContentBackground #212121 → #131C22). Another gray is interpolated between the
    /// two anchors around its brightness, so popups, separators, hover states etc. get the same tint.
    /// Colored values (accent, errors, …) are left alone. Returns null if the theme has fewer than two anchors.
    /// </summary>
    internal Func<Color, Color>? BuildNeutralMapper(ThemeDto theme)
    {
        if (GetChain(theme).Any(t => t.DeriveNeutralColors == false))
        {
            return null;
        }

        var anchors = new SortedList<double, (Color From, Color To)>();
        foreach (var (key, to) in ResolveOverrides(theme))
        {
            if (!_defaults.TryGetValue(key, out var resource))
            {
                continue;
            }
            var from = resource.Color;
            if (from.A != 0xFF || to.A != 0xFF || !IsNeutral(from))
            {
                continue;
            }
            anchors.TryAdd(Luma(from), (from, to));
        }
        if (anchors.Count < 2)
        {
            return null;
        }

        var keys = anchors.Keys.ToArray();
        var values = anchors.Values.ToArray();

        return color =>
        {
            if (!IsNeutral(color))
            {
                return color;
            }

            var luma = Luma(color);
            Color mapped;
            if (luma <= keys[0])
            {
                mapped = Shift(color, values[0]);
            }
            else if (luma >= keys[^1])
            {
                mapped = Shift(color, values[^1]);
            }
            else
            {
                var i = 0;
                while (keys[i + 1] < luma)
                {
                    i++;
                }
                var t = (luma - keys[i]) / (keys[i + 1] - keys[i]);
                mapped = Lerp(values[i].To, values[i + 1].To, t);
            }
            return Color.FromArgb(color.A, mapped.R, mapped.G, mapped.B);
        };
    }

    private static bool IsNeutral(Color c) => Math.Max(c.R, Math.Max(c.G, c.B)) - Math.Min(c.R, Math.Min(c.G, c.B)) <= 12;

    private static double Luma(Color c) => (0.2126 * c.R) + (0.7152 * c.G) + (0.0722 * c.B);

    private static Color Shift(Color c, (Color From, Color To) anchor) => Color.FromRgb(
        ClampByte(c.R + anchor.To.R - anchor.From.R),
        ClampByte(c.G + anchor.To.G - anchor.From.G),
        ClampByte(c.B + anchor.To.B - anchor.From.B));

    private static Color Lerp(Color a, Color b, double t) => Color.FromRgb(
        ClampByte(a.R + ((b.R - a.R) * t)),
        ClampByte(a.G + ((b.G - a.G) * t)),
        ClampByte(a.B + ((b.B - a.B) * t)));

    private static byte ClampByte(double v) => (byte)Math.Clamp(Math.Round(v), 0, 255);

    /// <summary>WolvenKit panel key → Syncfusion key it follows when a theme does not set it.</summary>
    private static readonly (string Target, string Source)[] s_surfaceLinks =
    [
        ("WolvenKitPanelHeaderSelected", "ContentBackgroundAlt"),
        ("WolvenKitPanelTabSelected", "ContentBackgroundAlt4"),
        ("WolvenKitPanelLogBackground", "ContentBackground"),
        ("WolvenKitPanelCardHover", "ContentBackgroundAlt3"),
        ("WolvenKitPanelProgressTrack", "ContentBackground"),
    ];

    /// <summary>HandyControl palette stem → Syncfusion key it follows when a theme does not set it.</summary>
    private static readonly (string Stem, string Source)[] s_handyControlLinks =
    [
        ("Region", "ContentBackground"),
        ("Background", "ContentBackground"),
        ("SecondaryRegion", "ContentBackgroundAlt2"),
        ("ThirdlyRegion", "ContentBackgroundAlt3"),
        ("Default", "ContentBackgroundAlt2"),
        ("DarkDefault", "ContentBackgroundAlt3"),
        ("Border", "BorderAlt"),
        ("SecondaryBorder", "BorderAlt"),
        ("PrimaryText", "ContentForeground"),
        ("Title", "ContentBackgroundAlt"),
        ("SecondaryTitle", "ContentBackgroundAlt2"),
    ];

    private static Color Darken(Color color, double factor) =>
        Color.FromArgb(color.A, (byte)(color.R * factor), (byte)(color.G * factor), (byte)(color.B * factor));

    private const int MinOperationsToDetach = 8;

    /// <summary>
    /// Writes the theme color (or the original value) into every dictionary that defines a key.
    /// Read-only dictionaries get a writable shadow dictionary merged right after them.
    /// </summary>
    private void PatchSources(ThemeDto theme)
    {
        _patchedTheme = theme;
        var map = BuildColorMap(theme);
        var neutralMapper = BuildNeutralMapper(theme);

        // root (null = write directly) → pending operations
        var batches = new Dictionary<ResourceDictionary, List<Action>>(ReferenceEqualityComparer.Instance);
        // read-only dictionary → values to write while it is temporarily unlocked
        var readOnlyWrites = new Dictionary<ResourceDictionary, List<(string Key, object Value)>>(ReferenceEqualityComparer.Instance);
        var direct = new List<Action>();
        var afterReattach = new List<Action>();

        foreach (var (key, list) in _sources)
        {
            var hasTarget = map.TryGetValue(key, out var target);
            list.RemoveAll(r => !r.TryGetTarget(out _));

            foreach (var reference in list)
            {
                if (!reference.TryGetTarget(out var dictionary)
                    || !_originalValues.TryGetValue(dictionary, out var originals)
                    || !originals.TryGetValue(key, out var original))
                {
                    continue;
                }

                var readOnly = IsReadOnly(dictionary);
                object desired = hasTarget ? (original is Color ? (object)target : CreateBrush(target)) : original;
                if (original is DrawingBrush drawingBrush)
                {
                    desired = Recolor(drawingBrush, map, neutralMapper);
                }
                if (!hasTarget && neutralMapper is not null && original is not DrawingBrush)
                {
                    desired = original switch
                    {
                        Color c when neutralMapper(c) is var mc && mc != c => mc,
                        SolidColorBrush b when neutralMapper(b.Color) is var mb && mb != b.Color => CreateBrush(mb),
                        _ => original
                    };
                }
                var root = _rootOf.TryGetValue(dictionary, out var rootDictionary) ? rootDictionary : null;

                if (!readOnly)
                {
                    if (SameColor(TryGetValue(dictionary, key), desired))
                    {
                        continue;
                    }
                    var k = key;
                    Queue(root, () => dictionary[k] = desired);
                    continue;
                }

                // Read-only (Syncfusion's shared Brushes.xaml): write into it while temporarily unlocked.
                // It is merged into every lazily loaded Syncfusion control dictionary, so this is the only place
                // where controls created later pick the theme color up.
                if (CanUnlock)
                {
                    if (!SameColor(TryGetValue(dictionary, key), desired))
                    {
                        if (!readOnlyWrites.TryGetValue(dictionary, out var writes))
                        {
                            writes = [];
                            readOnlyWrites[dictionary] = writes;
                        }
                        writes.Add((key, desired));
                    }
                    continue;
                }

                // fallback: the value goes into a shadow dictionary merged after it
                var shadow = GetOrCreateShadow(dictionary, root, out var insert);
                if (shadow is null)
                {
                    continue;
                }
                if (insert is not null)
                {
                    // inserting into the parent of a root must happen while the root is attached
                    if (ReferenceEquals(root, dictionary))
                    {
                        afterReattach.Add(insert);
                    }
                    else
                    {
                        Queue(root, insert);
                    }
                }

                var shadowKey = key;
                if (hasTarget)
                {
                    if (!SameColor(TryGetValue(shadow, key), desired))
                    {
                        Queue(ReferenceEquals(root, dictionary) ? null : root, () => shadow[shadowKey] = desired);
                    }
                }
                else if (shadow.Contains(key))
                {
                    Queue(ReferenceEquals(root, dictionary) ? null : root, () => shadow.Remove(shadowKey));
                }
            }
        }

        // Every write into an attached dictionary makes WPF re-evaluate resource references; Syncfusion's Brushes.xaml
        // takes dozens of writes. Many of them go with the other operations of its root, which is then detached.
        var weights = new Dictionary<ResourceDictionary, int>(ReferenceEqualityComparer.Instance);
        foreach (var (dictionary, writes) in readOnlyWrites)
        {
            // Detaching the root of Brushes.xaml costs ~0.1 s even for few writes; written in place a color costs ~5 ms.
            if (writes.Count < MinUnlockedWritesToDetach || !_rootOf.TryGetValue(dictionary, out var root))
            {
                WriteUnlocked(dictionary, writes);
                continue;
            }
            if (!batches.TryGetValue(root, out var ops))
            {
                ops = [];
                batches[root] = ops;
            }
            // first, as before: the other operations may add shadows after this dictionary
            ops.Insert(0, () => WriteUnlocked(dictionary, writes));
            weights[root] = (weights.TryGetValue(root, out var w) ? w : 0) + writes.Count - 1;
        }
        foreach (var (root, operations) in batches)
        {
            // Detaching and re-attaching a dictionary of the application resources makes WPF re-evaluate every
            // resource reference once (~0.3 s). That pays off for many writes, not for a few.
            if (operations.Count + (weights.TryGetValue(root, out var extra) ? extra : 0) < MinOperationsToDetach)
            {
                RunAll(operations);
            }
            else
            {
                RunDetached(root, operations);
            }
        }
        RunAll(direct);
        RunAll(afterReattach);

        void Queue(ResourceDictionary? root, Action action)
        {
            if (root is null)
            {
                direct.Add(action);
                return;
            }
            if (!batches.TryGetValue(root, out var ops))
            {
                ops = [];
                batches[root] = ops;
            }
            ops.Add(action);
        }
    }

    /// <summary>
    /// Internal setter of ResourceDictionary.IsReadOnly. Syncfusion seals its shared theme dictionaries;
    /// all access happens on the UI thread, so unlocking one briefly is safe.
    /// </summary>
    private static readonly MethodInfo? s_setReadOnly =
        typeof(ResourceDictionary).GetProperty("IsReadOnly", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
            ?.GetSetMethod(nonPublic: true);

    private static bool CanUnlock => s_setReadOnly is not null;

    public IDisposable BeginSkinUpdate()
    {
        var unlocked = new List<ResourceDictionary>();
        if (!CanUnlock || Application.Current is not { } app)
        {
            return new Relock(unlocked);
        }

        // SfSkinManager.RegisterThemeSettings writes into the sealed theme dictionaries it merged earlier
        // (Common.xaml for fonts, Brushes.xaml for the accent), not only into those holding theme colors.
        var visited = new HashSet<ResourceDictionary>(ReferenceEqualityComparer.Instance);
        var stack = new Stack<ResourceDictionary>();
        stack.Push(app.Resources);
        foreach (Window window in app.Windows)
        {
            stack.Push(window.Resources);
        }

        while (stack.Count > 0)
        {
            var dictionary = stack.Pop();
            if (!visited.Add(dictionary))
            {
                continue;
            }
            foreach (var merged in dictionary.MergedDictionaries)
            {
                stack.Push(merged);
            }
            if (!IsReadOnly(dictionary) || !IsSyncfusionDictionary(dictionary))
            {
                continue;
            }
            try
            {
                s_setReadOnly!.Invoke(dictionary, [false]);
                unlocked.Add(dictionary);
            }
            catch (Exception ex)
            {
                _loggerService.Debug($"Themes: can't unlock {dictionary.Source?.OriginalString}: {ex.Message}");
            }
        }

        _loggerService.Debug($"Themes: unlocked {unlocked.Count} Syncfusion dictionaries for re-applying the skin.");
        return new Relock(unlocked);
    }

    private static bool IsSyncfusionDictionary(ResourceDictionary dictionary) =>
        dictionary.Source?.OriginalString.Contains("Syncfusion.", StringComparison.OrdinalIgnoreCase) == true
        || dictionary.GetType().Namespace?.StartsWith("Syncfusion", StringComparison.Ordinal) == true;

    private sealed class Relock(List<ResourceDictionary> dictionaries) : IDisposable
    {
        public void Dispose()
        {
            foreach (var dictionary in dictionaries)
            {
                try
                {
                    s_setReadOnly!.Invoke(dictionary, [true]);
                }
                catch (Exception)
                {
                    // already sealed by someone else
                }
            }
            dictionaries.Clear();
        }
    }

    /// <summary>Below this many writes a read-only dictionary is written in place, without detaching its root.</summary>
    private const int MinUnlockedWritesToDetach = 30;

    private void WriteUnlocked(ResourceDictionary dictionary, List<(string Key, object Value)> writes)
    {
        try
        {
            s_setReadOnly!.Invoke(dictionary, [false]);
        }
        catch (Exception ex)
        {
            _loggerService.Warning($"Themes: can't unlock {dictionary.Source?.OriginalString}: {ex.Message}");
            return;
        }

        try
        {
            foreach (var (key, value) in writes)
            {
                try
                {
                    dictionary[key] = value;
                }
                catch (Exception ex)
                {
                    _loggerService.Debug($"Themes: can't set {key}: {ex.Message}");
                }
            }
        }
        finally
        {
            s_setReadOnly!.Invoke(dictionary, [true]);
        }

        _loggerService.Debug($"Themes: wrote {writes.Count} colors into {dictionary.Source?.OriginalString ?? "read-only dictionary"}.");
    }

    /// <summary>
    /// Returns the shadow of a read-only dictionary. If it still has to be merged into the parent,
    /// <paramref name="insert"/> is the action that does it.
    /// </summary>
    private ResourceDictionary? GetOrCreateShadow(ResourceDictionary readOnlyDictionary, ResourceDictionary? root, out Action? insert)
    {
        insert = null;
        if (_shadowOf.TryGetValue(readOnlyDictionary, out var existing))
        {
            return existing;
        }

        var parent = _parentOf.TryGetValue(readOnlyDictionary, out var p) ? p : null;
        if (parent is null || IsReadOnly(parent))
        {
            if (_unpatchable++ < 5)
            {
                _loggerService.Debug($"Themes: read-only dictionary {readOnlyDictionary.Source?.OriginalString ?? readOnlyDictionary.GetType().Name} has no writable parent; its colors can't be themed.");
            }
            return null;
        }

        var shadow = new ResourceDictionary();
        _shadows.Add(shadow, new object());
        _shadowOf.Add(readOnlyDictionary, shadow);

        insert = () =>
        {
            var merged = parent.MergedDictionaries;
            var index = merged.IndexOf(readOnlyDictionary);
            try
            {
                // later merged dictionaries win the lookup
                merged.Insert(index < 0 ? merged.Count : index + 1, shadow);
            }
            catch (Exception ex)
            {
                _loggerService.Debug($"Themes: can't add shadow dictionary: {ex.Message}");
            }
        };
        return shadow;
    }

    /// <summary>
    /// Runs operations on a subtree while its top-level dictionary is detached, so WPF invalidates resource
    /// references once instead of once per write.
    /// </summary>
    private void RunDetached(ResourceDictionary root, List<Action> operations)
    {
        var parent = _parentOf.TryGetValue(root, out var p) ? p : null;
        var index = parent?.MergedDictionaries.IndexOf(root) ?? -1;

        if (parent is null || index < 0)
        {
            RunAll(operations);
            return;
        }

        parent.MergedDictionaries.RemoveAt(index);
        try
        {
            RunAll(operations);
        }
        finally
        {
            parent.MergedDictionaries.Insert(index, root);
        }
    }

    private void RunAll(List<Action> operations)
    {
        foreach (var operation in operations)
        {
            try
            {
                operation();
            }
            catch (Exception ex)
            {
                _loggerService.Debug($"Themes: patch failed: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Freezable brushes built from theme colors (DrawingBrush with GeometryDrawings). They can't reference the
    /// colors with DynamicResource, so a recolored copy is written instead.
    /// </summary>
    private static readonly HashSet<string> s_compositeKeys = new(StringComparer.Ordinal)
    {
        "WolvenKitDocumentAreaBrush",
        "EditorGridBrush",       // GraphEditorView: minor grid lines
        "EditorGridMajorBrush",  // GraphEditorView: major grid lines
    };

    /// <summary>
    /// Copy of <paramref name="original"/> with every solid color replaced: a default color of a themed key
    /// becomes that key's theme color, other grays go through the neutral mapper.
    /// </summary>
    private Brush Recolor(DrawingBrush original, Dictionary<string, Color> map, Func<Color, Color>? neutralMapper)
    {
        var byDefault = new Dictionary<Color, Color>();
        foreach (var (key, color) in map)
        {
            if (_defaults.TryGetValue(key, out var defaultResource))
            {
                byDefault.TryAdd(defaultResource.Color, color);
            }
        }

        Color Map(Color c)
        {
            var mapped = byDefault.TryGetValue(c, out var themed) ? themed : neutralMapper?.Invoke(c) ?? c;
            return Color.FromArgb(c.A, mapped.R, mapped.G, mapped.B);
        }

        var copy = original.CloneCurrentValue();
        RecolorDrawing(copy.Drawing);
        if (copy.CanFreeze)
        {
            copy.Freeze();
        }
        return copy;

        void RecolorDrawing(Drawing? drawing)
        {
            switch (drawing)
            {
                case DrawingGroup group:
                    foreach (var child in group.Children)
                    {
                        RecolorDrawing(child);
                    }
                    break;
                case GeometryDrawing geometry:
                    if (geometry.Brush is SolidColorBrush fill)
                    {
                        geometry.Brush = CreateBrush(Map(fill.Color));
                    }
                    if (geometry.Pen is { Brush: SolidColorBrush stroke } pen)
                    {
                        var newPen = pen.CloneCurrentValue();
                        newPen.Brush = CreateBrush(Map(stroke.Color));
                        geometry.Pen = newPen;
                    }
                    break;
                default:
                    break;
            }
        }
    }

    /// <summary>true if the key is handled by patching its defining dictionaries.</summary>
    private bool IsPatchedAtSource(string key) => _sources.ContainsKey(key);

    private static SolidColorBrush CreateBrush(Color color)
    {
        var brush = new SolidColorBrush(color);
        brush.Freeze();
        return brush;
    }

    private static bool SameColor(object? a, object b) => (a, b) switch
    {
        (Color x, Color y) => x == y,
        (SolidColorBrush x, SolidColorBrush y) => ReferenceEquals(x, y) || x.Color == y.Color,
        (DrawingBrush x, DrawingBrush y) => ReferenceEquals(x, y) || SolidColors(x.Drawing).SequenceEqual(SolidColors(y.Drawing)),
        _ => false
    };

    private static IEnumerable<Color> SolidColors(Drawing? drawing) => drawing switch
    {
        DrawingGroup group => group.Children.SelectMany(SolidColors),
        GeometryDrawing geometry =>
            new[] { (geometry.Brush as SolidColorBrush)?.Color, (geometry.Pen?.Brush as SolidColorBrush)?.Color }
                .Where(c => c.HasValue).Select(c => c!.Value),
        _ => []
    };

    private static object? TryGetValue(ResourceDictionary dictionary, string key)
    {
        try
        {
            return dictionary[key];
        }
        catch (Exception)
        {
            return null; // broken resource, see CaptureDefaults
        }
    }

    private static string Humanize(string key) =>
        Regex.Replace(key.Replace('_', ' '), "(?<=[a-z0-9])(?=[A-Z])", " ").Trim();
}
