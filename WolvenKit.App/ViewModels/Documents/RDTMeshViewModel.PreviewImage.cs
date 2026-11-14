using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using WolvenKit.App.Services;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// "Save Preview Image": the current view of the preview as a PNG with a transparent
/// background, e.g. for inventory icons. The view renders the frame twice, over black and over
/// white (<see cref="SavePreviewImageAsync"/> gets both); the difference between the two gives
/// the exact alpha, including soft edges, hair and glass.
/// </summary>
public partial class RDTMeshViewModel
{
    /// <summary>Output size of the saved image. Label is what the ComboBox shows.</summary>
    public sealed record PreviewImageOption(int Width, int Height, string Label)
    {
        public override string ToString() => Label;
    }

    /// <summary>
    /// Inventory icon sizes from the modding wiki ("Your own inventory preview icons":
    /// clothing 130–160 × 76–160, guns 320 × 80–160, melee 320 × 60–145), larger versions of
    /// the same ratios for working copies, and plain squares.
    /// </summary>
    public IReadOnlyList<PreviewImageOption> PreviewImageFormats { get; } =
    [
        new(160, 160, "160 × 160 (clothing icon)"),
        new(320, 160, "320 × 160 (gun icon)"),
        new(320, 145, "320 × 145 (melee icon)"),
        new(640, 320, "640 × 320 (2:1, ×2)"),
        new(1280, 640, "1280 × 640 (2:1, ×4)"),
        new(512, 512, "512 × 512"),
        new(1024, 1024, "1024 × 1024"),
        new(2048, 2048, "2048 × 2048"),
        new(0, 0, "Custom..."),
    ];

    private PreviewImageOption? _previewImageFormat;

    public PreviewImageOption PreviewImageFormat
    {
        get => _previewImageFormat ??= PreviewImageFormats[5];
        set
        {
            if (SetProperty(ref _previewImageFormat, value))
            {
                OnPropertyChanged(nameof(IsCustomImageSize));
            }
        }
    }

    /// <summary>"Custom..." is selected: the size comes from the width / height fields.</summary>
    public bool IsCustomImageSize => PreviewImageFormat.Width <= 0;

    private int _customImageWidth = 400;
    private int _customImageHeight = 200;

    public int CustomImageWidth
    {
        get => _customImageWidth;
        set => SetProperty(ref _customImageWidth, Math.Clamp(value, 16, 8192));
    }

    public int CustomImageHeight
    {
        get => _customImageHeight;
        set => SetProperty(ref _customImageHeight, Math.Clamp(value, 16, 8192));
    }

    /// <summary>Output size in pixels: the selected preset, or the custom fields.</summary>
    public (int Width, int Height) PreviewImageSize =>
        IsCustomImageSize ? (CustomImageWidth, CustomImageHeight) : (PreviewImageFormat.Width, PreviewImageFormat.Height);

    // ---- Margin, alignment, background, supersampling, lighting ----

    /// <summary>Empty space around the item, in percent of the shorter side.</summary>
    public IReadOnlyList<int> PreviewImageMargins { get; } = [0, 3, 5, 10, 15, 20];

    private int _previewImageMargin = 3;

    public int PreviewImageMargin
    {
        get => _previewImageMargin;
        set => SetProperty(ref _previewImageMargin, value);
    }

    /// <summary>Where the item sits in the image: centered, or standing on the bottom edge (shoes, props).</summary>
    public IReadOnlyList<string> PreviewImageAlignments { get; } = ["Center", "Bottom"];

    private string _previewImageAlignment = "Center";

    public string PreviewImageAlignment
    {
        get => _previewImageAlignment;
        set => SetProperty(ref _previewImageAlignment, value);
    }

    public sealed record PreviewBackgroundOption(string Label, Color? Color)
    {
        public override string ToString() => Label;
    }

    public IReadOnlyList<PreviewBackgroundOption> PreviewBackgrounds { get; } =
    [
        new("Transparent", null),
        new("White", Color.White),
        new("Black", Color.Black),
        new("Grey", Color.FromArgb(255, 128, 128, 128)),
    ];

