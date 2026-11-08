using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Media;
using Moq;
using WolvenKit.App.Services;
using WolvenKit.App.Services.Themes;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.Core.Interfaces;
using Xunit;

namespace Wolvenkit.Test.App.Services;

/// <summary>
/// Theme logic that doesn't need a running WPF application: loading, inheritance (basedOn), persistence,
/// import/export, fallbacks, the neutral color mapping and contrast checks.
/// Every test works on its own temporary themes folder.
/// </summary>
public class ThemeServiceTests
{
    private const string NightCity = "Night City Cyan";

    #region helpers

    private sealed class Fixture : IDisposable
    {
        private string? _activeTheme;

        public Fixture(string? activeTheme = null, string? legacyAccent = null, Action<string>? seed = null)
        {
            Directory = Path.Combine(Path.GetTempPath(), "wk-themes-" + Guid.NewGuid().ToString("N"));
            System.IO.Directory.CreateDirectory(Directory);
            seed?.Invoke(Directory);

            _activeTheme = activeTheme;
            Settings = new Mock<ISettingsManager>();
            Settings.SetupGet(s => s.ActiveTheme).Returns(() => _activeTheme);
            Settings.SetupSet(s => s.ActiveTheme = It.IsAny<string?>()).Callback<string?>(value =>
            {
                _activeTheme = value;
                Settings.Raise(s => s.PropertyChanged += null, new PropertyChangedEventArgs(nameof(ISettingsManager.ActiveTheme)));
            });
            Settings.SetupProperty(s => s.ThemeAccentString, legacyAccent);

            Service = new ThemeService(Settings.Object, new Mock<ILoggerService>().Object) { UserThemesDirectory = Directory };
            Service.Initialize();
        }

        public string Directory { get; }

        public Mock<ISettingsManager> Settings { get; }

        public ThemeService Service { get; }

        public string? ActiveTheme => _activeTheme;

        public ThemeDto Get(string name) => Service.Find(name) ?? throw new InvalidOperationException($"theme {name} not found");

        public ThemeDto SaveNew(string name, string? basedOn, params (string Key, string Hex)[] colors) =>
            Service.Save(new ThemeDto
            {
                Name = name,
                BasedOn = basedOn,
                Colors = colors.ToDictionary(c => c.Key, c => c.Hex, StringComparer.Ordinal)
            });

        public void Dispose()
        {
            try
            {
                System.IO.Directory.Delete(Directory, true);
            }
            catch (IOException)
            {
                // best effort
            }
        }
    }

    private static void WriteTheme(string directory, string fileName, string json) =>
        File.WriteAllText(Path.Combine(directory, fileName), json);

    private static Color Hex(string hex) => ThemeService.TryParseColor(hex) ?? throw new ArgumentException(hex);

    #endregion

    #region built-in themes

    [Fact]
    public void Initialize_LoadsBuiltInThemes_DefaultFirst()
    {
        using var f = new Fixture();

        var themes = f.Service.Themes;
        Assert.True(themes.Count >= 12, $"expected the built-in themes, got {themes.Count}");
        Assert.True(themes[0].IsDefault);
        Assert.Equal(IThemeService.DefaultThemeName, themes[0].Name);
        Assert.Equal(themes.Count, themes.Select(t => t.Name).Distinct(StringComparer.OrdinalIgnoreCase).Count());
    }

    [Fact]
    public void BuiltInThemes_UseOnlyKnownKeys_AndValidColors()
    {
        using var f = new Fixture();

        foreach (var theme in f.Service.Themes.Where(t => t.IsBuiltIn))
        {
            foreach (var (key, value) in theme.Colors)
            {
                Assert.True(f.Service.Catalog.Find(key) is not null, $"{theme.Name}: unknown key {key}");
                Assert.True(ThemeService.TryParseColor(value) is not null, $"{theme.Name}: invalid color {value} for {key}");
            }
            Assert.True(theme.Accent is null || ThemeService.TryParseColor(theme.Accent) is not null, $"{theme.Name}: invalid accent");
            Assert.True(theme.BasedOn is null || f.Service.Find(theme.BasedOn) is not null, $"{theme.Name}: unknown base {theme.BasedOn}");
        }
    }

