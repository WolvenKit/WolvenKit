using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.App.Models;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents.Multilayer;
using Material = WolvenKit.App.Models.Material;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Mesh decals the way the game draws them: a mesh_decal does not shade on its own, it is
/// blended into the surface under it (colour by DiffuseAlpha, normal by NormalAlpha,
/// roughness / metalness by RoughnessMetalnessAlpha, each times the decal's coverage) and
/// the surface is then lit as usual. Drawing the decal as its own mesh lights it differently
/// (patches of another brightness, halos at soft edges, normal-only decals invisible).
///
/// The preview finds the surface a decal lies on (decal vertices on surface vertices), draws
/// the decal's triangles into the surface's texture space (decal UV -> surface UV per
/// triangle), writes composite colour / normal / roughness-metalness maps for the surface
/// and hides the decal. Decals that do not lie on a baked surface (multilayer clothes,
/// another mesh) are drawn as before.
/// </summary>
public partial class RDTMeshViewModel
{
    private const double DecalPositionTolerance = 0.006;   // 6 mm: decals float slightly above
    private const double DecalMinPart = 0.02;              // smaller pieces stay in the decal
    private const double DecalLeftoverShare = 0.05;        // left-over edge pieces searched wider
    private const double DecalLeftoverTolerance = 0.03;    // 3 cm
    private const double DecalDropShare = 0.01;            // stray triangles not drawn

    private readonly ConcurrentDictionary<string, byte> _decalBakesRunning = new();

    private static bool s_blendDecals = true;

    /// <summary>
    /// Blend mesh decals into the surfaces under them (on), or draw them as their own meshes
    /// (off). Shared by all preview tabs; switching re-applies the current appearance.
    /// </summary>
    public bool BlendDecalsIntoSurfaces
    {
        get => s_blendDecals;
        set
        {
            if (SetProperty(ref s_blendDecals, value) && SelectedAppearance is { } app && !IsLoadingMaterials)
            {
                ApplyAppearancePreviewMaterials(app);
            }
        }
    }
    private PBRMaterial? _hiddenDecalMaterial;

    // surface material -> its copy with the decal overlay (for the shader debug views)
    private readonly Dictionary<string, MultilayerPBRMaterial> _decalOverlayMaterials = new();

    // decal submesh -> (surface submesh -> its triangles on that surface): geometry only,
    // so kept between applies.
    private readonly System.Runtime.CompilerServices.ConditionalWeakTable<SubmeshComponent, Dictionary<SubmeshComponent, List<(int Triangle, double[] SurfaceUv, double Distance)>>> _decalMaps = new();

    // decal submesh -> its triangles on UV the surface also uses elsewhere (mirrored / shared UV):
    // drawn into the texture they would show on the other place too, so they stay decal meshes.
    private readonly System.Runtime.CompilerServices.ConditionalWeakTable<SubmeshComponent, HashSet<int>> _decalSharedUv = new();

    // decal submesh -> multilayer surfaces it lies on with shared UV: kept there (the overlay is
    // one-sided: it stores which way the decals faced and the shader checks it).
    private readonly System.Runtime.CompilerServices.ConditionalWeakTable<SubmeshComponent, HashSet<SubmeshComponent>> _decalSharedOnOverlay = new();

    // decal submesh -> its own geometry and the triangles now carried by surfaces.
    private readonly System.Runtime.CompilerServices.ConditionalWeakTable<SubmeshComponent, DecalHideState> _decalHidden = new();

    private sealed class DecalHideState
    {
        public HelixToolkit.SharpDX.Core.Geometry3D? Original;
        public readonly HashSet<int> Baked = new();
    }

    /// <summary>The part of a decal (its triangles) that lies on one surface.</summary>
    private sealed record DecalLayer(
        string DecalName, LoadableModel DecalModel, SubmeshComponent Decal, SurfaceGeometry DecalGeometry,
        LoadableModel SurfaceModel, SubmeshComponent Surface,
        List<(int Triangle, double[] SurfaceUv)> Triangles, bool Whole, List<int> Dropped);

    private sealed class SurfaceGeometry
    {
        public Point3D[] Positions { get; init; } = null!;
        public double[] Uvs { get; init; } = null!;
        public int[] Indices { get; init; } = null!;

        /// <summary>World-space vertex normals (null when the mesh has none).</summary>
        public Vector3D[]? Normals { get; init; }

        /// <summary>Which way a triangle faces (vertex normals, else its winding).</summary>
        public Vector3D Facing(int t)
        {
            int a = Indices[t * 3], b = Indices[t * 3 + 1], c = Indices[t * 3 + 2];
            var n = Normals != null
                ? Normals[a] + Normals[b] + Normals[c]
                : Vector3D.CrossProduct(Positions[b] - Positions[a], Positions[c] - Positions[a]);
            if (n.LengthSquared < 1e-20)
            {
                return new Vector3D(0, 0, 1);
            }

            n.Normalize();
            return n;
        }
    }

    // ---- entry point -------------------------------------------------------------------------