    private PreviewBackgroundOption? _previewBackground;

    public PreviewBackgroundOption PreviewBackground
    {
        get => _previewBackground ??= PreviewBackgrounds[0];
        set => SetProperty(ref _previewBackground, value);
    }

    /// <summary>
    /// Render the preview at this multiple of its size for the capture, then scale down:
    /// cleaner edges, and large images no longer depend on the window size.
    /// </summary>
    public IReadOnlyList<int> PreviewSupersampleFactors { get; } = [1, 2, 3, 4];

    private int _previewSupersample = 2;

    public int PreviewSupersample
    {
        get => _previewSupersample;
        set => SetProperty(ref _previewSupersample, value);
    }

    /// <summary>
    /// Light presets of the preview (also used for saved images), shared by all preview tabs:
    /// Default = the usual work lights; Icon (soft) = key from the front upper left, weaker fill,
    /// rim and ambient, fixed in the scene; Icon (follow camera) = the same set turning with
    /// the camera, so back and side views are lit like the front; Flat = ambient only, for
    /// checking colours and textures without highlights.
    /// </summary>
    public IReadOnlyList<string> PreviewLightingPresets { get; } = ["Default", "Icon", "Icon (soft)", "Icon (follow camera)", "Flat"];

    private static string s_previewLighting = "Default";

    public string PreviewLighting
    {
        get => s_previewLighting;
        set
        {
            if (SetProperty(ref s_previewLighting, value))
            {
                OnPropertyChanged(nameof(UseWorkLighting));
                OnPropertyChanged(nameof(UseIconContrastLighting));
                OnPropertyChanged(nameof(UseIconLighting));
                OnPropertyChanged(nameof(UseFollowLighting));
                OnPropertyChanged(nameof(UseFlatLighting));
            }
        }
    }

    // Sector / block previews have no Camera section: they keep the default lights even when
    // another preview tab picked a preset (the preset is shared by all tabs).
    public bool UseWorkLighting => !IsObjectPreview || PreviewLighting == "Default";
    public bool UseIconContrastLighting => IsObjectPreview && PreviewLighting == "Icon";
    public bool UseIconLighting => IsObjectPreview && PreviewLighting == "Icon (soft)";
    public bool UseFollowLighting => IsObjectPreview && PreviewLighting == "Icon (follow camera)";
    public bool UseFlatLighting => IsObjectPreview && PreviewLighting == "Flat";

    /// <summary>
    /// Mesh and entity previews. The Camera, Image &amp; Icons and Shader Debug sections are made
    /// for single items; sector and block previews hide them.
    /// </summary>
    public bool IsObjectPreview => Header != WolvenKit.App.Models.MeshViewHeaders.SectorPreview && Header != WolvenKit.App.Models.MeshViewHeaders.AllSectorPreview;

    private static string? s_previewImageFolder;

    // ---- Progress cover over the preview while saving ----
    // The capture reads the render buffer, not the screen, so the cover is not in the images;
    // it hides the resizing (Quality ×2–×4) and the appearance / material switching.

    private bool _isSavingImage;
    private bool _isSavingImageBatch;
    private string _savingImageStatus = "";
    private int _savingImageDone;
    private int _savingImageTotal = 1;

    public bool IsSavingImage
    {
        get => _isSavingImage;
        set => SetProperty(ref _isSavingImage, value);
    }

    /// <summary>A batch is running: shows the Cancel button.</summary>
    public bool IsSavingImageBatch
    {
        get => _isSavingImageBatch;
        set => SetProperty(ref _isSavingImageBatch, value);
    }

    public string SavingImageStatus
    {
        get => _savingImageStatus;
        set => SetProperty(ref _savingImageStatus, value);
    }

    public int SavingImageDone
    {
        get => _savingImageDone;
        set => SetProperty(ref _savingImageDone, value);
    }

    public int SavingImageTotal
    {
        get => _savingImageTotal;
        set => SetProperty(ref _savingImageTotal, Math.Max(1, value));
    }

