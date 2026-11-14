using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents.Multilayer;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using DxgiFormat = SharpDX.DXGI.Format;
using Material = WolvenKit.App.Models.Material;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Live multilayer preview: instead of baking the mlsetup into PNGs, the layer textures,
/// masks and parameters are uploaded once and blended per pixel by <see cref="MultilayerShader"/>.
/// The bake stays as fallback (shader off, compile failure, too many textures) and for export.
/// </summary>
public partial class RDTMeshViewModel
{
    private bool _useMultilayerShader = true;

    /// <summary>Evaluate multilayer materials in the shader instead of baking them (needs Generate Materials).</summary>
    public bool UseMultilayerShader
    {
        get => _useMultilayerShader;
        set => SetProperty(ref _useMultilayerShader, value);
    }

    /// <summary>
    /// The material and layer pickers only matter in the debug views: Shaded draws every
    /// material whole, so they are greyed out there.
    /// </summary>
    public bool IsMultilayerDebugPickerEnabled => MultilayerShader.DebugMode != 0;

    /// <summary>Debug view of the multilayer shader (see <see cref="MultilayerShader.DebugMode"/>).</summary>
    public int MultilayerDebugMode
    {
        get => MultilayerShader.DebugMode;
        set
        {
            if (MultilayerShader.DebugMode == value)
            {
                return;
            }

            var wasSingleLayerMode = IsSingleLayerDebugMode(MultilayerShader.DebugMode);
            MultilayerShader.DebugMode = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(IsMultilayerDebugPickerEnabled));

            if (value == 0)
            {
                // Back to Shaded: the whole material again, not the layer picked for debugging.
                _selectedMultilayerDebugLayer = null;
                RebuildMultilayerDebugLayers();
            }
            else if (wasSingleLayerMode != IsSingleLayerDebugMode(value))
            {
                // Layer mask / Layer tiling show one layer, so their list has no "All layers".
                RebuildMultilayerDebugLayers();
            }

            ApplyMultilayerDebugView();
        }
    }

    /// <summary>A choice in the debug pickers.</summary>
    public sealed record MultilayerDebugChoice(string Key, int Index, string Label)
    {
        public override string ToString() => Label;
    }

    /// <summary>Multilayer materials of the current appearance shown by the shader.</summary>
    public System.Collections.ObjectModel.ObservableCollection<MultilayerDebugChoice> MultilayerDebugMaterials { get; } = new();

    /// <summary>"All layers" + the layers of <see cref="SelectedMultilayerDebugMaterial"/>.</summary>
    public System.Collections.ObjectModel.ObservableCollection<MultilayerDebugChoice> MultilayerDebugLayers { get; } = new();

    private MultilayerDebugChoice? _selectedMultilayerDebugMaterial;

    public MultilayerDebugChoice? SelectedMultilayerDebugMaterial
    {
        get => _selectedMultilayerDebugMaterial;
        set
        {
            if (!SetProperty(ref _selectedMultilayerDebugMaterial, value))
            {
                return;
            }

            _selectedMultilayerDebugLayer = null;
            RebuildMultilayerDebugLayers();
        }
    }

    /// <summary>Layer mask (6) and Layer tiling (7) show a single layer.</summary>
    private static bool IsSingleLayerDebugMode(int mode) => mode is 6 or 7;

    /// <summary>
    /// Fills the layer picker for the selected material: "All layers" (no solo) and its layers,
    /// without "All layers" in the single-layer modes. Keeps the picked layer when it is still
    /// listed; otherwise picks "All layers", or in the single-layer modes the first masked
    /// layer (layer 0 is the base and always fully covered).
    /// </summary>
    private void RebuildMultilayerDebugLayers()
    {
        var material = SelectedMultilayerDebugMaterial;
        var previous = SelectedMultilayerDebugLayer;
        var singleLayer = IsSingleLayerDebugMode(MultilayerDebugMode);

        MultilayerDebugLayers.Clear();
        if (!singleLayer)
        {
            MultilayerDebugLayers.Add(new MultilayerDebugChoice(material?.Key ?? "", -1, "All layers"));
        }

        // "All materials" (sector previews) lists the layers of the first material: the solo
        // layer then goes by number to every material (terrain cells share one mlsetup).
        var labelsFrom = material is { Key: "" }
            ? MultilayerDebugMaterials.FirstOrDefault(c => c.Key.Length > 0)?.Key
            : material?.Key;
        if (material != null && labelsFrom != null && _multilayerGpuData.TryGetValue(labelsFrom, out var data))
        {
            for (var i = 0; i < data.LayerLabels.Count; i++)
            {
                MultilayerDebugLayers.Add(new MultilayerDebugChoice(material.Key, i, data.LayerLabels[i]));
            }
        }

        if (MultilayerDebugLayers.Count == 0)
        {
            SelectedMultilayerDebugLayer = null;
            return;
        }

        SelectedMultilayerDebugLayer =
            (previous != null ? MultilayerDebugLayers.FirstOrDefault(l => l == previous) : null)
            ?? (singleLayer ? MultilayerDebugLayers[Math.Min(1, MultilayerDebugLayers.Count - 1)] : MultilayerDebugLayers[0]);
    }

    private MultilayerDebugChoice? _selectedMultilayerDebugLayer;

    /// <summary>Solo layer of the selected material; every other material shows all its layers.</summary>
    public MultilayerDebugChoice? SelectedMultilayerDebugLayer
    {
        get => _selectedMultilayerDebugLayer;
        set
        {
            if (!SetProperty(ref _selectedMultilayerDebugLayer, value))
            {
                return;
            }

            ApplyMultilayerDebugView();
        }
    }

    /// <summary>
    /// The debug view and the solo layer apply to the selected material only; every other mesh
    /// keeps its normal shaded look (debugging the pants does not turn the jacket into a mask).
    /// Sector / block previews also offer "All materials": the view and the solo layer number
    /// then apply to every multilayer material, so neighbouring pieces (terrain cells sharing
    /// one mlsetup) can be compared.
    /// </summary>
    private void ApplyMultilayerDebugView()
    {
        var target = SelectedMultilayerDebugMaterial?.Key is { Length: > 0 } key ? key : null;
        var layer = SelectedMultilayerDebugLayer;
        // Copies carrying a decal overlay are debugged like their material.
        foreach (var (name, material) in Materials.Concat(_decalOverlayMaterials.Select(x => new KeyValuePair<string, PBRMaterial>(x.Key, x.Value))))
        {
            if (material is not MultilayerPBRMaterial ml)
            {
                continue;
            }

            var isTarget = target == null || name == target;
            var mode = isTarget ? MultilayerShader.DebugMode : 0;
            var solo = !isTarget || layer == null ? -1
                : target != null || !IsObjectPreview || layer.Key == name ? layer.Index : -1;

            if (ml.DebugMode != mode)
            {
                ml.DebugMode = mode;
            }

            if (ml.SoloLayer != solo)
            {
                ml.SoloLayer = solo;
            }
        }
    }

    /// <summary>Refills the material picker after Generate Materials / an appearance change.</summary>
    private void RefreshMultilayerDebugMaterials()
    {
        var previous = SelectedMultilayerDebugMaterial?.Key;
        MultilayerDebugMaterials.Clear();

        var names = (SelectedAppearance?.RawMaterials.Keys ?? Enumerable.Empty<string>())
            .Where(n => _multilayerGpuData.ContainsKey(n))
            .ToList();

        // Short names; where two meshes of the entity have a material of the same name,
        // the mesh is added: "default (t1_jacket)".
        string Plain(string n) => SubmeshComponent.StripMeshPrefix(n) ?? n;
        var ambiguous = names.GroupBy(Plain, StringComparer.OrdinalIgnoreCase)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToHashSet(StringComparer.OrdinalIgnoreCase);

        if (!IsObjectPreview && names.Count > 1)
        {
            MultilayerDebugMaterials.Add(new MultilayerDebugChoice("", -1, "All materials"));
        }

        foreach (var name in names.OrderBy(Plain, StringComparer.OrdinalIgnoreCase).ThenBy(n => n))
        {
            var label = Plain(name);
            if (ambiguous.Contains(label))
            {
                // cache key = "<mesh>_<8 hex>__<material>"
                var cut = name.Length - label.Length - "_00000000__".Length;
                if (cut > 0)
                {
                    label += $" ({name[..cut]})";
                }
            }

            MultilayerDebugMaterials.Add(new MultilayerDebugChoice(name, -1, label));
        }

        // Re-select even when the choice is equal (records compare by value): its layers may have
        // changed with the files, and the materials were re-created by Generate.
        var previousLayer = SelectedMultilayerDebugLayer;
        _selectedMultilayerDebugMaterial = null;
        SelectedMultilayerDebugMaterial =
            MultilayerDebugMaterials.FirstOrDefault(c => c.Key == previous)
            ?? MultilayerDebugMaterials.FirstOrDefault(c => c.Key.Length > 0)
            ?? MultilayerDebugMaterials.FirstOrDefault();

        if (previousLayer != null && MultilayerDebugLayers.FirstOrDefault(l => l == previousLayer) is { } sameLayer)
        {
            SelectedMultilayerDebugLayer = sameLayer;
        }

        ApplyMultilayerDebugView();
    }

    /// <summary>Selecting a submesh in the tree picks its material in the debug picker.</summary>
    private void SyncMultilayerDebugMaterial(object? selected)
    {
        if (selected is SubmeshComponent { MaterialName: { } name } &&
            MultilayerDebugMaterials.FirstOrDefault(c => c.Key == name) is { } choice)
        {
            SelectedMultilayerDebugMaterial = choice;
        }
    }

    // ---- Export Materials ----

    /// <summary>Sizes offered for multilayer maps by Export Materials.</summary>
    public IReadOnlyList<int> MultilayerExportResolutions { get; } = [1024, 2048, 4096];

    private int _multilayerExportResolution = 2048;

    /// <summary>Square size of the exported multilayer maps.</summary>
    public int MultilayerExportResolution
    {
        get => _multilayerExportResolution;
        set => SetProperty(ref _multilayerExportResolution, value);
    }

    // Set while Export Materials runs: LoadMaterial records every material and bakes multilayer
    // at exactly the chosen size.
    private bool _exportBake;
    private readonly HashSet<string> _exportBakedNames = new(StringComparer.Ordinal);

    // Last export folder per project (or "" without a project), for this session.
    private static readonly Dictionary<string, string> s_exportFolders = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Bakes every material of the selected appearance and copies its _d / _n / _rm (and
    /// _emissive) PNGs to a folder the user picks. Multilayer maps are baked at
    /// <see cref="MultilayerExportResolution"/>; the other kinds keep their source size.
    /// _d is sRGB; _n (OpenGL, Y up) and _rm (G roughness, B metalness) are Non-Color in Blender.
    /// </summary>
    [CommunityToolkit.Mvvm.Input.RelayCommand]
    private async Task ExportMaterials()
    {
        if (IsLoadingMaterials || SelectedAppearance == null)
        {
            return;
        }

        var folder = PickExportFolder();
        if (folder == null)
        {
            return;
        }

        var size = MultilayerExportResolution;
        IsLoadingMaterials = true;
        lock (_exportBakedNames)
        {
            _exportBakedNames.Clear();
        }

        try
        {
            RefreshMaterialsFromDisk();

            IEnumerable<KeyValuePair<string, Material>> batch = SelectedAppearance.RawMaterials;
            if (SelectedAppearance.Models is { Count: > 0 } models)
            {
                var names = models.SelectMany(m => m.Materials.Select(x => x.Name)).ToHashSet();
                if (names.Count > 0)
                {
                    batch = batch.Where(x => names.Contains(x.Key));
                }
            }

            var ordered = batch.OrderBy(x => x.Key).ToList();
            _exportBake = true;
            await Task.Run(async () =>
            {
                foreach (var (_, m) in ordered)
                {
                    await LoadMaterial(m, size, forceBake: false);
                }
            });
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Error($"[Export Materials] {ex.Message}");
            return;
        }
        finally
        {
            _exportBake = false;
            IsLoadingMaterials = false;
        }

        List<string> baked;
        lock (_exportBakedNames)
        {
            baked = _exportBakedNames.OrderBy(x => x).ToList();
        }

        // Plain material names ("hair_cards"), unless two meshes share one: then the cache
        // name with its mesh prefix keeps them apart.
        var duplicates = baked
            .GroupBy(n => SubmeshComponent.StripMeshPrefix(n) ?? n, StringComparer.OrdinalIgnoreCase)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToHashSet(StringComparer.OrdinalIgnoreCase);

        var copies = new List<(string Source, string Target)>();
        foreach (var name in baked)
        {
            var (bd, bn, rm) = GetMaterialFilePathsFromCache(name);
            var plain = SubmeshComponent.StripMeshPrefix(name) ?? name;
            var baseName = SanitizeFileName(duplicates.Contains(plain) ? name : plain);
            var emissive = Path.Combine(ISettingsManager.GetTemp_OBJPath(), name + "_emissive.png");
            foreach (var (src, suffix) in new[] { (bd, "_d.png"), (bn, "_n.png"), (rm, "_rm.png"), (emissive, "_emissive.png") })
            {
                if (File.Exists(src))
                {
                    copies.Add((src, Path.Combine(folder, baseName + suffix)));
                }
            }
        }

        if (copies.Count == 0)
        {
            Parent?.GetLoggerService()?.Warning("[Export Materials] nothing was baked for this appearance");
            return;
        }

        var existing = copies.Count(c => File.Exists(c.Target));
        if (existing > 0)
        {
            var answer = System.Windows.MessageBox.Show(
                $"{existing} file(s) already exist in\n{folder}\n\nOverwrite them?",
                "Export Materials", System.Windows.MessageBoxButton.YesNo, System.Windows.MessageBoxImage.Question);
            if (answer != System.Windows.MessageBoxResult.Yes)
            {
                return;
            }
        }

        var failed = 0;
        foreach (var (src, dst) in copies)
        {
            try
            {
                File.Copy(src, dst, overwrite: true);
            }
            catch (Exception ex)
            {
                failed++;
                Parent?.GetLoggerService()?.Warning($"[Export Materials] {Path.GetFileName(dst)}: {ex.Message}");
            }
        }

        Parent?.GetLoggerService()?.Success(
            $"[Export Materials] {baked.Count} material(s), {copies.Count - failed} file(s), multilayer at {size}px → {folder}");
    }

    /// <summary>
    /// Folder dialog. Starts in the last folder used for this project, else in the project's
    /// raw folder next to this mesh (raw\&lt;mesh folder&gt;), else in the raw folder itself.
    /// </summary>
    private string? PickExportFolder()
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

        var key = rawDir ?? string.Empty;
        string? initial = null;
        if (s_exportFolders.TryGetValue(key, out var last) && Directory.Exists(last))
        {
            initial = last;
        }
        else if (!string.IsNullOrEmpty(rawDir))
        {
            var depotDir = Path.GetDirectoryName(GetDocumentDepotPath()) ?? string.Empty;
            var nextToMesh = Path.Combine(rawDir, depotDir);
            initial = !Path.IsPathRooted(depotDir) && Directory.Exists(nextToMesh) ? nextToMesh : rawDir;
        }

        var dlg = new Microsoft.Win32.OpenFolderDialog
        {
            Title = $"Export Materials (multilayer {MultilayerExportResolution}px): choose the output folder",
            Multiselect = false,
        };
        if (!string.IsNullOrEmpty(initial) && Directory.Exists(initial))
        {
            dlg.InitialDirectory = initial;
        }

        if (dlg.ShowDialog() != true || string.IsNullOrEmpty(dlg.FolderName))
        {
            return null;
        }

        s_exportFolders[key] = dlg.FolderName;
        return dlg.FolderName;
    }

    // Material name → GPU data built by the last Generate Materials.
    private readonly ConcurrentDictionary<string, MultilayerGpuData> _multilayerGpuData = new(StringComparer.Ordinal);

    // One TextureModel per (file, channel, project stamp): shared by every material and layer that
    // uses it, and rebuilt only when the project copy of the file changes. Ctrl clears it.
    private readonly ConcurrentDictionary<string, TextureEntry> _multilayerTextureCache = new(StringComparer.OrdinalIgnoreCase);

    // Decoded masks of one .mlmask (per project stamp), one entry per layer.
    private readonly ConcurrentDictionary<string, TextureEntry[]> _multilayerMaskCache = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// A texture for the pool, or a constant when the source is a solid placeholder
    /// (engine black/white/grey/flat-normal and lookalikes in other folders).
    /// </summary>
    private sealed class TextureEntry
    {
        public TextureModel? Texture { get; init; }

        /// <summary>BGRA 0..1 of the solid colour when <see cref="Texture"/> is null.</summary>
        public float B { get; init; }
        public float G { get; init; }
        public float R { get; init; }
        public float A { get; init; }

        public bool IsConstant => Texture == null;
    }

    // 1x1 flat tangent-space normal (B=255, G=128, R=128, A=255).
    private static readonly TextureModel s_flatNormal =
        new(new byte[] { 255, 128, 128, 255 }, DxgiFormat.B8G8R8A8_UNorm, 1, 1);

    /// <summary>
    /// Smooth per-vertex tangent frame for the preview shaders. T is the mesh's own tangent when
    /// available (else the averaged UV gradient), oriented along +U; B follows +V of the UVs as given (the same directions as the screen-space frame the shaders used before,
    /// so normal maps keep their relief). Both are averaged over the triangles of a vertex and
    /// made orthogonal to its normal; B keeps its own sign, so mirrored UVs stay correct.
    /// </summary>
    private static void ComputeSmoothTangentFrame(
        IList<SharpDX.Vector3> positions, IList<SharpDX.Vector3> normals, IList<SharpDX.Vector2> uvs, IList<int> indices,
        out Vector3Collection tangents, out Vector3Collection bitangents,
        IList<SharpDX.Vector3>? sourceTangents = null)
    {
        var n = positions.Count;
        var accT = new SharpDX.Vector3[n];
        var accB = new SharpDX.Vector3[n];

        for (var i = 0; i + 2 < indices.Count; i += 3)
        {
            int i0 = indices[i], i1 = indices[i + 1], i2 = indices[i + 2];
            if (i0 >= n || i1 >= n || i2 >= n || i0 >= uvs.Count || i1 >= uvs.Count || i2 >= uvs.Count)
            {
                continue;
            }

            var e1 = positions[i1] - positions[i0];
            var e2 = positions[i2] - positions[i0];
            var d1 = uvs[i1] - uvs[i0];
            var d2 = uvs[i2] - uvs[i0];
            var det = (d1.X * d2.Y) - (d2.X * d1.Y);
            if (MathF.Abs(det) < 1e-12f)
            {
                continue; // degenerate UV triangle
            }

            var r = 1f / det;
            var t = ((e1 * d2.Y) - (e2 * d1.Y)) * r;
            var b = ((e2 * d1.X) - (e1 * d2.X)) * r;

            // Area weighting comes from the unnormalized cross terms; it keeps tiny slivers
            // from dominating the average.
            accT[i0] += t; accT[i1] += t; accT[i2] += t;
            accB[i0] += b; accB[i1] += b; accB[i2] += b;
        }

        tangents = new Vector3Collection(n);
        bitangents = new Vector3Collection(n);
        for (var v = 0; v < n; v++)
        {
            var nv = v < normals.Count ? normals[v] : SharpDX.Vector3.UnitY;
            if (nv.LengthSquared() < 1e-12f)
            {
                nv = SharpDX.Vector3.UnitY;
            }

            nv.Normalize();

            // The mesh's own tangent (what its normal maps were baked against) when it has one.
            // Averaging UV gradients fails where a vertex is shared by mirrored UV islands:
            // the gradients cancel and the tangent points anywhere.
            var t = SharpDX.Vector3.Zero;
            if (sourceTangents != null && v < sourceTangents.Count)
            {
                var src = sourceTangents[v];
                t = src - (nv * SharpDX.Vector3.Dot(nv, src));
            }

            if (t.LengthSquared() < 1e-8f)
            {
                t = accT[v] - (nv * SharpDX.Vector3.Dot(nv, accT[v]));
            }
            else if (SharpDX.Vector3.Dot(t, accT[v]) < 0)
            {
                // Keep the +U direction the shaders expect.
                t = -t;
            }

            if (t.LengthSquared() < 1e-12f)
            {
                // No usable UV gradient: any vector perpendicular to the normal.
                t = SharpDX.Vector3.Cross(nv, MathF.Abs(nv.Y) < 0.9f ? SharpDX.Vector3.UnitY : SharpDX.Vector3.UnitX);
            }

            t.Normalize();

            var bPerp = SharpDX.Vector3.Cross(nv, t);
            if (SharpDX.Vector3.Dot(bPerp, accB[v]) < 0)
            {
                bPerp = -bPerp;
            }

            tangents.Add(t);
            bitangents.Add(bPerp);
        }
    }

    // ---- Missing files / embedded files ----

    private readonly HashSet<string> _missingFilesWarned = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Logs a referenced file the preview could not use, once per Generate: not found anywhere
    /// (document, project, mods, archive), found but of the wrong kind (a texture path where an
    /// mlsetup is expected, or the other way round, which File Validation does not catch),
    /// or found but unreadable. Without it such a slot just stays empty or grey.
    /// </summary>
    private void WarnMissingFile(string kind, ResourcePath path, string? context = null)
    {
        if (path == ResourcePath.Empty)
        {
            return;
        }

        var text = path.GetResolvedText() ?? path.ToString() ?? string.Empty;
        lock (_missingFilesWarned)
        {
            if (!_missingFilesWarned.Add(kind + "|" + text + "|" + context))
            {
                return;
            }
        }

        RedBaseClass? root = null;
        try
        {
            root = GetProjectOrDepotFile(path)?.RootChunk;
        }
        catch
        {
            // reported as not found
        }

        string problem;
        if (root == null)
        {
            problem = $"{kind} not found";
        }
        else if (IsExpectedKind(kind, root))
        {
            problem = $"{kind} could not be read";
        }
        else
        {
            problem = $"wrong file type: expected {kind}, the path points to {DescribeFileKind(root)}";
        }

        Parent?.GetLoggerService()?.Warning(
            $"[Preview] {(string.IsNullOrEmpty(context) ? "" : context + ": ")}{problem}: {text}");
    }

    private static bool IsExpectedKind(string kind, RedBaseClass root) => kind switch
    {
        "texture" or "microblend" => root is ITexture,
        "mlsetup" => root is Multilayer_Setup,
        "mlmask" => root is Multilayer_Mask,
        "mltemplate" => root is Multilayer_LayerTemplate,
        "material" or "base material" => root is WolvenKit.RED4.Types.IMaterial,
        _ => true,
    };

    private static string DescribeFileKind(RedBaseClass root) => root switch
    {
        Multilayer_Setup => "an mlsetup",
        Multilayer_Mask => "an mlmask",
        Multilayer_LayerTemplate => "an mltemplate",
        ITexture => "a texture",
        CMaterialInstance => "a material instance (.mi)",
        CMesh => "a mesh",
        _ => "a " + root.GetType().Name,
    };

    /// <summary>
    /// The modding wiki: preloaded and non-preloaded material lists must not be mixed in one
    /// mesh; in game, materials outside the preload list may render transparent. The preview
    /// itself reads localMaterialBuffer first, so it can look right while the game does not.
    /// </summary>
    private void WarnMixedMaterialLists(CMesh mesh, string? meshPath)
    {
        var preloadLocal = mesh.PreloadLocalMaterialInstances.Count(h => !ReferenceEquals(h, _generatedInstanceHandle));
        var bufferLocal = mesh.LocalMaterialBuffer?.Materials?.Count ?? 0;
        if (bufferLocal == 0 && mesh.LocalMaterialBuffer?.RawData?.Buffer.Data is CR2WList raw)
        {
            bufferLocal = raw.Files.Count;
        }

        var external = mesh.ExternalMaterials.Count;
        var preloadExternal = mesh.PreloadExternalMaterials?.Count ?? 0;

        var name = string.IsNullOrEmpty(meshPath) ? Path.GetFileName(GetDocumentDepotPath()) : Path.GetFileName(meshPath);
        if (preloadLocal > 0 && bufferLocal > 0)
        {
            WarnOnce($"mixed-local|{meshPath}",
                $"[Preview] {name}: mixes preloadLocalMaterialInstances ({preloadLocal}) and localMaterialBuffer ({bufferLocal}). " +
                "These lists must not be mixed: in game, materials outside the preload list may render transparent. " +
                "The preview reads localMaterialBuffer first.");
        }

        if (preloadExternal > 0 && external > 0)
        {
            WarnOnce($"mixed-external|{meshPath}",
                $"[Preview] {name}: mixes preloadExternalMaterials ({preloadExternal}) and externalMaterials ({external}). " +
                "These lists must not be mixed: in game, materials outside the preload list may render transparent. " +
                "The preview reads externalMaterials first.");
        }
    }

    private void WarnOnce(string key, string message)
    {
        lock (_missingFilesWarned)
        {
            if (!_missingFilesWarned.Add(key))
            {
                return;
            }
        }

        Parent?.GetLoggerService()?.Warning(message);
    }

    /// <summary>Content of a file embedded in the open document under this path, if any.</summary>
    private RedBaseClass? FindEmbeddedContent(ResourcePath path)
    {
        if (path == ResourcePath.Empty)
        {
            return null;
        }

        var files = Parent?.Cr2wFile?.EmbeddedFiles;
        if (files == null)
        {
            return null;
        }

        foreach (var file in files)
        {
            if (file.FileName == path)
            {
                return file.Content;
            }
        }

        return null;
    }

    private RedBaseClass? FindEmbeddedContent(string relPath) =>
        string.IsNullOrEmpty(relPath) ? null : FindEmbeddedContent((ResourcePath)relPath);

    private void ClearMultilayerShaderCache()
    {
        _multilayerGpuData.Clear();
        _multilayerTextureCache.Clear();
        _multilayerMaskCache.Clear();
    }

    /// <summary>
    /// Builds the shader data for a multilayer material. Returns false when the material is not
    /// multilayer or cannot be shown by the shader; the caller then bakes it as before.
    /// </summary>
    private async Task<bool> TryBuildMultilayerGpuData(Material material, Dictionary<string, object> dictionary)
    {
        _multilayerGpuData.TryRemove(material.Name, out _);

        if (!UseMultilayerShader || !MultilayerShader.IsAvailable)
        {
            return false;
        }

        if (!dictionary.TryGetValue("MultilayerSetup", out var mlsetup) ||
            !dictionary.TryGetValue("MultilayerMask", out var mlmask) ||
            mlsetup is not CResourceReference<Multilayer_Setup> mlsRef ||
            mlmask is not CResourceReference<Multilayer_Mask> mlmRef)
        {
            return false;
        }

        var materialLabel = SubmeshComponent.StripMeshPrefix(material.Name) ?? material.Name;
        if (GetReferencedFile(mlsRef.DepotPath, mlsRef.Flags)?.RootChunk is not Multilayer_Setup mls)
        {
            WarnMissingFile("mlsetup", mlsRef.DepotPath, materialLabel);
            return false;
        }

        var masks = await GetMultilayerMasks(mlmRef.DepotPath);
        if (masks == null)
        {
            WarnMissingFile("mlmask", mlmRef.DepotPath, materialLabel);
            return false;
        }

        var pool = new List<TextureModel>();
        var poolIndex = new Dictionary<TextureModel, int>(ReferenceEqualityComparer.Instance);

        int Slot(TextureModel tex)
        {
            if (!poolIndex.TryGetValue(tex, out var idx))
            {
                idx = pool.Count;
                pool.Add(tex);
                poolIndex[tex] = idx;
            }

            return idx;
        }

        // Filled as a plain array: a Span cannot live across the awaits below.
        var c = new float[MultilayerConstants.FloatCount];
        const int HeaderFloats = MultilayerConstants.HeaderVectors * 4;
        const int LayerFloats = MultilayerShader.VectorsPerLayer * 4;

        var written = 0;
        var layerLog = new List<string>();
        var layerLabels = new List<string>();
        for (var layerIndex = 0; layerIndex < mls.Layers.Count; layerIndex++)
        {
            var layer = mls.Layers[layerIndex];
            if (written >= MultilayerShader.MaxLayers || layerIndex >= masks.Length)
            {
                break;
            }

            if (layer.Material.DepotPath == ResourcePath.Empty ||
                GetProjectOrDepotFile(layer.Material.DepotPath)?.RootChunk is not Multilayer_LayerTemplate mllt)
            {
                WarnMissingFile("mltemplate", layer.Material.DepotPath, $"{materialLabel}, layer {layerIndex}");
                continue;
            }

            var layerLabel = $"{materialLabel}, layer {layerIndex}";

            var isBaseLayer = layerIndex == 0;
            var opacity = (float)layer.Opacity;
            if (!isBaseLayer && opacity < 0.0001f)
            {
                continue;
            }

            // ---- mask (layer 0 never uses one) ----
            var maskIdx = -1f;
            var maskConst = 1f;
            if (!isBaseLayer)
            {
                var mask = masks[layerIndex];
                if (mask.IsConstant)
                {
                    maskConst = mask.R;
                    if (maskConst <= 0f)
                    {
                        continue; // solid black mask: the layer is invisible everywhere
                    }
                }
                else
                {
                    maskIdx = Slot(mask.Texture!);
                }
            }

            // ---- tiling ----
            var tilingMul = 1f;
            try
            {
                tilingMul = (float)mllt.TilingMultiplier;
                if (tilingMul < 0.0001f)
                {
                    tilingMul = 1f;
                }
            }
            catch
            {
                tilingMul = 1f;
            }

            var matTile = (float)layer.MatTile * tilingMul;
            if (matTile < 0.0001f)
            {
                matTile = 1f;
            }

            var mbTile = (float)layer.MbTile;
            if (mbTile < 0.0001f)
            {
                mbTile = 1f;
            }

            // ---- microblend ----
            var mbIdx = -1f;
            var mbPath = MicroblendOrDefault(layer.Microblend.DepotPath, layerLabel);
            if (mbPath != ResourcePath.Empty)
            {
                // Never a constant: a solid microblend (default.xbm: flat normal, alpha ~0.41)
                // still drives the mask mixer, so it gets a tiny texture instead.
                var mb = await GetMultilayerTexture(mbPath, channel: -1, allowConstant: false, context: layerLabel);
                if (mb?.Texture != null)
                {
                    mbIdx = Slot(mb.Texture);
                }
            }

            // ---- colour ----
            float cr = 1f, cg = 1f, cb = 1f;
            var colorOv = FindOverride(mllt.Overrides.ColorScale, layer.ColorScale, mllt.DefaultOverrides?.ColorScale, x => x.N);
            var colorVec = colorOv?.V;
            if (colorVec != null && colorVec.Count >= 3)
            {
                cr = colorVec[0];
                cg = colorVec[1];
                cb = colorVec[2];
            }

            var colorIdx = -1f;
            var hasConstColor = false;
            float ccR = 1f, ccG = 1f, ccB = 1f;
            var useColorTexture = false;
            if (mllt.ColorTexture.DepotPath != ResourcePath.Empty && opacity > 0)
            {
                var col = await GetMultilayerTexture(mllt.ColorTexture.DepotPath, channel: -1, context: layerLabel);
                if (col != null)
                {
                    useColorTexture = true;
                    if (col.IsConstant)
                    {
                        hasConstColor = true;
                        ccR = col.R;
                        ccG = col.G;
                        ccB = col.B;
                    }
                    else
                    {
                        colorIdx = Slot(col.Texture!);
                    }
                }
            }

            var colorEnabled = !(opacity == 0 || (!useColorTexture && colorVec == null));

            // ---- levels ----
            TryGetLevels(mllt.Overrides.RoughLevelsIn, layer.RoughLevelsIn, mllt.DefaultOverrides?.RoughLevelsIn, x => x.N, x => x.V,
                out var roughInScale, out var roughInOffset);
            TryGetLevels(mllt.Overrides.RoughLevelsOut, layer.RoughLevelsOut, mllt.DefaultOverrides?.RoughLevelsOut, x => x.N, x => x.V,
                out var roughOutScale, out var roughOutOffset);
            TryGetLevels(mllt.Overrides.MetalLevelsIn, layer.MetalLevelsIn, mllt.DefaultOverrides?.MetalLevelsIn, x => x.N, x => x.V,
                out var metalInScale, out var metalInOffset);
            TryGetLevels(mllt.Overrides.MetalLevelsOut, layer.MetalLevelsOut, mllt.DefaultOverrides?.MetalLevelsOut, x => x.N, x => x.V,
                out var metalOutScale, out var metalOutOffset);

            // ---- roughness / metalness (bake: roughness from G, metalness from B) ----
            var roughIdx = -1f;
            var roughConst = 0.5f;
            if (mllt.RoughnessTexture.DepotPath != ResourcePath.Empty)
            {
                var rough = await GetMultilayerTexture(mllt.RoughnessTexture.DepotPath, channel: 1, context: layerLabel);
                if (rough != null)
                {
                    if (rough.IsConstant)
                    {
                        roughConst = rough.G;
                    }
                    else
                    {
                        roughIdx = Slot(rough.Texture!);
                    }
                }
            }

            var metalIdx = -1f;
            var metalConst = 0f;
            if (mllt.MetalnessTexture.DepotPath != ResourcePath.Empty)
            {
                if (mllt.MetalnessTexture.DepotPath == mllt.RoughnessTexture.DepotPath)
                {
                    // Same file (packed _r / foil): the bake reuses the roughness sample.
                    metalIdx = roughIdx;
                    metalConst = roughConst;
                }
                else
                {
                    var metal = await GetMultilayerTexture(mllt.MetalnessTexture.DepotPath, channel: 0, context: layerLabel);
                    if (metal != null)
                    {
                        if (metal.IsConstant)
                        {
                            metalConst = metal.B;
                        }
                        else
                        {
                            metalIdx = Slot(metal.Texture!);
                        }
                    }
                }
            }

            // ---- normal ----
            var nsOv = FindOverride(mllt.Overrides.NormalStrength, layer.NormalStrength, mllt.DefaultOverrides?.NormalStrength, x => x.N);
            var normalStrength = nsOv != null ? (float)nsOv.V : 1f;

            var normalIdx = -1f;
            if (mllt.NormalTexture.DepotPath != ResourcePath.Empty)
            {
                var nrm = await GetMultilayerTexture(mllt.NormalTexture.DepotPath, channel: -1, context: layerLabel);
                // A solid normal is a flat placeholder: no detail, so no slot.
                if (nrm?.Texture != null)
                {
                    normalIdx = Slot(nrm.Texture);
                }
            }

            if (pool.Count > MultilayerShader.PoolSize)
            {
                Parent?.GetLoggerService()?.Warning(
                    $"[ML shader] '{material.Name}': more than {MultilayerShader.PoolSize} unique textures, using the bake");
                return false;
            }

            // ---- write the layer (layout: see psMultilayer.hlsl) ----
            var o = HeaderFloats + (written * LayerFloats);
            Set(c, o + 0, cr, cg, cb, opacity);
            Set(c, o + 4, matTile, mbTile, (float)layer.OffsetU, (float)layer.OffsetV);
            Set(c, o + 8, (float)layer.MicroblendOffsetU, (float)layer.MicroblendOffsetV,
                (float)layer.MicroblendContrast, (float)layer.MicroblendNormalStrength);
            Set(c, o + 12, roughInScale, roughInOffset, roughOutScale, roughOutOffset);
            Set(c, o + 16, metalInScale, metalInOffset, metalOutScale, metalOutOffset);
            Set(c, o + 20, normalStrength, roughConst, metalConst, colorEnabled ? 1f : 0f);
            Set(c, o + 24, maskIdx, colorIdx, normalIdx, roughIdx);
            Set(c, o + 28, metalIdx, mbIdx, isBaseLayer ? 1f : 0f, maskConst);
            Set(c, o + 32, ccR, ccG, ccB, hasConstColor ? 1f : 0f);
            var templateName = Path.GetFileNameWithoutExtension(layer.Material.DepotPath.GetResolvedText() ?? "");
            layerLog.Add($"{written}: mlsetup layer {layerIndex}, {templateName}, " +
                         $"tile {matTile:0.##}/{mbTile:0.##}, opacity {opacity:0.##}");
            layerLabels.Add($"Layer {layerIndex}: {templateName}");
            written++;
        }

        if (written == 0)
        {
            return false;
        }

        // ---- GlobalNormal (off when the material sets UseGlobalNormal to 0) ----
        var globalIdx = -1f;
        var globalIntensity = 1f;
        float gScaleU = 1f, gScaleV = 1f, gBiasU = 0f, gBiasV = 0f;
        if (UsesGlobalNormal(dictionary) &&
            dictionary.TryGetValue("GlobalNormal", out var gObj) &&
            gObj is CResourceReference<ITexture> gRef &&
            gRef.DepotPath != ResourcePath.Empty)
        {
            var g = await GetMultilayerTexture(gRef.DepotPath, channel: -1, context: $"{materialLabel}, GlobalNormal");
            if (g?.Texture != null)
            {
                globalIdx = Slot(g.Texture);
            }

            if (dictionary.TryGetValue("GlobalNormalIntensity", out var gInt) && gInt != null)
            {
                globalIntensity = ReadFloat(gInt);
            }

            if (dictionary.TryGetValue("GlobalNormalUVScale", out var gSc) && gSc is Vector4 gScV)
            {
                gScaleU = gScV.X;
                gScaleV = gScV.Y;
            }

            if (dictionary.TryGetValue("GlobalNormalUVBias", out var gBi) && gBi is Vector4 gBiV)
            {
                gBiasU = gBiV.X;
                gBiasV = gBiV.Y;
            }
        }

        if (pool.Count > MultilayerShader.PoolSize)
        {
            Parent?.GetLoggerService()?.Warning(
                $"[ML shader] '{material.Name}': more than {MultilayerShader.PoolSize} unique textures, using the bake");
            return false;
        }

        Set(c, 0, written, globalIdx, globalIntensity, 0f);
        Set(c, 4, gScaleU, gScaleV, gBiasU, gBiasV);
        Set(c, MultilayerConstants.DebugOffset, 0f, -1f, 0f, 0f); // filled per draw
        Set(c, MultilayerConstants.OverlayOffset, -1f, -1f, -1f, -1f); // no decal overlay
        Set(c, MultilayerConstants.OverlayBOffset, -1f, -1f, -1f, -1f);
        Set(c, MultilayerConstants.OverlayFlagsOffset, 0f, 0f, 0f, 0f);

        _multilayerGpuData[material.Name] = new MultilayerGpuData(pool.ToArray(), Pack(c), layerLabels);
        Parent?.GetLoggerService()?.Debug(
            $"[ML shader] '{material.Name}': {written} layers, {pool.Count} textures\n  " + string.Join("\n  ", layerLog));
        return true;

        static void Set(float[] values, int offset, float x, float y, float z, float w)
        {
            values[offset] = x;
            values[offset + 1] = y;
            values[offset + 2] = z;
            values[offset + 3] = w;
        }
    }

    private static MultilayerConstants Pack(float[] values)
    {
        var constants = new MultilayerConstants();
        values.AsSpan().CopyTo(constants);
        return constants;
    }

    // Textures up to this many pixels are decoded on the CPU (cheap) so solid placeholders
    // become constants; larger ones go to the GPU as their DDS, block compression and mips included.
    private const int DecodeMaxPixels = 64 * 64;

    /// <summary>
    /// Layer masks of an .mlmask (R8, the shader reads R), once per project stamp of the file.
    /// </summary>
    private async Task<TextureEntry[]?> GetMultilayerMasks(ResourcePath maskPath)
    {
        var text = maskPath.GetResolvedText() ?? maskPath.ToString() ?? string.Empty;
        if (GetProjectOrDepotFile(maskPath)?.RootChunk is not Multilayer_Mask mlm)
        {
            return null;
        }

        var key = text + "|" + DepStamp(text);
        if (_multilayerMaskCache.TryGetValue(key, out var cached))
        {
            return cached;
        }

        var layers = ReadMaskDds(mlm);
        if (layers == null || layers.Count == 0)
        {
            return null;
        }

        var result = new TextureEntry[layers.Count];
        for (var i = 0; i < layers.Count; i++)
        {
            var index = i;
            try
            {
                result[i] = await ToTextureEntry(layers[i], Enums.ETextureRawFormat.TRF_Grayscale, null, channel: 2, allowConstant: true,
                    reload: () => GetProjectOrDepotFile(maskPath)?.RootChunk is Multilayer_Mask m &&
                                  ReadMaskDds(m) is { } again && index < again.Count ? again[index] : null);
            }
            catch (Exception ex)
            {
                Parent?.GetLoggerService()?.Warning($"[ML shader] mask {i} of {text}: {ex.Message}");
                // A layer whose mask cannot be read is treated as fully hidden.
                result[i] = new TextureEntry { R = 0f, G = 0f, B = 0f, A = 1f };
            }
        }

        _multilayerMaskCache[key] = result;
        return result;
    }

    private static List<byte[]>? ReadMaskDds(Multilayer_Mask mlm)
    {
        ModTools.ConvertMultilayerMaskToDdsStreams(mlm, out var streams);
        if (streams == null)
        {
            return null;
        }

        var list = new List<byte[]>(streams.Count);
        foreach (var stream in streams)
        {
            using (stream)
            {
                using var ms = new MemoryStream();
                stream.Position = 0;
                stream.CopyTo(ms);
                list.Add(ms.ToArray());
            }
        }

        return list;
    }

    /// <summary>
    /// A layer texture for the pool, in its stored orientation (no V flip; the shader samples
    /// accordingly). channel (0 B, 1 G, 2 R, -1 all) only matters for small decoded textures:
    /// which channel a solid one turns into a constant, and the R8 copy of grayscale maps.
    /// </summary>
    private async Task<TextureEntry?> GetMultilayerTexture(ResourcePath path, int channel, bool allowConstant = true, string? context = null)
    {
        var text = path.GetResolvedText() ?? path.ToString() ?? string.Empty;
        var key = text + "|" + channel + (allowConstant ? "|c|" : "|t|") + DepStamp(text);
        if (_multilayerTextureCache.TryGetValue(key, out var cached))
        {
            return cached;
        }

        var dds = ReadTextureDds(path, out var decodeFormat);
        if (dds == null)
        {
            WarnMissingFile("texture", path, context);
            return null;
        }

        TextureEntry entry;
        try
        {
            entry = await ToTextureEntry(dds, null, decodeFormat, channel, allowConstant,
                reload: () => ReadTextureDds(path, out _));
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[ML shader] {text}: {ex.Message}");
            return null;
        }

        _multilayerTextureCache[key] = entry;
        return entry;
    }

    /// <summary>The xbm as a DDS file, exactly as stored (format, mips), not flipped.</summary>
    private byte[]? ReadTextureDds(ResourcePath path, out WolvenKit.Common.DDS.DXGI_FORMAT decodeFormat)
    {
        decodeFormat = WolvenKit.Common.DDS.DXGI_FORMAT.DXGI_FORMAT_UNKNOWN;
        if (path == ResourcePath.Empty || GetProjectOrDepotFile(path)?.RootChunk is not ITexture texture)
        {
            return null;
        }

        using var ms = new MemoryStream();
        if (!ModTools.ConvertRedClassToDdsStream(texture, ms, out _, out decodeFormat, false))
        {
            return null;
        }

        return ms.ToArray();
    }

    /// <summary>
    /// Small textures: decoded, solid ones become constants (unless allowConstant is false),
    /// the rest a small uncompressed texture. Large ones: the DDS itself, sRGB tag removed
    /// (the shader linearizes colour itself, like the addon), uploaded by Helix with its mips.
    /// </summary>
    private async Task<TextureEntry> ToTextureEntry(
        byte[] dds, Enums.ETextureRawFormat? rawFormat, WolvenKit.Common.DDS.DXGI_FORMAT? decodeFormat,
        int channel, bool allowConstant, Func<byte[]?> reload)
    {
        var (width, height) = ReadDdsSize(dds);
        if (width * height > 0 && width * height <= DecodeMaxPixels)
        {
            using var stream = new MemoryStream(dds);
            var image = rawFormat is { } raw
                ? await ImageDecoder.RenderToBitmapImageDds(stream, raw)
                : await ImageDecoder.RenderToBitmapImageDds(stream, decodeFormat ?? WolvenKit.Common.DDS.DXGI_FORMAT.DXGI_FORMAT_UNKNOWN);
            if (image != null)
            {
                if (image.CanFreeze && !image.IsFrozen)
                {
                    image.Freeze();
                }

                using var bmp = BitmapSourceToBitmap(image);
                return ToTextureEntry(bmp, channel, allowConstant);
            }
        }

        var first = ForceLinearDdsFormat(dds);
        var loader = new ReloadableDdsLoader(first, () => reload() is { } again ? ForceLinearDdsFormat(again) : null);
        return new TextureEntry { Texture = new TextureModel(Guid.NewGuid(), loader) };
    }

    private static (int Width, int Height) ReadDdsSize(byte[] dds)
    {
        // "DDS " + DDS_HEADER: dwHeight at 12, dwWidth at 16
        if (dds.Length < 20 || dds[0] != (byte)'D' || dds[1] != (byte)'D' || dds[2] != (byte)'S')
        {
            return (0, 0);
        }

        return (BitConverter.ToInt32(dds, 16), BitConverter.ToInt32(dds, 12));
    }

    /// <summary>
    /// Rewrites an sRGB DXGI format in the DX10 header to its UNORM twin, so the GPU returns the
    /// stored values (as the CPU decode did) instead of converting them to linear.
    /// </summary>
    private static byte[] ForceLinearDdsFormat(byte[] dds)
    {
        const uint Dx10 = 0x30315844; // "DX10"
        if (dds.Length < 148 || BitConverter.ToUInt32(dds, 84) != Dx10)
        {
            return dds;
        }

        var format = BitConverter.ToUInt32(dds, 128);
        uint linear = format switch
        {
            29 => 28, // R8G8B8A8
            72 => 71, // BC1
            75 => 74, // BC2
            78 => 77, // BC3
            91 => 87, // B8G8R8A8
            93 => 88, // B8G8R8X8
            99 => 98, // BC7
            _ => format,
        };

        if (linear != format)
        {
            BitConverter.TryWriteBytes(dds.AsSpan(128, 4), linear);
        }

        return dds;
    }

    /// <summary>
    /// Hands Helix the DDS once and drops it after the upload, so the bytes do not stay in
    /// memory next to the GPU copy. If Helix needs it again (device re-created), it is read
    /// again from the project / archive.
    /// </summary>
    private sealed class ReloadableDdsLoader : ITextureInfoLoader
    {
        private readonly Func<byte[]?> _reload;
        private readonly object _lock = new();
        private byte[]? _pending;

        public ReloadableDdsLoader(byte[] first, Func<byte[]?> reload)
        {
            _pending = first;
            _reload = reload;
        }

        public TextureInfo Load(Guid id)
        {
            lock (_lock)
            {
                var data = _pending ?? _reload();
                _pending = data;
                return data == null ? TextureInfo.Null : new TextureInfo(new MemoryStream(data, writable: false));
            }
        }

        public void Complete(Guid id, TextureInfo info, bool succeeded)
        {
            lock (_lock)
            {
                _pending = null;
            }

            info?.Texture?.Dispose();
        }
    }

    private static TextureEntry ToTextureEntry(Bitmap bmp, int channel, bool allowConstant = true)
    {
        var w = bmp.Width;
        var h = bmp.Height;
        var data = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
        try
        {
            var stride = data.Stride;
            var raw = new byte[stride * h];
            Marshal.Copy(data.Scan0, raw, 0, raw.Length);

            if (IsSolid(raw, stride, w, h, channel))
            {
                if (allowConstant)
                {
                    const float inv = 1f / 255f;
                    return new TextureEntry
                    {
                        B = raw[0] * inv,
                        G = raw[1] * inv,
                        R = raw[2] * inv,
                        A = raw[3] * inv,
                    };
                }

                // Solid but must stay a texture: 4x4 of the same pixel is enough.
                const int Tiny = 4;
                if (channel < 0)
                {
                    var tiny = new byte[Tiny * Tiny * 4];
                    for (var i = 0; i < tiny.Length; i += 4)
                    {
                        tiny[i] = raw[0];
                        tiny[i + 1] = raw[1];
                        tiny[i + 2] = raw[2];
                        tiny[i + 3] = raw[3];
                    }

                    return new TextureEntry { Texture = new TextureModel(tiny, DxgiFormat.B8G8R8A8_UNorm, Tiny, Tiny) };
                }

                var tinyR8 = new byte[Tiny * Tiny];
                Array.Fill(tinyR8, raw[channel]);
                return new TextureEntry { Texture = new TextureModel(tinyR8, DxgiFormat.R8_UNorm, Tiny, Tiny) };
            }

            if (channel < 0)
            {
                var bgra = new byte[w * h * 4];
                for (var y = 0; y < h; y++)
                {
                    System.Buffer.BlockCopy(raw, y * stride, bgra, y * w * 4, w * 4);
                }

                return new TextureEntry { Texture = new TextureModel(bgra, DxgiFormat.B8G8R8A8_UNorm, w, h) };
            }

            var r8 = new byte[w * h];
            for (var y = 0; y < h; y++)
            {
                var row = y * stride;
                var dst = y * w;
                for (var x = 0; x < w; x++)
                {
                    r8[dst + x] = raw[row + (x * 4) + channel];
                }
            }

            return new TextureEntry { Texture = new TextureModel(r8, DxgiFormat.R8_UNorm, w, h) };
        }
        finally
        {
            bmp.UnlockBits(data);
        }
    }

    /// <summary>
    /// True when every pixel equals the first within ±2 (block compression noise).
    /// Only the channels the shader reads are compared.
    /// </summary>
    private static bool IsSolid(byte[] raw, int stride, int w, int h, int channel)
    {
        const int Tolerance = 2;
        int b0 = raw[0], g0 = raw[1], r0 = raw[2], a0 = raw[3];
        for (var y = 0; y < h; y++)
        {
            var row = y * stride;
            for (var x = 0; x < w; x++)
            {
                var p = row + (x * 4);
                if (channel >= 0)
                {
                    var first = channel switch { 0 => b0, 1 => g0, _ => r0 };
                    if (Math.Abs(raw[p + channel] - first) > Tolerance)
                    {
                        return false;
                    }

                    continue;
                }

                if (Math.Abs(raw[p] - b0) > Tolerance ||
                    Math.Abs(raw[p + 1] - g0) > Tolerance ||
                    Math.Abs(raw[p + 2] - r0) > Tolerance ||
                    Math.Abs(raw[p + 3] - a0) > Tolerance)
                {
                    return false;
                }
            }
        }

        return true;
    }

    /// <summary>
    /// Preview material for a multilayer material evaluated by the shader. Factors follow the
    /// bake path in <see cref="SetupPBRMaterial"/> (albedo tint, RoughnessFactor 1, MetallicFactor 0.8),
    /// so switching between shader and bake changes only the detail, not the overall look.
    /// </summary>
    private PBRMaterial SetupMultilayerShaderMaterial(string name, MultilayerGpuData data)
    {
        if (!Materials.TryGetValue(name, out var existing) || existing is not MultilayerPBRMaterial material)
        {
            material = new MultilayerPBRMaterial
            {
                EnableAutoTangent = true,
                RenderShadowMap = true,
                ClayExempt = !IsObjectPreview,
            };
            Materials[name] = material;
        }

        material.AlbedoMap = null;
        // Not sampled by the multilayer shader: it only switches on the vertex shader's tangent
        // output (Helix writes the vertex tangents only for materials with a normal map).
        material.NormalMap = s_flatNormal;
        material.EnableAutoTangent = false;
        material.RoughnessMetallicMap = null;
        material.EmissiveMap = null;
        material.RenderAlbedoMap = false;
        material.RenderNormalMap = true;
        material.RenderRoughnessMetallicMap = false;
        material.RenderEmissiveMap = false;
        material.RenderEnvironmentMap = false;

        var albedoColor = new SharpDX.Color4(0.5f, 0.5f, 0.5f, 1f);
        if (TryGetRawMaterial(name, out var raw) &&
            raw?.Values?.TryGetValue("BaseColorScale", out var scaleObj) == true &&
            scaleObj is Vector4 v4)
        {
            albedoColor = new SharpDX.Color4(v4.X, v4.Y, v4.Z, v4.W);
        }

        material.AlbedoColor = albedoColor;
        material.RoughnessFactor = 1f;
        material.MetallicFactor = 0.8f;
        material.MultilayerData = data;

        return material;
    }

    /// <summary>
    /// The GlobalNormal map is applied unless the material switches it off: terrain materials
    /// carry UseGlobalNormal (0 / 1); without the parameter it is on, as before.
    /// </summary>
    private static bool UsesGlobalNormal(Dictionary<string, object> dictionary) =>
        !dictionary.TryGetValue("UseGlobalNormal", out var use) || ReadFloat(use) > 0.5f;
}
