using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public bool ExportMorphTargets(CR2WFile cr2w, FileInfo outfile, bool isGLBinary = true, ValidationMode vMode = ValidationMode.TryFix)
        {
            if (cr2w is not { RootChunk: MorphTargetMesh morphBlob } || morphBlob.Blob.Chunk is not rendRenderMorphTargetMeshBlob blob || blob.BaseBlob.Chunk is not rendRenderMeshBlob rendBlob)
            {
                _loggerService.Error("Morphtarget: does not look like a valid morphtarget");
                return false;
            }

            RawArmature? rig = null;

            if (TryFindFile(morphBlob.BaseMesh.DepotPath, out var result) == FindFileResult.NoError && 
                result.File is { RootChunk: CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob } baseMeshBlob })
            {
                rig = MeshTools.GetOrphanRig(baseMeshBlob);
            }

            using var meshBuffer = new MemoryStream(rendBlob.RenderBuffer.Buffer.GetBytes());

            var meshesInfo = MeshTools.GetMeshesinfo(rendBlob, result.File?.RootChunk as CMesh);

            var expMeshes = MeshTools.ContainRawMesh(meshBuffer, meshesInfo, true);

            var diffsBuffer = blob.DiffsBuffer is not null ? new MemoryStream(blob.DiffsBuffer.Buffer.GetBytes()) : new MemoryStream();
            var mappingBuffer = blob.MappingBuffer is not null ? new MemoryStream(blob.MappingBuffer.Buffer.GetBytes()) : new MemoryStream();
            var texBuffer = blob.TextureDiffsBuffer is not null ? new MemoryStream(blob.TextureDiffsBuffer.Buffer.GetBytes()) : new MemoryStream();

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
                var tempNumVertexDiffsInEachChunk = new uint[expMeshes.Count];
                var tempNumVertexDiffsMappingInEachChunk = new uint[expMeshes.Count];
                for (var e = 0; e < expMeshes.Count; e++)
                {
                    tempNumVertexDiffsInEachChunk[e] = targetsInfo.NumVertexDiffsInEachChunk[i, e];
                    tempNumVertexDiffsMappingInEachChunk[e] = targetsInfo.NumVertexDiffsMappingInEachChunk[i, e];
                }
                expTargets.Add(ContainRawTarget(diffsBuffer, mappingBuffer, tempNumVertexDiffsInEachChunk, tempNumVertexDiffsMappingInEachChunk, targetsInfo.TargetStartsInVertexDiffs[i], targetsInfo.TargetStartsInVertexDiffsMapping[i], targetsInfo.TargetPositionDiffOffset[i], targetsInfo.TargetPositionDiffScale[i], expMeshes.Count));
            }

            var textureStreams = ContainTextureStreams(blob, texBuffer);
            var model = RawTargetsToGLTF(expMeshes, expTargets, targetsInfo.Names, rig);

            if (WolvenTesting.IsTesting)
            {
                return true;
            }

            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vMode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vMode));
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

            return true;
        }

        private static TargetsInfo GetTargetInfos(CR2WFile cr2w, int subMeshC)
        {
            var morphBlob = (MorphTargetMesh)cr2w.RootChunk;
            var rendMorphBlob = (rendRenderMorphTargetMeshBlob)morphBlob.Blob.Chunk.NotNull();

            uint numTargets = rendMorphBlob.Header.NumTargets;

            if (numTargets < 1)
            {
                var helpMessage =
                    morphBlob.Targets.Count > 0
                        ? $"There are {morphBlob.Targets.Count} targets, but `blob.header.numTargets` is 0. This was probably done intentionally to disable morphing, but you MAY be able to make this a valid .morphtarget by setting `numTargets` to the actual number of targets."
                        : $"`numTargets` is 0 and there are no `targets` defined, this doesn't look like a valid .morphtarget";

                throw new ArgumentOutOfRangeException("blob.header.numTargets", rendMorphBlob.Header.NumTargets, helpMessage);
            }

            var numVertexDiffsInEachChunk = new uint[numTargets, subMeshC];
            uint numDiffs = rendMorphBlob.Header.NumDiffs;
            uint numDiffsMapping = rendMorphBlob.Header.NumDiffsMapping;
            var numVertexDiffsMappingInEachChunk = new uint[numTargets, subMeshC];
            var targetStartsInVertexDiffs = new uint[numTargets];
            var targetStartsInVertexDiffsMapping = new uint[numTargets];
            var targetPositionDiffOffset = new Vec4[numTargets];
            var targetPositionDiffScale = new Vec4[numTargets];
            for (var i = 0; i < numTargets; i++)
            {
                var diffs = rendMorphBlob.Header.NumVertexDiffsInEachChunk[i];
                var maps = rendMorphBlob.Header.NumVertexDiffsMappingInEachChunk[i];

                for (var e = 0; e < subMeshC; e++)
                {
                    numVertexDiffsInEachChunk[i, e] = diffs[e];
                    numVertexDiffsMappingInEachChunk[i, e] = maps[e];
                }

                targetStartsInVertexDiffs[i] = rendMorphBlob.Header.TargetStartsInVertexDiffs[i];
                targetStartsInVertexDiffsMapping[i] = rendMorphBlob.Header.TargetStartsInVertexDiffsMapping[i];

                var o = rendMorphBlob.Header.TargetPositionDiffOffset[i];
                targetPositionDiffOffset[i] = new Vec4(o.X, o.Y, o.Z, o.W);

                var s = rendMorphBlob.Header.TargetPositionDiffScale[i];
                targetPositionDiffScale[i] = new Vec4(s.X, s.Y, s.Z, s.W);
            }

            var names = new string[numTargets];
            var regionNames = new string[numTargets];
            string baseMesh = morphBlob.BaseMesh.DepotPath.ToString().NotNull();
            string baseTexture = morphBlob.BaseTexture.DepotPath.ToString().NotNull();

            for (var i = 0; i < numTargets; i++)
            {
                var target = morphBlob.Targets[i];

                names[i] = $"{target.Name}_{target.RegionName}";
                regionNames[i] = target.RegionName.ToString().NotNull();
            }

            var targetsInfo = new TargetsInfo()
            {
                NumVertexDiffsInEachChunk = numVertexDiffsInEachChunk,
                NumDiffs = numDiffs,
                NumDiffsMapping = numDiffsMapping,
                NumVertexDiffsMappingInEachChunk = numVertexDiffsMappingInEachChunk,
                TargetStartsInVertexDiffs = targetStartsInVertexDiffs,
                TargetStartsInVertexDiffsMapping = targetStartsInVertexDiffsMapping,
                TargetPositionDiffOffset = targetPositionDiffOffset,
                TargetPositionDiffScale = targetPositionDiffScale,
                Names = names,
                RegionNames = regionNames,
                NumTargets = numTargets,
                BaseMesh = baseMesh,
                BaseTexture = baseTexture,
            };

            return targetsInfo;
        }

        private RawTargetContainer[] ContainRawTarget(MemoryStream diffsBuffer, MemoryStream mappingBuffer, uint[] numVertexDiffsInEachChunk, uint[] numVertexDiffsMappingInEachChunk, uint targetStartsInVertexDiffs, uint targetStartsInVertexDiffsMapping, Vec4 targetPositionDiffOffset, Vec4 targetPositionDiffScale, int subMeshC)
        {
            const int diffByteWidth = 12;
            const int mappingByteWidth = 2;
            const int mappingCountAlignedMultiplier = 2; // Count is stored as half actual, and we align to even rounded up

            var baseDiffsStartPositionForTarget = targetStartsInVertexDiffs * diffByteWidth;
            var baseMappingsStartPositionForTarget = targetStartsInVertexDiffsMapping * mappingCountAlignedMultiplier * mappingByteWidth;

            var rawTarget = new RawTargetContainer[subMeshC];

            var diffsBr = new BinaryReader(diffsBuffer);
            var mappingBr = new BinaryReader(mappingBuffer);

            for (var subMeshIndex = 0; subMeshIndex < subMeshC; subMeshIndex++)
            {
                var diffsCount = numVertexDiffsInEachChunk[subMeshIndex];
                var storedMapsCount = numVertexDiffsMappingInEachChunk[subMeshIndex];

                if (storedMapsCount == 0 && diffsCount != 0)
                {
                    _loggerService.Warning($"Submesh {subMeshIndex} will be exported with 0 diffs: numVertexDiffsMappingInEachChunk[{subMeshIndex}] == 0, so we ignore the numVertexDiffsInEachChunk[{subMeshIndex}] == {diffsCount} (it's probably a bookkeeping error.)");

                    // Normal export handles this case, so let's use that to avoid
                    // missing any logic that should be applied for a valid 0 diff
                    // both here and in following chunks
                    numVertexDiffsInEachChunk[subMeshIndex] = diffsCount = 0;
                }

                var unevenDivisionOffset = diffsCount % 2;

                var actualMapsCount = (storedMapsCount * 2) - unevenDivisionOffset;

                if (actualMapsCount != diffsCount)
                {
                    throw new ArgumentOutOfRangeException($"Submesh {subMeshIndex} mapping count {actualMapsCount} doesn't match diff count {diffsCount}! Can't export this.");
                }

                var positionDeltas = new TargetVec3[diffsCount];
                var normalDeltas = new Vec3[diffsCount];
                var tangentDeltas = new Vec3[diffsCount];
                var vertexMapping = new ushort[actualMapsCount];

                diffsBuffer.Position = baseDiffsStartPositionForTarget;
                mappingBuffer.Position = baseMappingsStartPositionForTarget;

                for (var preceding = 0; preceding < subMeshIndex; preceding++)
                {
                    diffsBuffer.Position += numVertexDiffsInEachChunk[preceding] * diffByteWidth;

                    // Skip previous data as aligned, NOT actual maps count
                    mappingBuffer.Position += numVertexDiffsMappingInEachChunk[preceding] * mappingCountAlignedMultiplier * mappingByteWidth;
                }

                for (var diffIndex = 0; diffIndex < diffsCount; diffIndex++)
                {
                    var positionDelta = Converters.TenBitUnsigned(diffsBr.ReadUInt32());
                    var normalDelta = Converters.TenBitShifted(diffsBr.ReadUInt32());
                    var tangentDelta = Converters.TenBitShifted(diffsBr.ReadUInt32());

                    var dequantizedPositionDeltaX = (positionDelta.X * targetPositionDiffScale.X) + targetPositionDiffOffset.X;
                    var dequantizedPositionDeltaY = (positionDelta.Y * targetPositionDiffScale.Y) + targetPositionDiffOffset.Y;
                    var dequantizedPositionDeltaZ = (positionDelta.Z * targetPositionDiffScale.Z) + targetPositionDiffOffset.Z;

                    // LHCS Zup to RHCS Yup
                    positionDeltas[diffIndex] = new TargetVec3(dequantizedPositionDeltaX, dequantizedPositionDeltaZ, -dequantizedPositionDeltaY);
                    normalDeltas[diffIndex] = new Vec3(normalDelta.X, normalDelta.Z, -normalDelta.Y);
                    tangentDeltas[diffIndex] = new Vec3(tangentDelta.X, tangentDelta.Z, -tangentDelta.Y);
                }

                for (var mapIdx = 0; mapIdx < actualMapsCount; mapIdx++)
                {
                    vertexMapping[mapIdx] = mappingBr.ReadUInt16();
                }

                rawTarget[subMeshIndex] = new RawTargetContainer()
                {
                    vertexDelta = positionDeltas,
                    normalDelta = normalDeltas,
                    tangentDelta = tangentDeltas,
                    vertexMapping = vertexMapping,
                    diffsCount = diffsCount
                };
            }

            return rawTarget;
        }

        private static List<MemoryStream> ContainTextureStreams(rendRenderMorphTargetMeshBlob blob, MemoryStream texbuffer)
        {
            var textureStreams = new List<MemoryStream>();

            var count = blob.Header.TargetTextureDiffsData.Count;
            var texCount = 0;
            var targetDiffsDataOffset = new List<uint>();
            var targetDiffsDataSize = new List<uint>();
            var targetDiffsMipLevelCounts = new List<uint>();
            var targetDiffsWidth = new List<uint>();

            for (var i = 0; i < count; i++)
            {
                var diff = blob.Header.TargetTextureDiffsData[i];

                if (diff.TargetDiffsDataSize.Count == 0)
                {
                    break;
                }

                if (diff.TargetDiffsDataSize[0] == 0)
                {
                    continue;
                }

                targetDiffsDataOffset.Add(diff.TargetDiffsDataOffset[0]);
                targetDiffsDataSize.Add(diff.TargetDiffsDataSize[0]);
                targetDiffsMipLevelCounts.Add(diff.TargetDiffsMipLevelCounts[0]);
                targetDiffsWidth.Add(diff.TargetDiffsWidth[0]);
                texCount++;
            }

            var texBr = new BinaryReader(texbuffer);
            for (var i = 0; i < texCount; i++)
            {
                texbuffer.Position = targetDiffsDataOffset[i];
                var bytes = texBr.ReadBytes((int)targetDiffsDataSize[i]);

                var ms = new MemoryStream();
                var metadata = new DDSMetadata(
                    targetDiffsWidth[i], targetDiffsWidth[i],
                    1, 1, targetDiffsMipLevelCounts[i], 0, 0, DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM, TEX_DIMENSION.TEX_DIMENSION_TEXTURE2D, 16, true);
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
                    bw.Write((mesh.texCoords0[i].Y * -1) + 1); // Flip UV Y like mesh export does
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
                foreach (var t in expTargets)
                {
                    ArgumentNullException.ThrowIfNull(t[mIndex].vertexMapping);

                    var mappings = t[mIndex].vertexMapping.NotNull().ToList();
                    for (ushort e = 0; e < mesh.positions.Length; e++)
                    {
                        if (mappings.Contains(e))
                        {
                            var idx = mappings.IndexOf(e);

                            var vd = t[mIndex].vertexDelta.NotNull();

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

                            var nd = t[mIndex].normalDelta.NotNull();

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

                            var td = t[mIndex].tangentDelta.NotNull();

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
            var buffViewOffset = 0;

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
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.positions.Length * 12);
                    acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("POSITION", acc);
                    buffViewOffset += mesh.positions.Length * 12;
                }
                if (mesh.normals.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.normals.Length * 12);
                    acc.SetData(buff, 0, mesh.normals.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("NORMAL", acc);
                    buffViewOffset += mesh.normals.Length * 12;
                }
                if (mesh.tangents.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.tangents.Length * 16);
                    acc.SetData(buff, 0, mesh.tangents.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TANGENT", acc);
                    buffViewOffset += mesh.tangents.Length * 16;
                }
                if (mesh.colors0.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.colors0.Length * 16);
                    acc.SetData(buff, 0, mesh.colors0.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("COLOR_0", acc);
                    buffViewOffset += mesh.colors0.Length * 16;
                }
                if (mesh.colors1.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.colors1.Length * 16);
                    acc.SetData(buff, 0, mesh.colors1.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("COLOR_1", acc);
                    buffViewOffset += mesh.colors1.Length * 16;
                }
                if (mesh.texCoords0.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.texCoords0.Length * 8);
                    acc.SetData(buff, 0, mesh.texCoords0.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_0", acc);
                    buffViewOffset += mesh.texCoords0.Length * 8;
                }
                if (mesh.texCoords1.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.texCoords1.Length * 8);
                    acc.SetData(buff, 0, mesh.texCoords1.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_1", acc);
                    buffViewOffset += mesh.texCoords1.Length * 8;
                }
                if (mesh.weightCount > 0)
                {
                    if (rig != null)
                    {
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, buffViewOffset, mesh.positions.Length * 8);
                            acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                            prim.SetVertexAccessor("JOINTS_0", acc);
                            buffViewOffset += mesh.positions.Length * 8;
                        }
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, buffViewOffset, mesh.positions.Length * 16);
                            acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                            prim.SetVertexAccessor("WEIGHTS_0", acc);
                            buffViewOffset += mesh.positions.Length * 16;
                        }
                        if (mesh.weightCount > 4)
                        {
                            {
                                var acc = model.CreateAccessor();
                                var buff = model.UseBufferView(buffer, buffViewOffset, mesh.positions.Length * 8);
                                acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                                prim.SetVertexAccessor("JOINTS_1", acc);
                                buffViewOffset += mesh.positions.Length * 8;
                            }
                            {
                                var acc = model.CreateAccessor();
                                var buff = model.UseBufferView(buffer, buffViewOffset, mesh.positions.Length * 16);
                                acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                                prim.SetVertexAccessor("WEIGHTS_1", acc);
                                buffViewOffset += mesh.positions.Length * 16;
                            }
                        }
                    }
                }
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, buffViewOffset, mesh.indices.Length * 2);
                    acc.SetData(buff, 0, mesh.indices.Length, DimensionType.SCALAR, EncodingType.UNSIGNED_SHORT, false);
                    prim.SetIndexAccessor(acc);
                    buffViewOffset += mesh.indices.Length * 2;
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
                        var buff = model.UseBufferView(buffer, buffViewOffset, mesh.positions.Length * 12);
                        acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                        dict.Add("POSITION", acc);
                        buffViewOffset += mesh.positions.Length * 12;
                    }
                    if (mesh.normals.Length > 0)
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, buffViewOffset, mesh.normals.Length * 12);
                        acc.SetData(buff, 0, mesh.normals.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                        dict.Add("NORMAL", acc);
                        buffViewOffset += mesh.normals.Length * 12;
                    }
                    if (mesh.tangents.Length > 0)
                    {
                        var acc = model.CreateAccessor();
                        var buff = model.UseBufferView(buffer, buffViewOffset, mesh.tangents.Length * 12);
                        acc.SetData(buff, 0, mesh.tangents.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                        dict.Add("TANGENT", acc);
                        buffViewOffset += mesh.tangents.Length * 12;
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
