using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using Splat;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using ReactiveUI;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common;
using WolvenKit.Functionality.Extensions;

namespace WolvenKit.ViewModels.Documents
{
    public partial class RDTMeshViewModel
    {
        public RDTMeshViewModel(worldStreamingSector data, RedDocumentViewModel file) : this(file)
        {
            Header = "Sector Preview";
            _data = data;

            var app = new Appearance()
            {
                Name = Path.GetFileNameWithoutExtension(File.ContentId).Replace("-", "_"),
            };

            Appearances.Add(app);
            SelectedAppearance = app;

            this.WhenActivated((CompositeDisposable disposables) =>
            {
                RenderSectorSolo();
            });
        }

        public void RenderSectorSolo()
        {
            if (IsRendered)
            {
                return;
            }
            IsRendered = true;
            RenderSector((worldStreamingSector)_data, Appearances[0]);
        }

        public Element3D RenderSector(worldStreamingSector data, Appearance app)
        {
            var ssTransforms = ((worldNodeDataBuffer)data.NodeData.Data).Lookup;

            var groups = new List<Element3D>();
            foreach (var (handleIndex, transforms) in ssTransforms)
            {
                var handle = data.Nodes[handleIndex];
                var name = (string)handle.Chunk.DebugName;
                name = "_" + name?.Replace("{", "").Replace("}", "").Replace("\\", "_").Replace(".", "_").Replace("!", "").Replace("-", "_") ?? "none";

                if (handle.Chunk is IRedMeshNode irmn)
                {
                    var meshFile = File.GetFileFromDepotPathOrCache(irmn.Mesh.DepotPath);

                    if (meshFile == null || meshFile.RootChunk is not CMesh mesh)
                    {
                        continue;
                    }

                    var appMaterials = GetMaterialsForAppearance(mesh, irmn.MeshAppearance);

                    var group = new MeshComponent()
                    {
                        Name = name,
                        AppearanceName = irmn.MeshAppearance,
                        DepotPath = irmn.Mesh.DepotPath
                    };

                    var model = new LoadableModel()
                    {
                        MeshFile = File.Cr2wFile,
                        AppearanceIndex = 0,
                        AppearanceName = irmn.MeshAppearance,
                        Materials = appMaterials,
                        Name = name,
                        IsEnabled = true,
                    };

                    foreach (var material in model.Materials)
                    {
                        app.RawMaterials[material.Name] = material;
                    }

                    if (handle.Chunk is worldInstancedMeshNode wimn)
                    {
                        if (wimn.WorldTransformsBuffer.SharedDataBuffer.Chunk.Buffer.Data is not WorldTransformsBuffer wtb)
                        {
                            continue;
                        }

                        var wtbTransforms = wtb.Transforms;
                        for (int i = 0; i < wimn.WorldTransformsBuffer.NumElements; i++)
                        {
                            var meshes = MakeMesh(mesh, ulong.MaxValue, 0);

                            var subgroup = new MeshComponent()
                            {
                                Name = name + $"_instance_{i:D2}",
                                AppearanceName = wimn.MeshAppearance,
                                DepotPath = irmn.Mesh.DepotPath
                            };

                            foreach (var submesh in meshes)
                            {
                                if (!app.LODLUT.ContainsKey(submesh.LOD))
                                {
                                    app.LODLUT[submesh.LOD] = new List<SubmeshComponent>();
                                }
                                app.LODLUT[submesh.LOD].Add(submesh);
                                subgroup.Children.Add(submesh);
                            }

                            var matrix = new Matrix3D();
                            matrix.Scale(ToScaleVector3D(transforms[0].Scale));
                            matrix.Rotate(ToQuaternion(transforms[0].Orientation));
                            matrix.Translate(ToVector3D(transforms[0].Position));

                            var wtbMatrix = new Matrix3D();
                            if (wtbTransforms[(int)(wimn.WorldTransformsBuffer.StartIndex + i)] is worldNodeTransform wte)
                            {
                                wtbMatrix.Scale(ToScaleVector3D(wte.Scale));
                            }
                            wtbMatrix.Rotate(ToQuaternion(wtbTransforms[(int)(wimn.WorldTransformsBuffer.StartIndex + i)].Rotation));
                            wtbMatrix.Translate(ToVector3D(wtbTransforms[(int)(wimn.WorldTransformsBuffer.StartIndex + i)].Translation));

                            wtbMatrix.Append(matrix);

                            subgroup.Transform = new MatrixTransform3D(wtbMatrix);

                            group.Children.Add(subgroup);
                        }
                    }
                    else if (handle.Chunk is worldInstancedDestructibleMeshNode widmn)
                    {
                        if (widmn.CookedInstanceTransforms.SharedDataBuffer.Chunk.Buffer.Data is not CookedInstanceTransformsBuffer citb)
                        {
                            continue;
                        }

                        var citbTransforms = citb.Transforms;
                        for (int i = 0; i < widmn.CookedInstanceTransforms.NumElements; i++)
                        {
                            //for (int j = 0; j < transforms.Count; j++)
                            //{
                            var meshes = MakeMesh(mesh, ulong.MaxValue, 0);

                            var subgroup = new MeshComponent()
                            {
                                Name = name + $"_instance_{i:D2}",
                                AppearanceName = widmn.MeshAppearance,
                                DepotPath = irmn.Mesh.DepotPath
                            };

                            foreach (var submesh in meshes)
                            {
                                if (!app.LODLUT.ContainsKey(submesh.LOD))
                                {
                                    app.LODLUT[submesh.LOD] = new List<SubmeshComponent>();
                                }
                                app.LODLUT[submesh.LOD].Add(submesh);
                                subgroup.Children.Add(submesh);
                            }

                            var matrix = new Matrix3D();
                            matrix.Scale(ToScaleVector3D(transforms[0].Scale));
                            matrix.Rotate(ToQuaternion(transforms[0].Orientation));
                            matrix.Translate(ToVector3D(transforms[0].Position));

                            var citbMatrix = new Matrix3D();
                            citbMatrix.Rotate(ToQuaternion(citbTransforms[(int)(widmn.CookedInstanceTransforms.StartIndex + i)].Orientation));
                            citbMatrix.Translate(ToVector3D(citbTransforms[(int)(widmn.CookedInstanceTransforms.StartIndex + i)].Position));

                            citbMatrix.Append(matrix);

                            subgroup.Transform = new MatrixTransform3D(citbMatrix);

                            group.Children.Add(subgroup);
                            //}
                        }
                    }
                    else
                    {
                        var i = 0;
                        foreach (var transform in transforms)
                        {
                            var meshes = MakeMesh(mesh, ulong.MaxValue, 0);

                            var subgroup = new MeshComponent()
                            {
                                Name = name + $"_instance_{i:D2}",
                                AppearanceName = irmn.MeshAppearance,
                                DepotPath = irmn.Mesh.DepotPath
                            };

                            foreach (var submesh in meshes)
                            {
                                if (!app.LODLUT.ContainsKey(submesh.LOD))
                                {
                                    app.LODLUT[submesh.LOD] = new List<SubmeshComponent>();
                                }
                                app.LODLUT[submesh.LOD].Add(submesh);
                                subgroup.Children.Add(submesh);
                            }

                            var matrix = new Matrix3D();
                            matrix.Scale(ToScaleVector3D(transform.Scale));
                            matrix.Rotate(ToQuaternion(transform.Orientation));
                            matrix.Translate(ToVector3D(transform.Position));

                            if (irmn is worldBendedMeshNode wbmn)
                            {
                                //matrix.Append(ToMatrix3D(wbmn.DeformationData[i]));
                            }

                            subgroup.Transform = new MatrixTransform3D(matrix);

                            group.Children.Add(subgroup);
                            i++;
                        }
                    }

                    groups.Add(group);
                }
                else if (handle.Chunk is worldCollisionNode wcn)
                {
                    if (wcn.CompiledData.Data is not CollisionBuffer cb)
                    {
                        continue;
                    }

                    var gcs = Locator.Current.GetService<GeometryCacheService>();

                    var mesh = new MeshComponent()
                    {
                        Name = "collisionNode_" + wcn.SectorHash
                    };

                    var colliderMaterial = new PBRMaterial()
                    {
                        EnableAutoTangent = true,
                        RenderShadowMap = true,
                        RenderEnvironmentMap = true,
                        //AlbedoColor = new SharpDX.Color4(0.5f * Random.Shared.NextSingle(), 0f, 0.5f * Random.Shared.NextSingle(), 1f),
                        AlbedoColor = new SharpDX.Color4(0.5f, 0f, 0.5f, 1f),
                        RoughnessFactor = 0.5,
                        MetallicFactor = 0
                    };

                    foreach (var actor in cb.Actors)
                    {
                        var actorGroup = new MeshComponent()
                        {
                            Name = "actor_" + cb.Actors.IndexOf(actor)
                        };

                        foreach (var shape in actor.Shapes)
                        {
                            HelixToolkit.SharpDX.Core.MeshGeometry3D geometry = null;

                            if (shape.ShapeType == Enums.physicsShapeType.Box)
                            {
                                var mb = new MeshBuilder();
                                mb.CreateNormals = true;
                                mb.AddBox(new SharpDX.Vector3(0f, 0f, 0f), shape.Size.X * 2, shape.Size.Z * 2, shape.Size.Y * 2);

                                mb.ComputeNormalsAndTangents(MeshFaces.Default, true);

                                geometry = mb.ToMeshGeometry3D();
                            }
                            else if (shape.ShapeType == Enums.physicsShapeType.ConvexMesh || shape.ShapeType == Enums.physicsShapeType.TriangleMesh)
                            {
                                var geo = gcs.GetEntry(wcn.SectorHash, shape.Hash);

                                if (geo == null)
                                {
                                    //Locator.Current.GetService<ILoggerService>().Warning($"Couldn't find entry with hash {shape.Hash} in sector {wcn.SectorHash}, handle[{data.Handles.IndexOf(handle)}], actor[{cb.Actors.IndexOf(actor)}], shape[{actor.Shapes.IndexOf(shape)}]");
                                    continue;
                                }

                                if (geo is CVXMCacheEntry cce)
                                {
                                    var mb = new MeshBuilder();

                                    mb.CreateNormals = true;

                                    var positions = new Vector3Collection();
                                    for (var i = 0; i < cce.Vertices.Count; i++)
                                    {
                                        positions.Add(cce.Vertices[i].ToVector3());
                                    }

                                    //foreach (var face in cce.Faces)
                                    //{
                                    //    var points = new List<SharpDX.Vector3>();
                                    //    foreach (var point in face)
                                    //    {
                                    //        points.Add(positions[point]);
                                    //    }
                                    //    switch (points.Count)
                                    //    {
                                    //        case 3:
                                    //            mb.AddTriangle(points[0], points[1], points[2]);
                                    //            break;
                                    //        case 4:
                                    //            mb.AddQuad(points[3], points[2], points[1], points[0]);
                                    //            break;
                                    //        default:
                                    //            for (int i = 0; i + 2 < points.Count; i++)
                                    //            {
                                    //                mb.AddTriangle(points[0], points[i + 1], points[i + 2]);
                                    //            }
                                    //            break;
                                    //    }
                                    //}


                                    //for (var i = 0; i < cce.Vertices.Count; i++)
                                    //{
                                    //    mb.Positions.Add(cce.Vertices[i].ToVector3());
                                    //}

                                    for (var i = 0; i < cce.FaceData.Count; i++)
                                    {
                                        var count = mb.Positions.Count;
                                        switch (cce.Faces[i].Count)
                                        {
                                            case 3:
                                                mb.Positions.Add(positions[cce.Faces[i][0]]);
                                                mb.Positions.Add(positions[cce.Faces[i][1]]);
                                                mb.Positions.Add(positions[cce.Faces[i][2]]);
                                                mb.Normals.Add(cce.FaceData[i].Normal.ToVector3());
                                                mb.Normals.Add(cce.FaceData[i].Normal.ToVector3());
                                                mb.Normals.Add(cce.FaceData[i].Normal.ToVector3());
                                                mb.TriangleIndices.Add(count);
                                                mb.TriangleIndices.Add(count + 1);
                                                mb.TriangleIndices.Add(count + 2);
                                                break;
                                            case 4:
                                                mb.Positions.Add(positions[cce.Faces[i][0]]);
                                                mb.Positions.Add(positions[cce.Faces[i][1]]);
                                                mb.Positions.Add(positions[cce.Faces[i][2]]);
                                                mb.Positions.Add(positions[cce.Faces[i][3]]);
                                                mb.Normals.Add(cce.FaceData[i].Normal.ToVector3());
                                                mb.Normals.Add(cce.FaceData[i].Normal.ToVector3());
                                                mb.Normals.Add(cce.FaceData[i].Normal.ToVector3());
                                                mb.Normals.Add(cce.FaceData[i].Normal.ToVector3());
                                                mb.TriangleIndices.Add(count);
                                                mb.TriangleIndices.Add(count + 1);
                                                mb.TriangleIndices.Add(count + 2);
                                                mb.TriangleIndices.Add(count + 2);
                                                mb.TriangleIndices.Add(count + 3);
                                                mb.TriangleIndices.Add(count);
                                                break;
                                            default:
                                                for (int j = 0; j < cce.Faces[i].Count; j++)
                                                {
                                                    mb.Positions.Add(positions[cce.Faces[i][j]]);
                                                    mb.Normals.Add(cce.FaceData[i].Normal.ToVector3());
                                                }
                                                for (int j = 0; j + 2 < cce.Faces[i].Count; j++)
                                                {
                                                    mb.TriangleIndices.Add(count);
                                                    mb.TriangleIndices.Add(count + j + 1);
                                                    mb.TriangleIndices.Add(count + j + 2);
                                                }
                                                break;
                                        }
                                    }

                                    //mb.ComputeNormalsAndTangents(MeshFaces.Default);

                                    geometry = mb.ToMeshGeometry3D();
                                }
                                else if (geo is MeshCacheEntry mce)
                                {
                                    var mb = new MeshBuilder();

                                    mb.CreateNormals = true;

                                    var positions = new Vector3Collection();
                                    for (var i = 0; i < mce.Vertices.Count; i++)
                                    {
                                        positions.Add(mce.Vertices[i].ToVector3());
                                    }

                                    foreach (var face in mce.Faces)
                                    {
                                        var points = new List<SharpDX.Vector3>();
                                        foreach (var point in face)
                                        {
                                            points.Add(positions[point]);
                                        }
                                        mb.AddTriangle(points[0], points[1], points[2]);
                                    }

                                    //mb.ComputeNormalsAndTangents(MeshFaces.Default);

                                    geometry = mb.ToMeshGeometry3D();
                                }
                            }

                            if (geometry == null)
                            {
                                continue;
                            }

                            var shapeGroup = new SubmeshComponent()
                            {
                                Name = "shape_" + shape.Hash,
                                IsRendering = true,
                                Geometry = geometry,
                                Material = colliderMaterial,
                                IsTransparent = true
                            };

                            var shapeMatrix = new Matrix3D();
                            shapeMatrix.Rotate(ToQuaternion(shape.Rotation));
                            shapeMatrix.Translate(ToVector3D(shape.Position));

                            shapeGroup.Transform = new MatrixTransform3D(shapeMatrix);

                            actorGroup.Children.Add(shapeGroup);
                        }

                        var matrix = new Matrix3D();
                        matrix.Scale(ToScaleVector3D(actor.Scale));
                        matrix.Rotate(ToQuaternion(actor.Orientation));
                        matrix.Translate(ToVector3D(actor.Position));

                        actorGroup.Transform = new MatrixTransform3D(matrix);

                        mesh.Children.Add(actorGroup);
                    }

                    // not used?
                    //var meshMatrix = new Matrix3D();
                    //meshMatrix.Scale(ToScaleVector3D(transforms[0].Scale));
                    //meshMatrix.Rotate(ToQuaternion(transforms[0].Orientation));
                    //meshMatrix.Translate(ToVector3D(transforms[0].Position));

                    //mesh.Transform = new MatrixTransform3D(meshMatrix);
                    groups.Add(mesh);
                }
                else if (handle.Chunk is worldNavigationNode wnm)
                {
                    var navmeshFile = File.GetFileFromDepotPathOrCache(wnm.NavigationTileResource.DepotPath);

                    if (navmeshFile.RootChunk is not worldNavigationTileResource wntr)
                    {
                        continue;
                    }

                    foreach (var tile in wntr.TilesData)
                    {
                        if (tile.TilesBuffer.Data is not TilesBuffer tb)
                        {
                            continue;
                        }

                        var positions = new Vector3Collection();

                        foreach (var v in tb.Vertices)
                        {
                            positions.Add(new SharpDX.Vector3(v.X, v.Y, -v.Z));
                        }

                        var mb = new MeshBuilder();

                        foreach (var f in tb.FaceInfo)
                        {
                            if (f.NumIndices == 3)
                            {
                                mb.AddTriangle(positions[f.Indices[0]], positions[f.Indices[2]], positions[f.Indices[1]]);
                            }
                            else if (f.NumIndices == 2)
                            {
                                mb.AddPipe(positions[f.Indices[0]], positions[f.Indices[1]], 0, 0.1, 16);
                            }
                        }

                        mb.ComputeNormalsAndTangents(MeshFaces.Default);

                        var material = SetupPBRMaterial("DefaultMaterial");
                        material.AlbedoColor = new SharpDX.Color4(1f, 1f, 1f, 0.5f);
                        //material.AlbedoColor = new SharpDX.Color4(.5f, .5f, .5f, 1.0f);

                        var mesh = new MeshGeometryModel3D()
                        {
                            Geometry = mb.ToMeshGeometry3D(),
                            Material = material,
                            IsTransparent = true
                            //Transform = new TranslateTransform3D(tile.TileX * 100, 0, tile.TileY * 100)
                        };

                        var group = new MeshComponent()
                        {
                            Name = name
                        };

                        group.Children.Add(mesh);

                        groups.Add(group);
                    }
                }
                else if (handle.Chunk is worldEntityNode wen)
                {
                    //a little slow for what we want to do
                    // <3

                    try
                    {

                        var entFile = File.GetFileFromDepotPathOrCache(wen.EntityTemplate.DepotPath);

                        if (entFile != null && entFile.RootChunk is entEntityTemplate eet)
                        {
                            var entity = RenderEntity(eet, app);
                            if (entity != null)
                            {
                                entity.Name = "Entity";
                                //var f = Shell.ChunkViewModel.FixRotation;

                                var q = new System.Numerics.Quaternion()
                                {
                                    W = transforms[0].Orientation.R,
                                    X = transforms[0].Orientation.I,
                                    Y = transforms[0].Orientation.J,
                                    Z = transforms[0].Orientation.K
                                };

                                //q = Shell.ChunkViewModel.FixRotation(q);
                                var qq = new System.Windows.Media.Media3D.Quaternion(q.X, q.Y, q.Z, q.W);

                                var matrix = new Matrix3D();
                                matrix.Scale(ToScaleVector3D(transforms[0].Scale));
                                matrix.Rotate(qq);
                                matrix.Translate(ToVector3D(transforms[0].Position));

                                entity.Transform = new MatrixTransform3D(matrix);

                                groups.Add(entity);
                            }
                        }
                    }
                    catch (Exception ex){Locator.Current.GetService<ILoggerService>().Error(ex);}
                }
                else if (handle.Chunk is worldPopulationSpawnerNode wpsn)
                {
                    //var tdb = Locator.Current.GetService<TweakDBService>();
                    //var record = tdb.GetRecord(wpsn.ObjectRecordId);

                    //if (record is gamedataVehicle_Record vehicle)
                    //{
                    //    var entFile = File.GetFileFromDepotPathOrCache(vehicle.EntityTemplatePath.DepotPath);

                    //    if (entFile != null && entFile.RootChunk is entEntityTemplate eet)
                    //    {
                    //        var entity = RenderEntity(eet, app);
                    //        if (entity != null)
                    //        {
                    //            entity.Name = "Entity";

                    //            var matrix = new Matrix3D();
                    //            matrix.Scale(ToScaleVector3D(transforms[0].Scale));
                    //            matrix.Rotate(ToQuaternion(transforms[0].Orientation));
                    //            matrix.Translate(ToVector3D(transforms[0].Position));

                    //            entity.Transform = new MatrixTransform3D(matrix);

                    //            groups.Add(entity);
                    //        }
                    //    }
                    //}
                }
                else if (handle.Chunk is worldAreaShapeNode wasn)
                {
                    var shape = wasn.Outline.Chunk;
                    var mb = new MeshBuilder();

                    var center = new SharpDX.Vector3();

                    foreach (var point in shape.Points)
                    {
                        center.X += (point.X / shape.Points.Count);
                        center.Y += (point.Z / shape.Points.Count);
                        center.Z += (-point.Y / shape.Points.Count);
                    }

                    mb.AddBox(center, Math.Abs(shape.Points[0].X) * 2, shape.Height, Math.Abs(shape.Points[0].Y) * 2);
                    mb.ComputeNormalsAndTangents(MeshFaces.Default);

                    var material = SetupPBRMaterial("DefaultMaterial");
                    material.AlbedoColor = new SharpDX.Color4(1f, 1f, 1f, 0.1f);

                    var mesh = new MeshGeometryModel3D()
                    {
                        Geometry = mb.ToMeshGeometry3D(),
                        Material = material,
                        IsTransparent = true
                    };

                    var matrix = new Matrix3D();
                    matrix.Scale(ToScaleVector3D(transforms[0].Scale));
                    matrix.Rotate(ToQuaternion(transforms[0].Orientation));
                    matrix.Translate(ToVector3D(transforms[0].Position));

                    var group = new MeshComponent()
                    {
                        Name = name,
                        Transform = new MatrixTransform3D(matrix)
                    };

                    group.Children.Add(mesh);

                    groups.Add(group);

                }
            }

            var element = new SectorGroup()
            {

            };
            foreach (var group in groups)
            {
                element.Children.Add(group);
            }
            app.ModelGroup.Add(element);
            return element;
        }

        public static SharpDX.Vector3 ToVector3(Vector3 v)
        {
            return new SharpDX.Vector3(v.X, v.Y, v.Z);
        }
    }

    public class SectorGroup : GroupModel3D
    {
        public string MaterialName { get; set; }
        public string AppearanceName { get; set; }
    }

}
