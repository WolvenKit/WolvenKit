using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.App.Models;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Makeup decals with NormalAlpha 0 leave the normals of the skin under them in the game
/// (the lips keep their folds). The preview draws the decal as its own mesh, so it takes the
/// normal map of the skin it lies on - but only when the decal really shares that surface:
/// its vertices sit on skin vertices (within 2 mm) with the same UVs (character creator makeup meshes are
/// cut from the head). Otherwise the decal stays as it is.
/// </summary>
public partial class RDTMeshViewModel
{
    private const int MakeupUvSamples = 256;
    private const double MakeupPositionTolerance = 0.002;   // 2 mm (decals may sit slightly above)
    private const double MakeupUvTolerance = 0.002;
    private const double MakeupMatchRatio = 0.8;

    private void ApplySkinNormalsUnderMakeup(Appearance app)
    {
        try
        {
            var all = app.Models.SelectMany(m => m.Meshes.Select(sm => (Model: m, Mesh: sm))).ToList();

            var skins = all
                .Where(x => !string.IsNullOrEmpty(x.Mesh.MaterialName) &&
                            x.Mesh.Material is PBRMaterial { NormalMap: not null, RenderNormalMap: true } &&
                            Has(ClassifyMaterialFor(x.Mesh.MaterialName), MaterialKind.Skin))
                .ToList();
            if (skins.Count == 0)
            {
                return;
            }

            var cellsCache = new Dictionary<SubmeshComponent, Dictionary<(long, long, long), List<(Point3D Pos, double U, double V)>>?>();

            foreach (var (model, sm) in all)
            {
                if (sm.Material is not PBRMaterial mat || string.IsNullOrEmpty(sm.MaterialName) ||
                    !Has(ClassifyMaterialFor(sm.MaterialName), MaterialKind.Makeup) ||
                    !KeepsSurfaceNormals(sm.MaterialName))
                {
                    continue;
                }

                // Same LOD first: other LODs have other vertices.
                foreach (var (skinModel, skin) in skins.OrderBy(s => s.Mesh.LOD == sm.LOD ? 0 : 1))
                {
                    if (!cellsCache.TryGetValue(skin, out var cells))
                    {
                        cells = BuildVertexCells(skinModel, skin);
                        cellsCache[skin] = cells;
                    }

                    if (cells != null && SharesSurface(model, sm, cells))
                    {
                        var skinMat = (PBRMaterial)skin.Material;
                        mat.NormalMap = skinMat.NormalMap;
                        mat.RenderNormalMap = true;
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Debug($"[Preview] skin normals under makeup: {ex.Message}");
        }
    }

    /// <summary>NormalAlpha 0: the decal does not write normals, the skin's stay.</summary>
    private bool KeepsSurfaceNormals(string materialName)
    {
        if (!TryGetRawMaterial(materialName, out var raw) || raw?.Values == null)
        {
            return false;
        }

        return !raw.Values.TryGetValue("NormalAlpha", out var na) || ReadFloat(na) <= 0.001f;
    }

    private static (Point3D[]? Positions, double[]? Uvs) ReadGeometry(LoadableModel model, SubmeshComponent sm)
    {
        if (sm.Geometry is not HelixToolkit.SharpDX.Core.MeshGeometry3D g ||
            g.Positions == null || g.TextureCoordinates == null ||
            g.Positions.Count == 0 || g.TextureCoordinates.Count != g.Positions.Count)
        {
            return (null, null);
        }

        var matrix = model.Transform?.Value ?? Matrix3D.Identity;
        var positions = new Point3D[g.Positions.Count];
        var uvs = new double[g.Positions.Count * 2];
        for (var i = 0; i < positions.Length; i++)
        {
            var p = g.Positions[i];
            positions[i] = matrix.Transform(new Point3D(p.X, p.Y, p.Z));
            uvs[i * 2] = g.TextureCoordinates[i].X;
            uvs[i * 2 + 1] = g.TextureCoordinates[i].Y;
        }

        return (positions, uvs);
    }

    private static (long, long, long) Cell(Point3D p) =>
        ((long)Math.Floor(p.X / MakeupPositionTolerance),
         (long)Math.Floor(p.Y / MakeupPositionTolerance),
         (long)Math.Floor(p.Z / MakeupPositionTolerance));

    private static Dictionary<(long, long, long), List<(Point3D Pos, double U, double V)>>? BuildVertexCells(LoadableModel model, SubmeshComponent sm)
    {
        var (positions, uvs) = ReadGeometry(model, sm);
        if (positions == null || uvs == null)
        {
            return null;
        }

        var cells = new Dictionary<(long, long, long), List<(Point3D, double, double)>>();
        for (var i = 0; i < positions.Length; i++)
        {
            var key = Cell(positions[i]);
            if (!cells.TryGetValue(key, out var list))
            {
                list = new List<(Point3D, double, double)>(1);
                cells[key] = list;
            }

            list.Add((positions[i], uvs[i * 2], uvs[i * 2 + 1]));
        }

        return cells;
    }

    /// <summary>Most sampled decal vertices lie on a skin vertex (2 mm) with the same UV.</summary>
    private static bool SharesSurface(LoadableModel model, SubmeshComponent sm,
        Dictionary<(long, long, long), List<(Point3D Pos, double U, double V)>> cells)
    {
        var (positions, uvs) = ReadGeometry(model, sm);
        if (positions == null || uvs == null)
        {
            return false;
        }

        var samples = Math.Min(MakeupUvSamples, positions.Length);
        var step = Math.Max(1, positions.Length / samples);
        int tested = 0, matched = 0;
        var tol2 = MakeupPositionTolerance * MakeupPositionTolerance;

        for (var i = 0; i < positions.Length && tested < samples; i += step)
        {
            tested++;
            var p = positions[i];
            var (cx, cy, cz) = Cell(p);
            var found = false;
            for (var dx = -1; dx <= 1 && !found; dx++)
            for (var dy = -1; dy <= 1 && !found; dy++)
            for (var dz = -1; dz <= 1 && !found; dz++)
            {
                if (!cells.TryGetValue((cx + dx, cy + dy, cz + dz), out var list))
                {
                    continue;
                }

                foreach (var (pos, u, v) in list)
                {
                    if ((pos - p).LengthSquared <= tol2 &&
                        Math.Abs(u - uvs[i * 2]) <= MakeupUvTolerance &&
                        Math.Abs(v - uvs[i * 2 + 1]) <= MakeupUvTolerance)
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                matched++;
            }
        }

        return tested > 0 && matched >= tested * MakeupMatchRatio;
    }
}
