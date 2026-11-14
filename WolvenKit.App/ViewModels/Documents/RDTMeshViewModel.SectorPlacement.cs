using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media.Media3D;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.App.Models;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using MeshGeometry3D = HelixToolkit.SharpDX.Core.MeshGeometry3D;
using NMatrix = System.Numerics.Matrix4x4;
using NQuaternion = System.Numerics.Quaternion;
using NVector3 = System.Numerics.Vector3;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Sector preview: where meshes of sector nodes go.
/// - every nodeData entry of a cooked node (game 2.5) places only the inner node its
///   instanceIndex picks; a worldInstancedMeshNode entry places the transform range of
///   that inner node (the transforms are already in world space)
/// - bended meshes (roads, rails...) and cables follow their deformation frames, the way
///   the Blender add-on bends them
/// </summary>
public partial class RDTMeshViewModel
{
    /// <summary>The axis a deformed mesh runs along, in the mesh's own (game) space.</summary>
    private enum SectorBendAxis
    {
        /// <summary>worldBendedMeshNode: +Y, from min to max.</summary>
        PositiveY,

        /// <summary>worldCableMeshNode: -X, from max to min.</summary>
        NegativeX,
    }

    /// <param name="NodeDataIndex">index of the nodeData entry (shown in the node tree)</param>
    /// <param name="Matrix">placement of the mesh</param>
    /// <param name="Frames">deformation frames in the placement's space, or null</param>
    private sealed record SectorMeshPlacement(int NodeDataIndex, Matrix3D Matrix, IReadOnlyList<CMatrix>? Frames = null);

    private static Matrix3D SectorNodeMatrix(worldCompiledNodeInstanceSetupInfo info)
    {
        var matrix = new Matrix3D();
        matrix.Scale(ToScaleVector3D(info.Scale));
        matrix.Rotate(ToQuaternion(info.Transform.Orientation));
        matrix.Translate(ToVector3D(info.Transform.Position));
        return matrix;
    }

    private static Matrix3D SectorInstanceMatrix(RenderProxyTransform transform)
    {
        var matrix = new Matrix3D();
        matrix.Scale(ToScaleVector3D(transform.Scale));
        matrix.Rotate(ToQuaternion(transform.Transform.Orientation));
        matrix.Translate(ToVector3D(transform.Transform.Position));
        return matrix;
    }

    private static IReadOnlyList<CMatrix> SliceFrames(IList<CMatrix> all, uint start, uint count)
    {
        if (start >= all.Count || count == 0)
        {
            return [];
        }

        var end = (int)Math.Min((long)start + count, all.Count);
        var list = new List<CMatrix>(end - (int)start);
        for (var i = (int)start; i < end; i++)
        {
            list.Add(all[i]);
        }

        return list;
    }

    /// <summary>
    /// Cooked node (game 2.5): each nodeData entry places the inner node its instanceIndex picks.
    /// One tree row per inner node, one instance per entry.
    /// </summary>
    private void AddCookedSectorMeshes(List<Element3D> groups, Appearance app, string name, string typeStr, ulong handleIndex,
        worldNodeDataBuffer buffer, List<worldCompiledNodeInstanceSetupInfo> transforms, int innerCount,
        Func<int, (ResourcePath Mesh, CName Appearance)> innerMesh,
        Func<int, IReadOnlyList<CMatrix>?>? innerFrames = null,
        SectorBendAxis bendAxis = SectorBendAxis.PositiveY)
    {
        var byInner = new SortedDictionary<int, List<SectorMeshPlacement>>();
        foreach (var info in transforms)
        {
            var inner = (int)(uint)info.InstanceIndex;
            if (inner < 0 || inner >= innerCount)
            {
                continue;
            }

            if (!byInner.TryGetValue(inner, out var placements))
            {
                placements = [];
                byInner[inner] = placements;
            }

            placements.Add(new SectorMeshPlacement(buffer.IndexOf(info), SectorNodeMatrix(info), innerFrames?.Invoke(inner)));
        }

        foreach (var (inner, placements) in byInner)
        {
            var (mesh, appearance) = innerMesh(inner);
            var rowName = byInner.Count > 1 ? $"{name}_{inner}" : name;
            AddSectorMeshGroup(groups, app, rowName, typeStr, handleIndex, mesh, appearance, placements, bendAxis);
        }
    }