    /// <summary>Set by Cancel; the batch stops after the current icon.</summary>
    public bool CancelSavingImages { get; set; }

    // ---- Panel sections ----
    // Expanded / collapsed state of the side panel sections: shared by all preview tabs and
    // kept between sessions (previewSections.json in the app data folder), so whoever never
    // makes icons collapses that section once. All start open except Shader Debug. Shader
    // Debug keeps one state for sectors and one for meshes / entities, so opening it to check
    // terrain does not leave it open on every mesh (or the other way).

    private static readonly Dictionary<string, bool> s_sectionDefaults = new()
    {
        ["Materials"] = true,
        ["Image"] = true,
        ["Camera"] = true,
        ["Export"] = true,
        ["Sector"] = true,
        ["Debug"] = false,
        ["SectorDebug"] = false,
    };

    private static Dictionary<string, bool>? s_sections;

    private static string SectionsPath => Path.Combine(ISettingsManager.GetAppData(), "previewSections.json");

    private bool GetSection(string name)
    {
        if (s_sections == null)
        {
            s_sections = new Dictionary<string, bool>(s_sectionDefaults);
            try
            {
                if (File.Exists(SectionsPath) &&
                    System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, bool>>(File.ReadAllText(SectionsPath)) is { } saved)
                {
                    foreach (var (key, value) in saved)
                    {
                        s_sections[key] = value;
                    }
                }
            }
            catch (Exception ex)
            {
                Parent?.GetLoggerService()?.Warning($"[Preview] panel section states could not be read: {ex.Message}");
            }
        }

        return s_sections.TryGetValue(name, out var expanded) ? expanded : s_sectionDefaults.GetValueOrDefault(name, true);
    }

