using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents.Multilayer;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Wireframe and clay views of mesh / entity previews (the switches on the viewport): off, edges
/// drawn over the shaded meshes, or edges only. Shared by all mesh / entity preview tabs; the
/// edge opacity and colour are also kept between sessions (previewWireframe.json in the app data
/// folder), the mode and clay start off. Sector previews never show them.
/// </summary>
public partial class RDTMeshViewModel
{
    public const string WireframeOff = "Off";
    public const string WireframeOverlay = "Over shaded";
    public const string WireframeOnly = "Wireframe only";

    public IReadOnlyList<string> WireframeModes { get; } = [WireframeOff, WireframeOverlay, WireframeOnly];

    // Shared by the tabs; mode for the session, opacity and colour saved.
    private static string s_wireframeMode = WireframeOff;
    private static double s_wireframeOpacity = 0.6;
    private static string s_wireframeColorName = "Auto";
    private static bool s_wireframeSettingsLoaded;

    /// <summary>Open preview tabs, to show a change made in one of them in all.</summary>
    private static readonly List<WeakReference<RDTMeshViewModel>> s_wireframeTabs = [];

    private bool _wireframeTabRegistered;

    /// <summary>The mode this tab draws: sector previews have none.</summary>
    private string EffectiveWireframeMode => IsObjectPreview ? s_wireframeMode : WireframeOff;

    public string WireframeMode
    {
        get
        {
            RegisterWireframeTab();
            return s_wireframeMode;
        }
        set
        {
            value ??= WireframeOff;
            if (s_wireframeMode != value)
            {
                s_wireframeMode = value;
                WireframeSettingsChanged();
            }
        }
    }

    /// <summary>Opacity of the edges in "Over shaded" (0.05..1).</summary>
    public double WireframeOpacity
    {
        get
        {
            LoadWireframeSettings();
            return s_wireframeOpacity;
        }
        set
        {
            value = Math.Clamp(value, 0.05, 1.0);
            if (Math.Abs(s_wireframeOpacity - value) > 1e-6)
            {
                s_wireframeOpacity = value;
                SaveWireframeSettings();
                WireframeSettingsChanged();
            }
        }
    }

    public bool IsWireframeOverlay => s_wireframeMode == WireframeOverlay;

    /// <summary>An edge colour of the "Over shaded" wireframe; no colour = automatic.</summary>
    public sealed record WireframeColorChoice(string Name, System.Windows.Media.Color? Color)
    {
        /// <summary>Swatch in the picker (automatic: half light, half dark).</summary>
        public System.Windows.Media.Brush Swatch { get; } = Color is { } c
            ? new System.Windows.Media.SolidColorBrush(c)
            : new System.Windows.Media.LinearGradientBrush(
                new System.Windows.Media.GradientStopCollection
                {
                    new(System.Windows.Media.Color.FromRgb(0xC8, 0xC8, 0xC8), 0.5),
                    new(System.Windows.Media.Color.FromRgb(0x20, 0x20, 0x20), 0.5),
                },
                new System.Windows.Point(0, 0), new System.Windows.Point(1, 1));

        public override string ToString() => Name;
    }

    private static System.Windows.Media.Color Rgb(byte r, byte g, byte b) => System.Windows.Media.Color.FromRgb(r, g, b);

    public IReadOnlyList<WireframeColorChoice> WireframeColors { get; } =
    [
        new("Auto", null),
        new("White", Rgb(0xFF, 0xFF, 0xFF)),
        new("Black", Rgb(0x00, 0x00, 0x00)),
        new("Red", Rgb(0xFF, 0x40, 0x40)),
        new("Orange", Rgb(0xFF, 0x99, 0x22)),
        new("Yellow", Rgb(0xFF, 0xE6, 0x33)),
        new("Green", Rgb(0x44, 0xDD, 0x55)),
        new("Cyan", Rgb(0x33, 0xDD, 0xEE)),
        new("Blue", Rgb(0x44, 0x88, 0xFF)),
        new("Magenta", Rgb(0xEE, 0x44, 0xEE)),
    ];

    /// <summary>Edge colour of "Over shaded"; Auto = light over the materials, dark over clay.</summary>
    public WireframeColorChoice WireframeColor
    {
        get
        {
            LoadWireframeSettings();
            foreach (var choice in WireframeColors)
            {
                if (choice.Name == s_wireframeColorName)
                {
                    return choice;
                }
            }

            return WireframeColors[0];
        }
        set
        {
            var name = value?.Name ?? "Auto";
            if (s_wireframeColorName != name)
            {
                s_wireframeColorName = name;
                SaveWireframeSettings();
                WireframeSettingsChanged();
            }
        }
    }

    private void RegisterWireframeTab()
    {
        if (_wireframeTabRegistered)
        {
            return;
        }

        _wireframeTabRegistered = true;
        s_wireframeTabs.RemoveAll(r => !r.TryGetTarget(out _));
        s_wireframeTabs.Add(new WeakReference<RDTMeshViewModel>(this));
    }