    /// <summary>
    /// worldInstancedMeshNode (game 2.5): an entry places the transform range of the inner node its
    /// instanceIndex picks. The transforms are world space, so the entry's own transform is not applied.
    /// </summary>
    private void AddInstancedSectorMeshes(List<Element3D> groups, Appearance app, string name, string typeStr, ulong handleIndex,
        worldNodeDataBuffer buffer, List<worldCompiledNodeInstanceSetupInfo> transforms,
        worldInstancedMeshNodeBuffer inner, WorldTransformsBuffer world)
    {
        var dataIndices = new SortedDictionary<int, List<int>>();
        foreach (var info in transforms)
        {
            var index = (int)(uint)info.InstanceIndex;
            if (index < 0 || index >= inner.InnerNodes.Count || index >= inner.TransformRanges.Count)
            {
                continue;
            }

            if (!dataIndices.TryGetValue(index, out var list))
            {
                list = [];
                dataIndices[index] = list;
            }

            list.Add(buffer.IndexOf(info));
        }

        foreach (var (index, entries) in dataIndices)
        {
            var node = inner.InnerNodes[index];
            var range = inner.TransformRanges[index];

            var placements = new List<SectorMeshPlacement>();
            var start = (int)(ushort)range.TransformIndex;
            var end = Math.Min(start + (ushort)range.TransformCount, world.Transforms.Count);
            for (var j = start; j < end; j++)
            {
                if (world.Transforms[j] is { } transform)
                {
                    placements.Add(new SectorMeshPlacement(entries[0], SectorInstanceMatrix(transform)));
                }
            }

            var rowName = dataIndices.Count > 1 ? $"{name}_{index}" : name;
            // the transforms are shared by the entries: the group shows with any of them
            AddSectorMeshGroup(groups, app, rowName, typeStr, handleIndex, node.Mesh.DepotPath, node.MeshAppearance, placements,
                groupDataIndices: entries.ToArray());
        }
    }

    /// <summary>
    /// One tree row for a mesh a sector node places, with one child per placement.
    /// Geometry and materials are shared between placements, except for bended meshes,
    /// which get their own deformed copy.
    /// </summary>
    /// <param name="embeddedMesh">mesh kept in the node itself (terrain), used when meshRef is empty</param>
    /// <param name="instances">hardware instances of every placement (foliage), in the placement's space</param>
    private void AddSectorMeshGroup(List<Element3D> groups, Appearance app, string name, string typeStr, ulong handleIndex,
        ResourcePath meshRef, CName meshAppearance, IReadOnlyList<SectorMeshPlacement> placements,
        SectorBendAxis bendAxis = SectorBendAxis.PositiveY, int[]? groupDataIndices = null,
        CMesh? embeddedMesh = null, IList<SharpDX.Matrix>? instances = null)
    {
        if (placements.Count == 0)
        {
            return;
        }

        CMesh? mesh;
        string meshPath;
        if (meshRef != ResourcePath.Empty || embeddedMesh is null)
        {
            mesh = GetProjectOrDepotFile(meshRef)?.RootChunk as CMesh;
            meshPath = meshRef.GetResolvedText() ?? string.Empty;
        }
        else
        {
            mesh = embeddedMesh;
            // no depot path: key the shared geometry by the mesh object
            meshPath = $"embedded mesh {System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(embeddedMesh)}";
        }

        if (mesh is null)
        {
            return;
        }

        foreach (var material in GetSectorMaterials(mesh, meshAppearance, meshPath))
        {
            app.RawMaterials[material.Name] = material;
        }

        // The node's appearance picks the chunk materials.
        var appearanceIndex = GetMeshAppearanceIndex(mesh, meshAppearance);

        var group = new MeshComponent()
        {
            Name = name,
            Text = name,
            WorldNodeIndex = $"{handleIndex}",
            WorldNodeType = typeStr,
            WorldNodeDataIndices = groupDataIndices != null
                ? string.Join(", ", groupDataIndices)
                : string.Join(", ", placements.Select(p => p.NodeDataIndex).Distinct()),
            AppearanceName = meshAppearance,
            DepotPath = meshRef
        };

        if (group.WorldNodeIndex == SelectedNodeIndex)
        {
            SelectedItem = group;
        }

        for (var i = 0; i < placements.Count; i++)
        {
            var placement = placements[i];
            var meshes = MakeMeshShared(mesh, ulong.MaxValue, appearanceIndex, meshPath);

            if (placement.Frames is { Count: >= 2 } frames)
            {
                BendSectorSubmeshes(meshes, frames, bendAxis);
            }

            var subgroup = new MeshComponent()
            {
                Name = name + $"_instance_{i:D2}",
                Text = name + $"_instance_{i:D2}",
                AppearanceName = meshAppearance,
                DepotPath = meshRef
            };

            foreach (var submesh in meshes)
            {
                if (instances != null)
                {
                    submesh.Instances = instances;
                }

                if (!app.LODLUT.TryGetValue(submesh.LOD, out var lodMeshes))
                {
                    lodMeshes = [];
                    app.LODLUT[submesh.LOD] = lodMeshes;
                }

                lodMeshes.Add(submesh);
                subgroup.Children.Add(submesh);
            }

            subgroup.Transform = new MatrixTransform3D(placement.Matrix);
            group.Children.Add(subgroup);

            if (groupDataIndices == null)
            {
                // variants: the placement shows with its nodeData entry
                RegisterSectorPlacement(subgroup, placement.NodeDataIndex);
            }
        }

        if (groupDataIndices != null)
        {
            RegisterSectorPlacement(group, groupDataIndices);
        }

        // proxy mesh nodes (worldPrefabProxyMeshNode / worldCooked*ProxyMeshNode and their kinds)
        if (typeStr.Contains("ProxyMesh", StringComparison.Ordinal))
        {
            RegisterSectorProxy(group);
        }

        // foliage nodes ("Show foliage")
        if (instances != null)
        {
            RegisterSectorFoliage(group);
        }

        groups.Add(group);
    }

