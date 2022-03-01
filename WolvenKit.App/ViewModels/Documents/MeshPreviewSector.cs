using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using HelixToolkit.SharpDX.Core;
using HelixToolkit.Wpf.SharpDX;
using ReactiveUI;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

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
            var ssTransforms = ((StreamingSectorBuffer)data.Transforms.Data).Transforms;

            var groups = new List<Element3D>();
            foreach (var (handleIndex, transforms) in ssTransforms)
            {
                var handle = data.Handles[handleIndex];
                var name = (string)handle.Chunk.DebugName;
                name = "_"+name?.Replace("{", "").Replace("}", "").Replace("\\", "_").Replace(".", "_").Replace("!", "").Replace("-", "_") ?? "none";

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
                            if (wtbTransforms[(int)(wimn.WorldTransformsBuffer.StartIndex + i)] is WorldTransformExt wte)
                            {
                                wtbMatrix.Scale(ToScaleVector3D(wte.Scale));
                            }
                            wtbMatrix.Rotate(ToQuaternion(wtbTransforms[(int)(wimn.WorldTransformsBuffer.StartIndex + i)].Orientation));
                            wtbMatrix.Translate(ToVector3D(wtbTransforms[(int)(wimn.WorldTransformsBuffer.StartIndex + i)].Position));

                            matrix.Append(wtbMatrix);

                            subgroup.Transform = new MatrixTransform3D(matrix);

                            group.Children.Add(subgroup);
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

                        foreach(var v in tb.Vertices)
                        {
                            positions.Add(ToVector3(v));
                        }

                        var mb = new MeshBuilder();

                        foreach (var f in tb.FaceInfo)
                        {
                            mb.AddTriangle(positions[f.Indices[0]], positions[f.Indices[1]], positions[f.Indices[2]]); 
                        }

                        mb.ComputeNormalsAndTangents(MeshFaces.Default);

                        var material = SetupPBRMaterial("DefaultMaterial");
                        material.AlbedoColor = new SharpDX.Color4(1f, 1f, 1f, 0.1f);

                        var mesh = new MeshGeometryModel3D()
                        {
                            Geometry = mb.ToMeshGeometry3D(),
                            Material = material
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
                    // a little slow for what we want to do
                    //var entFile = File.GetFileFromDepotPathOrCache(wen.EntityTemplate.DepotPath);

                    //if (entFile != null && entFile.RootChunk is entEntityTemplate eet)
                    //{
                    //    var entity = RenderEntity(eet, app);
                    //    if (entity != null)
                    //    {
                    //        entity.Name = "Entity";

                    //        var matrix = new Matrix3D();
                    //        matrix.Scale(ToScaleVector3D(transforms[0].Scale));
                    //        matrix.Rotate(ToQuaternion(transforms[0].Orientation));
                    //        matrix.Translate(ToVector3D(transforms[0].Position));

                    //        entity.Transform = new MatrixTransform3D(matrix);

                    //        groups.Add(entity);
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
