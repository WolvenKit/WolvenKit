using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Oodle;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using SharpGLTF.Schema2;
using WolvenKit.Common.Services;
using CP77.CR2W;
using WolvenKit.Common.FNV1A;
using WolvenKit.Modkit.RED4.RigFile;

namespace WolvenKit.Modkit.RED4
{
    using Vec4 = System.Numerics.Vector4;
    using Vec3 = System.Numerics.Vector3;
    public partial class ModTools
    {
        public bool ExportMorphTargets(Stream targetStream, FileInfo outfile,List<Archive> archives, string modFolder, bool isGLBinary = true)
        {
            var cr2w = _wolvenkitFileService.TryReadRED4File(targetStream);
            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<MorphTargetMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            RawArmature Rig = null;
            MemoryStream meshbuffer = MeshTools.GetMeshBufferStream(targetStream, cr2w);
            MeshesInfo meshinfo = MeshTools.GetMeshesinfo(cr2w);
            List<RawMeshContainer> expMeshes = MeshTools.ContainRawMesh(meshbuffer, meshinfo, true);
            int subMeshC = expMeshes.Count;

            var buffers = cr2w.Buffers;
            var blob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMorphTargetMeshBlob>().First();
            string baseMeshPath = cr2w.Chunks.Select(_ => _.Data).OfType<MorphTargetMesh>().First().BaseMesh.DepotPath;
            ulong hash = FNV1A64HashAlgorithm.HashString(baseMeshPath);

            MemoryStream meshStream = new MemoryStream();
            if(File.Exists(Path.Combine(modFolder,baseMeshPath)))
            {
                meshStream = new MemoryStream(File.ReadAllBytes(Path.Combine(modFolder, baseMeshPath)));
            }
            else
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
            {
                var meshCr2w = _wolvenkitFileService.TryReadRED4File(meshStream);

                if (meshCr2w != null && meshCr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any() && meshCr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
                {
                    MeshTools.MeshBones meshBones = new MeshTools.MeshBones();
                    meshBones.boneCount = meshCr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First().BoneNames.Count;
                    if (meshBones.boneCount != 0)    // for rigid meshes
                    {
                        meshBones.Names = RIG.GetboneNames(meshCr2w);
                        meshBones.WorldPosn = MeshTools.GetMeshBonesPosn(meshCr2w);
                    }

                    Rig = MeshTools.GetNonParentedRig(meshBones);

                    MemoryStream ms = MeshTools.GetMeshBufferStream(meshStream, meshCr2w);
                    meshinfo = MeshTools.GetMeshesinfo(meshCr2w);
                    expMeshes = MeshTools.ContainRawMesh(ms, meshinfo, true);
                    subMeshC = expMeshes.Count;
                    if (meshBones.boneCount == 0)    // for rigid meshes
                    {
                        for (int i = 0; i < expMeshes.Count; i++)
                            expMeshes[i].weightcount = 0;
                    }
                    MeshTools.UpdateMeshJoints(ref expMeshes, Rig, meshBones);
                }
            }
            MemoryStream diffsbuffer = new MemoryStream();
            MemoryStream mappingbuffer = new MemoryStream();
            MemoryStream texbuffer = new MemoryStream();

            if(blob.DiffsBuffer.IsSerialized)
            {
                targetStream.Seek(cr2w.Buffers[blob.DiffsBuffer.Buffer.Value - 1].Offset, SeekOrigin.Begin);
                targetStream.DecompressAndCopySegment(diffsbuffer, buffers[blob.DiffsBuffer.Buffer.Value - 1].DiskSize, buffers[blob.DiffsBuffer.Buffer.Value - 1].MemSize);
            }

            if(blob.MappingBuffer.IsSerialized)
            {
                targetStream.Seek(cr2w.Buffers[blob.MappingBuffer.Buffer.Value - 1].Offset, SeekOrigin.Begin);
                targetStream.DecompressAndCopySegment(mappingbuffer, buffers[blob.MappingBuffer.Buffer.Value - 1].DiskSize, buffers[blob.MappingBuffer.Buffer.Value - 1].MemSize);
            }

            if(blob.TextureDiffsBuffer.IsSerialized)
            {
                targetStream.Seek(cr2w.Buffers[blob.TextureDiffsBuffer.Buffer.Value - 1].Offset, SeekOrigin.Begin);
                targetStream.DecompressAndCopySegment(texbuffer, buffers[blob.TextureDiffsBuffer.Buffer.Value - 1].DiskSize, buffers[blob.TextureDiffsBuffer.Buffer.Value - 1].MemSize);
            }

            TargetsInfo targetsInfo = GetTargetInfos(cr2w, subMeshC);

            List<RawTargetContainer[]> expTargets = new List<RawTargetContainer[]>();

            for (int i = 0; i < targetsInfo.NumTargets; i++)
            {
                UInt32[] temp_NumVertexDiffsInEachChunk = new UInt32[subMeshC];
                UInt32[] temp_NumVertexDiffsMappingInEachChunk = new UInt32[subMeshC];
                for (int e = 0; e < subMeshC; e++)
                {
                    temp_NumVertexDiffsInEachChunk[e] = targetsInfo.NumVertexDiffsInEachChunk[i, e];
                    temp_NumVertexDiffsMappingInEachChunk[e] = targetsInfo.NumVertexDiffsMappingInEachChunk[i, e];
                }
                expTargets.Add(ContainRawTargets(diffsbuffer, mappingbuffer, temp_NumVertexDiffsInEachChunk, temp_NumVertexDiffsMappingInEachChunk, targetsInfo.TargetStartsInVertexDiffs[i], targetsInfo.TargetStartsInVertexDiffsMapping[i], targetsInfo.TargetPositionDiffOffset[i], targetsInfo.TargetPositionDiffScale[i], subMeshC));
            }

            string[] names = new string[targetsInfo.NumTargets];
            for (int i = 0; i < targetsInfo.NumTargets; i++)
            {
                names[i] = targetsInfo.Names[i] + "_" + targetsInfo.RegionNames[i];
            }

            List<MemoryStream> textureStreams = ContainTextureStreams(blob, texbuffer);
            ModelRoot model = RawTargetsToGLTF(expMeshes, expTargets, names,Rig);

            if (WolvenTesting.IsTesting)
            {
                return true;
            }
            model.Extras = SharpGLTF.IO.JsonContent.Serialize(new { BaseMesh = targetsInfo.BaseMesh});
            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            var dir = new DirectoryInfo(outfile.FullName.Replace(Path.GetExtension(outfile.FullName), string.Empty) + "_Textures");

            if (textureStreams.Count > 0)
            {
                Directory.CreateDirectory(dir.FullName);
            }

            for (int i = 0; i < textureStreams.Count; i++)
            {
                File.WriteAllBytes(dir.FullName + "\\" + Path.GetFileNameWithoutExtension(outfile.FullName) + i + ".dds", textureStreams[i].ToArray());
            }

            targetStream.Dispose();
            targetStream.Close();

            return true;
        }
        static TargetsInfo GetTargetInfos(CR2WFile cr2w, int SubMeshC)
        {
            var rendMorphBlob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMorphTargetMeshBlob>().First();

            UInt32 NumTargets = rendMorphBlob.Header.NumTargets.Value;

            UInt32[,] NumVertexDiffsInEachChunk = new UInt32[NumTargets, SubMeshC];
            UInt32 NumDiffs = rendMorphBlob.Header.NumDiffs.Value;
            UInt32 NumDiffsMapping = rendMorphBlob.Header.NumDiffsMapping.Value;
            UInt32[,] NumVertexDiffsMappingInEachChunk = new UInt32[NumTargets, SubMeshC];
            UInt32[] TargetStartsInVertexDiffs = new UInt32[NumTargets];
            UInt32[] TargetStartsInVertexDiffsMapping = new UInt32[NumTargets];
            Vec4[] TargetPositionDiffOffset = new Vec4[NumTargets];
            Vec4[] TargetPositionDiffScale = new Vec4[NumTargets];
            for (int i = 0; i < NumTargets; i++)
            {
                for (int e = 0; e < SubMeshC; e++)
                {
                    NumVertexDiffsInEachChunk[i, e] = rendMorphBlob.Header.NumVertexDiffsInEachChunk[i][e].Value;
                    NumVertexDiffsMappingInEachChunk[i, e] = rendMorphBlob.Header.NumVertexDiffsMappingInEachChunk[i][e].Value;
                }

                TargetStartsInVertexDiffs[i] = rendMorphBlob.Header.TargetStartsInVertexDiffs[i].Value;
                TargetStartsInVertexDiffsMapping[i] = rendMorphBlob.Header.TargetStartsInVertexDiffsMapping[i].Value;


                var o = rendMorphBlob.Header.TargetPositionDiffOffset[i];
                TargetPositionDiffOffset[i] = new Vec4(o.X.Value, o.Y.Value, o.Z.Value, o.W.Value);
                var s = rendMorphBlob.Header.TargetPositionDiffScale[i];
                TargetPositionDiffScale[i] = new Vec4(s.X.Value, s.Y.Value, s.Z.Value, s.W.Value);
            }

            var morphBlob = cr2w.Chunks.Select(_ => _.Data).OfType<MorphTargetMesh>().First();

            string[] Names = new string[NumTargets];
            string[] RegionNames = new string[NumTargets];
            string BaseMesh = morphBlob.BaseMesh.DepotPath;
            string BaseTexture = morphBlob.BaseTexture.DepotPath;

            for (int i = 0; i < NumTargets; i++)
            {
                Names[i] = morphBlob.Targets[i].Name.Value;
                RegionNames[i] = morphBlob.Targets[i].RegionName.Value;
            }

            TargetsInfo targetsInfo = new TargetsInfo()
            {
                NumVertexDiffsInEachChunk = NumVertexDiffsInEachChunk,
                NumDiffs = NumDiffs,
                NumDiffsMapping = NumDiffsMapping,
                NumVertexDiffsMappingInEachChunk = NumVertexDiffsMappingInEachChunk,
                TargetStartsInVertexDiffs = TargetStartsInVertexDiffs,
                TargetStartsInVertexDiffsMapping = TargetStartsInVertexDiffsMapping,
                TargetPositionDiffOffset = TargetPositionDiffOffset,
                TargetPositionDiffScale = TargetPositionDiffScale,
                Names = Names,
                RegionNames = RegionNames,
                NumTargets = NumTargets,
                BaseMesh = BaseMesh,
                BaseTexture = BaseTexture,
            };

            return targetsInfo;
        }
        static RawTargetContainer[] ContainRawTargets(MemoryStream diffsbuffer, MemoryStream mappingbuffer, UInt32[] NumVertexDiffsInEachChunk, UInt32[] NumVertexDiffsMappingInEachChunk, UInt32 TargetStartsInVertexDiffs, UInt32 TargetStartsInVertexDiffsMapping, Vec4 TargetPositionDiffOffset, Vec4 TargetPositionDiffScale, int SubMeshC)
        {
            RawTargetContainer[] rawtarget = new RawTargetContainer[SubMeshC];

            BinaryReader diffsbr = new BinaryReader(diffsbuffer);
            BinaryReader mappingbr = new BinaryReader(mappingbuffer);

            for (int i = 0; i < SubMeshC; i++)
            {
                UInt32 diffsCount = NumVertexDiffsInEachChunk[i];
                Vec3[] vertexDelta = new Vec3[diffsCount];
                Vec3[] normalDelta = new Vec3[diffsCount];
                Vec3[] tangentDelta = new Vec3[diffsCount];

                if (i == 0)
                    diffsbuffer.Position = TargetStartsInVertexDiffs * 12;
                else
                {
                    diffsbuffer.Position = TargetStartsInVertexDiffs * 12;

                    for (int eye = 0; eye < i; eye++)
                    {
                        diffsbuffer.Position += NumVertexDiffsInEachChunk[eye] * 12;
                    }
                }


                for (int e = 0; e < diffsCount; e++)
                {
                    Vec4 v = Converters.TenBitUnsigned(diffsbr.ReadUInt32());
                    vertexDelta[e] = new Vec3((v.X * TargetPositionDiffScale.X + TargetPositionDiffOffset.X), (v.Z * TargetPositionDiffScale.Z + TargetPositionDiffOffset.Z), -(v.Y * TargetPositionDiffScale.Y + TargetPositionDiffOffset.Y));
                    Vec4 n = Converters.TenBitShifted(diffsbr.ReadUInt32());
                    normalDelta[e] = new Vec3(n.X, n.Z, -n.Y);
                    Vec4 t = Converters.TenBitShifted(diffsbr.ReadUInt32());
                    tangentDelta[e] = new Vec3(t.X, t.Z, -t.Y);
                }

                UInt16[] vertexMapping = new UInt16[diffsCount];

                if (i == 0)
                    mappingbuffer.Position = TargetStartsInVertexDiffsMapping * 4;
                else
                {
                    mappingbuffer.Position = TargetStartsInVertexDiffsMapping * 4;

                    for (int eye = 0; eye < i; eye++)
                    {
                        mappingbuffer.Position += NumVertexDiffsMappingInEachChunk[eye] * 4;
                    }
                }

                for (int e = 0; e < diffsCount; e++)
                {
                    vertexMapping[e] = mappingbr.ReadUInt16();
                }

                rawtarget[i] = new RawTargetContainer()
                {
                    vertexDelta = vertexDelta,
                    normalDelta = normalDelta,
                    tangentDelta = tangentDelta,
                    vertexMapping = vertexMapping,
                    diffsCount = diffsCount
                };
            }

            return rawtarget;
        }
        static List<MemoryStream> ContainTextureStreams(rendRenderMorphTargetMeshBlob blob, MemoryStream texbuffer)
        {
            List<MemoryStream> textureStreams = new List<MemoryStream>();

            int Count = blob.Header.TargetTextureDiffsData.Count;
            int texCount = 0;
            List<UInt32> TargetDiffsDataOffset = new List<UInt32>();
            List<UInt32> TargetDiffsDataSize = new List<UInt32>();
            List<UInt32> TargetDiffsMipLevelCounts = new List<UInt32>();
            List<UInt32> TargetDiffsWidth = new List<UInt32>();

            for (int i = 0; i < Count; i++)
            {
                if (blob.Header.TargetTextureDiffsData[i].TargetDiffsDataSize.Count == 0)
                    break;
                TargetDiffsDataOffset.Add(blob.Header.TargetTextureDiffsData[i].TargetDiffsDataOffset[0].Value);
                TargetDiffsDataSize.Add(blob.Header.TargetTextureDiffsData[i].TargetDiffsDataSize[0].Value);
                TargetDiffsMipLevelCounts.Add(blob.Header.TargetTextureDiffsData[i].TargetDiffsMipLevelCounts[0].Value);
                TargetDiffsWidth.Add(blob.Header.TargetTextureDiffsData[i].TargetDiffsWidth[0].Value);
                texCount++;
            }

            BinaryReader texbr = new BinaryReader(texbuffer);
            for (int i = 0; i < texCount; i++)
            {
                texbuffer.Position = TargetDiffsDataOffset[i];
                byte[] bytes = texbr.ReadBytes((int)TargetDiffsDataSize[i]);

                MemoryStream ms = new MemoryStream();
                DDSMetadata metadata = new DDSMetadata(
                    TargetDiffsWidth[i], TargetDiffsWidth[i],
                    1, 1, TargetDiffsMipLevelCounts[i], 0,0, EFormat.BC7_UNORM, TEX_DIMENSION.TEX_DIMENSION_TEXTURE2D, 16, true);
                DDSUtils.GenerateAndWriteHeader(ms, metadata);
                BinaryWriter bw = new BinaryWriter(ms);
                bw.Write(bytes);
                textureStreams.Add(ms);
            }

            return textureStreams;
        }
        static ModelRoot RawTargetsToGLTF(List<RawMeshContainer> meshes, List<RawTargetContainer[]> expTargets, string[] names, RawArmature Rig)
        {
            var model = ModelRoot.CreateModel();
            var mat = model.CreateMaterial("Default");
            mat.WithPBRMetallicRoughness().WithDefault();
            mat.DoubleSided = true;
            List<Skin> skins = new List<Skin>();
            if (Rig != null)
            {
                var skin = model.CreateSkin();
                skin.BindJoints(RIG.ExportNodes(ref model, Rig).Values.ToArray());
                skins.Add(skin);
            }

            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);
            int mIndex = -1;
            foreach (var mesh in meshes)
            {
                ++mIndex;
                for (int i = 0; i < mesh.vertices.Length; i++)
                {
                    bw.Write(mesh.vertices[i].X);
                    bw.Write(mesh.vertices[i].Y);
                    bw.Write(mesh.vertices[i].Z);
                }
                for (int i = 0; i < mesh.normals.Length; i++)
                {
                    bw.Write(mesh.normals[i].X);
                    bw.Write(mesh.normals[i].Y);
                    bw.Write(mesh.normals[i].Z);
                }
                for (int i = 0; i < mesh.tangents.Length; i++)
                {
                    bw.Write(mesh.tangents[i].X);
                    bw.Write(mesh.tangents[i].Y);
                    bw.Write(mesh.tangents[i].Z);
                    bw.Write(mesh.tangents[i].W);
                }
                for (int i = 0; i < mesh.colors0.Length; i++)
                {
                    bw.Write(mesh.colors0[i].X);
                    bw.Write(mesh.colors0[i].Y);
                    bw.Write(mesh.colors0[i].Z);
                    bw.Write(mesh.colors0[i].W);
                }
                for (int i = 0; i < mesh.colors1.Length; i++)
                {
                    bw.Write(mesh.colors1[i].X);
                    bw.Write(mesh.colors1[i].Y);
                    bw.Write(mesh.colors1[i].Z);
                    bw.Write(mesh.colors1[i].W);
                }
                for (int i = 0; i < mesh.tx0coords.Length; i++)
                {
                    bw.Write(mesh.tx0coords[i].X);
                    bw.Write(mesh.tx0coords[i].Y);
                }
                for (int i = 0; i < mesh.tx1coords.Length; i++)
                {
                    bw.Write(mesh.tx1coords[i].X);
                    bw.Write(mesh.tx1coords[i].Y);
                }

                if (mesh.weightcount > 0)
                {
                    if (Rig != null)
                    {
                        for (int i = 0; i < mesh.vertices.Length; i++)
                        {
                            bw.Write(mesh.boneindices[i, 0]);
                            bw.Write(mesh.boneindices[i, 1]);
                            bw.Write(mesh.boneindices[i, 2]);
                            bw.Write(mesh.boneindices[i, 3]);
                        }
                        for (int i = 0; i < mesh.vertices.Length; i++)
                        {
                            bw.Write(mesh.weights[i, 0]);
                            bw.Write(mesh.weights[i, 1]);
                            bw.Write(mesh.weights[i, 2]);
                            bw.Write(mesh.weights[i, 3]);
                        }
                        if (mesh.weightcount > 4)
                        {
                            for (int i = 0; i < mesh.vertices.Length; i++)
                            {
                                bw.Write(mesh.boneindices[i, 4]);
                                bw.Write(mesh.boneindices[i, 5]);
                                bw.Write(mesh.boneindices[i, 6]);
                                bw.Write(mesh.boneindices[i, 7]);
                            }
                            for (int i = 0; i < mesh.vertices.Length; i++)
                            {
                                bw.Write(mesh.weights[i, 4]);
                                bw.Write(mesh.weights[i, 5]);
                                bw.Write(mesh.weights[i, 6]);
                                bw.Write(mesh.weights[i, 7]);
                            }
                        }
                    }
                }
                for (int i = 0; i < mesh.indices.Length; i += 3)
                {
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 1]));
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 0]));
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 2]));
                }
                for (int i = 0; i < expTargets.Count; i++)
                {
                    var mappings = expTargets[i][mIndex].vertexMapping.ToList();
                    for (ushort e = 0; e < mesh.vertices.Length; e++)
                    {
                        if(mappings.Contains(e))
                        {
                            int idx = mappings.IndexOf(e);
                            bw.Write(expTargets[i][mIndex].vertexDelta[idx].X);
                            bw.Write(expTargets[i][mIndex].vertexDelta[idx].Y);
                            bw.Write(expTargets[i][mIndex].vertexDelta[idx].Z);
                        }
                        else
                        {
                            bw.Write(0f);
                            bw.Write(0f);
                            bw.Write(0f);
                        }
                    }
                    for (ushort e = 0; e < mesh.normals.Length; e++)
                    {
                        if (mappings.Contains(e))
                        {
                            int idx = mappings.IndexOf(e);
                            bw.Write(expTargets[i][mIndex].normalDelta[idx].X);
                            bw.Write(expTargets[i][mIndex].normalDelta[idx].Y);
                            bw.Write(expTargets[i][mIndex].normalDelta[idx].Z);
                        }
                        else
                        {
                            bw.Write(0f);
                            bw.Write(0f);
                            bw.Write(0f);
                        }
                    }
                    for (ushort e = 0; e < mesh.tangents.Length; e++)
                    {
                        if (mappings.Contains(e))
                        {
                            int idx = mappings.IndexOf(e);
                            bw.Write(expTargets[i][mIndex].tangentDelta[idx].X);
                            bw.Write(expTargets[i][mIndex].tangentDelta[idx].Y);
                            bw.Write(expTargets[i][mIndex].tangentDelta[idx].Z);
                        }
                        else
                        {
                            bw.Write(0f);
                            bw.Write(0f);
                            bw.Write(0f);
                        }
                    }
                }
            }
            var buffer = model.UseBuffer(ms.ToArray());
            int BuffViewoffset = 0;

            foreach (var mesh in meshes)
            {
                var mes = model.CreateMesh(mesh.name);
                var prim = mes.CreatePrimitive();
                prim.Material = mat;
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.vertices.Length * 12);
                    acc.SetData(buff, 0, mesh.vertices.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("POSITION", acc);
                    BuffViewoffset += mesh.vertices.Length * 12;
                }
                if (mesh.normals.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.normals.Length * 12);
                    acc.SetData(buff, 0, mesh.normals.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("NORMAL", acc);
                    BuffViewoffset += mesh.normals.Length * 12;
                }
                if (mesh.tangents.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.tangents.Length * 16);
                    acc.SetData(buff, 0, mesh.tangents.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TANGENT", acc);
                    BuffViewoffset += mesh.tangents.Length * 16;
                }
                if (mesh.colors0.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.colors0.Length * 16);
                    acc.SetData(buff, 0, mesh.colors0.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("COLOR_0", acc);
                    BuffViewoffset += mesh.colors0.Length * 16;
                }
                if (mesh.colors1.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.colors1.Length * 16);
                    acc.SetData(buff, 0, mesh.colors1.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("COLOR_1", acc);
                    BuffViewoffset += mesh.colors1.Length * 16;
                }
                if (mesh.tx0coords.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.tx0coords.Length * 8);
                    acc.SetData(buff, 0, mesh.tx0coords.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_0", acc);
                    BuffViewoffset += mesh.tx0coords.Length * 8;
                }
                if (mesh.tx1coords.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.tx1coords.Length * 8);
                    acc.SetData(buff, 0, mesh.tx1coords.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_1", acc);
                    BuffViewoffset += mesh.tx1coords.Length * 8;
                }
                if (mesh.weightcount > 0)
                {
                    if (Rig != null)
                    {
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.vertices.Length * 8);
                            acc.SetData(buff, 0, mesh.vertices.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                            prim.SetVertexAccessor("JOINTS_0", acc);
                            BuffViewoffset += mesh.vertices.Length * 8;
                        }
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.vertices.Length * 16);
                            acc.SetData(buff, 0, mesh.vertices.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                            prim.SetVertexAccessor("WEIGHTS_0", acc);
                            BuffViewoffset += mesh.vertices.Length * 16;
                        }
                        if (mesh.weightcount > 4)
                        {
                            {
                                var acc = model.CreateAccessor();
                                var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.vertices.Length * 8);
                                acc.SetData(buff, 0, mesh.vertices.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                                prim.SetVertexAccessor("JOINTS_1", acc);
                                BuffViewoffset += mesh.vertices.Length * 8;
                            }
                            {
                                var acc = model.CreateAccessor();
                                var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.vertices.Length * 16);
                                acc.SetData(buff, 0, mesh.vertices.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                                prim.SetVertexAccessor("WEIGHTS_1", acc);
                                BuffViewoffset += mesh.vertices.Length * 16;
                            }
                        }
                    }
                }
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.indices.Length * 2);
                    acc.SetData(buff, 0, mesh.indices.Length, DimensionType.SCALAR, EncodingType.UNSIGNED_SHORT, false);
                    prim.SetIndexAccessor(acc);
                    BuffViewoffset += mesh.indices.Length * 2;
                }
                var nod = model.UseScene(0).CreateNode(mesh.name);
                nod.Mesh = mes;
                if (Rig != null && mesh.weightcount > 0)
                    nod.Skin = skins[0];

                var obj = new { targetNames = names }; // anonymous variable/obj
                mes.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);

                for (int i = 0; i < expTargets.Count; i++)
                {
                    var dict = new Dictionary<string, Accessor>();
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.vertices.Length * 12);
                        acc.SetData(buff, 0, mesh.vertices.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                        dict.Add("POSITION", acc);
                        BuffViewoffset += mesh.vertices.Length * 12;
                    }
                    if(mesh.normals.Length > 0)
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.normals.Length * 12);
                        acc.SetData(buff, 0, mesh.normals.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                        dict.Add("NORMAL", acc);
                        BuffViewoffset += mesh.normals.Length * 12;
                    }
                    if (mesh.tangents.Length > 0)
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.tangents.Length * 12);
                        acc.SetData(buff, 0, mesh.tangents.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                        dict.Add("TANGENT", acc);
                        BuffViewoffset += mesh.tangents.Length * 12;
                    }
                    prim.SetMorphTargetAccessors(i, dict);
                }
            }
            model.UseScene(0).Name = "Scene";
            model.DefaultScene = model.UseScene(0);
            model.MergeBuffers();
            return model;
        }
    }
}