    /// <summary>
    /// worldFoliageNode: the node places its span of the foliage resource's populations
    /// (position, rotation, uniform scale, relative to the node), as the Blender add-on does.
    /// Drawn with hardware instancing: grass and bushes come in thousands.
    /// It used to be one mesh at the node's origin.
    /// </summary>
    private void AddFoliageSectorMeshes(List<Element3D> groups, Appearance app, string name, string typeStr, ulong handleIndex,
        worldNodeDataBuffer buffer, List<worldCompiledNodeInstanceSetupInfo> transforms, worldFoliageNode node)
    {
        if (GetProjectOrDepotFile(node.FoliageResource.DepotPath)?.RootChunk is not worldFoliageCompiledResource resource ||
            resource.DataBuffer.Data is not FoliageBuffer foliage)
        {
            return;
        }

        var span = node.PopulationSpanInfo;
        var begin = (int)Math.Min((uint)span.StancesBegin, (uint)foliage.Populations.Count);
        var end = (int)Math.Min((long)begin + (uint)span.StancesCount, foliage.Populations.Count);

        var instances = new List<SharpDX.Matrix>(end - begin);
        for (var i = begin; i < end; i++)
        {
            var population = foliage.Populations[i];
            float scale = population.Scale;
            if (!float.IsFinite(scale) || scale <= 0f)
            {
                continue;
            }

            // Rotation is (X, Y, Z, W) = (i, j, k, r); preview space is (x, z, -y)
            var r = population.Rotation;
            var rotation = new System.Windows.Media.Media3D.Quaternion(r.X, r.Z, -r.Y, r.W);
            if (rotation.X * rotation.X + rotation.Y * rotation.Y + rotation.Z * rotation.Z + rotation.W * rotation.W <= 1e-12)
            {
                rotation = System.Windows.Media.Media3D.Quaternion.Identity;
            }
            else
            {
                rotation.Normalize();
            }

            var matrix = new Matrix3D();
            matrix.Scale(new Vector3D(scale, scale, scale));
            matrix.Rotate(rotation);
            matrix.Translate(ToVector3D(population.Position));
            instances.Add(ToSharpDXMatrix(matrix));
        }

        if (instances.Count == 0)
        {
            return;
        }

        var placements = transforms
            .Select(t => new SectorMeshPlacement(buffer.IndexOf(t), SectorNodeMatrix(t)))
            .ToList();
        AddSectorMeshGroup(groups, app, name, typeStr, handleIndex, node.Mesh.DepotPath, node.MeshAppearance, placements,
            instances: instances);
    }