    [Fact]
    public void BuiltInThemes_CannotBeSavedOrDeleted()
    {
        using var f = new Fixture();
        var builtIn = f.Get(NightCity);

        Assert.Throws<InvalidOperationException>(() => f.Service.Save(builtIn));
        Assert.Throws<InvalidOperationException>(() => f.Service.Delete(builtIn));
    }

    [Fact]
    public void Duplicate_OfBuiltIn_InheritsInsteadOfCopying()
    {
        using var f = new Fixture();

        var copy = f.Service.Duplicate(f.Get(NightCity), "My cyan");

        Assert.False(copy.IsBuiltIn);
        Assert.Equal(NightCity, copy.BasedOn);
        Assert.Empty(copy.Colors);
        Assert.True(File.Exists(copy.FilePath));
        Assert.Equal(f.Service.ResolveOverrides(f.Get(NightCity)), f.Service.ResolveOverrides(copy));
    }

    #endregion

    #region fallbacks

    [Fact]
    public void MissingActiveTheme_FallsBackToDefault()
    {
        using var f = new Fixture(activeTheme: "Does not exist");

        Assert.Equal(IThemeService.DefaultThemeName, f.Service.Current.Name);
        Assert.Equal(IThemeService.DefaultThemeName, f.ActiveTheme);
    }

    [Fact]
    public void InvalidThemeFiles_AreSkipped()
    {
        using var f = new Fixture(seed: dir =>
        {
            WriteTheme(dir, "broken.json", "{ this is not json");
            WriteTheme(dir, "future.json", """{ "formatVersion": 99, "name": "From the future", "colors": {} }""");
            WriteTheme(dir, "nocolors.json", """{ "formatVersion": 1, "name": "No colors", "colors": null }""");
        });

        Assert.Null(f.Service.Find("broken"));
        Assert.Null(f.Service.Find("From the future"));
        Assert.NotNull(f.Service.Find("No colors"));
    }

    [Fact]
    public void InvalidColorValues_AreIgnored_OthersApply()
    {
        using var f = new Fixture();
        var theme = f.SaveNew("Partly broken", null, ("ContentBackground", "#123456"), ("BorderAlt", "#ZZZZZZ"));

        var overrides = f.Service.ResolveOverrides(theme);

        Assert.Equal(Hex("#123456"), overrides["ContentBackground"]);
        Assert.False(overrides.ContainsKey("BorderAlt"));
    }

    [Fact]
    public void LegacyAccent_IsMigratedToUserTheme()
    {
        using var f = new Fixture(legacyAccent: "#FF00FF00");

        Assert.Equal("Custom (migrated accent)", f.Service.Current.Name);
        Assert.Equal(Hex("#00FF00"), f.Service.ResolveAccent(f.Service.Current));
        Assert.True(File.Exists(f.Service.Current.FilePath));
    }

    [Fact]
    public void DefaultLegacyAccent_IsNotMigrated()
    {
        using var f = new Fixture(legacyAccent: "#FFDF2935");

        Assert.Equal(IThemeService.DefaultThemeName, f.Service.Current.Name);
        Assert.Empty(Directory.GetFiles(f.Directory));
    }

    #endregion

    #region inheritance

    [Fact]
    public void ResolveOverrides_MergesBasedOnChain_OwnValuesWin()
    {
        using var f = new Fixture();
        var nightCity = f.Service.ResolveOverrides(f.Get(NightCity));
        var theme = f.SaveNew("Child of night city", NightCity, ("ContentBackground", "#010203"));

        var overrides = f.Service.ResolveOverrides(theme);

        Assert.Equal(Hex("#010203"), overrides["ContentBackground"]);
        Assert.Equal(nightCity["BorderAlt"], overrides["BorderAlt"]);
        Assert.Equal(f.Service.ResolveAccent(f.Get(NightCity)), f.Service.ResolveAccent(theme));
    }

