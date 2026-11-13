using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Camera presets of mesh and entity previews: a saved view (direction, up, distance, framing,
/// projection and lighting) that can be applied to any item. Positions are kept relative to
/// the bounding sphere of what is shown, so a preset frames a pistol and a jacket alike.
/// Shared by all preview tabs and kept in the app data folder.
/// </summary>
public partial class RDTMeshViewModel
{
    /// <summary>
    /// A saved view. Look / Up are directions; Distance, Target and OrthoWidth are in radii of
    /// the bounding sphere (Target: look-at point minus the sphere's centre).
    /// </summary>
    public sealed record CameraPreset
    {
        public string Name { get; init; } = "";
        public double LookX { get; init; }
        public double LookY { get; init; }
        public double LookZ { get; init; } = -1;
        public double UpX { get; init; }
        public double UpY { get; init; } = 1;
        public double UpZ { get; init; }
        public double Distance { get; init; } = 3;
        public double TargetX { get; init; }
        public double TargetY { get; init; }
        public double TargetZ { get; init; }
        public double OrthoWidth { get; init; }
        public string Projection { get; init; } = "";
        public string Lighting { get; init; } = "";

        /// <summary>The "None" entry: no preset, the view is framed as before. Not saved.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public bool IsNone { get; init; }

        public override string ToString() => Name;
    }

    /// <summary>First entry of the list: no preset (Save Appearance Icons frames the current view).</summary>
    private static readonly CameraPreset s_noCameraPreset = new() { Name = "None (current view)", IsNone = true };

    private static ObservableCollection<CameraPreset>? s_cameraPresets;

    private static string CameraPresetsPath => Path.Combine(ISettingsManager.GetAppData(), "previewCameraPresets.json");

    /// <summary>"None" and the saved presets, loaded once per session.</summary>
    public ObservableCollection<CameraPreset> CameraPresets => s_cameraPresets ??= LoadCameraPresets();

    private CameraPreset? _selectedCameraPreset;

    public CameraPreset? SelectedCameraPreset
    {
        get => _selectedCameraPreset ??= s_noCameraPreset;
        set
        {
            if (SetProperty(ref _selectedCameraPreset, value))
            {
                OnPropertyChanged(nameof(HasSelectedCameraPreset));
            }
        }
    }

    /// <summary>A saved preset is selected (not "None").</summary>
    public bool HasSelectedCameraPreset => SelectedCameraPreset is { IsNone: false };

    /// <summary>The selected saved preset, or null for "None".</summary>
    public CameraPreset? ActiveCameraPreset => SelectedCameraPreset is { IsNone: false } preset ? preset : null;

    private ObservableCollection<CameraPreset> LoadCameraPresets()
    {
        try
        {
            if (File.Exists(CameraPresetsPath) &&
                JsonSerializer.Deserialize<List<CameraPreset>>(File.ReadAllText(CameraPresetsPath)) is { } list)
            {
                return new ObservableCollection<CameraPreset>(
                    list.Where(p => !string.IsNullOrWhiteSpace(p.Name)).Prepend(s_noCameraPreset));
            }
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Preview] camera presets could not be read: {ex.Message}");
        }

        return [s_noCameraPreset];
    }

    private void SaveCameraPresets()
    {
        try
        {
            var json = JsonSerializer.Serialize(CameraPresets.Where(p => !p.IsNone).ToList(), new JsonSerializerOptions { WriteIndented = true });
            var temp = CameraPresetsPath + ".tmp";
            File.WriteAllText(temp, json);
            File.Move(temp, CameraPresetsPath, true);
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Preview] camera presets could not be saved: {ex.Message}");
        }
    }

    /// <summary>Adds the preset, replacing one of the same name, and selects it.</summary>
    public void StoreCameraPreset(CameraPreset preset)
    {
        var existing = CameraPresets.FirstOrDefault(p => !p.IsNone && string.Equals(p.Name, preset.Name, StringComparison.OrdinalIgnoreCase));
        if (existing != null)
        {
            CameraPresets[CameraPresets.IndexOf(existing)] = preset;
        }
        else
        {
            CameraPresets.Add(preset);
        }

        SaveCameraPresets();
        SelectedCameraPreset = preset;
    }

    public void DeleteSelectedCameraPreset()
    {
        if (ActiveCameraPreset is not { } preset)
        {
            return;
        }

        CameraPresets.Remove(preset);
        SaveCameraPresets();
        SelectedCameraPreset = s_noCameraPreset;
    }

    /// <summary>Projection and lighting of a preset; the view itself is placed by the view.</summary>
    public void ApplyCameraPresetSettings(CameraPreset preset)
    {
        if (PreviewCameraOptions.FirstOrDefault(o => o.Label == preset.Projection) is { } projection)
        {
            PreviewCamera = projection;
        }

        if (PreviewLightingPresets.Contains(preset.Lighting))
        {
            PreviewLighting = preset.Lighting;
        }
    }
}