    /// <summary>
    /// worldInstancedDestructibleMeshNode: every instance transform (relative to the node) at every
    /// nodeData entry of the node. Only the first entry was used.
    /// </summary>
    private void AddDestructibleSectorMeshes(List<Element3D> groups, Appearance app, string name, string typeStr, ulong handleIndex,
        worldNodeDataBuffer buffer, List<worldCompiledNodeInstanceSetupInfo> transforms, worldInstancedDestructibleMeshNode node)
    {
        var placements = new List<SectorMeshPlacement>();
        foreach (var info in transforms)
        {
            var nodeMatrix = SectorNodeMatrix(info);
            foreach (var transform in node.InstanceTransforms)
            {
                if (transform is null)
                {
                    continue;
                }

                var matrix = new Matrix3D();
                matrix.Rotate(ToQuaternion(transform.Orientation));
                matrix.Translate(ToVector3D(transform.Position));
                matrix.Append(nodeMatrix);
                placements.Add(new SectorMeshPlacement(buffer.IndexOf(info), matrix));
            }
        }

        // The node may name its mesh in staticMesh only.
        var mesh = node.Mesh.DepotPath != ResourcePath.Empty ? node.Mesh.DepotPath : node.StaticMesh.DepotPath;
        var appearance = node.Mesh.DepotPath != ResourcePath.Empty ? node.MeshAppearance : node.StaticMeshAppearance;
        AddSectorMeshGroup(groups, app, name, typeStr, handleIndex, mesh, appearance, placements);
    }

    /// <summary>
    /// Area nodes (triggers, interiors, ambient / GI / light channel areas, world boundaries...):
    /// their outline extruded by its height, centred on the outline as in the Blender add-on,
    /// in the node's colour. They were drawn as a box sized from the first outline point.
    /// </summary>
    private void AddAreaShape(List<Element3D> groups, string name, string typeStr, ulong handleIndex, string indexStr,
        worldNodeDataBuffer buffer, List<worldCompiledNodeInstanceSetupInfo> transforms, worldAreaShapeNode node)
    {
        if (node.Outline.Chunk is not { Points.Count: >= 3 } outline)
        {
            return;
        }

        var points = outline.Points.Where(p => p is not null).Select(p => new SharpDX.Vector3(p.X, p.Y, p.Z)).ToList();
        if (points.Count < 3)
        {
            return;
        }

        float half = outline.Height * 0.5f;
        SharpDX.Vector3 Preview(SharpDX.Vector3 p, float dz) => new(p.X, p.Z + dz, -p.Y);

        var mb = new MeshBuilder();
        for (var i = 1; i + 1 < points.Count; i++)
        {
            // caps (fan: fine for the convex outlines most areas have)
            mb.AddTriangle(Preview(points[0], -half), Preview(points[i + 1], -half), Preview(points[i], -half));
            mb.AddTriangle(Preview(points[0], half), Preview(points[i], half), Preview(points[i + 1], half));
        }

        for (var i = 0; i < points.Count; i++)
        {
            var a = points[i];
            var b = points[(i + 1) % points.Count];
            mb.AddQuad(Preview(a, -half), Preview(b, -half), Preview(b, half), Preview(a, half));
        }

        mb.ComputeNormalsAndTangents(MeshFaces.Default);
        var geometry = mb.ToMeshGeometry3D();

        var material = SetupPBRMaterial("DefaultMaterial");
        var (areaColor, areaKind) = AreaShapeLook(node);
        material.AlbedoColor = RegisterSectorAreaMaterial(material, areaColor);

        var group = new MeshComponent()
        {
            Name = name,
            Text = name,
            WorldNodeIndex = $"{handleIndex}",
            WorldNodeType = typeStr,
            WorldNodeDataIndices = indexStr,
        };

        foreach (var info in transforms)
        {
            // a submesh, so that selecting the node highlights it like a mesh
            var volume = new SubmeshComponent()
            {
                Name = name + "_volume",
                Text = name + "_volume",
                MaterialName = areaKind, // Material column of the tree: what kind of area this is
                Geometry = geometry,
                Material = material,
                IsTransparent = true,
                CullMode = SharpDX.Direct3D11.CullMode.None,
                Transform = new MatrixTransform3D(SectorNodeMatrix(info))
            };
            group.Children.Add(volume);
            RegisterSectorPlacement(volume, buffer.IndexOf(info));
        }

        if (group.WorldNodeIndex == SelectedNodeIndex)
        {
            SelectedItem = group;
        }

        RegisterSectorArea(group); // "Show areas"
        groups.Add(group);
    }

