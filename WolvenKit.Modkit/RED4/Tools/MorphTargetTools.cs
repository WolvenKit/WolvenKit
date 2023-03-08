using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.DependencyModel;
using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using WolvenKit.Common.DDS;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public bool ExportMorphTargets(Stream targetStream, FileInfo outfile, List<ICyberGameArchive> archives, string modFolder, bool isGLBinary = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            var cr2w = _parserService.ReadRed4File(targetStream);
            if (cr2w == null || cr2w.RootChunk is not MorphTargetMesh morphBlob || morphBlob.Blob.Chunk is not rendRenderMorphTargetMeshBlob blob || blob.BaseBlob.Chunk is not rendRenderMeshBlob rendblob)
            {
                _loggerService.Error("Morphtarget: does not look like a valid morphtarget");
                return false;
            }

            RawArmature? Rig = null;

            var hash = morphBlob.BaseMesh.DepotPath.GetRedHash(); //FNV1A64HashAlgorithm.HashString(morphBlob.BaseMesh.DepotPath.ToString().NotNull());
            var meshStream = new MemoryStream();
            foreach (var ar in archives)
            {
                if (ar.Files.TryGetValue(hash, out var gameFile))
                {
                    gameFile.Extract(meshStream);
                    break;
                }
            }
            var meshCr2w = _parserService.ReadRed4File(meshStream);
            if (meshCr2w != null && meshCr2w.RootChunk is CMesh baseMeshBlob && baseMeshBlob.RenderResourceBlob != null && baseMeshBlob.RenderResourceBlob.Chunk is rendRenderMeshBlob)
            {
                Rig = MeshTools.GetOrphanRig(baseMeshBlob);
            }


            using var meshbuffer = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

            var meshesinfo = MeshTools.GetMeshesinfo(rendblob, cr2w.RootChunk as CMesh);

            var expMeshes = MeshTools.ContainRawMesh(meshbuffer, meshesinfo, true);

            var diffsbuffer = (blob.DiffsBuffer is not null) ? new MemoryStream(blob.DiffsBuffer.Buffer.GetBytes()) : new MemoryStream();
            var mappingbuffer = (blob.MappingBuffer is not null) ? new MemoryStream(blob.MappingBuffer.Buffer.GetBytes()) : new MemoryStream();
            var texbuffer = (blob.TextureDiffsBuffer is not null) ? new MemoryStream(blob.TextureDiffsBuffer.Buffer.GetBytes()) : new MemoryStream();

            var targetsInfo = GetTargetInfos(cr2w, expMeshes.Count);

            ArgumentNullException.ThrowIfNull(targetsInfo.NumVertexDiffsInEachChunk);
            ArgumentNullException.ThrowIfNull(targetsInfo.NumVertexDiffsMappingInEachChunk);
            ArgumentNullException.ThrowIfNull(targetsInfo.TargetStartsInVertexDiffs);
            ArgumentNullException.ThrowIfNull(targetsInfo.TargetStartsInVertexDiffsMapping);
            ArgumentNullException.ThrowIfNull(targetsInfo.Names);
            ArgumentNullException.ThrowIfNull(targetsInfo.TargetPositionDiffOffset);
            ArgumentNullException.ThrowIfNull(targetsInfo.TargetPositionDiffScale);

            var expTargets = new List<RawTargetContainer[]>();

            for (var i = 0; i < targetsInfo.NumTargets; i++)
            {
                var temp_NumVertexDiffsInEachChunk = new uint[expMeshes.Count];
                var temp_NumVertexDiffsMappingInEachChunk = new uint[expMeshes.Count];
                for (var e = 0; e < expMeshes.Count; e++)
                {
                    temp_NumVertexDiffsInEachChunk[e] = targetsInfo.NumVertexDiffsInEachChunk[i, e];
                    temp_NumVertexDiffsMappingInEachChunk[e] = targetsInfo.NumVertexDiffsMappingInEachChunk[i, e];
                }
                expTargets.Add(ContainRawTargets(diffsbuffer, mappingbuffer, temp_NumVertexDiffsInEachChunk, temp_NumVertexDiffsMappingInEachChunk, targetsInfo.TargetStartsInVertexDiffs[i], targetsInfo.TargetStartsInVertexDiffsMapping[i], targetsInfo.TargetPositionDiffOffset[i], targetsInfo.TargetPositionDiffScale[i], expMeshes.Count));
            }

            var textureStreams = ContainTextureStreams(blob, texbuffer);
            var model = RawTargetsToGLTF(expMeshes, expTargets, targetsInfo.Names, Rig);

            if (WolvenTesting.IsTesting)
            {
                return true;
            }

            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            var dir = new DirectoryInfo(outfile.FullName.Replace(Path.GetExtension(outfile.FullName), string.Empty) + "_textures");

            if (textureStreams.Count > 0)
            {
                Directory.CreateDirectory(dir.FullName);
            }

            for (var i = 0; i < textureStreams.Count; i++)
            {
                File.WriteAllBytes(Path.Combine(dir.FullName, $"{Path.GetFileNameWithoutExtension(outfile.FullName)}_{i}.dds"), textureStreams[i].ToArray());
            }

            targetStream.Dispose();
            targetStream.Close();

            return true;
        }

        private static TargetsInfo GetTargetInfos(CR2WFile cr2w, int subMeshC)
        {
            var morphBlob = (MorphTargetMesh)cr2w.RootChunk;
            var rendMorphBlob = (rendRenderMorphTargetMeshBlob)morphBlob.Blob.Chunk.NotNull();

            uint NumTargets = rendMorphBlob.Header.NumTargets;
            ArgumentNullException.ThrowIfNull(NumTargets, nameof(NumTargets));

            if (NumTargets < 1)
            {
                var helpMessage =
                    morphBlob.Targets.Count > 0
                        ? $"There are {morphBlob.Targets.Count} targets, but `blob.header.numTargets` is 0. This was probably done intentionally to disable morphing, but you MAY be able to make this a valid .morphtarget by setting `numTargets` to the actual number of targets."
                        : $"`numTargets` is 0 and there are no `targets` defined, this doesn't look like a valid .morphtarget";

                throw new ArgumentOutOfRangeException("blob.header.numTargets", rendMorphBlob.Header.NumTargets, helpMessage);
            }

            var NumVertexDiffsInEachChunk = new uint[NumTargets, subMeshC];
            uint NumDiffs = rendMorphBlob.Header.NumDiffs;
            uint NumDiffsMapping = rendMorphBlob.Header.NumDiffsMapping;
            var NumVertexDiffsMappingInEachChunk = new uint[NumTargets, subMeshC];
            var TargetStartsInVertexDiffs = new uint[NumTargets];
            var TargetStartsInVertexDiffsMapping = new uint[NumTargets];
            var TargetPositionDiffOffset = new Vec4[NumTargets];
            var TargetPositionDiffScale = new Vec4[NumTargets];
            for (var i = 0; i < NumTargets; i++)
            {
                for (var e = 0; e < subMeshC; e++)
                {
                    var diff = rendMorphBlob.Header.NumVertexDiffsInEachChunk[i];
                    ArgumentNullException.ThrowIfNull(diff);

                    NumVertexDiffsInEachChunk[i, e] = diff[e];
                    NumVertexDiffsMappingInEachChunk[i, e] = diff[e];
                }

                TargetStartsInVertexDiffs[i] = rendMorphBlob.Header.TargetStartsInVertexDiffs[i];
                TargetStartsInVertexDiffsMapping[i] = rendMorphBlob.Header.TargetStartsInVertexDiffsMapping[i];


                var o = rendMorphBlob.Header.TargetPositionDiffOffset[i];
                ArgumentNullException.ThrowIfNull(o);
                TargetPositionDiffOffset[i] = new Vec4(o.X, o.Y, o.Z, o.W);

                var s = rendMorphBlob.Header.TargetPositionDiffScale[i];
                ArgumentNullException.ThrowIfNull(s);
                TargetPositionDiffScale[i] = new Vec4(s.X, s.Y, s.Z, s.W);
            }

            var Names = new string[NumTargets];
            var RegionNames = new string[NumTargets];
            string BaseMesh = morphBlob.BaseMesh.DepotPath.ToString().NotNull();
            string BaseTexture = morphBlob.BaseTexture.DepotPath.ToString().NotNull();

            for (var i = 0; i < NumTargets; i++)
            {
                var target = morphBlob.Targets[i];
                ArgumentNullException.ThrowIfNull(target);

                Names[i] = string.Format("{0}_{1}", target.Name, target.RegionName);
                RegionNames[i] = target.RegionName.ToString().NotNull();
            }

            var targetsInfo = new TargetsInfo()
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

        private static RawTargetContainer[] ContainRawTargets(MemoryStream diffsbuffer, MemoryStream mappingbuffer, uint[] numVertexDiffsInEachChunk, uint[] numVertexDiffsMappingInEachChunk, uint targetStartsInVertexDiffs, uint targetStartsInVertexDiffsMapping, Vec4 targetPositionDiffOffset, Vec4 targetPositionDiffScale, int subMeshC)
        {
            var rawtarget = new RawTargetContainer[subMeshC];

            var diffsbr = new BinaryReader(diffsbuffer);
            var mappingbr = new BinaryReader(mappingbuffer);

            for (var i = 0; i < subMeshC; i++)
            {
                var diffsCount = numVertexDiffsInEachChunk[i];
                var vertexDelta = new TargetVec3[diffsCount];
                var normalDelta = new Vec3[diffsCount];
                var tangentDelta = new Vec3[diffsCount];

                if (i == 0)
                {
                    diffsbuffer.Position = targetStartsInVertexDiffs * 12;
                }
                else
                {
                    diffsbuffer.Position = targetStartsInVertexDiffs * 12;

                    for (var eye = 0; eye < i; eye++)
                    {
                        diffsbuffer.Position += numVertexDiffsInEachChunk[eye] * 12;
                    }
                }

                for (var e = 0; e < diffsCount; e++)
                {
                    if (diffsbr.BaseStream.Position < (diffsbr.BaseStream.Length - 3))
                    {
                        var v = Converters.TenBitUnsigned(diffsbr.ReadUInt32());

                        var x = (v.X * targetPositionDiffScale.X) + targetPositionDiffOffset.X;
                        var y = (v.Y * targetPositionDiffScale.Y) + targetPositionDiffOffset.Y;
                        var z = (v.Z * targetPositionDiffScale.Z) + targetPositionDiffOffset.Z;

                        vertexDelta[e] = new TargetVec3(x, z, -y);
                        var n = Converters.TenBitShifted(diffsbr.ReadUInt32());
                        normalDelta[e] = new Vec3(n.X, n.Z, -n.Y);
                        var t = Converters.TenBitShifted(diffsbr.ReadUInt32());
                        tangentDelta[e] = new Vec3(t.X, t.Z, -t.Y);
                    }
                }

                var vertexMapping = new ushort[diffsCount];

                if (i == 0)
                {
                    mappingbuffer.Position = targetStartsInVertexDiffsMapping * 4;
                }
                else
                {
                    mappingbuffer.Position = targetStartsInVertexDiffsMapping * 4;

                    for (var eye = 0; eye < i; eye++)
                    {
                        mappingbuffer.Position += numVertexDiffsMappingInEachChunk[eye] * 4;
                    }
                }

                for (var e = 0; e < diffsCount; e++)
                {
                    if (mappingbr.BaseStream.Position < (mappingbr.BaseStream.Length - 1))
                    {
                        vertexMapping[e] = mappingbr.ReadUInt16();
                    }
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

        private static List<MemoryStream> ContainTextureStreams(rendRenderMorphTargetMeshBlob blob, MemoryStream texbuffer)
        {
            var textureStreams = new List<MemoryStream>();

            var Count = blob.Header.TargetTextureDiffsData.Count;
            var texCount = 0;
            var TargetDiffsDataOffset = new List<uint>();
            var TargetDiffsDataSize = new List<uint>();
            var TargetDiffsMipLevelCounts = new List<uint>();
            var TargetDiffsWidth = new List<uint>();

            for (var i = 0; i < Count; i++)
            {
                var diff = blob.Header.TargetTextureDiffsData[i];
                ArgumentNullException.ThrowIfNull(diff);

                if (diff.TargetDiffsDataSize.Count == 0)
                {
                    break;
                }

                if (diff.TargetDiffsDataSize[0] == 0)
                {
                    continue;
                }

                TargetDiffsDataOffset.Add(diff.TargetDiffsDataOffset[0]);
                TargetDiffsDataSize.Add(diff.TargetDiffsDataSize[0]);
                TargetDiffsMipLevelCounts.Add(diff.TargetDiffsMipLevelCounts[0]);
                TargetDiffsWidth.Add(diff.TargetDiffsWidth[0]);
                texCount++;
            }

            var texbr = new BinaryReader(texbuffer);
            for (var i = 0; i < texCount; i++)
            {
                texbuffer.Position = TargetDiffsDataOffset[i];
                var bytes = texbr.ReadBytes((int)TargetDiffsDataSize[i]);

                var ms = new MemoryStream();
                var metadata = new DDSMetadata(
                    TargetDiffsWidth[i], TargetDiffsWidth[i],
                    1, 1, TargetDiffsMipLevelCounts[i], 0, 0, DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM, TEX_DIMENSION.TEX_DIMENSION_TEXTURE2D, 16, true);
                DDSUtils.GenerateAndWriteHeader(ms, metadata);
                var bw = new BinaryWriter(ms);
                bw.Write(bytes);
                textureStreams.Add(ms);
            }

            return textureStreams;
        }

        private static ModelRoot RawTargetsToGLTF(List<RawMeshContainer> meshes, List<RawTargetContainer[]> expTargets, string[] names, RawArmature? rig)
        {
            var model = ModelRoot.CreateModel();
            var mat = model.CreateMaterial("Default");
            mat.WithPBRMetallicRoughness().WithDefault();
            mat.DoubleSided = true;
            var skins = new List<Skin>();
            if (rig != null)
            {
                var skin = model.CreateSkin();
                skin.BindJoints(RIG.ExportNodes(ref model, rig).Values.ToArray());
                skins.Add(skin);
            }

            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);
            var mIndex = -1;
            foreach (var mesh in meshes)
            {
                ArgumentNullException.ThrowIfNull(mesh.positions);
                ArgumentNullException.ThrowIfNull(mesh.normals);
                ArgumentNullException.ThrowIfNull(mesh.tangents);
                ArgumentNullException.ThrowIfNull(mesh.colors0);
                ArgumentNullException.ThrowIfNull(mesh.colors1);
                ArgumentNullException.ThrowIfNull(mesh.texCoords0);
                ArgumentNullException.ThrowIfNull(mesh.texCoords1);
                ArgumentNullException.ThrowIfNull(mesh.boneindices);
                ArgumentNullException.ThrowIfNull(mesh.weights);
                ArgumentNullException.ThrowIfNull(mesh.indices);

                ++mIndex;
                for (var i = 0; i < mesh.positions.Length; i++)
                {
                    bw.Write(mesh.positions[i].X);
                    bw.Write(mesh.positions[i].Y);
                    bw.Write(mesh.positions[i].Z);
                }
                for (var i = 0; i < mesh.normals.Length; i++)
                {
                    bw.Write(mesh.normals[i].X);
                    bw.Write(mesh.normals[i].Y);
                    bw.Write(mesh.normals[i].Z);
                }
                for (var i = 0; i < mesh.tangents.Length; i++)
                {
                    bw.Write(mesh.tangents[i].X);
                    bw.Write(mesh.tangents[i].Y);
                    bw.Write(mesh.tangents[i].Z);
                    bw.Write(mesh.tangents[i].W);
                }
                for (var i = 0; i < mesh.colors0.Length; i++)
                {
                    bw.Write(mesh.colors0[i].X);
                    bw.Write(mesh.colors0[i].Y);
                    bw.Write(mesh.colors0[i].Z);
                    bw.Write(mesh.colors0[i].W);
                }
                for (var i = 0; i < mesh.colors1.Length; i++)
                {
                    bw.Write(mesh.colors1[i].X);
                    bw.Write(mesh.colors1[i].Y);
                    bw.Write(mesh.colors1[i].Z);
                    bw.Write(mesh.colors1[i].W);
                }
                for (var i = 0; i < mesh.texCoords0.Length; i++)
                {
                    bw.Write(mesh.texCoords0[i].X);
                    bw.Write(mesh.texCoords0[i].Y);
                }
                for (var i = 0; i < mesh.texCoords1.Length; i++)
                {
                    bw.Write(mesh.texCoords1[i].X);
                    bw.Write(mesh.texCoords1[i].Y);
                }

                if (mesh.weightCount > 0)
                {
                    if (rig != null)
                    {
                        for (var i = 0; i < mesh.positions.Length; i++)
                        {
                            bw.Write(mesh.boneindices[i, 0]);
                            bw.Write(mesh.boneindices[i, 1]);
                            bw.Write(mesh.boneindices[i, 2]);
                            bw.Write(mesh.boneindices[i, 3]);
                        }
                        for (var i = 0; i < mesh.positions.Length; i++)
                        {
                            bw.Write(mesh.weights[i, 0]);
                            bw.Write(mesh.weights[i, 1]);
                            bw.Write(mesh.weights[i, 2]);
                            bw.Write(mesh.weights[i, 3]);
                        }
                        if (mesh.weightCount > 4)
                        {
                            for (var i = 0; i < mesh.positions.Length; i++)
                            {
                                bw.Write(mesh.boneindices[i, 4]);
                                bw.Write(mesh.boneindices[i, 5]);
                                bw.Write(mesh.boneindices[i, 6]);
                                bw.Write(mesh.boneindices[i, 7]);
                            }
                            for (var i = 0; i < mesh.positions.Length; i++)
                            {
                                bw.Write(mesh.weights[i, 4]);
                                bw.Write(mesh.weights[i, 5]);
                                bw.Write(mesh.weights[i, 6]);
                                bw.Write(mesh.weights[i, 7]);
                            }
                        }
                    }
                }
                for (var i = 0; i < mesh.indices.Length; i += 3)
                {
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 1]));
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 0]));
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 2]));
                }
                for (var i = 0; i < expTargets.Count; i++)
                {
                    ArgumentNullException.ThrowIfNull(expTargets[i][mIndex].vertexMapping);

                    var mappings = expTargets[i][mIndex].vertexMapping.NotNull().ToList();
                    for (ushort e = 0; e < mesh.positions.Length; e++)
                    {
                        if (mappings.Contains(e))
                        {
                            var idx = mappings.IndexOf(e);

                            var vd = expTargets[i][mIndex].vertexDelta.NotNull();

                            bw.Write(vd[idx].X);
                            bw.Write(vd[idx].Y);
                            bw.Write(vd[idx].Z);
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
                            var idx = mappings.IndexOf(e);

                            var nd = expTargets[i][mIndex].normalDelta.NotNull();

                            bw.Write(nd[idx].X);
                            bw.Write(nd[idx].Y);
                            bw.Write(nd[idx].Z);
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
                            var idx = mappings.IndexOf(e);

                            var td = expTargets[i][mIndex].tangentDelta.NotNull();

                            bw.Write(td[idx].X);
                            bw.Write(td[idx].Y);
                            bw.Write(td[idx].Z);
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
            var BuffViewoffset = 0;

            foreach (var mesh in meshes)
            {
                ArgumentNullException.ThrowIfNull(mesh.positions);
                ArgumentNullException.ThrowIfNull(mesh.normals);
                ArgumentNullException.ThrowIfNull(mesh.tangents);
                ArgumentNullException.ThrowIfNull(mesh.colors0);
                ArgumentNullException.ThrowIfNull(mesh.colors1);
                ArgumentNullException.ThrowIfNull(mesh.texCoords0);
                ArgumentNullException.ThrowIfNull(mesh.texCoords1);
                ArgumentNullException.ThrowIfNull(mesh.boneindices);
                ArgumentNullException.ThrowIfNull(mesh.weights);
                ArgumentNullException.ThrowIfNull(mesh.indices);

                var mes = model.CreateMesh(mesh.name);
                var prim = mes.CreatePrimitive();
                prim.Material = mat;
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 12);
                    acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("POSITION", acc);
                    BuffViewoffset += mesh.positions.Length * 12;
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
                if (mesh.texCoords0.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.texCoords0.Length * 8);
                    acc.SetData(buff, 0, mesh.texCoords0.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_0", acc);
                    BuffViewoffset += mesh.texCoords0.Length * 8;
                }
                if (mesh.texCoords1.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.texCoords1.Length * 8);
                    acc.SetData(buff, 0, mesh.texCoords1.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_1", acc);
                    BuffViewoffset += mesh.texCoords1.Length * 8;
                }
                if (mesh.weightCount > 0)
                {
                    if (rig != null)
                    {
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 8);
                            acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                            prim.SetVertexAccessor("JOINTS_0", acc);
                            BuffViewoffset += mesh.positions.Length * 8;
                        }
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 16);
                            acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                            prim.SetVertexAccessor("WEIGHTS_0", acc);
                            BuffViewoffset += mesh.positions.Length * 16;
                        }
                        if (mesh.weightCount > 4)
                        {
                            {
                                var acc = model.CreateAccessor();
                                var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 8);
                                acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                                prim.SetVertexAccessor("JOINTS_1", acc);
                                BuffViewoffset += mesh.positions.Length * 8;
                            }
                            {
                                var acc = model.CreateAccessor();
                                var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 16);
                                acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                                prim.SetVertexAccessor("WEIGHTS_1", acc);
                                BuffViewoffset += mesh.positions.Length * 16;
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
                if (rig != null && mesh.weightCount > 0)
                {
                    nod.Skin = skins[0];
                }

                var obj = new { targetNames = names }; // anonymous variable/obj
                mes.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);

                for (var i = 0; i < expTargets.Count; i++)
                {
                    var dict = new Dictionary<string, Accessor>();
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 12);
                        acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                        dict.Add("POSITION", acc);
                        BuffViewoffset += mesh.positions.Length * 12;
                    }
                    if (mesh.normals.Length > 0)
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