    private void SetSection(string name, bool value, [System.Runtime.CompilerServices.CallerMemberName] string? property = null)
    {
        if (GetSection(name) == value)
        {
            return;
        }

        s_sections![name] = value;
        OnPropertyChanged(property);
        try
        {
            var temp = SectionsPath + ".tmp";
            File.WriteAllText(temp, System.Text.Json.JsonSerializer.Serialize(s_sections));
            File.Move(temp, SectionsPath, true);
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Preview] panel section states could not be saved: {ex.Message}");
        }
    }

    public bool IsSectorSectionExpanded
    {
        get => GetSection("Sector");
        set => SetSection("Sector", value);
    }

    public bool IsExportSectionExpanded
    {
        get => GetSection("Export");
        set => SetSection("Export", value);
    }

    public bool IsMaterialsSectionExpanded
    {
        get => GetSection("Materials");
        set => SetSection("Materials", value);
    }

    public bool IsImageSectionExpanded
    {
        get => GetSection("Image");
        set => SetSection("Image", value);
    }

    public bool IsCameraSectionExpanded
    {
        get => GetSection("Camera");
        set => SetSection("Camera", value);
    }

    public bool IsDebugSectionExpanded
    {
        get => GetSection(IsObjectPreview ? "Debug" : "SectorDebug");
        set => SetSection(IsObjectPreview ? "Debug" : "SectorDebug", value);
    }

    // ---- Camera for icons ----

    /// <summary>Projection of the preview camera. FieldOfView 0 = orthographic.</summary>
    public sealed record PreviewCameraOption(string Label, double FieldOfView)
    {
        public override string ToString() => Label;
    }

    /// <summary>
    /// A narrow field of view or an orthographic camera removes the perspective distortion of
    /// close-ups, so icons of different items line up; the default stays the usual 45°.
    /// </summary>
    public IReadOnlyList<PreviewCameraOption> PreviewCameraOptions { get; } =
    [
        new("Perspective 45° (default)", 45),
        new("Perspective 30°", 30),
        new("Perspective 15° (icons)", 15),
        new("Orthographic", 0),
    ];

    private PreviewCameraOption? _previewCamera;

    public PreviewCameraOption PreviewCamera
    {
        get => _previewCamera ??= PreviewCameraOptions[0];
        set
        {
            if (SetProperty(ref _previewCamera, value))
            {
                ApplyPreviewCamera();
            }
        }
    }

    /// <summary>
    /// Swaps the camera for the chosen projection, keeping where it looks from. The view zooms
    /// to the object afterwards, since the distance that frames it depends on the projection.
    /// </summary>
    private void ApplyPreviewCamera()
    {
        if (Camera is not HelixToolkit.Wpf.SharpDX.ProjectionCamera old)
        {
            return;
        }

        var option = PreviewCamera;
        if (option.FieldOfView > 0 && old is HelixToolkit.Wpf.SharpDX.PerspectiveCamera perspective)
        {
            perspective.SetCurrentValue(HelixToolkit.Wpf.SharpDX.PerspectiveCamera.FieldOfViewProperty, option.FieldOfView);
            return;
        }

        if (option.FieldOfView <= 0 && old is HelixToolkit.Wpf.SharpDX.OrthographicCamera)
        {
            return;
        }

        // Take the view from the render camera: mouse navigation and ZoomExtents change only
        // that one, the WPF camera properties can be stale.
        var core = old.CameraInternal;
        var position = new System.Windows.Media.Media3D.Point3D(core.Position.X, core.Position.Y, core.Position.Z);
        var look = new System.Windows.Media.Media3D.Vector3D(core.LookDirection.X, core.LookDirection.Y, core.LookDirection.Z);
        var up = new System.Windows.Media.Media3D.Vector3D(core.UpDirection.X, core.UpDirection.Y, core.UpDirection.Z);

        if (option.FieldOfView > 0)
        {
            // Coming from orthographic, the near plane is negative (see below), which breaks a
            // perspective projection and the object vanished. The preview's near planes are
            // far / 1e6 (0.01 for meshes and entities, 0.1 sectors, 1 blocks).
            var near = old.NearPlaneDistance > 0 ? old.NearPlaneDistance : old.FarPlaneDistance * 1e-6;
            Camera = new HelixToolkit.Wpf.SharpDX.PerspectiveCamera
            {
                FieldOfView = option.FieldOfView,
                Position = position,
                LookDirection = look,
                UpDirection = up,
                NearPlaneDistance = near,
                FarPlaneDistance = old.FarPlaneDistance,
            };
            return;
        }

        // Same visible size at the look-at point as the perspective view had. Orthographic
        // gets a negative near plane: its view does not depend on distance, and this keeps
        // the whole object visible even when the camera ends up inside it (that showed the
        // far side of the object, as if the buttons were swapped).
        var fov = old is HelixToolkit.Wpf.SharpDX.PerspectiveCamera p ? p.FieldOfView : 45.0;
        var width = 2.0 * look.Length * Math.Tan(fov * Math.PI / 360.0);
        Camera = new HelixToolkit.Wpf.SharpDX.OrthographicCamera
        {
            Width = width > 0 ? width : 10,
            Position = position,
            LookDirection = look,
            UpDirection = up,
            NearPlaneDistance = -100, // 100 units behind the camera; more would cost depth precision
            FarPlaneDistance = old.FarPlaneDistance,
        };
    }

    // ---- View cube ----

    private HelixToolkit.SharpDX.Core.TextureModel? _viewCubeTexture;

    /// <summary>
    /// View cube with the item's front on the face the standard "Front" view looks at. Game
    /// meshes face +Y, which is -Z in the preview, and Helix's default cube calls -Z "B":
    /// clicking "F" showed the back. Only front and back swap; Helix's R (+X) already is the
    /// item's right side.
    /// </summary>
    public HelixToolkit.SharpDX.Core.TextureModel? ViewCubeTexture
    {
        get
        {
            if (_viewCubeTexture == null && EffectsManager is { IsDisposed: false } effects)
            {
                try
                {
                    var red = new SharpDX.Color4(1f, 0f, 0f, 1f);
                    var blue = new SharpDX.Color4(0f, 0f, 1f, 1f);
                    var green = new SharpDX.Color4(0f, 0.5f, 0f, 1f);
                    var white = new SharpDX.Color4(1f, 1f, 1f, 1f);
                    // Kept as bytes behind a loader: Helix loads a texture again whenever it
                    // recreates its resources (viewport unloaded / reloaded, tab moved, device
                    // reset). A TextureModel over a stream only loads once (the stream is closed
                    // or at its end), and the cube turned black after such a reload.
                    using var stream = HelixToolkit.SharpDX.Core.BitmapExtensions.CreateViewBoxTexture(effects,
                        "B", "F", "L", "R", "U", "D",
                        red, red, blue, blue, green, green,
                        white, white, white, white, white, white);
                    using var copy = new MemoryStream();
                    stream.Position = 0;
                    stream.CopyTo(copy);
                    _viewCubeTexture = new HelixToolkit.SharpDX.Core.TextureModel(Guid.NewGuid(), new BytesTextureLoader(copy.ToArray()));
                }
                catch (Exception ex)
                {
                    Parent?.GetLoggerService()?.Debug($"[Preview] view cube texture: {ex.Message}");
                }
            }

            return _viewCubeTexture;
        }
    }

    /// <summary>Hands Helix a fresh stream over the same bytes on every (re)load.</summary>
    private sealed class BytesTextureLoader : HelixToolkit.SharpDX.Core.ITextureInfoLoader
    {
        private readonly byte[] _data;

        public BytesTextureLoader(byte[] data) => _data = data;

        public HelixToolkit.SharpDX.Core.TextureInfo Load(Guid id) =>
            new(new MemoryStream(_data, writable: false));

        public void Complete(Guid id, HelixToolkit.SharpDX.Core.TextureInfo info, bool succeeded) =>
            info?.Texture?.Dispose();
    }

    // ---- Icons for every appearance ----

    /// <summary>Generates (or reuses cached) materials for the selected appearance; used per appearance by the batch.</summary>
    public async Task GenerateMaterialsForPreviewImageAsync()
    {
        // Selecting the appearance may already have started the automatic generation; wait
        // for it, then generate (cached, so quick) to be sure this appearance is done.
        while (IsLoadingMaterials)
        {
            await Task.Delay(50);
        }

        await GenerateMaterials(clearCache: false, refreshFromDisk: false);
    }

    /// <summary>Asks for the folder of the per-appearance icons; null if cancelled or not confirmed.</summary>
    public string? PickPreviewIconFolder(IReadOnlyList<string> appearanceNames)
    {
        string? rawDir = null;
        try
        {
            rawDir = Parent?.GetActiveProject()?.RawDirectory;
        }
        catch
        {
            // no project
        }

        var dlg = new Microsoft.Win32.OpenFolderDialog
        {
            Title = $"Save icons for {appearanceNames.Count} appearances ({PreviewImageSize.Width}x{PreviewImageSize.Height})",
        };

        var initial = s_previewImageFolder is { } last && Directory.Exists(last) ? last : rawDir;
        if (!string.IsNullOrEmpty(initial) && Directory.Exists(initial))
        {
            dlg.InitialDirectory = initial;
        }

        if (dlg.ShowDialog() != true || string.IsNullOrEmpty(dlg.FolderName))
        {
            return null;
        }

        var folder = dlg.FolderName;
        var existing = 0;
        foreach (var name in appearanceNames)
        {
            if (File.Exists(GetPreviewIconFileName(folder, name)))
            {
                existing++;
            }
        }

        if (existing > 0 &&
            System.Windows.MessageBox.Show(
                $"{existing} of the {appearanceNames.Count} icon files already exist in\n{folder}\n\nOverwrite them?",
                "Save Appearance Icons",
                System.Windows.MessageBoxButton.YesNo,
                System.Windows.MessageBoxImage.Question) != System.Windows.MessageBoxResult.Yes)
        {
            return null;
        }

        s_previewImageFolder = folder;
        return folder;
    }

    // ---- Icon file names: <prefix><appearance><suffix>.png, remembered per file ----

    /// <summary>Prefix and suffix around the appearance name in icon file names.</summary>
    public sealed record IconNameParts(string Prefix, string Suffix);

    private static Dictionary<string, IconNameParts>? s_iconNames;

    private static string IconNamesPath => Path.Combine(ISettingsManager.GetAppData(), "previewIconNames.json");

    /// <summary>The default prefix: the file's name and an underscore (none without a file name).</summary>
    public string DefaultIconNamePrefix =>
        Path.GetFileNameWithoutExtension(GetDocumentDepotPath()) is { } baseName && !string.IsNullOrWhiteSpace(baseName)
            ? baseName + "_"
            : "";

    private string IconNamesKey => GetDocumentDepotPath();

    private Dictionary<string, IconNameParts> IconNames => s_iconNames ??= LoadIconNames();

    private Dictionary<string, IconNameParts> LoadIconNames()
    {
        try
        {
            if (File.Exists(IconNamesPath) &&
                JsonSerializer.Deserialize<Dictionary<string, IconNameParts>>(File.ReadAllText(IconNamesPath)) is { } map)
            {
                return new Dictionary<string, IconNameParts>(map, StringComparer.OrdinalIgnoreCase);
            }
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Preview Image] icon names could not be read: {ex.Message}");
        }

        return new Dictionary<string, IconNameParts>(StringComparer.OrdinalIgnoreCase);
    }

    /// <summary>The prefix and suffix saved for this file, or the default (file name, no suffix).</summary>
    public IconNameParts GetIconNameParts() =>
        IconNameKeyValid && IconNames.TryGetValue(IconNamesKey, out var parts)
            ? parts
            : new IconNameParts(DefaultIconNamePrefix, "");

    private bool IconNameKeyValid => !string.IsNullOrEmpty(IconNamesKey);

    /// <summary>Keeps the prefix and suffix for this file; the default ones remove its entry.</summary>
    public void StoreIconNameParts(string prefix, string suffix)
    {
        if (!IconNameKeyValid)
        {
            return;
        }

        var isDefault = prefix == DefaultIconNamePrefix && suffix.Length == 0;
        var changed = isDefault
            ? IconNames.Remove(IconNamesKey)
            : !IconNames.TryGetValue(IconNamesKey, out var old) || old != new IconNameParts(prefix, suffix);
        if (!changed)
        {
            return;
        }

        if (!isDefault)
        {
            IconNames[IconNamesKey] = new IconNameParts(prefix, suffix);
        }

        try
        {
            var json = JsonSerializer.Serialize(IconNames, new JsonSerializerOptions { WriteIndented = true });
            var temp = IconNamesPath + ".tmp";
            File.WriteAllText(temp, json);
            File.Move(temp, IconNamesPath, true);
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Preview Image] icon names could not be saved: {ex.Message}");
        }
    }

    /// <summary>&lt;prefix&gt;&lt;appearance&gt;&lt;suffix&gt;.png, characters not allowed in file names replaced by '_'.</summary>
    public static string BuildIconFileName(string prefix, string appearanceName, string suffix)
    {
        var name = prefix + appearanceName + suffix;
        foreach (var c in Path.GetInvalidFileNameChars())
        {
            name = name.Replace(c, '_');
        }

        return name + ".png";
    }

    /// <summary>The icon file of an appearance in the folder, with this file's prefix and suffix.</summary>
    public string GetPreviewIconFileName(string folder, string appearanceName)
    {
        var parts = GetIconNameParts();
        return Path.Combine(folder, BuildIconFileName(parts.Prefix, appearanceName, parts.Suffix));
    }

    public void ReportPreviewIconsCancelled(int saved, int total, string folder) =>
        Parent?.GetLoggerService()?.Warning($"[Preview Image] cancelled: {saved} of {total} icons saved → {folder}");

    public void ReportPreviewIcons(int saved, int total, string folder, IReadOnlyCollection<string>? failed = null)
    {
        if (saved == total)
        {
            Parent?.GetLoggerService()?.Success($"[Preview Image] {saved} icons → {folder}");
            return;
        }

        var list = failed is { Count: > 0 } ? $"; not saved: {string.Join(", ", failed)} (reasons above)" : "";
        Parent?.GetLoggerService()?.Warning($"[Preview Image] {saved} of {total} icons saved → {folder}{list}");
    }

    /// <summary>Asks where to save the image; null if cancelled.</summary>
    public string? PickPreviewImageFile()
    {
        string? rawDir = null;
        try
        {
            rawDir = Parent?.GetActiveProject()?.RawDirectory;
        }
        catch
        {
            // no project
        }

        var name = SelectedAppearance?.Name;
        if (string.IsNullOrWhiteSpace(name))
        {
            name = Path.GetFileNameWithoutExtension(GetDocumentDepotPath());
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            name = "preview";
        }

        foreach (var c in Path.GetInvalidFileNameChars())
        {
            name = name.Replace(c, '_');
        }

        var dlg = new Microsoft.Win32.SaveFileDialog
        {
            Title = $"Save Image ({PreviewImageSize.Width}x{PreviewImageSize.Height}, {PreviewBackground.Label.ToLowerInvariant()} background)",
            Filter = "PNG image (*.png)|*.png",
            DefaultExt = ".png",
            AddExtension = true,
            FileName = name + ".png",
        };

        var initial = s_previewImageFolder is { } last && Directory.Exists(last) ? last : rawDir;
        if (!string.IsNullOrEmpty(initial) && Directory.Exists(initial))
        {
            dlg.InitialDirectory = initial;
        }

        if (dlg.ShowDialog() != true || string.IsNullOrEmpty(dlg.FileName))
        {
            return null;
        }

        s_previewImageFolder = Path.GetDirectoryName(dlg.FileName);
        return dlg.FileName;
    }

    public void ReportPreviewImageError(string message) =>
        Parent?.GetLoggerService()?.Error($"[Preview Image] {message}");

    /// <summary>
    /// Builds the PNG from two renders of the same frame, one over black and one over white:
    /// over black a pixel is a·color, over white a·color + (1 − a)·255, so
    /// a = 1 − (white − black) / 255 and the black render is already the premultiplied color.
    /// The object is cropped to its visible pixels, centered and scaled into the square.
    /// </summary>
    public async Task<bool> SavePreviewImageAsync(Stream overBlack, Stream overWhite, string fileName, bool quiet = false)
    {
        var (outW, outH) = PreviewImageSize;
        var options = new PreviewImageLayout(
            PreviewImageMargin / 100f,
            PreviewImageAlignment == "Bottom",
            PreviewBackground.Color);
        try
        {
            var result = await Task.Run(() => BuildPreviewImage(overBlack, overWhite, outW, outH, options, fileName));
            if (result == null)
            {
                ReportPreviewImageError($"nothing visible in the preview: {Path.GetFileName(fileName)}");
                return false;
            }

            var (objectPixels, upscale) = result.Value;
            if (upscale > 1.25f && !quiet)
            {
                Parent?.GetLoggerService()?.Warning(
                    $"[Preview Image] the object is only {objectPixels}px in the preview and was upscaled ×{upscale:0.#}; " +
                    "zoom in or enlarge the preview for a sharper image");
            }

            if (!quiet)
            {
                Parent?.GetLoggerService()?.Success($"[Preview Image] {outW}x{outH} → {fileName}");
            }

            return true;
        }
        catch (Exception ex)
        {
            ReportPreviewImageError($"{Path.GetFileName(fileName)}: {ex.Message}");
            return false;
        }
        finally
        {
            overBlack.Dispose();
            overWhite.Dispose();
        }
    }

    private sealed record PreviewImageLayout(float Margin, bool AlignBottom, Color? Background);

    private static (int ObjectPixels, float Upscale)? BuildPreviewImage(
        Stream overBlack, Stream overWhite, int outW, int outH, PreviewImageLayout layout, string fileName)
    {
        using var black = new Bitmap(overBlack);
        using var white = new Bitmap(overWhite);
        if (black.Width != white.Width || black.Height != white.Height)
        {
            throw new InvalidOperationException("the two renders differ in size");
        }

        int w = black.Width, h = black.Height;
        var b = ReadBgra(black);
        var wh = ReadBgra(white);

        // Premultiplied BGRA of the object alone, plus its bounds.
        var matte = new byte[w * h * 4];
        int minX = w, minY = h, maxX = -1, maxY = -1;
        for (var y = 0; y < h; y++)
        {
            for (var x = 0; x < w; x++)
            {
                var o = (y * w + x) * 4;
                var diff = (wh[o] - b[o] + wh[o + 1] - b[o + 1] + wh[o + 2] - b[o + 2]) / 3f;
                var a = (int)MathF.Round(255f - Math.Clamp(diff, 0f, 255f));
                if (a <= 2)
                {
                    continue; // background
                }

                matte[o] = (byte)Math.Min((int)b[o], a);
                matte[o + 1] = (byte)Math.Min((int)b[o + 1], a);
                matte[o + 2] = (byte)Math.Min((int)b[o + 2], a);
                matte[o + 3] = (byte)a;

                if (a > 8)
                {
                    if (x < minX) minX = x;
                    if (x > maxX) maxX = x;
                    if (y < minY) minY = y;
                    if (y > maxY) maxY = y;
                }
            }
        }

        if (maxX < minX || maxY < minY)
        {
            return null;
        }

        using var source = new Bitmap(w, h, PixelFormat.Format32bppPArgb);
        var data = source.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, PixelFormat.Format32bppPArgb);
        try
        {
            for (var y = 0; y < h; y++)
            {
                Marshal.Copy(matte, y * w * 4, data.Scan0 + y * data.Stride, w * 4);
            }
        }
        finally
        {
            source.UnlockBits(data);
        }

        // Crop with a pixel of slack for the soft edge; fit into the output without distortion,
        // with the chosen margin, centered or standing on the bottom margin.
        var crop = Rectangle.FromLTRB(Math.Max(0, minX - 1), Math.Max(0, minY - 1), Math.Min(w, maxX + 2), Math.Min(h, maxY + 2));
        var margin = Math.Max(layout.Margin > 0 ? 1f : 0f, Math.Min(outW, outH) * layout.Margin);
        var scale = Math.Min((outW - 2 * margin) / crop.Width, (outH - 2 * margin) / crop.Height);
        var dw = crop.Width * scale;
        var dh = crop.Height * scale;
        var top = layout.AlignBottom ? outH - margin - dh : (outH - dh) / 2f;
        var dest = new RectangleF((outW - dw) / 2f, top, dw, dh);

        using var output = new Bitmap(outW, outH, PixelFormat.Format32bppPArgb);
        using (var g = Graphics.FromImage(output))
        using (var attributes = new ImageAttributes())
        {
            g.Clear(layout.Background ?? Color.Transparent);
            g.CompositingMode = CompositingMode.SourceOver;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            attributes.SetWrapMode(WrapMode.TileFlipXY); // no dark seam at the crop border
            g.DrawImage(source,
                [new PointF(dest.Left, dest.Top), new PointF(dest.Right, dest.Top), new PointF(dest.Left, dest.Bottom)],
                crop, GraphicsUnit.Pixel, attributes);
        }

        var dir = Path.GetDirectoryName(fileName);
        if (!string.IsNullOrEmpty(dir))
        {
            Directory.CreateDirectory(dir);
        }

        output.Save(fileName, ImageFormat.Png);
        return (Math.Max(crop.Width, crop.Height), scale);
    }

    private static byte[] ReadBgra(Bitmap bmp)
    {
        int w = bmp.Width, h = bmp.Height;
        var bytes = new byte[w * h * 4];
        var data = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
        try
        {
            for (var y = 0; y < h; y++)
            {
                Marshal.Copy(data.Scan0 + y * data.Stride, bytes, y * w * 4, w * 4);
            }
        }
        finally
        {
            bmp.UnlockBits(data);
        }

        return bytes;
    }
}