    /// <summary>
    /// Area colours by node type (the Blender add-on's palette), so the colour tells the kind of area:
    /// the type itself, else its nearest listed base type (other triggers are trigger orange).
    /// </summary>
    private static readonly (Type Type, SharpDX.Color4 Color, string Kind)[] s_areaPalette =
    [
        (typeof(gameKillTriggerNode), new SharpDX.Color4(1f, 0f, 0f, 0.15f), "Area: kill trigger"),
        (typeof(gameWorldBoundaryNode), new SharpDX.Color4(1f, 0f, 0.4f, 0.15f), "Area: world boundary"),
        (typeof(worldLightChannelVolumeNode), new SharpDX.Color4(0.75f, 0.2f, 1f, 0.15f), "Area: light channel"),
        (typeof(worldGISpaceNode), new SharpDX.Color4(0.2f, 1f, 0.65f, 0.15f), "Area: GI space"),
        (typeof(worldAmbientAreaNode), new SharpDX.Color4(0.15f, 0.55f, 1f, 0.15f), "Area: ambient (sound)"),
        (typeof(worldInteriorAreaNode), new SharpDX.Color4(0.2f, 0.65f, 1f, 0.15f), "Area: interior"),
        (typeof(worldTriggerAreaNode), new SharpDX.Color4(1f, 0.35f, 0.05f, 0.15f), "Area: trigger"),
    ];

    /// <summary>
    /// Colour and label of an area node: by type (see s_areaPalette); for other areas the colour
    /// the node carries for the editor, else a faint white.
    /// </summary>
    private static (SharpDX.Color4 Color, string Kind) AreaShapeLook(worldAreaShapeNode node)
    {
        // exact types first, then base types (the order of the palette)
        foreach (var entry in s_areaPalette)
        {
            if (node.GetType() == entry.Type)
            {
                return (entry.Color, entry.Kind);
            }
        }

        foreach (var entry in s_areaPalette)
        {
            if (entry.Type.IsInstanceOfType(node))
            {
                return (entry.Color, entry.Kind);
            }
        }

        var kind = "Area: " + node.GetType().Name;
        byte red = node.Color?.Red ?? (byte)0, green = node.Color?.Green ?? (byte)0, blue = node.Color?.Blue ?? (byte)0;
        return red == 0 && green == 0 && blue == 0
            ? (new SharpDX.Color4(1f, 1f, 1f, 0.1f), kind)
            : (new SharpDX.Color4(red / 255f, green / 255f, blue / 255f, 0.15f), kind);
    }

    private static SharpDX.Matrix ToSharpDXMatrix(Matrix3D m) => new(
        (float)m.M11, (float)m.M12, (float)m.M13, (float)m.M14,
        (float)m.M21, (float)m.M22, (float)m.M23, (float)m.M24,
        (float)m.M31, (float)m.M32, (float)m.M33, (float)m.M34,
        (float)m.OffsetX, (float)m.OffsetY, (float)m.OffsetZ, (float)m.M44);

    #region embedded files

    // Files embedded in the sector being drawn and in its extern inplace resource, by path.
    private Dictionary<ResourcePath, CR2WFile>? _sectorEmbeddedFiles;

    // What the shown sectors and the files read while building them embed besides meshes
    // (material instances, mlsetups, masks, textures - a terrain mesh carries its mask, base
    // colour and global normal as inplace resources), kept after building: materials are
    // generated later. The first file to embed a path wins.
    private readonly System.Collections.Concurrent.ConcurrentDictionary<ResourcePath, CR2WFile> _keptEmbeddedFiles = new();