    [Fact]
    public void BasedOnCycle_DoesNotLoop()
    {
        using var f = new Fixture(seed: dir =>
        {
            WriteTheme(dir, "a.json", """{ "formatVersion": 1, "name": "A", "basedOn": "B", "colors": { "ContentBackground": "#111111" } }""");
            WriteTheme(dir, "b.json", """{ "formatVersion": 1, "name": "B", "basedOn": "A", "colors": { "BorderAlt": "#222222" } }""");
        });

        var overrides = f.Service.ResolveOverrides(f.Get("A"));

        Assert.Equal(Hex("#111111"), overrides["ContentBackground"]);
        Assert.Equal(Hex("#222222"), overrides["BorderAlt"]);
    }

    #endregion

    #region save, rename, delete

    [Fact]
    public void Save_Rename_UpdatesActiveThemeChildrenAndFile()
    {
        using var f = new Fixture();
        var parent = f.SaveNew("Parent", null, ("ContentBackground", "#111111"));
        f.SaveNew("Child", "Parent", ("BorderAlt", "#222222"));
        f.Service.SetActive("Parent");
        var oldFile = parent.FilePath;

        var renamed = f.Get("Parent").Clone();
        renamed.Name = "Parent 2";
        f.Service.Save(renamed, "Parent");

        Assert.Null(f.Service.Find("Parent"));
        Assert.NotNull(f.Service.Find("Parent 2"));
        Assert.Equal("Parent 2", f.Get("Child").BasedOn);
        Assert.Equal("Parent 2", f.ActiveTheme);
        Assert.False(File.Exists(oldFile));
    }

    [Fact]
    public void Save_NameOfAnotherTheme_Throws()
    {
        using var f = new Fixture();
        f.SaveNew("Mine", null);

        Assert.Throws<InvalidOperationException>(() => f.SaveNew(NightCity, null));
        Assert.Throws<InvalidOperationException>(() => f.SaveNew(IThemeService.DefaultThemeName.ToUpperInvariant(), null));
    }

    [Fact]
    public void Delete_KeepsColorsOfChildren()
    {
        using var f = new Fixture();
        f.SaveNew("Parent", NightCity, ("ContentBackground", "#111111"));
        f.SaveNew("Child", "Parent", ("BorderAlt", "#222222"));

        f.Service.Delete(f.Get("Parent"));

        var child = f.Get("Child");
        var overrides = f.Service.ResolveOverrides(child);
        Assert.Equal(NightCity, child.BasedOn);
        Assert.Equal(Hex("#111111"), overrides["ContentBackground"]);
        Assert.Equal(Hex("#222222"), overrides["BorderAlt"]);
    }

    [Fact]
    public void Delete_ActiveTheme_SwitchesToItsBase()
    {
        using var f = new Fixture();
        f.SaveNew("Child", NightCity);
        f.Service.SetActive("Child");

        f.Service.Delete(f.Get("Child"));

        Assert.Equal(NightCity, f.ActiveTheme);
        Assert.Equal(NightCity, f.Service.Current.Name);
    }

    #endregion

    #region import / export

    [Fact]
    public void Export_Flattened_ContainsInheritedColors_AndNoBase()
    {
        using var f = new Fixture();
        var child = f.SaveNew("Child", NightCity, ("ContentBackground", "#010203"));
        var path = Path.Combine(f.Directory, "export.out");

        f.Service.Export(child, path, flatten: true);

        using var json = JsonDocument.Parse(File.ReadAllText(path));
        var root = json.RootElement;
        Assert.False(root.TryGetProperty("basedOn", out _));
        var colors = root.GetProperty("colors");
        Assert.Equal("#010203", colors.GetProperty("ContentBackground").GetString());
        Assert.Equal(f.Get(NightCity).Colors["BorderAlt"], colors.GetProperty("BorderAlt").GetString());
        Assert.Equal(ThemeService.ToHex(f.Service.ResolveAccent(f.Get(NightCity))), root.GetProperty("accent").GetString());
    }