    /// <summary>
    /// Called after the materials of an appearance are applied: composites the decals into
    /// the surfaces under them (from cache, or bakes in the background and applies again).
    /// </summary>
    private void ApplyDecalsToSurfaces(Appearance app)
    {
        try
        {
            RestoreDecals(app);
            if (!BlendDecalsIntoSurfaces)
            {
                return;
            }

            var layers = FindDecalLayers(app);
            if (layers.Count == 0)
            {
                return;
            }

            foreach (var group in layers.GroupBy(l => l.Surface.MaterialName!))
            {
                var surfaceName = group.Key;
                var decals = group.ToList();
                var overlay = IsOverlaySurface(decals[0].Surface);
                var key = DecalCompositeKey(surfaceName, decals) + (overlay ? "|ov" : "");
                var (cd, cn, crm) = DecalCompositePaths(surfaceName, key, overlay);
                var op = OverlayPaths(cd);

                void Use()
                {
                    if (overlay)
                    {
                        UseDecalOverlay(app, surfaceName, decals, op);
                    }
                    else
                    {
                        UseDecalComposite(app, surfaceName, decals, cd, cn, crm);
                    }
                }

                if (overlay ? File.Exists(op.Done) : File.Exists(cd))
                {
                    Use();
                    continue;
                }

                if (!_decalBakesRunning.TryAdd(key, 0))
                {
                    continue;
                }

                var context = SynchronizationContext.Current;
                var surfaceMaterial = app.Models.SelectMany(m => m.Meshes)
                    .First(sm => sm.MaterialName == surfaceName).Material as PBRMaterial;
                var job = PrepareDecalJob(surfaceName, surfaceMaterial, decals);

                _ = Task.Run(async () =>
                {
                    try
                    {
                        foreach (var l in job.Layers.Where(l => l.UseNormalAlphaTex && l.NormalAlphaTexPath != WolvenKit.RED4.Types.ResourcePath.Empty))
                        {
                            using var natBmp = await LoadTextureAsBitmap(l.NormalAlphaTexPath);
                            l.NormalAlphaTex = Pixels.From(natBmp);
                        }

                        if (overlay)
                        {
                            BakeDecalOverlay(job, op);
                        }
                        else
                        {
                            BakeDecalComposite(job, cd, cn, crm);
                        }
                    }
                    catch (Exception ex)
                    {
                        Parent?.GetLoggerService()?.Warning($"[Decals] '{surfaceName}': {ex.Message}");
                    }
                    finally
                    {
                        _decalBakesRunning.TryRemove(key, out _);
                    }

                    if (context != null && !_disposed)
                    {
                        context.Post(_ =>
                        {
                            if (!_disposed && BlendDecalsIntoSurfaces && SelectedAppearance == app &&
                                (overlay ? File.Exists(op.Done) : File.Exists(cd)))
                            {
                                Use();
                            }
                        }, null);
                    }
                });
            }
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Decals] {ex.Message}");
        }
    }

    // ---- which decal lies on which surface -----------------------------------------------------

    private List<DecalLayer> FindDecalLayers(Appearance app)
    {
        var all = app.Models.SelectMany(m => m.Meshes.Select(sm => (Model: m, Mesh: sm)))
            .Where(x => !string.IsNullOrEmpty(x.Mesh.MaterialName))
            .ToList();

        var surfaces = all.Where(x => IsDecalSurface(x.Mesh)).ToList();
        var result = new List<DecalLayer>();
        if (surfaces.Count == 0)
        {
            return result;
        }

        var grids = new Dictionary<SubmeshComponent, SurfaceTriangleGrid?>();
        var uvGrids = new Dictionary<SubmeshComponent, Dictionary<(int, int), List<int>>>();
        var geometries = new Dictionary<SubmeshComponent, SurfaceGeometry?>();
        SurfaceGeometry? Geo(LoadableModel m, SubmeshComponent sm)
        {
            if (!geometries.TryGetValue(sm, out var g))
            {
                g = ReadSurfaceGeometry(m, sm);
                geometries[sm] = g;
            }

            return g;
        }

        // One submesh per decal material (the lowest LOD): every LOD would blend it again.
        // Each triangle goes to the nearest baked surface under it (a decal may cross from
        // skin onto metal); triangles on none stay in the decal, which still draws them.
        foreach (var decalGroup in all.Where(x => IsBakeableDecal(x.Mesh.MaterialName!))
                     .GroupBy(x => x.Mesh.MaterialName!))
        {
            var (decalModel, decal) = decalGroup.OrderBy(x => x.Mesh.LOD).First();
            var dg = Geo(decalModel, decal);
            if (dg == null || dg.Indices.Length < 3)
            {
                continue;
            }

            var maps = _decalMaps.GetOrCreateValue(decal);
            var sharedUv = _decalSharedUv.GetOrCreateValue(decal);
            var total = dg.Indices.Length / 3;

            // triangle -> (surface, its UVs, distance + LOD penalty)
            var bestFor = new Dictionary<int, (int Surface, double[] Uv, double Score)>();
            for (var si = 0; si < surfaces.Count; si++)
            {
                var (surfaceModel, surface) = surfaces[si];
                if (!maps.TryGetValue(surface, out var mapped))
                {
                    mapped = new List<(int, double[], double)>();
                    if (Geo(surfaceModel, surface) is { } sg)
                    {
                        if (!grids.TryGetValue(surface, out var grid))
                        {
                            grid = BuildTriangleGrid(sg);
                            grids[surface] = grid;
                        }

                        if (grid != null)
                        {
                            MapDecalTriangles(dg, sg, grid, out mapped);
                        }

                        // A gun's two sides often share (mirror) one UV island: a decal drawn into
                        // that texture would show on both sides. Those triangles are left out.
                        if (mapped.Count > 0)
                        {
                            if (!uvGrids.TryGetValue(surface, out var uvGrid))
                            {
                                uvGrid = BuildUvGrid(sg);
                                uvGrids[surface] = uvGrid;
                            }

                            var shared = SharedUvTriangles(dg, sg, uvGrid, mapped);
                            if (shared.Count > 0 && IsOverlaySurface(surface))
                            {
                                _decalSharedOnOverlay.GetOrCreateValue(decal).Add(surface);
                            }
                            else if (shared.Count > 0)
                            {
                                mapped = mapped.Where(m => !shared.Contains(m.Triangle)).ToList();
                                sharedUv.UnionWith(shared);
                            }
                        }
                    }

                    maps[surface] = mapped;
                }

                var penalty = surface.LOD == decal.LOD ? 0 : 1;   // same LOD first
                foreach (var (t, uv, distance) in mapped)
                {
                    var score = distance + penalty;
                    if (!bestFor.TryGetValue(t, out var current) || score < current.Score)
                    {
                        bestFor[t] = (si, uv, score);
                    }
                }
            }

            // Edge pieces that float a little higher (a decal's rim over a collarbone): when only a
            // few triangles are left, give each the surface of its neighbours, searched wider.
            var leftover = Enumerable.Range(0, total).Where(t => !bestFor.ContainsKey(t) && !sharedUv.Contains(t)).ToList();
            if (leftover.Count > 0 && leftover.Count <= total * DecalLeftoverShare && bestFor.Count > 0)
            {
                // Centres of the triangles that found a surface (decal meshes often split their
                // vertices, so neighbours are found by distance, not by shared indices).
                Point3D Centre(int t)
                {
                    var a = dg.Positions[dg.Indices[t * 3]];
                    var b = dg.Positions[dg.Indices[t * 3 + 1]];
                    var c = dg.Positions[dg.Indices[t * 3 + 2]];
                    return new Point3D((a.X + b.X + c.X) / 3, (a.Y + b.Y + c.Y) / 3, (a.Z + b.Z + c.Z) / 3);
                }

                var placed = bestFor.Select(kv => (Centre: Centre(kv.Key), kv.Value.Surface)).ToList();

                foreach (var group in leftover
                             .Select(t => (Triangle: t, Surface: NeighbourSurface(t)))
                             .Where(x => x.Surface >= 0)
                             .GroupBy(x => x.Surface))
                {
                    var (surfaceModel, surface) = surfaces[group.Key];
                    if (Geo(surfaceModel, surface) is not { } sg)
                    {
                        continue;
                    }

                    if (!grids.TryGetValue(surface, out var grid))
                    {
                        grid = BuildTriangleGrid(sg);
                        grids[surface] = grid;
                    }

                    if (grid == null)
                    {
                        continue;
                    }

                    var only = group.Select(x => x.Triangle).ToHashSet();
                    MapDecalTriangles(dg, sg, grid, out var wide, only, DecalLeftoverTolerance);
                    foreach (var (t, uv, distance) in wide)
                    {
                        bestFor[t] = (group.Key, uv, distance + 1);
                    }
                }

                int NeighbourSurface(int t)
                {
                    // The surface of the nearest triangle that has one.
                    var c = Centre(t);
                    var best = -1;
                    var bestD = double.MaxValue;
                    foreach (var (centre, placedSurface) in placed)
                    {
                        var d = (centre - c).LengthSquared;
                        if (d < bestD)
                        {
                            bestD = d;
                            best = placedSurface;
                        }
                    }

                    return best;
                }
            }

            var parts = bestFor
                .GroupBy(kv => kv.Value.Surface)
                .Select(g => (Index: g.Key, Triangles: g.Select(kv => (kv.Key, kv.Value.Uv)).OrderBy(x => x.Key).ToList()))
                .Where(p => p.Triangles.Count >= Math.Max(3, total * DecalMinPart))
                .ToList();

            var assigned = parts.Sum(p => p.Triangles.Count);

            // A handful of triangles still without a surface once all the rest is baked (walls
            // standing off the skin, slivers): in the game a decal only paints the surface, they
            // add nothing there, so they are not drawn either instead of showing as a lit patch.
            var dropped = new List<int>();
            var unplaced = total - assigned - sharedUv.Count;
            if (parts.Count > 0 && unplaced > 0 && unplaced <= Math.Max(4, total * DecalDropShare))
            {
                var used = parts.SelectMany(p => p.Triangles.Select(x => x.Key)).ToHashSet();
                dropped = Enumerable.Range(0, total).Where(t => !used.Contains(t) && !sharedUv.Contains(t)).ToList();
            }

            var whole = assigned + dropped.Count == total;
            for (var pi = 0; pi < parts.Count; pi++)
            {
                var (index, triangles) = parts[pi];
                var (surfaceModel, surface) = surfaces[index];
                result.Add(new DecalLayer(decalGroup.Key, decalModel, decal, dg, surfaceModel, surface,
                    triangles.Select(x => (x.Key, x.Uv)).ToList(), whole, pi == 0 ? dropped : new List<int>()));
            }
        }

        return result;
    }

    // ---- mesh_decal parameters on the decal's own maps ------------------------------------------

    /// <summary>Templates whose decal maps take UVOffset / UVScale / UVRotation, flipbook and coverage params.</summary>
    private bool IsUvTransformedDecal(Material material)
    {
        var template = GetTemplateFileName(material);
        return IsPlainMeshDecalTemplate(template) &&
               Has(ClassifyMaterialFor(material.Name, material), MaterialKind.Decal);
    }

    /// <summary>
    /// The decal's baked maps as the game samples them (Blender add-on decal_nodes.py):
    /// UV = frac(rotate((uv - 0.5) * UVScale, UVRotation * pi) + 0.5 + UVOffset) in mesh UV
    /// (V up), divided by the flipbook grid (AnimationFramesWidth / Height: its first frame);
    /// coverage = contrast(alpha, AlphaMaskContrast)^2 * (1 - SecondaryMask.r * SecondaryMaskInfluence).
    /// The normal map's XY turn with the UV.
    /// </summary>
    private async Task PostProcessMeshDecalMaps(Material material, Dictionary<string, object> dictionary, string bd, string bn, string rm)
    {
        // Gradient-map decals (road markings, signs): colour and alpha come from the gradient.
        var gradient = IsGradientDecalTemplate(GetTemplateFileName(material));
        if (gradient)
        {
            await BakeGradientDecalColor(dictionary, bd);
        }

        float P(string key, float fallback) => dictionary.TryGetValue(key, out var o) ? ReadFloat(o) : fallback;

        double offX = P("UVOffsetX", 0), offY = P("UVOffsetY", 0);
        double sX = P("UVScaleX", 1), sY = P("UVScaleY", 1);
        if (Math.Abs(sX) < 1e-6)
        {
            sX = 1e-6;
        }

        if (Math.Abs(sY) < 1e-6)
        {
            sY = 1e-6;
        }
        double angle = P("UVRotation", 0) * Math.PI;
        var cols = Math.Max(1, (int)P("AnimationFramesWidth", 1));
        var rows = Math.Max(1, (int)P("AnimationFramesHeight", 1));
        var contrast = Math.Clamp(P("AlphaMaskContrast", 0), -1f, 0.99f);
        var secInfluence = P("SecondaryMaskInfluence", 0);
        var secScale = P("SecondaryMaskUVScale", 1);

        var identity = Math.Abs(offX) < 1e-6 && Math.Abs(offY) < 1e-6 && Math.Abs(sX - 1) < 1e-6 &&
                       Math.Abs(sY - 1) < 1e-6 && Math.Abs(angle) < 1e-6 && cols == 1 && rows == 1;
        double cos = Math.Cos(angle), sin = Math.Sin(angle);

        // Mesh UV (V up) -> texture UV (V up), flipbook frame 0.
        (double U, double V) Map(double u, double v)
        {
            double cu = (u - 0.5) * sX, cv = (v - 0.5) * sY;
            double ru = cu * cos - cv * sin, rv = cu * sin + cv * cos;
            double tu = ru + 0.5 + offX, tv = rv + 0.5 + offY;
            tu -= Math.Floor(tu);
            tv -= Math.Floor(tv);
            return (tu / cols, tv / rows);
        }

        // Normal XY (PNG, Y up = V up): texture frame -> mesh frame, inverse of scale * rotation.
        double n00 = cos / sX, n01 = sin / sX, n10 = -sin / sY, n11 = cos / sY;
        var nScale = Math.Sqrt(Math.Abs(n00 * n11 - n01 * n10));
        if (nScale > 1e-9)
        {
            n00 /= nScale;
            n01 /= nScale;
            n10 /= nScale;
            n11 /= nScale;
        }

        Pixels? Remap(string path, bool isNormal)
        {
            using var src = LoadPng32(path);
            var sp = Pixels.From(src);
            if (sp == null || identity)
            {
                return sp;
            }

            var dst = new Pixels { W = sp.W, H = sp.H, Data = new byte[sp.Data.Length] };
            Span<float> s4 = stackalloc float[4];
            for (var y = 0; y < dst.H; y++)
            {
                var v = 1.0 - (y + 0.5) / dst.H;
                for (var x = 0; x < dst.W; x++)
                {
                    var (tu, tv) = Map((x + 0.5) / dst.W, v);
                    sp.Sample(tu, 1.0 - tv, s4);
                    var o = (y * dst.W + x) * 4;
                    if (isNormal)
                    {
                        double nx = s4[2] * 2 - 1, ny = s4[1] * 2 - 1;
                        var rx = n00 * nx + n01 * ny;
                        var ry = n10 * nx + n11 * ny;
                        dst.Data[o + 2] = (byte)Math.Clamp((rx * 0.5 + 0.5) * 255, 0, 255);
                        dst.Data[o + 1] = (byte)Math.Clamp((ry * 0.5 + 0.5) * 255, 0, 255);
                        dst.Data[o] = (byte)Math.Clamp(s4[0] * 255, 0, 255);
                    }
                    else
                    {
                        dst.Data[o] = (byte)Math.Clamp(s4[0] * 255, 0, 255);
                        dst.Data[o + 1] = (byte)Math.Clamp(s4[1] * 255, 0, 255);
                        dst.Data[o + 2] = (byte)Math.Clamp(s4[2] * 255, 0, 255);
                    }

                    dst.Data[o + 3] = (byte)Math.Clamp(s4[3] * 255, 0, 255);
                }
            }

            return dst;
        }

        void Save(Pixels p, string path)
        {
            using var bmp = p.ToBitmap();
            SavePngAtomic(bmp, path);
        }

        try
        {
            if (!identity)
            {
                foreach (var (path, isNormal) in new[] { (bn, true), (rm, false) })
                {
                    if (File.Exists(path) && Remap(path, isNormal) is { } p)
                    {
                        Save(p, path);
                    }
                }
            }

            if (!File.Exists(bd) || Remap(bd, false) is not { } color)
            {
                return;
            }

            // Coverage: contrast, then squared and the secondary mask (mesh_decal).
            Pixels? secondary = null;
            if (Math.Abs(secInfluence) > 1e-8 &&
                dictionary.TryGetValue("SecondaryMask", out var smObj) &&
                smObj is WolvenKit.RED4.Types.CResourceReference<WolvenKit.RED4.Types.ITexture> smRef &&
                smRef.DepotPath != WolvenKit.RED4.Types.ResourcePath.Empty)
            {
                using var sb = await LoadTextureAsBitmap(smRef.DepotPath);
                secondary = Pixels.From(sb);
            }

            ApplyCoverage(color, secondary);
            Save(color, bd);
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Decals] decal parameters: {ex.Message}");
        }

        void ApplyCoverage(Pixels target, Pixels? mask2)
        {
            var slope = MathF.Tan((contrast + 1f) * MathF.PI / 4f);
            Span<float> m4 = stackalloc float[4];
            for (var y = 0; y < target.H; y++)
            {
                var v = 1.0 - (y + 0.5) / target.H;
                for (var x = 0; x < target.W; x++)
                {
                    var o = (y * target.W + x) * 4;
                    var a = target.Data[o + 3] / 255f;
                    if (contrast != 0f)
                    {
                        a = Math.Clamp((a - 0.5f) * slope + 0.5f, 0f, 1f);
                    }

                    // mesh_decal: alpha x alpha x (1 - secondary x influence); gradient decals:
                    // alpha x lerp(1, secondary, influence), not squared (add-on decal_nodes.py).
                    var keep = gradient ? 1f : a;
                    if (mask2 != null)
                    {
                        // Secondary mask on the transformed UV (before the flipbook), scaled.
                        var (tu, tv) = Map((x + 0.5) / target.W, v);
                        mask2.Sample(tu * cols * secScale, 1.0 - tv * rows * secScale, m4);
                        keep = gradient
                            ? 1f - secInfluence + m4[2] * secInfluence
                            : a * (1f - m4[2] * secInfluence);
                    }

                    target.Data[o + 3] = (byte)Math.Clamp(a * keep * 255f, 0f, 255f);
                }
            }
        }
    }

    private const int UvGridCells = 512;          // per UV unit
    private const double SharedUvDistance = 0.02; // 2 cm apart on the mesh = another place

    /// <summary>Surface triangles bucketed by their (wrapped) UV.</summary>
    private static Dictionary<(int, int), List<int>> BuildUvGrid(SurfaceGeometry g)
    {
        var cells = new Dictionary<(int, int), List<int>>();
        var triangles = g.Indices.Length / 3;
        for (var t = 0; t < triangles; t++)
        {
            int a = g.Indices[t * 3], b = g.Indices[t * 3 + 1], c = g.Indices[t * 3 + 2];
            double u0 = g.Uvs[a * 2], v0 = g.Uvs[a * 2 + 1], u1 = g.Uvs[b * 2], v1 = g.Uvs[b * 2 + 1], u2 = g.Uvs[c * 2], v2 = g.Uvs[c * 2 + 1];
            double minU = Math.Min(u0, Math.Min(u1, u2)), maxU = Math.Max(u0, Math.Max(u1, u2));
            double minV = Math.Min(v0, Math.Min(v1, v2)), maxV = Math.Max(v0, Math.Max(v1, v2));
            if (maxU - minU > 0.5 || maxV - minV > 0.5)
            {
                continue;
            }

            for (var x = (int)Math.Floor(minU * UvGridCells); x <= (int)Math.Floor(maxU * UvGridCells); x++)
            for (var y = (int)Math.Floor(minV * UvGridCells); y <= (int)Math.Floor(maxV * UvGridCells); y++)
            {
                var key = (((x % UvGridCells) + UvGridCells) % UvGridCells, ((y % UvGridCells) + UvGridCells) % UvGridCells);
                if (!cells.TryGetValue(key, out var list))
                {
                    list = new List<int>(2);
                    cells[key] = list;
                }

                list.Add(t);
            }
        }

        return cells;
    }

    /// <summary>
    /// Decal triangles whose UV spot on the surface is also used by a part of the surface far
    /// from them (the other side of a mirrored mesh, a shared UV island, a tiled repeat).
    /// </summary>
    private static HashSet<int> SharedUvTriangles(SurfaceGeometry decal, SurfaceGeometry surface,
        Dictionary<(int, int), List<int>> uvGrid, List<(int Triangle, double[] SurfaceUv, double Distance)> mapped)
    {
        var shared = new HashSet<int>();
        var d2 = SharedUvDistance * SharedUvDistance;
        foreach (var (t, suv, _) in mapped)
        {
            var a = decal.Positions[decal.Indices[t * 3]];
            var b = decal.Positions[decal.Indices[t * 3 + 1]];
            var c = decal.Positions[decal.Indices[t * 3 + 2]];
            var centre = new Point3D((a.X + b.X + c.X) / 3, (a.Y + b.Y + c.Y) / 3, (a.Z + b.Z + c.Z) / 3);
            var u = (suv[0] + suv[2] + suv[4]) / 3;
            var v = (suv[1] + suv[3] + suv[5]) / 3;
            var wu = u - Math.Floor(u);
            var wv = v - Math.Floor(v);
            var key = ((int)(wu * UvGridCells) % UvGridCells, (int)(wv * UvGridCells) % UvGridCells);
            if (!uvGrid.TryGetValue(key, out var list))
            {
                continue;
            }

            foreach (var st in list)
            {
                int ia = surface.Indices[st * 3], ib = surface.Indices[st * 3 + 1], ic = surface.Indices[st * 3 + 2];
                double u0 = surface.Uvs[ia * 2], v0 = surface.Uvs[ia * 2 + 1];
                double u1 = surface.Uvs[ib * 2], v1 = surface.Uvs[ib * 2 + 1];
                double u2 = surface.Uvs[ic * 2], v2 = surface.Uvs[ic * 2 + 1];
                var su = Math.Floor(Math.Min(u0, Math.Min(u1, u2)));
                var sv = Math.Floor(Math.Min(v0, Math.Min(v1, v2)));
                var det = (u1 - u0) * (v2 - v0) - (u2 - u0) * (v1 - v0);
                if (Math.Abs(det) < 1e-14)
                {
                    continue;
                }

                // The spot in this triangle's own UV repeat (it may straddle a whole number).
                for (var ou = 0; ou <= 1; ou++)
                for (var ov = 0; ov <= 1; ov++)
                {
                    double pu = wu + su + ou, pv = wv + sv + ov;
                    var w1 = ((pu - u0) * (v2 - v0) - (u2 - u0) * (pv - v0)) / det;
                    var w2 = ((u1 - u0) * (pv - v0) - (pu - u0) * (v1 - v0)) / det;
                    var w0 = 1 - w1 - w2;
                    if (w0 < -1e-4 || w1 < -1e-4 || w2 < -1e-4)
                    {
                        continue;
                    }

                    var pa = surface.Positions[ia];
                    var pb = surface.Positions[ib];
                    var pc = surface.Positions[ic];
                    var q = new Point3D(pa.X * w0 + pb.X * w1 + pc.X * w2, pa.Y * w0 + pb.Y * w1 + pc.Y * w2, pa.Z * w0 + pb.Z * w1 + pc.Z * w2);
                    if ((q - centre).LengthSquared > d2)
                    {
                        shared.Add(t);
                    }
                }

                if (shared.Contains(t))
                {
                    break;
                }
            }
        }

        return shared;
    }

    /// <summary>A plain mesh_decal (not emissive, not the makeup / hair / wet variants).</summary>
    private bool IsBakeableDecal(string name)
    {
        if (!TryGetRawMaterial(name, out var raw) || raw == null)
        {
            return false;
        }

        if (!Has(ClassifyMaterialFor(name, raw), MaterialKind.Decal))
        {
            return false;
        }

        if (!IsPlainMeshDecalTemplate(GetTemplateFileName(raw)))
        {
            return false;
        }

        if (raw.Values != null && raw.Values.TryGetValue("EmissiveEV", out var ev) && ReadFloat(ev) > 0.01f)
        {
            return false;
        }

        var (bd, _, _) = GetMaterialFilePathsFromCache(name);
        return File.Exists(bd) || DecalAlpha(raw, "NormalAlpha") > 0f;
    }

    /// <summary>An opaque, baked (PNG) surface a decal can be blended into.</summary>
    private bool IsDecalSurface(SubmeshComponent sm)
    {
        // Not sm.IsTransparent: skin albedo PNGs often carry an alpha channel, which makes the
        // submesh "transparent" for drawing although it is the opaque surface decals lie on.
        var name = sm.MaterialName!;
        if (_multilayerGpuData.ContainsKey(name))
        {
            // Multilayer drawn by the shader: decals go to an overlay the shader blends in.
            return IsOverlaySurface(sm);
        }

        if (sm.Material is not PBRMaterial)
        {
            return false;
        }

        var kind = ClassifyMaterialFor(name);
        if (Has(kind, MaterialKind.Decal) || Has(kind, MaterialKind.Makeup) || Has(kind, MaterialKind.Eyebrow) ||
            Has(kind, MaterialKind.Hair) || Has(kind, MaterialKind.Glass) || Has(kind, MaterialKind.Eye))
        {
            return false;
        }

        var (bd, _, _) = GetMaterialFilePathsFromCache(name);
        return File.Exists(bd);
    }

    /// <summary>A multilayer surface drawn by the live shader (decals become its overlay).</summary>
    private bool IsOverlaySurface(SubmeshComponent sm) =>
        UseMultilayerShader && MultilayerShader.IsAvailable &&
        sm.Material is MultilayerPBRMaterial { MultilayerData: not null };

    /// <summary>
    /// mesh_decal and the variants with the same parameters: emissive (glow skipped elsewhere),
    /// parallax (height not shown in the preview; its normal, colour, roughness / metalness are).
    /// </summary>
    private static bool IsPlainMeshDecalTemplate(string template) =>
        IsGradientDecalTemplate(template) ||
        template.Equals("mesh_decal", StringComparison.OrdinalIgnoreCase) ||
        template.Equals("mesh_decal_emissive", StringComparison.OrdinalIgnoreCase) ||
        template.Equals("mesh_decal_parallax", StringComparison.OrdinalIgnoreCase);

    private static bool IsGradientDecalTemplate(string template) =>
        template.Equals("mesh_decal_gradientmap_recolor", StringComparison.OrdinalIgnoreCase);

    /// <summary>
    /// mesh_decal_gradientmap_recolor (add-on decal_nodes.py _gradient_color): DiffuseTexture.r
    /// picks the colour along GradientMap (its middle row, clamped); colour x DiffuseColor,
    /// alpha = GradientMap.a x MaskTexture.r x DiffuseAlpha (the composite then takes it as is).
    /// Hair caps on this template are hair, not decals, and never get here.
    /// </summary>
    private async Task BakeGradientDecalColor(Dictionary<string, object> dictionary, string bd)
    {
        WolvenKit.RED4.Types.ResourcePath TexPath(string key) =>
            dictionary.TryGetValue(key, out var o) && o is WolvenKit.RED4.Types.CResourceReference<WolvenKit.RED4.Types.ITexture> r
                ? r.DepotPath
                : WolvenKit.RED4.Types.ResourcePath.Empty;

        try
        {
            using var diffuseBmp = await LoadTextureAsBitmap(TexPath("DiffuseTexture"));
            using var gradientBmp = await LoadTextureAsBitmap(TexPath("GradientMap"));
            using var maskBmp = await LoadTextureAsBitmap(TexPath("MaskTexture"));
            var diffuse = Pixels.From(diffuseBmp);
            if (diffuse == null)
            {
                return;
            }

            var gradientPixels = Pixels.From(gradientBmp);
            var mask = Pixels.From(maskBmp);
            float tr = 1f, tg = 1f, tb = 1f;
            if (dictionary.TryGetValue("DiffuseColor", out var dcObj) && dcObj is WolvenKit.RED4.Types.CColor dc)
            {
                tr = dc.Red / 255f;
                tg = dc.Green / 255f;
                tb = dc.Blue / 255f;
            }

            var diffuseAlpha = dictionary.TryGetValue("DiffuseAlpha", out var daObj) ? Math.Max(0f, ReadFloat(daObj)) : 0f;
            ComposeGradient(diffuse, gradientPixels, mask, tr, tg, tb, diffuseAlpha);
            using var bmp = diffuse.ToBitmap();
            SavePngAtomic(bmp, bd);
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Decals] gradient decal: {ex.Message}");
        }
    }

    private static void ComposeGradient(Pixels diffuse, Pixels? gradient, Pixels? mask, float tr, float tg, float tb, float diffuseAlpha)
    {
        Span<float> g4 = stackalloc float[4];
        Span<float> m4 = stackalloc float[4];
        for (var y = 0; y < diffuse.H; y++)
        {
            for (var x = 0; x < diffuse.W; x++)
            {
                var o = (y * diffuse.W + x) * 4;
                var position = diffuse.Data[o + 2] / 255f;
                float r = position, g = position, b = position, a = 1f;
                if (gradient != null)
                {
                    // Clamped along the ramp: sample texel centres only.
                    var gx = Math.Clamp(position * gradient.W, 0.5, gradient.W - 0.5) / gradient.W;
                    gradient.Sample(gx, 0.5, g4);
                    r = g4[2];
                    g = g4[1];
                    b = g4[0];
                    a = g4[3];
                }

                if (mask != null)
                {
                    mask.Sample((x + 0.5) / diffuse.W, (y + 0.5) / diffuse.H, m4);
                    a *= m4[2];
                }

                diffuse.Data[o + 2] = (byte)Math.Clamp(r * tr * 255f, 0f, 255f);
                diffuse.Data[o + 1] = (byte)Math.Clamp(g * tg * 255f, 0f, 255f);
                diffuse.Data[o] = (byte)Math.Clamp(b * tb * 255f, 0f, 255f);
                diffuse.Data[o + 3] = (byte)Math.Clamp(a * diffuseAlpha * 255f, 0f, 255f);
            }
        }
    }

    private static float DecalAlpha(Material raw, string key) =>
        // mesh_decal.mt defaults are 0 for all three (Blender add-on MESH_DEFAULTS). Values above
        // 1 occur (DiffuseAlpha 2): coverage x alpha is saturated where it is used.
        raw.Values != null && raw.Values.TryGetValue(key, out var v) ? Math.Clamp(ReadFloat(v), 0f, 16f) : 0f;

    private static SurfaceGeometry? ReadSurfaceGeometry(LoadableModel model, SubmeshComponent sm)
    {
        if (sm.Geometry is not HelixToolkit.SharpDX.Core.MeshGeometry3D g ||
            g.Positions == null || g.TextureCoordinates == null || g.Indices == null ||
            g.Positions.Count == 0 || g.TextureCoordinates.Count != g.Positions.Count)
        {
            return null;
        }

        var matrix = model.Transform?.Value ?? Matrix3D.Identity;
        var positions = new Point3D[g.Positions.Count];
        var uvs = new double[g.Positions.Count * 2];
        Vector3D[]? normals = g.Normals != null && g.Normals.Count == g.Positions.Count ? new Vector3D[g.Positions.Count] : null;
        for (var i = 0; i < positions.Length; i++)
        {
            var p = g.Positions[i];
            positions[i] = matrix.Transform(new Point3D(p.X, p.Y, p.Z));
            uvs[i * 2] = g.TextureCoordinates[i].X;
            uvs[i * 2 + 1] = g.TextureCoordinates[i].Y;
            if (normals != null)
            {
                var n = g.Normals![i];
                normals[i] = matrix.Transform(new Vector3D(n.X, n.Y, n.Z));
            }
        }

        return new SurfaceGeometry { Positions = positions, Uvs = uvs, Indices = g.Indices.ToArray(), Normals = normals };
    }

    /// <summary>Surface triangles bucketed by position, plus its usual UV-per-metre density.</summary>
    private sealed class SurfaceTriangleGrid
    {
        public double CellSize;
        public Dictionary<(long, long, long), List<int>> Cells = new();
        public double UvPerMetre;
    }

    private (long, long, long) GridCell(SurfaceTriangleGrid grid, Point3D p) =>
        ((long)Math.Floor(p.X / grid.CellSize), (long)Math.Floor(p.Y / grid.CellSize), (long)Math.Floor(p.Z / grid.CellSize));

    private SurfaceTriangleGrid? BuildTriangleGrid(SurfaceGeometry g)
    {
        var triangles = g.Indices.Length / 3;
        if (triangles == 0)
        {
            return null;
        }

        // Cell about two average edges; triangles go into every cell their (widened) box touches.
        double edgeSum = 0;
        var samples = Math.Min(triangles, 2000);
        var step = Math.Max(1, triangles / samples);
        var densities = new List<double>(samples);
        for (var t = 0; t < triangles; t += step)
        {
            int a = g.Indices[t * 3], b = g.Indices[t * 3 + 1], c = g.Indices[t * 3 + 2];
            var world = (g.Positions[a] - g.Positions[b]).Length + (g.Positions[b] - g.Positions[c]).Length +
                        (g.Positions[c] - g.Positions[a]).Length;
            edgeSum += world / 3;
            var uv = UvDistance(g.Uvs, a, b) + UvDistance(g.Uvs, b, c) + UvDistance(g.Uvs, c, a);
            if (world > 1e-6 && uv > 1e-9)
            {
                densities.Add(uv / world);
            }
        }

        var grid = new SurfaceTriangleGrid
        {
            CellSize = Math.Clamp(edgeSum / Math.Max(1, (triangles + step - 1) / step) * 2, 0.005, 0.1),
        };
        densities.Sort();
        grid.UvPerMetre = densities.Count > 0 ? densities[densities.Count / 2] : 0;

        for (var t = 0; t < triangles; t++)
        {
            var p0 = g.Positions[g.Indices[t * 3]];
            var p1 = g.Positions[g.Indices[t * 3 + 1]];
            var p2 = g.Positions[g.Indices[t * 3 + 2]];
            var min = new Point3D(Math.Min(p0.X, Math.Min(p1.X, p2.X)) - DecalPositionTolerance,
                                  Math.Min(p0.Y, Math.Min(p1.Y, p2.Y)) - DecalPositionTolerance,
                                  Math.Min(p0.Z, Math.Min(p1.Z, p2.Z)) - DecalPositionTolerance);
            var max = new Point3D(Math.Max(p0.X, Math.Max(p1.X, p2.X)) + DecalPositionTolerance,
                                  Math.Max(p0.Y, Math.Max(p1.Y, p2.Y)) + DecalPositionTolerance,
                                  Math.Max(p0.Z, Math.Max(p1.Z, p2.Z)) + DecalPositionTolerance);
            var (x0, y0, z0) = GridCell(grid, min);
            var (x1, y1, z1) = GridCell(grid, max);
            if ((x1 - x0 + 1) * (y1 - y0 + 1) * (z1 - z0 + 1) > 4096)
            {
                continue; // a huge triangle (ground plane etc.), not a surface a decal sits on
            }

            for (var x = x0; x <= x1; x++)
            for (var y = y0; y <= y1; y++)
            for (var z = z0; z <= z1; z++)
            {
                if (!grid.Cells.TryGetValue((x, y, z), out var list))
                {
                    list = new List<int>(4);
                    grid.Cells[(x, y, z)] = list;
                }

                list.Add(t);
            }
        }

        return grid;
    }

    private static double UvDistance(double[] uvs, int a, int b)
    {
        var du = uvs[a * 2] - uvs[b * 2];
        var dv = uvs[a * 2 + 1] - uvs[b * 2 + 1];
        return Math.Sqrt(du * du + dv * dv);
    }

    /// <summary>Closest point of a triangle (Ericson), as barycentric weights of its corners.</summary>
    private static (double U, double V, double W) ClosestOnTriangle(Point3D p, Point3D a, Point3D b, Point3D c)
    {
        var ab = b - a;
        var ac = c - a;
        var ap = p - a;
        var d1 = Vector3D.DotProduct(ab, ap);
        var d2 = Vector3D.DotProduct(ac, ap);
        if (d1 <= 0 && d2 <= 0)
        {
            return (1, 0, 0);
        }

        var bp = p - b;
        var d3 = Vector3D.DotProduct(ab, bp);
        var d4 = Vector3D.DotProduct(ac, bp);
        if (d3 >= 0 && d4 <= d3)
        {
            return (0, 1, 0);
        }

        var vc = d1 * d4 - d3 * d2;
        if (vc <= 0 && d1 >= 0 && d3 <= 0)
        {
            var v = d1 / (d1 - d3);
            return (1 - v, v, 0);
        }

        var cp = p - c;
        var d5 = Vector3D.DotProduct(ab, cp);
        var d6 = Vector3D.DotProduct(ac, cp);
        if (d6 >= 0 && d5 <= d6)
        {
            return (0, 0, 1);
        }

        var vb = d5 * d2 - d1 * d6;
        if (vb <= 0 && d2 >= 0 && d6 <= 0)
        {
            var w = d2 / (d2 - d6);
            return (1 - w, 0, w);
        }

        var va = d3 * d6 - d5 * d4;
        if (va <= 0 && d4 - d3 >= 0 && d5 - d6 >= 0)
        {
            var w = (d4 - d3) / (d4 - d3 + (d5 - d6));
            return (0, 1 - w, w);
        }

        var denom = 1 / (va + vb + vc);
        var vv = vb * denom;
        var ww = vc * denom;
        return (1 - vv - ww, vv, ww);
    }

    /// <summary>Barycentric weights of p's projection on the triangle's plane (not clamped).</summary>
    private static (double U, double V, double W) PlaneBarycentric(Point3D p, Point3D a, Point3D b, Point3D c)
    {
        var v0 = b - a;
        var v1 = c - a;
        var v2 = p - a;
        var d00 = Vector3D.DotProduct(v0, v0);
        var d01 = Vector3D.DotProduct(v0, v1);
        var d11 = Vector3D.DotProduct(v1, v1);
        var d20 = Vector3D.DotProduct(v2, v0);
        var d21 = Vector3D.DotProduct(v2, v1);
        var denom = d00 * d11 - d01 * d01;
        if (Math.Abs(denom) < 1e-18)
        {
            return (1, 0, 0);
        }

        var v = (d11 * d20 - d01 * d21) / denom;
        var w = (d00 * d21 - d01 * d20) / denom;
        return (1 - v - w, v, w);
    }

    /// <summary>The surface triangle nearest to p (within the tolerance) and the point on it.</summary>
    private (int Triangle, double U, double V, double W, double Distance)? ProjectOnSurface(
        Point3D p, SurfaceGeometry surface, SurfaceTriangleGrid grid, double tolerance = DecalPositionTolerance)
    {
        IEnumerable<int> list;
        if (tolerance <= DecalPositionTolerance)
        {
            if (!grid.Cells.TryGetValue(GridCell(grid, p), out var cell))
            {
                return null;
            }

            list = cell;
        }
        else
        {
            // Wider search: the cells around p as far as the extra distance reaches.
            var reach = (long)Math.Ceiling((tolerance - DecalPositionTolerance) / grid.CellSize);
            var (cx, cy, cz) = GridCell(grid, p);
            var found = new HashSet<int>();
            for (var x = cx - reach; x <= cx + reach; x++)
            for (var y = cy - reach; y <= cy + reach; y++)
            for (var z = cz - reach; z <= cz + reach; z++)
            {
                if (grid.Cells.TryGetValue((x, y, z), out var cell))
                {
                    found.UnionWith(cell);
                }
            }

            list = found;
        }

        (int, double, double, double, double)? best = null;
        var bestD2 = tolerance * tolerance;
        foreach (var t in list)
        {
            var a = surface.Positions[surface.Indices[t * 3]];
            var b = surface.Positions[surface.Indices[t * 3 + 1]];
            var c = surface.Positions[surface.Indices[t * 3 + 2]];
            var (u, v, w) = ClosestOnTriangle(p, a, b, c);
            var q = new Point3D(a.X * u + b.X * v + c.X * w, a.Y * u + b.Y * v + c.Y * w, a.Z * u + b.Z * v + c.Z * w);
            var d2 = (q - p).LengthSquared;
            if (d2 <= bestD2)
            {
                bestD2 = d2;
                best = (t, u, v, w, Math.Sqrt(d2));
            }
        }

        return best;
    }

    private static (double U, double V) SurfaceUvAt(SurfaceGeometry s, int t, double u, double v, double w)
    {
        int a = s.Indices[t * 3], b = s.Indices[t * 3 + 1], c = s.Indices[t * 3 + 2];
        return (s.Uvs[a * 2] * u + s.Uvs[b * 2] * v + s.Uvs[c * 2] * w,
                s.Uvs[a * 2 + 1] * u + s.Uvs[b * 2 + 1] * v + s.Uvs[c * 2 + 1] * w);
    }

    /// <summary>
    /// For each decal triangle on the surface: the surface UVs of its corners and how far it
    /// lies from the surface. Corners are projected on the nearest surface triangle; when the
    /// three land on different UV islands (a seam: far more UV than the surface's usual
    /// density), they are taken from the plane of the triangle under the decal triangle's centre.
    /// Decal vertices need not be surface vertices (decals are often their own geometry).
    /// </summary>
    private bool MapDecalTriangles(SurfaceGeometry decal, SurfaceGeometry surface, SurfaceTriangleGrid grid,
        out List<(int Triangle, double[] SurfaceUv, double Distance)> mapped,
        ICollection<int>? only = null, double tolerance = DecalPositionTolerance)
    {
        mapped = new List<(int, double[], double)>();
        var projected = new Dictionary<int, (int Triangle, double U, double V, double W, double Distance)?>();
        (int Triangle, double U, double V, double W, double Distance)? Project(int vertex)
        {
            if (!projected.TryGetValue(vertex, out var r))
            {
                r = ProjectOnSurface(decal.Positions[vertex], surface, grid, tolerance);
                projected[vertex] = r;
            }

            return r;
        }

        var maxDensity = grid.UvPerMetre > 0 ? grid.UvPerMetre * 4 : double.MaxValue;
        var triangles = decal.Indices.Length / 3;
        for (var t = 0; t < triangles; t++)
        {
            if (only != null && !only.Contains(t))
            {
                continue;
            }

            int ia = decal.Indices[t * 3], ib = decal.Indices[t * 3 + 1], ic = decal.Indices[t * 3 + 2];
            var pa = Project(ia);
            var pb = Project(ib);
            var pc = Project(ic);
            if (pa == null || pb == null || pc == null)
            {
                continue;
            }

            Point3D A = decal.Positions[ia], B = decal.Positions[ib], C = decal.Positions[ic];
            var world = (A - B).Length + (B - C).Length + (C - A).Length;
            if (world < 1e-7)
            {
                continue;
            }

            var ua = SurfaceUvAt(surface, pa.Value.Triangle, pa.Value.U, pa.Value.V, pa.Value.W);
            var ub = SurfaceUvAt(surface, pb.Value.Triangle, pb.Value.U, pb.Value.V, pb.Value.W);
            var uc = SurfaceUvAt(surface, pc.Value.Triangle, pc.Value.U, pc.Value.V, pc.Value.W);
            double[] uv = { ua.U, ua.V, ub.U, ub.V, uc.U, uc.V };

            if (UvPerimeter(uv) / world > maxDensity)
            {
                // Seam: all three corners from the plane of the triangle under the centre.
                var centre = new Point3D((A.X + B.X + C.X) / 3, (A.Y + B.Y + C.Y) / 3, (A.Z + B.Z + C.Z) / 3);
                if (ProjectOnSurface(centre, surface, grid, tolerance) is not { } under)
                {
                    continue;
                }

                var st = under.Triangle;
                var sa = surface.Positions[surface.Indices[st * 3]];
                var sb = surface.Positions[surface.Indices[st * 3 + 1]];
                var sc = surface.Positions[surface.Indices[st * 3 + 2]];
                var ba = PlaneBarycentric(A, sa, sb, sc);
                var bb = PlaneBarycentric(B, sa, sb, sc);
                var bc = PlaneBarycentric(C, sa, sb, sc);
                ua = SurfaceUvAt(surface, st, ba.U, ba.V, ba.W);
                ub = SurfaceUvAt(surface, st, bb.U, bb.V, bb.W);
                uc = SurfaceUvAt(surface, st, bc.U, bc.V, bc.W);
                uv = new[] { ua.U, ua.V, ub.U, ub.V, uc.U, uc.V };
                if (UvPerimeter(uv) / world > maxDensity)
                {
                    continue;
                }
            }

            var distance = (pa.Value.Distance + pb.Value.Distance + pc.Value.Distance) / 3;
            mapped.Add((t, uv, distance));
        }

        return mapped.Count > 0;
    }

    private static double UvPerimeter(double[] uv)
    {
        double D(int i, int j) => Math.Sqrt((uv[i] - uv[j]) * (uv[i] - uv[j]) + (uv[i + 1] - uv[j + 1]) * (uv[i + 1] - uv[j + 1]));
        return D(0, 2) + D(2, 4) + D(4, 0);
    }

    // ---- composite cache ---------------------------------------------------------------------

    private string DecalCompositeKey(string surfaceName, List<DecalLayer> decals)
    {
        // Composite format: bump when the bake changes (v2: decal detail resolution; v3: one-sided overlay; v4: alpha above 1, NormalAlphaTex).
        var sb = new System.Text.StringBuilder("v4;");
        void Stamp(string path)
        {
            sb.Append(path).Append('|');
            try
            {
                if (File.Exists(path))
                {
                    sb.Append(File.GetLastWriteTimeUtc(path).Ticks);
                }
            }
            catch
            {
                // missing
            }

            sb.Append(';');
        }

        var (sd, sn, srm) = GetMaterialFilePathsFromCache(surfaceName);
        Stamp(sd);
        Stamp(sn);
        Stamp(srm);
        foreach (var layer in decals.OrderBy(l => l.DecalName, StringComparer.Ordinal))
        {
            var (dd, dn, drm) = GetMaterialFilePathsFromCache(layer.DecalName);
            Stamp(dd);
            Stamp(dn);
            Stamp(drm);
            if (TryGetRawMaterial(layer.DecalName, out var raw) && raw != null)
            {
                sb.Append(DecalAlpha(raw, "DiffuseAlpha")).Append(',')
                  .Append(DecalAlpha(raw, "NormalAlpha")).Append(',')
                  .Append(DecalAlpha(raw, "RoughnessMetalnessAlpha")).Append(',');
                if (raw.Values?.TryGetValue("NormalsBlendingMode", out var nbm) == true)
                {
                    sb.Append(ReadFloat(nbm));
                }
            }

            sb.Append('#').Append(layer.DecalGeometry.Positions.Length).Append('/')
              .Append(layer.DecalGeometry.Indices.Length).Append('/').Append(layer.Triangles.Count);

            sb.Append(';');
        }

        var bytes = System.Security.Cryptography.SHA1.HashData(System.Text.Encoding.UTF8.GetBytes(sb.ToString()));
        return surfaceName + "|" + Convert.ToHexString(bytes)[..10];
    }

    private static (string D, string N, string RM) DecalCompositePaths(string surfaceName, string key, bool overlay = false)
    {
        var hash = key.Split('|')[1];
        var dir = ISettingsManager.GetTemp_OBJPath();
        var stem = Path.Combine(dir, surfaceName + (overlay ? "__decaloverlay_" : "__decals_") + hash);
        return (stem + "_d.png", stem + "_n.png", stem + "_rm.png");
    }

    // ---- applying ----------------------------------------------------------------------------

    private void UseDecalComposite(Appearance app, string surfaceName, List<DecalLayer> decals, string cd, string cn, string crm)
    {
        var meshes = app.Models.SelectMany(m => m.Meshes).ToList();
        var surface = meshes.FirstOrDefault(sm => sm.MaterialName == surfaceName);
        if (surface?.Material is not PBRMaterial original)
        {
            return;
        }

        var composite = original.CloneMaterial();
        composite.AlbedoMap = GetOrCreateTexture(cd);
        composite.RenderAlbedoMap = true;
        if (File.Exists(cn))
        {
            composite.NormalMap = GetOrCreateTexture(cn);
            composite.RenderNormalMap = true;
        }

        if (File.Exists(crm))
        {
            // Absolute values: the surface's factors are baked into the composite.
            composite.RoughnessMetallicMap = GetOrCreateTexture(crm);
            composite.RenderRoughnessMetallicMap = true;
            composite.RoughnessFactor = 1;
            composite.MetallicFactor = 1;
        }

        foreach (var sm in meshes.Where(sm => sm.MaterialName == surfaceName))
        {
            sm.Material = composite;
        }

        foreach (var layer in decals)
        {
            HideDecalTriangles(app, layer);
        }
    }

    /// <summary>
    /// A multilayer surface with its decal overlay: a copy of its material whose shader data
    /// carries the overlay maps (the material of other uses stays as it is).
    /// </summary>
    private void UseDecalOverlay(Appearance app, string surfaceName, List<DecalLayer> decals, DecalOverlayFiles files)
    {
        var meshes = app.Models.SelectMany(m => m.Meshes).ToList();
        if (meshes.FirstOrDefault(sm => sm.MaterialName == surfaceName)?.Material is not MultilayerPBRMaterial { MultilayerData: { } data } original)
        {
            return;
        }

        var rnm = decals
            .Where(d => TryGetRawMaterial(d.DecalName, out var raw) && raw != null && DecalAlpha(raw, "NormalAlpha") > 0f)
            .Select(d => TryGetRawMaterial(d.DecalName, out var raw) && raw?.Values?.TryGetValue("NormalsBlendingMode", out var nbm) == true && ReadFloat(nbm) > 0.5f)
            .ToList();

        HelixToolkit.SharpDX.Core.TextureModel? Tex(string path) => File.Exists(path) ? GetOrCreateTexture(path) : null;
        var slotA = new MultilayerOverlaySlot(Tex(files.ColorA), Tex(files.NormalA), Tex(files.RmA), Tex(files.FacingA));
        var slotB = new MultilayerOverlaySlot(Tex(files.ColorB), Tex(files.NormalB), Tex(files.RmB), Tex(files.FacingB));
        var withOverlay = data.WithOverlay(slotA, slotB.IsEmpty ? null : slotB, rnm.Count(x => x) * 2 > rnm.Count);
        if (withOverlay == null)
        {
            // no room for the decal overlay in the shader's texture pool: decals stay drawn on their own
            return;
        }

        var copy = (MultilayerPBRMaterial)original.CloneMaterial();
        copy.MultilayerData = withOverlay;
        copy.DebugMode = original.DebugMode;
        copy.SoloLayer = original.SoloLayer;
        _decalOverlayMaterials[surfaceName] = copy;
        foreach (var sm in meshes.Where(sm => sm.MaterialName == surfaceName))
        {
            sm.Material = copy;
        }

        foreach (var layer in decals)
        {
            HideDecalTriangles(app, layer);
        }
    }

    /// <summary>The overlay maps of a surface: slot A, slot B (the other side), facings, a marker.</summary>
    private sealed record DecalOverlayFiles(
        string ColorA, string NormalA, string RmA, string FacingA,
        string ColorB, string NormalB, string RmB, string FacingB, string Done);

    private static DecalOverlayFiles OverlayPaths(string colorPath)
    {
        var stem = colorPath[..^"_d.png".Length];
        return new DecalOverlayFiles(
            stem + "_d.png", stem + "_n.png", stem + "_rm.png", stem + "fa_d.png",
            stem + "b_d.png", stem + "b_n.png", stem + "b_rm.png", stem + "fb_d.png",
            stem + "done_d.png");
    }

    /// <summary>Back to the decals' own geometry before the layers are worked out again.</summary>
    private void RestoreDecals(Appearance app)
    {
        _decalOverlayMaterials.Clear();
        foreach (var sm in app.Models.SelectMany(m => m.Meshes))
        {
            if (_decalHidden.TryGetValue(sm, out var state))
            {
                if (state.Original != null)
                {
                    sm.Geometry = state.Original;
                }

                _decalHidden.Remove(sm);
            }
        }
    }

    /// <summary>
    /// The decal's triangles carried by a surface are not drawn any more: all of them (and the
    /// other LODs) hide the decal; some of them leave a decal with the rest of its triangles.
    /// </summary>
    private void HideDecalTriangles(Appearance app, DecalLayer layer)
    {
        _hiddenDecalMaterial ??= new PBRMaterial
        {
            AlbedoColor = new SharpDX.Color4(0f, 0f, 0f, 0f),
            RenderAlbedoMap = false,
            RenderShadowMap = false,
        };

        var state = _decalHidden.GetValue(layer.Decal, _ => new DecalHideState { Original = layer.Decal.Geometry });
        foreach (var (triangle, _) in layer.Triangles)
        {
            state.Baked.Add(triangle);
        }

        state.Baked.UnionWith(layer.Dropped);

        var total = layer.DecalGeometry.Indices.Length / 3;
        if (state.Baked.Count >= total)
        {
            // Whole decal on surfaces: hide it, and its other LODs.
            foreach (var sm in app.Models.SelectMany(m => m.Meshes).Where(sm => sm.MaterialName == layer.DecalName))
            {
                sm.Material = _hiddenDecalMaterial;
                sm.IsTransparent = true;
            }

            return;
        }

        if (state.Original is not HelixToolkit.SharpDX.Core.MeshGeometry3D original || original.Indices == null)
        {
            return;
        }

        var kept = new HelixToolkit.SharpDX.Core.IntCollection();
        for (var t = 0; t < total; t++)
        {
            if (!state.Baked.Contains(t))
            {
                kept.Add(original.Indices[t * 3]);
                kept.Add(original.Indices[t * 3 + 1]);
                kept.Add(original.Indices[t * 3 + 2]);
            }
        }

        layer.Decal.Geometry = new HelixToolkit.SharpDX.Core.MeshGeometry3D
        {
            Positions = original.Positions,
            Normals = original.Normals,
            TextureCoordinates = original.TextureCoordinates,
            Tangents = original.Tangents,
            BiTangents = original.BiTangents,
            Colors = original.Colors,
            Indices = kept,
        };
    }

    // ---- baking ------------------------------------------------------------------------------

    private sealed class DecalJobLayer
    {
        public SurfaceGeometry Decal { get; init; } = null!;
        public List<(int Triangle, double[] SurfaceUv)> Triangles { get; init; } = null!;
        public string ColorPng { get; init; } = null!;
        public string NormalPng { get; init; } = null!;
        public string RmPng { get; init; } = null!;
        public float DiffuseAlpha { get; init; }
        public float NormalAlpha { get; init; }
        public float RmAlpha { get; init; }
        public bool Rnm { get; init; }
        public float ConstRoughness { get; init; }
        public float ConstMetalness { get; init; }

        /// <summary>The decal lies on UV the surface also uses elsewhere: the overlay is one-sided.</summary>
        public bool SharedUv { get; init; }

        /// <summary>UseNormalAlphaTex: the normal's coverage is NormalAlphaTex.r (white by default).</summary>
        public bool UseNormalAlphaTex { get; init; }

        public WolvenKit.RED4.Types.ResourcePath NormalAlphaTexPath { get; init; }

        /// <summary>Loaded before the bake (null: the default white).</summary>
        public Pixels? NormalAlphaTex { get; set; }
    }

    private sealed class DecalJob
    {
        public string SurfaceColor { get; init; } = null!;
        public string SurfaceNormal { get; init; } = null!;
        public string SurfaceRm { get; init; } = null!;
        public bool SurfaceUsesRmMap { get; init; }
        public float SurfaceRoughnessFactor { get; init; }
        public float SurfaceMetallicFactor { get; init; }
        public List<DecalJobLayer> Layers { get; init; } = null!;
    }

    private DecalJob PrepareDecalJob(string surfaceName, PBRMaterial? surfaceMaterial, List<DecalLayer> decals)
    {
        var (sd, sn, srm) = GetMaterialFilePathsFromCache(surfaceName);
        var layers = new List<DecalJobLayer>();

        foreach (var layer in decals)
        {
            if (!TryGetRawMaterial(layer.DecalName, out var raw) || raw == null)
            {
                continue;
            }

            var (dd, dn, drm) = GetMaterialFilePathsFromCache(layer.DecalName);
            var (rough, metal) = GetDecalRoughMetal(layer.DecalName);
            layers.Add(new DecalJobLayer
            {
                Decal = layer.DecalGeometry,
                Triangles = layer.Triangles,
                ColorPng = dd,
                NormalPng = dn,
                RmPng = drm,
                // Gradient decals carry DiffuseAlpha in the baked alpha already.
                DiffuseAlpha = IsGradientDecalTemplate(GetTemplateFileName(raw)) ? 1f : DecalAlpha(raw, "DiffuseAlpha"),
                NormalAlpha = DecalAlpha(raw, "NormalAlpha"),
                RmAlpha = DecalAlpha(raw, "RoughnessMetalnessAlpha"),
                Rnm = raw.Values?.TryGetValue("NormalsBlendingMode", out var nbm) == true && ReadFloat(nbm) > 0.5f,
                ConstRoughness = rough,
                ConstMetalness = metal,
                SharedUv = _decalSharedOnOverlay.TryGetValue(layer.Decal, out var so) && so.Contains(layer.Surface),
                UseNormalAlphaTex = raw.Values?.TryGetValue("UseNormalAlphaTex", out var unat) == true && ReadFloat(unat) >= 0.5f,
                NormalAlphaTexPath = raw.Values?.TryGetValue("NormalAlphaTex", out var natObj) == true &&
                                     natObj is WolvenKit.RED4.Types.CResourceReference<WolvenKit.RED4.Types.ITexture> natRef
                    ? natRef.DepotPath
                    : WolvenKit.RED4.Types.ResourcePath.Empty,
            });
        }

        return new DecalJob
        {
            SurfaceColor = sd,
            SurfaceNormal = sn,
            SurfaceRm = srm,
            SurfaceUsesRmMap = surfaceMaterial?.RenderRoughnessMetallicMap == true && File.Exists(srm),
            SurfaceRoughnessFactor = (float)(surfaceMaterial?.RoughnessFactor ?? 0.8),
            SurfaceMetallicFactor = (float)(surfaceMaterial?.MetallicFactor ?? 0),
            Layers = layers,
        };
    }

    /// <summary>A PNG as a 32-bit ARGB bitmap, without keeping the file open.</summary>
    private static Bitmap? LoadPng32(string path)
    {
        if (!File.Exists(path))
        {
            return null;
        }

        using var stream = new MemoryStream(File.ReadAllBytes(path));
        using var src = new Bitmap(stream);
        var bmp = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb);
        using (var g = Graphics.FromImage(bmp))
        {
            g.DrawImage(src, 0, 0, src.Width, src.Height);
        }

        return bmp;
    }

    /// <summary>Pixels of one bitmap, BGRA, row-major (stride = width * 4).</summary>
    private sealed class Pixels
    {
        public int W;
        public int H;
        public byte[] Data = Array.Empty<byte>();

        public static Pixels? From(Bitmap? bmp)
        {
            if (bmp == null)
            {
                return null;
            }

            var p = new Pixels { W = bmp.Width, H = bmp.Height, Data = new byte[bmp.Width * bmp.Height * 4] };
            var data = bmp.LockBits(new Rectangle(0, 0, p.W, p.H), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            try
            {
                for (var y = 0; y < p.H; y++)
                {
                    System.Runtime.InteropServices.Marshal.Copy(data.Scan0 + y * data.Stride, p.Data, y * p.W * 4, p.W * 4);
                }
            }
            finally
            {
                bmp.UnlockBits(data);
            }

            return p;
        }

        public Bitmap ToBitmap()
        {
            var bmp = new Bitmap(W, H, PixelFormat.Format32bppArgb);
            var data = bmp.LockBits(new Rectangle(0, 0, W, H), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            try
            {
                for (var y = 0; y < H; y++)
                {
                    System.Runtime.InteropServices.Marshal.Copy(Data, y * W * 4, data.Scan0 + y * data.Stride, W * 4);
                }
            }
            finally
            {
                bmp.UnlockBits(data);
            }

            return bmp;
        }

        /// <summary>Bilinear sample with wrap; channels 0..3 = B, G, R, A, in 0..1.</summary>
        public void Sample(double u, double v, Span<float> bgra)
        {
            var x = (u - Math.Floor(u)) * W - 0.5;
            var y = (v - Math.Floor(v)) * H - 0.5;
            var x0 = (int)Math.Floor(x);
            var y0 = (int)Math.Floor(y);
            var fx = (float)(x - x0);
            var fy = (float)(y - y0);
            int Wrap(int i, int n) => ((i % n) + n) % n;
            int ix0 = Wrap(x0, W), ix1 = Wrap(x0 + 1, W), iy0 = Wrap(y0, H), iy1 = Wrap(y0 + 1, H);
            for (var c = 0; c < 4; c++)
            {
                float a = Data[(iy0 * W + ix0) * 4 + c], b = Data[(iy0 * W + ix1) * 4 + c];
                float d = Data[(iy1 * W + ix0) * 4 + c], e = Data[(iy1 * W + ix1) * 4 + c];
                bgra[c] = ((a + (b - a) * fx) * (1 - fy) + (d + (e - d) * fx) * fy) / 255f;
            }
        }
    }

    private static void BakeDecalComposite(DecalJob job, string outColor, string outNormal, string outRm)
    {
        if (job.Layers.Count == 0)
        {
            return;
        }

        using var surfaceColor = LoadPng32(job.SurfaceColor);
        if (surfaceColor == null)
        {
            return;
        }

        // Composite at the decals' detail: a sharp decal over a small part of a low-resolution
        // skin texture would otherwise be blurred down to the skin's texel size.
        var scale = DecalDetailScale(job, surfaceColor.Width, surfaceColor.Height);
        int tw = surfaceColor.Width * scale, th = surfaceColor.Height * scale;
        using var colorBmp = Resized(surfaceColor, tw, th);
        var color = Pixels.From(colorBmp)!;

        var anyNormal = job.Layers.Any(l => (l.NormalAlpha > 0f || l.UseNormalAlphaTex) && File.Exists(l.NormalPng));
        var anyRm = job.Layers.Any(l => l.RmAlpha > 0f);

        // Normal target: the surface's map, or a flat one when only the decals have normals.
        Pixels? normal = null;
        if (anyNormal || File.Exists(job.SurfaceNormal))
        {
            using var nbRaw = LoadPng32(job.SurfaceNormal);
            using var nb = nbRaw == null ? null : Resized(nbRaw, tw, th);
            normal = Pixels.From(nb);
            if (normal == null && anyNormal)
            {
                normal = new Pixels { W = color.W, H = color.H, Data = new byte[color.W * color.H * 4] };
                for (var i = 0; i < normal.Data.Length; i += 4)
                {
                    normal.Data[i] = 255;       // z
                    normal.Data[i + 1] = 128;   // y
                    normal.Data[i + 2] = 128;   // x
                    normal.Data[i + 3] = 255;
                }
            }
        }

        // Roughness / metalness target with absolute values (the surface's factors applied).
        Pixels? rm = null;
        if (anyRm)
        {
            using var rbRaw = job.SurfaceUsesRmMap ? LoadPng32(job.SurfaceRm) : null;
            using var rb = rbRaw == null ? null : Resized(rbRaw, tw, th);
            rm = Pixels.From(rb) ?? new Pixels { W = color.W, H = color.H, Data = new byte[color.W * color.H * 4] };
            var fill = rb == null;
            for (var i = 0; i < rm.Data.Length; i += 4)
            {
                float r = fill ? 1f : rm.Data[i + 1] / 255f;
                float m = fill ? 1f : rm.Data[i] / 255f;
                rm.Data[i] = (byte)(Math.Clamp(m * job.SurfaceMetallicFactor, 0f, 1f) * 255f);
                rm.Data[i + 1] = (byte)(Math.Clamp(r * job.SurfaceRoughnessFactor, 0f, 1f) * 255f);
                rm.Data[i + 2] = 255;
                rm.Data[i + 3] = 255;
            }
        }

        foreach (var layer in job.Layers)
        {
            // No colour PNG (normal-only decal): full coverage, no colour.
            using var dcb = LoadPng32(layer.ColorPng);
            var dColor = Pixels.From(dcb);

            using var dnb = layer.NormalAlpha > 0f || layer.UseNormalAlphaTex ? LoadPng32(layer.NormalPng) : null;
            var dNormal = Pixels.From(dnb);
            using var drb = layer.RmAlpha > 0f ? LoadPng32(layer.RmPng) : null;
            var dRm = Pixels.From(drb);

            foreach (var (tri, suv) in layer.Triangles)
            {
                var dIdx = layer.Decal.Indices;
                var duv = layer.Decal.Uvs;
                int i0 = dIdx[tri * 3], i1 = dIdx[tri * 3 + 1], i2 = dIdx[tri * 3 + 2];
                double[] d = { duv[i0 * 2], duv[i0 * 2 + 1], duv[i1 * 2], duv[i1 * 2 + 1], duv[i2 * 2], duv[i2 * 2 + 1] };

                // Decal tangent frame -> surface tangent frame: M = S * D^-1 (UV edge matrices),
                // made a rotation (/ sqrt|det|) for the normal's XY.
                var (m00, m01, m10, m11) = UvFrameRotation(d, suv);

                if (dColor is { } dC && layer.DiffuseAlpha > 0f)
                {
                    RasterizeInto(color, suv, d, (px, uv) =>
                    {
                        Span<float> s = stackalloc float[4];
                        dC.Sample(uv.U, uv.V, s);
                        var a = Math.Min(1f, s[3] * layer.DiffuseAlpha);
                        if (a > 0f)
                        {
                            for (var c = 0; c < 3; c++)
                            {
                                var o = px + c;
                                color.Data[o] = (byte)Math.Clamp(color.Data[o] + (s[c] * 255f - color.Data[o]) * a, 0f, 255f);
                            }
                        }
                    });
                }

                if (normal is { } nTarget && dNormal is { } dN && (layer.NormalAlpha > 0f || layer.UseNormalAlphaTex))
                {
                    RasterizeInto(nTarget, suv, d, (px, uv) =>
                    {
                        var a = NormalCoverage(layer, dColor, uv);
                        if (a <= 0f)
                        {
                            return;
                        }

                        Span<float> n4 = stackalloc float[4];
                        dN.Sample(uv.U, uv.V, n4);
                        float dx = n4[2] * 2f - 1f, dy = n4[1] * 2f - 1f, dz = n4[0] * 2f - 1f;
                        // PNG normals are Y up, M works in UV space (V down): flip, rotate, flip back.
                        float rx = m00 * dx - m01 * dy, ry = -m10 * dx + m11 * dy;
                        float bx = nTarget.Data[px + 2] / 255f * 2f - 1f;
                        float by = nTarget.Data[px + 1] / 255f * 2f - 1f;
                        float bz = nTarget.Data[px] / 255f * 2f - 1f;

                        float ox, oy, oz;
                        if (layer.Rnm)
                        {
                            // Reoriented normal mapping: the decal's detail on top of the surface.
                            float tx = bx, ty = by, tz = bz + 1f;
                            float ux = -rx, uy = -ry, uz = dz;
                            var dot = tx * ux + ty * uy + tz * uz;
                            ox = tx * dot / tz - ux;
                            oy = ty * dot / tz - uy;
                            oz = tz * dot / tz - uz;
                        }
                        else
                        {
                            ox = rx;
                            oy = ry;
                            oz = dz;
                        }

                        ox = bx + (ox - bx) * a;
                        oy = by + (oy - by) * a;
                        oz = bz + (oz - bz) * a;
                        var len = MathF.Sqrt(ox * ox + oy * oy + oz * oz);
                        if (len < 1e-5f)
                        {
                            return;
                        }

                        nTarget.Data[px + 2] = (byte)((ox / len * 0.5f + 0.5f) * 255f);
                        nTarget.Data[px + 1] = (byte)((oy / len * 0.5f + 0.5f) * 255f);
                        nTarget.Data[px] = (byte)((oz / len * 0.5f + 0.5f) * 255f);
                    });
                }

                if (rm is { } rmTarget && layer.RmAlpha > 0f)
                {
                    RasterizeInto(rmTarget, suv, d, (px, uv) =>
                    {
                        var a = Math.Min(1f, Coverage(dColor, uv) * layer.RmAlpha);
                        if (a <= 0f)
                        {
                            return;
                        }

                        float r = layer.ConstRoughness, m = layer.ConstMetalness;
                        if (dRm != null)
                        {
                            Span<float> r4 = stackalloc float[4];
                            dRm.Sample(uv.U, uv.V, r4);
                            r = r4[1];
                            m = r4[0];
                        }

                        rmTarget.Data[px + 1] = (byte)Math.Clamp(rmTarget.Data[px + 1] + (r * 255f - rmTarget.Data[px + 1]) * a, 0f, 255f);
                        rmTarget.Data[px] = (byte)Math.Clamp(rmTarget.Data[px] + (m * 255f - rmTarget.Data[px]) * a, 0f, 255f);
                    });
                }
            }
        }

        using (var outBmp = color.ToBitmap())
        {
            SavePngAtomic(outBmp, outColor);
        }

        if (normal != null)
        {
            using var outN = normal.ToBitmap();
            SavePngAtomic(outN, outNormal);
        }

        if (rm != null)
        {
            using var outRmBmp = rm.ToBitmap();
            SavePngAtomic(outRmBmp, outRm);
        }
    }

    private const int DecalCompositeMaxSize = 4096;
    private const int DecalOverlayMinSize = 256;

    /// <summary>
    /// Decals of a multilayer surface drawn into transparent maps in its UV space (colour,
    /// normal, roughness / metalness, each with its coverage in alpha); the shader blends them.
    /// Size: enough for the decals' own texel density (75th percentile), power of two.
    /// </summary>
    private static void BakeDecalOverlay(DecalJob job, DecalOverlayFiles files)
    {
        if (job.Layers.Count == 0)
        {
            return;
        }

        var size = DecalOverlaySize(job);
        var anyColor = job.Layers.Any(l => l.DiffuseAlpha > 0f && File.Exists(l.ColorPng));
        var anyNormal = job.Layers.Any(l => (l.NormalAlpha > 0f || l.UseNormalAlphaTex) && File.Exists(l.NormalPng));
        var anyRm = job.Layers.Any(l => l.RmAlpha > 0f);
        var oneSided = job.Layers.Any(l => l.SharedUv);

        Pixels Blank(byte b, byte g, byte r)
        {
            var p = new Pixels { W = size, H = size, Data = new byte[size * size * 4] };
            for (var i = 0; i < p.Data.Length; i += 4)
            {
                p.Data[i] = b;
                p.Data[i + 1] = g;
                p.Data[i + 2] = r;
            }

            return p;
        }

        // Slot A, and slot B for texels the other side (facing away) already uses.
        var slots = new OverlaySlotPixels?[2];
        OverlaySlotPixels Slot(int i) => slots[i] ??= new OverlaySlotPixels
        {
            Color = anyColor ? Blank(0, 0, 0) : null,
            Normal = anyNormal ? Blank(255, 128, 128) : null,
            Rm = anyRm ? Blank(0, 128, 255) : null,
            Facing = oneSided ? Blank(128, 128, 128) : null,
        };
        Slot(0);

        // "Over" in straight alpha: the later decal on top.
        static void Over(byte[] d, int px, float r, float g, float b, float a)
        {
            var da = d[px + 3] / 255f;
            var oa = a + da * (1 - a);
            if (oa <= 0f)
            {
                return;
            }

            var keep = da * (1 - a) / oa;
            var take = a / oa;
            d[px + 2] = (byte)Math.Clamp(r * 255f * take + d[px + 2] * keep, 0f, 255f);
            d[px + 1] = (byte)Math.Clamp(g * 255f * take + d[px + 1] * keep, 0f, 255f);
            d[px] = (byte)Math.Clamp(b * 255f * take + d[px] * keep, 0f, 255f);
            d[px + 3] = (byte)Math.Clamp(oa * 255f, 0f, 255f);
        }

        // The slot for a decal texel facing f: A when free or facing the same way, else B the
        // same way, else A (a third side on the same texel: the later decal wins).
        int SlotFor(int px, Vector3D f)
        {
            if (!oneSided)
            {
                return 0;
            }

            for (var i = 0; i < 2; i++)
            {
                var facing = Slot(i).Facing!;
                if (facing.Data[px + 3] == 0)
                {
                    return i;
                }

                var fx = facing.Data[px + 2] / 255.0 * 2 - 1;
                var fy = facing.Data[px + 1] / 255.0 * 2 - 1;
                var fz = facing.Data[px] / 255.0 * 2 - 1;
                if (fx * f.X + fy * f.Y + fz * f.Z > 0.5)
                {
                    return i;
                }
            }

            return 0;
        }

        foreach (var layer in job.Layers)
        {
            using var dcb = LoadPng32(layer.ColorPng);
            var dColor = Pixels.From(dcb);
            using var dnb = layer.NormalAlpha > 0f || layer.UseNormalAlphaTex ? LoadPng32(layer.NormalPng) : null;
            var dNormal = Pixels.From(dnb);
            using var drb = layer.RmAlpha > 0f ? LoadPng32(layer.RmPng) : null;
            var dRm = Pixels.From(drb);

            foreach (var (tri, suv) in layer.Triangles)
            {
                var dIdx = layer.Decal.Indices;
                var duv = layer.Decal.Uvs;
                int i0 = dIdx[tri * 3], i1 = dIdx[tri * 3 + 1], i2 = dIdx[tri * 3 + 2];
                double[] d = { duv[i0 * 2], duv[i0 * 2 + 1], duv[i1 * 2], duv[i1 * 2 + 1], duv[i2 * 2], duv[i2 * 2 + 1] };
                var (m00, m01, m10, m11) = UvFrameRotation(d, suv);
                var facing = layer.Decal.Facing(tri);

                RasterizeInto(Slot(0).Facing ?? Slot(0).Color ?? Slot(0).Normal ?? Slot(0).Rm!, suv, d, (px, uv) =>
                {
                    Span<float> c4 = stackalloc float[4];
                    var coverage = 1f;
                    if (dColor != null)
                    {
                        dColor.Sample(uv.U, uv.V, c4);
                        coverage = c4[3];
                    }

                    var aColor = dColor != null ? Math.Min(1f, coverage * layer.DiffuseAlpha) : 0f;
                    var aNormal = NormalCoverage(layer, dColor, uv);
                    var aRm = Math.Min(1f, coverage * layer.RmAlpha);
                    var aAny = Math.Max(aColor, Math.Max(aNormal, aRm));
                    if (aAny <= 0f)
                    {
                        return;
                    }

                    var slot = Slot(SlotFor(px, facing));

                    if (slot.Facing is { } f)
                    {
                        Over(f.Data, px, (float)(facing.X * 0.5 + 0.5), (float)(facing.Y * 0.5 + 0.5), (float)(facing.Z * 0.5 + 0.5), aAny);
                    }

                    if (slot.Color is { } c && aColor > 0f)
                    {
                        Over(c.Data, px, c4[2], c4[1], c4[0], aColor);
                    }

                    if (slot.Normal is { } n && dNormal != null && aNormal > 0f)
                    {
                        Span<float> n4 = stackalloc float[4];
                        dNormal.Sample(uv.U, uv.V, n4);
                        float dx = n4[2] * 2f - 1f, dy = n4[1] * 2f - 1f, dz = n4[0] * 2f - 1f;
                        float rx = m00 * dx - m01 * dy, ry = -m10 * dx + m11 * dy;
                        var len = MathF.Sqrt(rx * rx + ry * ry + dz * dz);
                        if (len > 1e-5f)
                        {
                            Over(n.Data, px, rx / len * 0.5f + 0.5f, ry / len * 0.5f + 0.5f, dz / len * 0.5f + 0.5f, aNormal);
                        }
                    }

                    if (slot.Rm is { } rmT && aRm > 0f)
                    {
                        float r = layer.ConstRoughness, m = layer.ConstMetalness;
                        if (dRm != null)
                        {
                            Span<float> r4 = stackalloc float[4];
                            dRm.Sample(uv.U, uv.V, r4);
                            r = r4[1];
                            m = r4[0];
                        }

                        Over(rmT.Data, px, 1f, r, m, aRm);
                    }
                });
            }
        }

        void Save(Pixels? p, string path, bool dilate = true)
        {
            if (p == null)
            {
                return;
            }

            using var bmp = p.ToBitmap();
            if (dilate)
            {
                // Colour of the covered pixels into the uncovered ones: filtering at the edge must
                // not pull in black (or the flat normal) with the coverage.
                DilateColorIntoTransparent(bmp);
            }

            SavePngAtomic(bmp, path);
        }

        foreach (var path in new[] { files.ColorB, files.NormalB, files.RmB, files.FacingB, files.FacingA })
        {
            try
            {
                File.Delete(path);
            }
            catch
            {
                // not there
            }
        }

        var a = slots[0]!;
        Save(a.Color, files.ColorA);
        Save(a.Normal, files.NormalA);
        Save(a.Rm, files.RmA);
        Save(a.Facing, files.FacingA);
        if (slots[1] is { } b)
        {
            Save(b.Color, files.ColorB);
            Save(b.Normal, files.NormalB);
            Save(b.Rm, files.RmB);
            Save(b.Facing, files.FacingB);
        }

        // Written last: the overlay is complete.
        using var marker = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        SavePngAtomic(marker, files.Done);
    }

    private sealed class OverlaySlotPixels
    {
        public Pixels? Color;
        public Pixels? Normal;
        public Pixels? Rm;
        public Pixels? Facing;
    }

    private static int DecalOverlaySize(DecalJob job)
    {
        var ratios = new List<double>();
        foreach (var layer in job.Layers)
        {
            var (dw, dh) = PngSize(layer.ColorPng);
            if (dw == 0)
            {
                (dw, dh) = PngSize(layer.NormalPng);
            }

            if (dw == 0)
            {
                dw = dh = 512;
            }

            foreach (var (tri, suv) in layer.Triangles)
            {
                var idx = layer.Decal.Indices;
                var uv = layer.Decal.Uvs;
                int a = idx[tri * 3], b = idx[tri * 3 + 1], c = idx[tri * 3 + 2];
                var decalPixels = Math.Abs((uv[b * 2] - uv[a * 2]) * (uv[c * 2 + 1] - uv[a * 2 + 1]) -
                                           (uv[c * 2] - uv[a * 2]) * (uv[b * 2 + 1] - uv[a * 2 + 1])) * dw * dh;
                var surfaceUv = Math.Abs((suv[2] - suv[0]) * (suv[5] - suv[1]) - (suv[4] - suv[0]) * (suv[3] - suv[1]));
                if (surfaceUv > 1e-12 && decalPixels > 1e-6)
                {
                    ratios.Add(Math.Sqrt(decalPixels / surfaceUv));
                }
            }
        }

        if (ratios.Count == 0)
        {
            return 1024;
        }

        ratios.Sort();
        var needed = ratios[(int)(ratios.Count * 0.75)];
        var size = DecalOverlayMinSize;
        while (size < needed && size < DecalCompositeMaxSize)
        {
            size *= 2;
        }

        return size;
    }

    /// <summary>
    /// How much larger than the surface texture the composite must be to keep the decals'
    /// detail: decal texels per surface texel over the decal triangles (75th percentile),
    /// as a power of two, up to <see cref="DecalCompositeMaxSize"/>.
    /// </summary>
    private static int DecalDetailScale(DecalJob job, int w, int h)
    {
        var ratios = new List<double>();
        foreach (var layer in job.Layers)
        {
            var (dw, dh) = PngSize(layer.ColorPng);
            if (dw == 0)
            {
                (dw, dh) = PngSize(layer.NormalPng);
            }

            if (dw == 0)
            {
                continue;
            }

            foreach (var (tri, suv) in layer.Triangles)
            {
                var idx = layer.Decal.Indices;
                var uv = layer.Decal.Uvs;
                int a = idx[tri * 3], b = idx[tri * 3 + 1], c = idx[tri * 3 + 2];
                var decalArea = Math.Abs((uv[b * 2] - uv[a * 2]) * (uv[c * 2 + 1] - uv[a * 2 + 1]) -
                                         (uv[c * 2] - uv[a * 2]) * (uv[b * 2 + 1] - uv[a * 2 + 1])) * dw * dh;
                var surfaceArea = Math.Abs((suv[2] - suv[0]) * (suv[5] - suv[1]) -
                                           (suv[4] - suv[0]) * (suv[3] - suv[1])) * w * h;
                if (surfaceArea > 1e-6 && decalArea > 1e-6)
                {
                    ratios.Add(Math.Sqrt(decalArea / surfaceArea));
                }
            }
        }

        if (ratios.Count == 0)
        {
            return 1;
        }

        ratios.Sort();
        var needed = ratios[(int)(ratios.Count * 0.75)];
        var scale = 1;
        while (scale < needed && Math.Max(w, h) * scale * 2 <= DecalCompositeMaxSize)
        {
            scale *= 2;
        }

        return scale;
    }

    private static (int W, int H) PngSize(string path)
    {
        try
        {
            if (!File.Exists(path))
            {
                return (0, 0);
            }

            using var stream = File.OpenRead(path);
            using var img = System.Drawing.Image.FromStream(stream, false, false);
            return (img.Width, img.Height);
        }
        catch
        {
            return (0, 0);
        }
    }

    /// <summary>The bitmap at w x h (a new one; the same size gives a copy).</summary>
    private static Bitmap Resized(Bitmap src, int w, int h)
    {
        var bmp = new Bitmap(w, h, PixelFormat.Format32bppArgb);
        using var g = Graphics.FromImage(bmp);
        g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
        g.InterpolationMode = w == src.Width && h == src.Height
            ? System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor
            : System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
        using var attributes = new ImageAttributes();
        attributes.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY); // no dark border
        g.DrawImage(src, new Rectangle(0, 0, w, h), 0, 0, src.Width, src.Height, GraphicsUnit.Pixel, attributes);
        return bmp;
    }

    /// <summary>
    /// Coverage of the decal's normal: NormalAlphaTex.r with UseNormalAlphaTex (white = everywhere
    /// on the decal mesh), else the colour coverage x NormalAlpha; saturated.
    /// </summary>
    private static float NormalCoverage(DecalJobLayer layer, Pixels? color, (double U, double V) uv)
    {
        if (layer.UseNormalAlphaTex)
        {
            if (layer.NormalAlphaTex == null)
            {
                return 1f;
            }

            Span<float> t4 = stackalloc float[4];
            layer.NormalAlphaTex.Sample(uv.U, uv.V, t4);
            return t4[2];
        }

        return Math.Min(1f, Coverage(color, uv) * layer.NormalAlpha);
    }

    /// <summary>Decal coverage at a decal UV: the colour PNG's alpha (1 without one).</summary>
    private static float Coverage(Pixels? color, (double U, double V) uv)
    {
        if (color == null)
        {
            return 1f;
        }

        Span<float> c4 = stackalloc float[4];
        color.Sample(uv.U, uv.V, c4);
        return c4[3];
    }

    /// <summary>
    /// Rotation taking a tangent-space XY of the decal to the surface: the matrix mapping decal
    /// UV edges onto surface UV edges, scaled to unit determinant.
    /// </summary>
    private static (float, float, float, float) UvFrameRotation(double[] d, double[] s)
    {
        double d00 = d[2] - d[0], d10 = d[3] - d[1], d01 = d[4] - d[0], d11 = d[5] - d[1];
        double s00 = s[2] - s[0], s10 = s[3] - s[1], s01 = s[4] - s[0], s11 = s[5] - s[1];
        var det = d00 * d11 - d01 * d10;
        if (Math.Abs(det) < 1e-12)
        {
            return (1, 0, 0, 1);
        }

        // D^-1
        double i00 = d11 / det, i01 = -d01 / det, i10 = -d10 / det, i11 = d00 / det;
        // M = S * D^-1
        var m00 = s00 * i00 + s01 * i10;
        var m01 = s00 * i01 + s01 * i11;
        var m10 = s10 * i00 + s11 * i10;
        var m11 = s10 * i01 + s11 * i11;
        var scale = Math.Sqrt(Math.Abs(m00 * m11 - m01 * m10));
        if (scale < 1e-12)
        {
            return (1, 0, 0, 1);
        }

        return ((float)(m00 / scale), (float)(m01 / scale), (float)(m10 / scale), (float)(m11 / scale));
    }

    /// <summary>
    /// Pixels of the target inside the triangle given in the target's UV space (wrapped),
    /// with the decal UV interpolated at each pixel centre.
    /// </summary>
    private static void RasterizeInto(Pixels target, double[] suv, double[] duv, Action<int, (double U, double V)> pixel)
    {
        double x0 = suv[0] * target.W, y0 = suv[1] * target.H;
        double x1 = suv[2] * target.W, y1 = suv[3] * target.H;
        double x2 = suv[4] * target.W, y2 = suv[5] * target.H;
        var area = (x1 - x0) * (y2 - y0) - (x2 - x0) * (y1 - y0);
        if (Math.Abs(area) < 1e-9)
        {
            return;
        }

        var minX = (int)Math.Floor(Math.Min(x0, Math.Min(x1, x2)) - 1);
        var maxX = (int)Math.Ceiling(Math.Max(x0, Math.Max(x1, x2)) + 1);
        var minY = (int)Math.Floor(Math.Min(y0, Math.Min(y1, y2)) - 1);
        var maxY = (int)Math.Ceiling(Math.Max(y0, Math.Max(y1, y2)) + 1);
        if ((long)(maxX - minX) * (maxY - minY) > 4L * target.W * target.H)
        {
            return;
        }

        // Barycentric slack of about half a pixel (w changes by edge length / area per pixel).
        var longest = Math.Max(Math.Max(Math.Sqrt((x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0)),
                                        Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1))),
                               Math.Sqrt((x0 - x2) * (x0 - x2) + (y0 - y2) * (y0 - y2)));
        var edge = 0.5 * longest / Math.Abs(area);
        for (var py = minY; py <= maxY; py++)
        {
            for (var px = minX; px <= maxX; px++)
            {
                double cx = px + 0.5, cy = py + 0.5;
                var w0 = ((x1 - cx) * (y2 - cy) - (x2 - cx) * (y1 - cy)) / area;
                var w1 = ((x2 - cx) * (y0 - cy) - (x0 - cx) * (y2 - cy)) / area;
                var w2 = 1 - w0 - w1;
                if (w0 < -edge || w1 < -edge || w2 < -edge)
                {
                    continue;
                }

                var u = w0 * duv[0] + w1 * duv[2] + w2 * duv[4];
                var v = w0 * duv[1] + w1 * duv[3] + w2 * duv[5];
                var tx = ((px % target.W) + target.W) % target.W;
                var ty = ((py % target.H) + target.H) % target.H;
                pixel((ty * target.W + tx) * 4, (u, v));
            }
        }
    }
}