    // What the files read for the materials embed besides meshes (a .mi often its mlsetup).
    // Lives as long as the file cache: cleared with it (Generate, Ctrl+Generate) and when a
    // project file changes, so an edited or removed file does not leave its embedded copies behind.
    private readonly System.Collections.Concurrent.ConcurrentDictionary<ResourcePath, CR2WFile> _readEmbeddedFiles = new();

    /// <summary>Keeps the non-mesh files a read file embeds (called for every file read).</summary>
    private void KeepEmbeddedFiles(CR2WFile? file)
    {
        if (file == null)
        {
            return;
        }

        foreach (var embedded in file.EmbeddedFiles)
        {
            if (embedded?.Content is { } content and not CMesh && embedded.FileName != ResourcePath.Empty)
            {
                // while a sector is built (the snapshot is taken): kept with the sector
                var kept = _projectFileSnapshot != null ? _keptEmbeddedFiles : _readEmbeddedFiles;
                if (!kept.ContainsKey(embedded.FileName))
                {
                    kept.TryAdd(embedded.FileName, new CR2WFile { RootChunk = content });
                }
            }
        }
    }

    /// <summary>
    /// Sectors often keep their foliage (and other resources) embedded: in the sector file itself,
    /// or in its extern inplace resource (.streamingsector_inplace). The open document's embedded files
    /// were found already; a sector loaded in a block preview and the inplace resource were not.
    /// </summary>
    private void PrepareSectorEmbeddedFiles(worldStreamingSector data, CR2WFile? sectorFile)
    {
        _sectorEmbeddedFiles = null;
        var found = new Dictionary<ResourcePath, CR2WFile>();

        void Add(CR2WFile? file)
        {
            if (file == null)
            {
                return;
            }

            foreach (var embedded in file.EmbeddedFiles)
            {
                if (embedded?.Content != null && embedded.FileName != ResourcePath.Empty)
                {
                    found.TryAdd(embedded.FileName, new CR2WFile { RootChunk = embedded.Content });
                }
            }
        }

        // the sector's own embedded files win over the shared inplace resource
        Add(sectorFile);

        try
        {
            if (data.ExternInplaceResource.DepotPath != ResourcePath.Empty)
            {
                Add(GetProjectOrDepotFile(data.ExternInplaceResource.DepotPath));
            }
        }
        catch (Exception ex)
        {
            _loggerService.Warning($"[Sector] could not read the inplace resource {data.ExternInplaceResource.DepotPath}: {ex.Message}");
        }

        if (found.Count > 0)
        {
            _sectorEmbeddedFiles = found;
            foreach (var (path, file) in found)
            {
                if (file.RootChunk is not CMesh)
                {
                    _keptEmbeddedFiles.TryAdd(path, file);
                }
            }
        }
    }

    /// <summary>A non-mesh file embedded in a sector or a file read for this preview, for material generation.</summary>
    /// <param name="readEmbedded">false: not the copies embedded in the files read for the materials</param>
    private CR2WFile? KeptEmbeddedFile(ResourcePath path, bool readEmbedded = true) =>
        _keptEmbeddedFiles.TryGetValue(path, out var file) || (readEmbedded && _readEmbeddedFiles.TryGetValue(path, out file)) ? file : null;

    /// <summary>Content of a file embedded in the sector (or the open document) under this path.</summary>
    private RedBaseClass? EmbeddedForSector(ResourcePath path) =>
        _sectorEmbeddedFiles != null && _sectorEmbeddedFiles.TryGetValue(path, out var file)
            ? file.RootChunk
            : FindEmbeddedContent(path);

    #endregion

    #region bended meshes

