using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using WolvenKit.Modkit.RED4.GeneralStructs;
using SharpGLTF.Schema2;
using SharpGLTF.IO;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.RED4.CR2W;
using CP77.CR2W;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.Modkit.RED4
{
    using Vec4 = System.Numerics.Vector4;
    using Vec2 = System.Numerics.Vector2;
    using Vec3 = System.Numerics.Vector3;
    public partial class ModTools
    {
        public bool ImportTargetBaseMesh(FileInfo inGltfFile, Stream intargetStream, List<Archive> archives, string modFolder, Stream outStream = null)
        {
            var cr2w = _wolvenkitFileService.TryReadRED4File(intargetStream);
            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<MorphTargetMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            var blob = cr2w.Chunks.Select(_ => _.Data).OfType<MorphTargetMesh>().First();

            string baseMeshPath = blob.BaseMesh.DepotPath;
            ulong hash = FNV1A64HashAlgorithm.HashString(baseMeshPath);
            baseMeshPath = Path.Combine(modFolder, baseMeshPath);
            if (!new FileInfo(baseMeshPath).Directory.Exists)
            {
                Directory.CreateDirectory(new FileInfo(baseMeshPath).Directory.FullName);
            }
            FileStream meshStream = new FileStream(baseMeshPath, FileMode.OpenOrCreate,FileAccess.ReadWrite);
            meshStream.Seek(0, SeekOrigin.Begin);
            if (meshStream.Length == 0)
            {
                foreach (Archive ar in archives)
                {
                    if (ar.Files.ContainsKey(hash))
                    {
                        ExtractSingleToStream(ar, hash, meshStream);
                        break;
                    }
                }
            }
            
            var renderblob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMorphTargetMeshBlob>().First();
            for (int i = 0; i < renderblob.Header.TargetPositionDiffOffset.Count; i++)
            {
                renderblob.Header.TargetPositionDiffOffset[i].X.Value = 0f;
                renderblob.Header.TargetPositionDiffOffset[i].Y.Value = 0f;
                renderblob.Header.TargetPositionDiffOffset[i].Z.Value = 0f;
            }
            for (int i = 0; i < renderblob.Header.TargetPositionDiffScale.Count; i++)
            {
                renderblob.Header.TargetPositionDiffScale[i].X.Value = 0f;
                renderblob.Header.TargetPositionDiffScale[i].Y.Value = 0f;
                renderblob.Header.TargetPositionDiffScale[i].Z.Value = 0f;
            }
            
            for (int i = 0; i < renderblob.Header.TargetTextureDiffsData.Count; i++)
            {
                renderblob.Header.TargetTextureDiffsData[i] = new rendRenderMorphTargetMeshBlobTextureData(cr2w, renderblob.Header.TargetTextureDiffsData, Convert.ToString(i));
            }
            
            
            var model = ModelRoot.Load(inGltfFile.FullName);

            VerifyGLTF(model);
            List<RawMeshContainer> Meshes = new List<RawMeshContainer>();

            for (int i = 0; i < model.LogicalMeshes.Count; i++)
            {
                Meshes.Add(GltfMeshToRawContainer(model.LogicalMeshes[i]));
            }
            Vec3 max = new Vec3(Meshes[0].vertices[0].X, Meshes[0].vertices[0].Y, Meshes[0].vertices[0].Z);
            Vec3 min = new Vec3(Meshes[0].vertices[0].X, Meshes[0].vertices[0].Y, Meshes[0].vertices[0].Z);

            for (int e = 0; e < Meshes.Count; e++)
                for (int i = 0; i < Meshes[e].vertices.Length; i++)
                {
                    if (Meshes[e].vertices[i].X >= max.X)
                        max.X = Meshes[e].vertices[i].X;
                    if (Meshes[e].vertices[i].Y >= max.Y)
                        max.Y = Meshes[e].vertices[i].Y;
                    if (Meshes[e].vertices[i].Z >= max.Z)
                        max.Z = Meshes[e].vertices[i].Z;
                    if (Meshes[e].vertices[i].X <= min.X)
                        min.X = Meshes[e].vertices[i].X;
                    if (Meshes[e].vertices[i].Y <= min.Y)
                        min.Y = Meshes[e].vertices[i].Y;
                    if (Meshes[e].vertices[i].Z <= min.Z)
                        min.Z = Meshes[e].vertices[i].Z;
                }


            // updating bounding box

            blob.BoundingBox.Min.X.Value = min.X;
            blob.BoundingBox.Min.Y.Value = min.Y;
            blob.BoundingBox.Min.Z.Value = min.Z;
            blob.BoundingBox.Max.X.Value = max.X;
            blob.BoundingBox.Max.Y.Value = max.Y;
            blob.BoundingBox.Max.Z.Value = max.Z;

            Vec4 QuantScale = new Vec4((max.X - min.X) / 2, (max.Y - min.Y) / 2, (max.Z - min.Z) / 2, 0);
            Vec4 QuantTrans = new Vec4((max.X + min.X) / 2, (max.Y + min.Y) / 2, (max.Z + min.Z) / 2, 1);

            if (model.LogicalSkins.Count != 0)
            {
                string[] bones = new string[model.LogicalSkins[0].JointsCount];

                for (int i = 0; i < model.LogicalSkins[0].JointsCount; i++)
                    bones[i] = model.LogicalSkins[0].GetJoint(i).Joint.Name;

                meshStream.Seek(0, SeekOrigin.Begin);
                string[] meshbones = RIG.GetboneNames(_wolvenkitFileService.TryReadRED4File(meshStream));

                // reset vertex joint indices according to original
                for (int i = 0; i < Meshes.Count; i++)
                    for (int e = 0; e < Meshes[i].vertices.Length; e++)
                        for (int eye = 0; eye < Meshes[i].weightcount; eye++)
                        {
                            if (Meshes[i].weights[e, eye] != 0)
                            {
                                bool existsInMeshBones = false;
                                string name = bones[Meshes[i].boneindices[e, eye]];
                                for (UInt16 t = 0; t < meshbones.Length; t++)
                                {
                                    if (name == meshbones[t])
                                    {
                                        Meshes[i].boneindices[e, eye] = t;
                                        existsInMeshBones = true;
                                    }
                                }
                                if (!existsInMeshBones)
                                {
                                    throw new Exception("One or more vertices in submesh: " + Meshes[i].name + " was weight Painted to bone: " + name + " Which Doesn't Exist in the provided .mesh file");
                                }
                            }
                            else
                            {
                                if (Meshes[i].boneindices[e, eye] > (meshbones.Length - 1))
                                {
                                    Meshes[i].boneindices[e, eye] = 0;
                                }
                            }
                        }

            }

            List<Re4MeshContainer> expMeshes = new List<Re4MeshContainer>();

            for (int i = 0; i < Meshes.Count; i++)
                expMeshes.Add(RawMeshToRE4Mesh(Meshes[i], QuantScale, QuantTrans));

            MemoryStream meshBuffer = new MemoryStream();
            MeshesInfo meshesInfo = BufferWriter(expMeshes, ref meshBuffer);

            meshesInfo.qScale = QuantScale;
            meshesInfo.qTrans = QuantTrans;
            
            MemoryStream ms = GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer);
            
            ms.Seek(0, SeekOrigin.Begin);
            if (outStream != null)
            {
                ms.CopyTo(outStream);
            }
            else
            {
                intargetStream.SetLength(0);
                ms.CopyTo(intargetStream);
            }
            meshStream.Seek(0, SeekOrigin.Begin);
            return ImportMesh(inGltfFile, meshStream);
        }
    }
}
