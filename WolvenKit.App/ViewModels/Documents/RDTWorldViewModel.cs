using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using HelixToolkit.Wpf.SharpDX;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public partial class RDTMeshViewModel
    {
        public RDTMeshViewModel(worldStreamingSector data, RedDocumentViewModel file) : this(file)
        {
            Header = "Streaming Sector Preview";
            _data = data;

            foreach (var res in file.Cr2wFile.EmbeddedFiles)
            {
                file.Files.Add(res.FileName, new CR2WFile()
                {
                    RootChunk = res.Content
                });
            }

            var app = new Appearance()
            {
                Name = Path.GetFileNameWithoutExtension(File.ContentId).Replace("-", "_"),
            };

            var ssTransforms = ((StreamingSectorBuffer)data.Transforms.Data).Transforms;

            foreach (var (handleIndex, transforms) in ssTransforms)
            {
                var handle = data.Handles[handleIndex];
                var name = (string)handle.Chunk.DebugName;
                name = name?.Replace("{", "").Replace("}", "") ?? "none";

                if (handle.Chunk is IRedMeshNode irmn)
                {
                    var meshFile = File.GetFileFromDepotPathOrCache(irmn.Mesh.DepotPath);

                    if (meshFile.RootChunk is not CMesh mesh)
                    {
                        continue;
                    }

                    var appMaterials = GetMaterialsForAppearance(mesh, irmn.MeshAppearance);

                    var group = new MeshComponent()
                    {
                        Name = name,
                        AppearanceName = irmn.MeshAppearance
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
                                AppearanceName = wimn.MeshAppearance
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
                            matrix.Scale(ToVector3D(transforms[0].Scale));
                            matrix.Rotate(ToQuaternion(transforms[0].Orientation));
                            matrix.Translate(ToVector3D(transforms[0].Position));

                            var wtbMatrix = new Matrix3D();
                            wtbMatrix.Scale(ToVector3D(wtbTransforms[(int)(wimn.WorldTransformsBuffer.StartIndex + i)].Scale));
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
                                AppearanceName = irmn.MeshAppearance
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
                            matrix.Scale(ToVector3D(transform.Scale));
                            matrix.Rotate(ToQuaternion(transform.Orientation));
                            matrix.Translate(ToVector3D(transform.Position));

                            if (irmn is worldBendedMeshNode wbmn)
                            {
                                matrix.Append(ToMatrix3D(wbmn.DeformationData[i]));
                            }

                            subgroup.Transform = new MatrixTransform3D(matrix);

                            group.Children.Add(subgroup);
                            i++;
                        }
                    }

                    app.ModelGroup.Add(group);
                }
            }

            Appearances.Add(app);
            SelectedAppearance = app;
        }
    }
}