    /// <summary>
    /// Bends the submeshes along the deformation frames. The submeshes share their geometry
    /// with other placements, so each one gets a deformed copy.
    /// </summary>
    private void BendSectorSubmeshes(List<SubmeshComponent> meshes, IReadOnlyList<CMatrix> frames, SectorBendAxis axis)
    {
        try
        {
            var geometries = meshes.Select(m => m.Geometry as MeshGeometry3D).OfType<MeshGeometry3D>().ToList();
            if (SectorBend.Create(frames, axis, geometries) is not { } bend)
            {
                return;
            }

            foreach (var submesh in meshes)
            {
                if (submesh.Geometry is MeshGeometry3D geometry)
                {
                    submesh.Geometry = bend.Apply(geometry);
                }
            }
        }
        catch (Exception ex)
        {
            // A broken frame list must not stop the sector: the mesh stays straight.
            _loggerService.Warning($"[Sector] could not bend mesh: {ex.Message}");
        }
    }

    /// <summary>
    /// Deformation of a bended / cable mesh, as in the Blender add-on (importers/sector/services/deformation.py):
    /// a vertex's position along the axis, between the mesh's min and max on that axis, picks a point
    /// between the frames (translation and scale interpolated, rotation slerped); the vertex's cross-section
    /// (its other two coordinates, scaled by the frame) is rotated and moved to that point.
    /// Worked in game space (Z up); preview geometry is (x, z, -y) of it.
    /// </summary>
    private sealed class SectorBend
    {
        private readonly NVector3[] _translations;
        private readonly NQuaternion[] _rotations;
        private readonly NVector3[] _scales;
        private readonly SectorBendAxis _axis;
        private readonly float _min;
        private readonly float _span;

        private SectorBend(NVector3[] translations, NQuaternion[] rotations, NVector3[] scales, SectorBendAxis axis, float min, float span)
        {
            _translations = translations;
            _rotations = rotations;
            _scales = scales;
            _axis = axis;
            _min = min;
            _span = span;
        }

        public static SectorBend? Create(IReadOnlyList<CMatrix> frames, SectorBendAxis axis, IReadOnlyList<MeshGeometry3D> geometries)
        {
            if (frames.Count < 2)
            {
                return null;
            }

            var min = float.PositiveInfinity;
            var max = float.NegativeInfinity;
            foreach (var geometry in geometries)
            {
                if (geometry.Positions is not { } positions)
                {
                    continue;
                }

                foreach (var p in positions)
                {
                    var value = AxisValue(ToGame(p), axis);
                    min = Math.Min(min, value);
                    max = Math.Max(max, value);
                }
            }

            if (!(max - min > 1e-8f))
            {
                return null;
            }

            var translations = new NVector3[frames.Count];
            var rotations = new NQuaternion[frames.Count];
            var scales = new NVector3[frames.Count];
            for (var i = 0; i < frames.Count; i++)
            {
                Decompose(frames[i], out translations[i], out rotations[i], out scales[i]);
            }

            return new SectorBend(translations, rotations, scales, axis, min, max - min);
        }

        public MeshGeometry3D Apply(MeshGeometry3D source)
        {
            var positions = source.Positions;
            if (positions is null || positions.Count == 0)
            {
                return source;
            }

            var normals = source.Normals;
            var tangents = source.Tangents;
            var bitangents = source.BiTangents;

            var newPositions = new Vector3Collection(positions.Count);
            var newNormals = normals is null ? null : new Vector3Collection(normals.Count);
            var newTangents = tangents is null ? null : new Vector3Collection(tangents.Count);
            var newBitangents = bitangents is null ? null : new Vector3Collection(bitangents.Count);

            for (var i = 0; i < positions.Count; i++)
            {
                var p = ToGame(positions[i]);
                Sample(Factor(p), out var t, out var r, out var s);

                newPositions.Add(ToPreview(t + NVector3.Transform(CrossSection(p) * s, r)));

                // Directions: the cross-section scale for vectors along the surface, its inverse for the normal.
                var surfaceScale = WithAxis(s, 1f);
                if (newNormals != null && i < normals!.Count)
                {
                    newNormals.Add(ToPreview(Direction(ToGame(normals[i]) / NonZero(surfaceScale), r)));
                }

                if (newTangents != null && i < tangents!.Count)
                {
                    newTangents.Add(ToPreview(Direction(ToGame(tangents[i]) * surfaceScale, r)));
                }

                if (newBitangents != null && i < bitangents!.Count)
                {
                    newBitangents.Add(ToPreview(Direction(ToGame(bitangents[i]) * surfaceScale, r)));
                }
            }

            var result = new MeshGeometry3D()
            {
                Positions = newPositions,
                Indices = source.Indices,
                TextureCoordinates = source.TextureCoordinates,
            };

            if (newNormals != null)
            {
                result.Normals = newNormals;
            }

            if (newTangents != null)
            {
                result.Tangents = newTangents;
            }

            if (newBitangents != null)
            {
                result.BiTangents = newBitangents;
            }

            if (source.Colors != null)
            {
                result.Colors = source.Colors;
            }

            return result;
        }