    /// <summary>Every open preview tab shows the new mode / opacity / colour.</summary>
    private void WireframeSettingsChanged()
    {
        RegisterWireframeTab();
        foreach (var reference in s_wireframeTabs.ToArray())
        {
            if (!reference.TryGetTarget(out var tab))
            {
                continue;
            }

            tab.OnPropertyChanged(nameof(WireframeMode));
            tab.OnPropertyChanged(nameof(IsWireframeOverlay));
            tab.OnPropertyChanged(nameof(WireframeOpacity));
            tab.OnPropertyChanged(nameof(WireframeColor));
            tab.OnPropertyChanged(nameof(IsClayShading));
            tab.OnPropertyChanged(nameof(ShadingLabel));
            tab.ApplyWireframe();
        }
    }

    private sealed record WireframeSettings(double Opacity, string Color);

    private static string WireframeSettingsPath => Path.Combine(ISettingsManager.GetAppData(), "previewWireframe.json");

    private void LoadWireframeSettings()
    {
        if (s_wireframeSettingsLoaded)
        {
            return;
        }

        s_wireframeSettingsLoaded = true;
        try
        {
            if (File.Exists(WireframeSettingsPath) &&
                JsonSerializer.Deserialize<WireframeSettings>(File.ReadAllText(WireframeSettingsPath)) is { } saved)
            {
                s_wireframeOpacity = Math.Clamp(saved.Opacity, 0.05, 1.0);
                s_wireframeColorName = string.IsNullOrEmpty(saved.Color) ? "Auto" : saved.Color;
            }
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Preview] wireframe settings could not be read: {ex.Message}");
        }
    }

    private void SaveWireframeSettings()
    {
        try
        {
            var temp = WireframeSettingsPath + ".tmp";
            File.WriteAllText(temp, JsonSerializer.Serialize(new WireframeSettings(s_wireframeOpacity, s_wireframeColorName)));
            File.Move(temp, WireframeSettingsPath, true);
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Preview] wireframe settings could not be saved: {ex.Message}");
        }
    }

    /// <summary>The viewport's wireframe button: Off → Over shaded → Wireframe only → Off.</summary>
    [CommunityToolkit.Mvvm.Input.RelayCommand]
    private void CycleWireframeMode()
    {
        var index = 0;
        while (index < WireframeModes.Count && WireframeModes[index] != WireframeMode)
        {
            index++;
        }

        WireframeMode = WireframeModes[(index + 1) % WireframeModes.Count];
    }

    /// <summary>Edge colour of the "over shaded" mode: light, so it reads on dark and coloured surfaces.</summary>
    private static readonly System.Windows.Media.Color s_wireframeColor = System.Windows.Media.Color.FromRgb(0xC8, 0xC8, 0xC8);

    /// <summary>Edge colour over the clay view: dark, so it reads on the grey.</summary>
    private static readonly System.Windows.Media.Color s_wireframeClayColor = System.Windows.Media.Color.FromRgb(0x20, 0x20, 0x20);

    /// <summary>
    /// Clay view (the viewport's Shading button): matte grey, mesh normals, no textures. It is
    /// a shader switch, so it is the same in every preview tab, like the shader debug view.
    /// </summary>
    public bool IsClayShading
    {
        get => MultilayerShader.ClayView;
        set
        {
            if (MultilayerShader.ClayView == value)
            {
                return;
            }

            MultilayerShader.ClayView = value;
            WireframeSettingsChanged();
            foreach (var reference in s_wireframeTabs.ToArray())
            {
                if (reference.TryGetTarget(out var tab))
                {
                    tab.RedrawMaterials();
                }
            }
        }
    }

    public string ShadingLabel => MultilayerShader.ClayView ? "Clay" : "Material";

    [CommunityToolkit.Mvvm.Input.RelayCommand]
    private void ToggleClayShading() => IsClayShading = !IsClayShading;

    /// <summary>Makes the viewport draw again with the new shading.</summary>
    private void RedrawMaterials()
    {
        foreach (var material in Materials.Values)
        {
            (material as MultilayerPBRMaterial)?.RequestRedraw();
        }
    }

    /// <summary>Sets the wireframe mode on every mesh of the shown appearance.</summary>
    private void ApplyWireframe()
    {
        if (SelectedAppearance?.ModelGroup is not { } group)
        {
            return;
        }

        foreach (var element in group)
        {
            ApplyWireframe(element);
        }
    }

    private void ApplyWireframe(Element3D element)
    {
        switch (element)
        {
            case GroupModel3D groupModel:
                foreach (var child in groupModel.Children)
                {
                    ApplyWireframe(child);
                }

                break;
            case MeshGeometryModel3D mesh:
                // Only meshes this mode changed before go back to solid, so nothing else is touched.
                var mode = EffectiveWireframeMode;
                if (mode == WireframeOff && !mesh.RenderWireframe &&
                    mesh.FillMode == SharpDX.Direct3D11.FillMode.Solid)
                {
                    break;
                }

                mesh.RenderWireframe = mode == WireframeOverlay;
                var edge = WireframeColor.Color ?? (MultilayerShader.ClayView ? s_wireframeClayColor : s_wireframeColor);
                mesh.WireframeColor = System.Windows.Media.Color.FromArgb(
                    (byte)Math.Round(WireframeOpacity * 255), edge.R, edge.G, edge.B);
                mesh.FillMode = mode == WireframeOnly
                    ? SharpDX.Direct3D11.FillMode.Wireframe
                    : SharpDX.Direct3D11.FillMode.Solid;
                break;
        }
    }
}