    [Fact]
    public void Import_RenamesOnNameConflict()
    {
        using var f = new Fixture();
        var path = Path.Combine(f.Directory, "night.out");
        f.Service.Export(f.Get(NightCity), path, flatten: false);

        var imported = f.Service.Import(path);

        Assert.Equal(NightCity + " 2", imported.Name);
        Assert.False(imported.IsBuiltIn);
        Assert.Equal(f.Service.ResolveOverrides(f.Get(NightCity)), f.Service.ResolveOverrides(imported));
    }

    #endregion

    #region neutral colors, contrast, parsing

    [Fact]
    public void NeutralMapper_InterpolatesGrays_KeepsColorsAndAlpha()
    {
        using var f = new Fixture();
        f.Service.SetDefaultColor("ContentBackground", Hex("#202020"));
        f.Service.SetDefaultColor("ContentForeground", Hex("#E0E0E0"));
        var theme = new ThemeDto
        {
            Name = "Blue",
            Colors = { ["ContentBackground"] = "#102030", ["ContentForeground"] = "#D0E0F0" }
        };

        var map = f.Service.BuildNeutralMapper(theme);

        Assert.NotNull(map);
        Assert.Equal(Hex("#102030"), map(Hex("#202020")));
        Assert.Equal(Hex("#D0E0F0"), map(Hex("#E0E0E0")));

        var middle = map(Hex("#808080"));
        Assert.InRange(middle.R, (byte)0x10, (byte)0xD0);
        Assert.True(middle.B > middle.R, "a gray between the anchors takes the theme's tint");

        Assert.Equal(Hex("#FF0000"), map(Hex("#FF0000")));
        Assert.Equal(0x80, map(Hex("#80202020")).A);
    }

    [Fact]
    public void NeutralMapper_NullWithoutTwoAnchors_OrWhenDisabled()
    {
        using var f = new Fixture();
        f.Service.SetDefaultColor("ContentBackground", Hex("#202020"));
        f.Service.SetDefaultColor("ContentForeground", Hex("#E0E0E0"));

        var oneAnchor = new ThemeDto { Name = "One", Colors = { ["ContentBackground"] = "#102030" } };
        var disabled = new ThemeDto
        {
            Name = "Off",
            DeriveNeutralColors = false,
            Colors = { ["ContentBackground"] = "#102030", ["ContentForeground"] = "#D0E0F0" }
        };

        Assert.Null(f.Service.BuildNeutralMapper(oneAnchor));
        Assert.Null(f.Service.BuildNeutralMapper(disabled));
    }

    [Fact]
    public void ContrastRatio_FollowsWcag()
    {
        Assert.Equal(21.0, ThemeEditorViewModel.ContrastRatio(Colors.Black, Colors.White), 1);
        Assert.Equal(1.0, ThemeEditorViewModel.ContrastRatio(Hex("#336699"), Hex("#336699")), 3);
        Assert.Equal(
            ThemeEditorViewModel.ContrastRatio(Hex("#123456"), Hex("#ABCDEF")),
            ThemeEditorViewModel.ContrastRatio(Hex("#ABCDEF"), Hex("#123456")),
            6);
    }

    [Theory]
    [InlineData("#DF2935", "#DF2935")]
    [InlineData("#ffdf2935", "#DF2935")]
    [InlineData("#80FFFFFF", "#80FFFFFF")]
    public void ColorHex_RoundTrips(string input, string expected) =>
        Assert.Equal(expected, ThemeService.ToHex(Hex(input)));

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("#ZZZZZZ")]
    [InlineData("not a color")]
    public void TryParseColor_RejectsInvalid(string? value) =>
        Assert.Null(ThemeService.TryParseColor(value));

    #endregion
}