        private float Factor(NVector3 p)
        {
            var value = AxisValue(p, _axis);
            return _axis == SectorBendAxis.PositiveY
                ? (value - _min) / _span
                : (_min + _span - value) / _span;
        }

        private NVector3 CrossSection(NVector3 p) => _axis == SectorBendAxis.PositiveY
            ? new NVector3(p.X, 0f, p.Z)
            : new NVector3(0f, p.Y, p.Z);

        private NVector3 WithAxis(NVector3 v, float value) => _axis == SectorBendAxis.PositiveY
            ? new NVector3(v.X, value, v.Z)
            : new NVector3(value, v.Y, v.Z);

        private void Sample(float factor, out NVector3 translation, out NQuaternion rotation, out NVector3 scale)
        {
            var position = Math.Clamp(factor, 0f, 1f) * (_translations.Length - 1);
            var index = Math.Min((int)MathF.Floor(position), _translations.Length - 2);
            var blend = position - index;

            translation = NVector3.Lerp(_translations[index], _translations[index + 1], blend);
            rotation = NQuaternion.Slerp(_rotations[index], _rotations[index + 1], blend);
            scale = NVector3.Lerp(_scales[index], _scales[index + 1], blend);
        }

        private static float AxisValue(NVector3 p, SectorBendAxis axis) => axis == SectorBendAxis.PositiveY ? p.Y : p.X;

        private static NVector3 Direction(NVector3 v, NQuaternion r)
        {
            var d = NVector3.Transform(v, r);
            var length = d.Length();
            return length > 1e-12f ? d / length : d;
        }

        private static NVector3 NonZero(NVector3 v) => new(
            MathF.Abs(v.X) > 1e-6f ? v.X : 1f,
            MathF.Abs(v.Y) > 1e-6f ? v.Y : 1f,
            MathF.Abs(v.Z) > 1e-6f ? v.Z : 1f);

        /// <summary>
        /// Frame matrix: columns X, Y, Z are the axes, W the translation (as the add-on reads them).
        /// A mirrored frame (negative determinant) keeps the mirror in its X scale.
        /// </summary>
        private static void Decompose(CMatrix m, out NVector3 translation, out NQuaternion rotation, out NVector3 scale)
        {
            var x = new NVector3(m.X.X, m.X.Y, m.X.Z);
            var y = new NVector3(m.Y.X, m.Y.Y, m.Y.Z);
            var z = new NVector3(m.Z.X, m.Z.Y, m.Z.Z);
            translation = new NVector3(m.W.X, m.W.Y, m.W.Z);

            var sx = x.Length();
            var sy = y.Length();
            var sz = z.Length();
            if (NVector3.Dot(NVector3.Cross(x, y), z) < 0f)
            {
                sx = -sx;
            }

            scale = new NVector3(sx, sy, sz);

            var ax = sx != 0f ? x / sx : NVector3.UnitX;
            var ay = sy != 0f ? y / sy : NVector3.UnitY;
            var az = sz != 0f ? z / sz : NVector3.UnitZ;

            // Row vectors (System.Numerics): rows are the axes.
            var basis = new NMatrix(
                ax.X, ax.Y, ax.Z, 0f,
                ay.X, ay.Y, ay.Z, 0f,
                az.X, az.Y, az.Z, 0f,
                0f, 0f, 0f, 1f);
            rotation = NQuaternion.Normalize(NQuaternion.CreateFromRotationMatrix(basis));
        }

        // preview (x, y, z) = game (x, z, -y)
        private static NVector3 ToGame(SharpDX.Vector3 v) => new(v.X, -v.Z, v.Y);

        private static SharpDX.Vector3 ToPreview(NVector3 v) => new(v.X, v.Z, -v.Y);
    }

    #endregion
}
