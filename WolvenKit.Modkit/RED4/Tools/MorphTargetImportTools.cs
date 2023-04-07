using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.DependencyModel;
using SharpGLTF.Schema2;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public bool ImportMorphTargets(FileInfo inGltfFile, Stream intargetStream, GltfImportArgs args/*, Stream outStream = null*/)
        {
            var cr2w = _parserService.ReadRed4File(intargetStream);
            if (cr2w == null || cr2w.RootChunk is not MorphTargetMesh targetRoot || targetRoot.Blob.Chunk is not rendRenderMorphTargetMeshBlob renderblob || renderblob.BaseBlob.Chunk is not rendRenderMeshBlob)
            {
                return false;
            }

            RawArmature? newRig = null;
            {
                var hash = targetRoot.BaseMesh.DepotPath.GetRedHash(); //FNV1A64HashAlgorithm.HashString(blob.BaseMesh.DepotPath.ToString().NotNull());
                var meshStream = new MemoryStream();
                foreach (var ar in args.Archives)
                {
                    if (ar.Files.TryGetValue(hash, out var gameFile))
                    {
                        gameFile.Extract(meshStream);
                        break;
                    }
                }
                var meshCr2w = _parserService.ReadRed4File(meshStream);
                if (meshCr2w != null && meshCr2w.RootChunk is CMesh mesh && mesh.RenderResourceBlob != null && mesh.RenderResourceBlob.Chunk is rendRenderMeshBlob rendBlob)
                {
                    newRig = MeshTools.GetOrphanRig(mesh);
                }
            }

            var model = ModelRoot.Load(inGltfFile.FullName, new ReadSettings(args.ValidationMode));
            VerifyGLTF(model, args);

            var RawMeshes = new List<RawMeshContainer>();

            foreach (var node in model.LogicalNodes)
            {
                if (node.Mesh != null)
                {
                    var rawMesh = GltfMeshToRawContainer(node);

                    RawMeshes.Add(rawMesh);
                }
                else if (args.FillEmpty)
                {
                    RawMeshes.Add(CreateEmptyMesh(node.Name));
                }
            }

            RawMeshes = RawMeshes.OrderBy(o => o.name).ToList();

            var (maxBound, minBound) = CalculateModelBoundsWithMorphs(RawMeshes, model);

            targetRoot.BoundingBox.Max = new Vector4 { X = maxBound.X, Y = maxBound.Y, Z = maxBound.Z, W = 1f };
            targetRoot.BoundingBox.Min = new Vector4 { X = minBound.X, Y = minBound.Y, Z = minBound.Z, W = 1f };

            // The /2 is because this one is stored in a signed int16... *sigh*
            var baseQuantOffset = new Vec4((maxBound.X + minBound.X) / 2f, (maxBound.Y + minBound.Y) / 2f, (maxBound.Z + minBound.Z) / 2f, 0f);
            var baseQuantScale = new Vec4((maxBound.X - minBound.X) / 2f, (maxBound.Y - minBound.Y) / 2f, (maxBound.Z - minBound.Z) / 2f, 0f);

            RawArmature? oldRig = null;
            if (model.LogicalSkins.Count > 0 && model.LogicalSkins[0].JointsCount > 0)
            {
                oldRig = new RawArmature
                {
                    BoneCount = model.LogicalSkins[0].JointsCount,
                    Names = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.Name).ToArray()
                };
            }

            MeshTools.UpdateMeshJoints(ref RawMeshes, newRig, oldRig);

            var red4Meshes = RawMeshes.Select(_ => RawMeshToRE4Mesh(_, baseQuantScale, baseQuantOffset)).ToList();

            var meshBuffer = new MemoryStream();
            var meshesInfo = BufferWriter(red4Meshes, ref meshBuffer, args);

            meshesInfo.quantScale = baseQuantScale;
            meshesInfo.quantTrans = baseQuantOffset;

            // ^ This basically finishes up the mesh setup. Morphtargets are
            // effectively injected at this point, and the mesh written out
            // at the end. The mesh processing needs to be unified so that
            // it's not duplicated here and in MeshImportTools.

            var diffsBuffer = new MemoryStream();
            var mappingsBuffer = new MemoryStream();
            var texbuffer = new MemoryStream();

            // Reset some more data - why is this not a new data structure, again?
            // Resetting up here because this is mutable data so there's no telling
            // who might fuck with it somewhere.

            var subMeshesCount = red4Meshes.Count;
            var morphTargetCount = model.LogicalMeshes[0].Primitives[0].MorphTargetsCount;
            var targetCountsMatch = model.LogicalMeshes.All(l => l.Primitives[0].MorphTargetsCount == morphTargetCount);

            if (!targetCountsMatch)
            {
                var totals = model.LogicalMeshes.Select(subMesh => $"{subMesh.Name}: {morphTargetCount}").ToArray();
                throw new Exception($"All submeshes don't have the same number of morph targets!\n{string.Join("\n", totals)}");
            }

            if (morphTargetCount == 0)
            {
                throw new Exception("Mesh contains no morph targets to import.");
            }

            renderblob.Header.NumDiffs = 0;
            renderblob.Header.NumDiffsMapping = 0;
            renderblob.Header.NumVertexDiffsInEachChunk = new(morphTargetCount);
            renderblob.Header.NumVertexDiffsMappingInEachChunk = new(morphTargetCount);
            renderblob.Header.TargetStartsInVertexDiffs = new(morphTargetCount);
            renderblob.Header.TargetStartsInVertexDiffsMapping = new(morphTargetCount);
            renderblob.Header.TargetPositionDiffOffset = new(morphTargetCount);
            renderblob.Header.TargetPositionDiffScale = new(morphTargetCount);

            for (var i = 0; i < morphTargetCount; i++)
            {
                renderblob.Header.NumVertexDiffsInEachChunk[i] = new(subMeshesCount);
                renderblob.Header.NumVertexDiffsMappingInEachChunk[i] = new(subMeshesCount);

                renderblob.Header.TargetStartsInVertexDiffs[i] = 0;
                renderblob.Header.TargetStartsInVertexDiffsMapping[i] = 0;

                renderblob.Header.TargetPositionDiffOffset[i] = new Vec4(0f, 0f, 0f, 0);
                renderblob.Header.TargetPositionDiffScale[i] = new Vec4(1f, 1f, 1f, 0);
            }

            // Do the thing
            ConvertAndSetTargetsData(cr2w, (uint)morphTargetCount, (uint)subMeshesCount, model, renderblob, diffsBuffer, mappingsBuffer);

            // Well most of the thing, this part of the thing is here instead
            renderblob.DiffsBuffer.Buffer.SetBytes(diffsBuffer.ToArray());
            renderblob.MappingBuffer.Buffer.SetBytes(mappingsBuffer.ToArray());

            // Fill out the rest (render data mostly)
            var ms = GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer);

            ms.Seek(0, SeekOrigin.Begin);
            intargetStream.SetLength(0);
            ms.CopyTo(intargetStream);
 
            return true;
        }

        private (Vec3, Vec3) CalculateModelBoundsWithMorphs(List<RawMeshContainer> rawMeshes, ModelRoot model)
        {
            var modelMax = new Vec3(float.MinValue, float.MinValue, float.MinValue);
            var modelMin = new Vec3(float.MaxValue, float.MaxValue, float.MaxValue);

            for (var subMeshIndex = 0; subMeshIndex < rawMeshes.Count; subMeshIndex++)
            {
                var (smMorphMax, smMorphMin) = GetZupPositionDeltaBoundsForSubMesh(model, subMeshIndex);

                var subMeshMax = new Vec3(float.MinValue, float.MinValue, float.MinValue);
                var subMeshMin = new Vec3(float.MaxValue, float.MaxValue, float.MaxValue);

                var subMeshPositions = rawMeshes[subMeshIndex].positions;
                ArgumentNullException.ThrowIfNull(subMeshPositions);

                foreach (var position in subMeshPositions)
                {
                    subMeshMax.X = Math.Max(position.X, subMeshMax.X);
                    subMeshMax.Y = Math.Max(position.Y, subMeshMax.Y);
                    subMeshMax.Z = Math.Max(position.Z, subMeshMax.Z);

                    subMeshMin.X = Math.Min(position.X, subMeshMin.X);
                    subMeshMin.Y = Math.Min(position.Y, subMeshMin.Y);
                    subMeshMin.Z = Math.Min(position.Z, subMeshMin.Z);
                }

                modelMax.X = Math.Max(modelMax.X, Math.Max(subMeshMax.X, (subMeshMax.X + smMorphMax.X)));
                modelMax.Y = Math.Max(modelMax.Y, Math.Max(subMeshMax.Y, (subMeshMax.Y + smMorphMax.Y)));
                modelMax.Z = Math.Max(modelMax.Z, Math.Max(subMeshMax.Z, (subMeshMax.Z + smMorphMax.Z)));

                modelMin.X = Math.Min(modelMin.X, Math.Min(subMeshMin.X, (subMeshMin.X + smMorphMin.X)));
                modelMin.Y = Math.Min(modelMin.Y, Math.Min(subMeshMin.Y, (subMeshMin.Y + smMorphMin.Y)));
                modelMin.Z = Math.Min(modelMin.Z, Math.Min(subMeshMin.Z, (subMeshMin.Z + smMorphMin.Z)));
            }

            return (modelMax, modelMin);
        }

        // Is this info already in the GLTF? Yes
        // Can I somehow get the POSITION.min/.max values with SharpGLTF? Also y-- no. Definitely no.
        // Are we therefore looping through all the vertices for like the 15th time? We sure are!
        private (Vec3, Vec3) GetZupPositionDeltaBoundsForSubMesh(ModelRoot model, int subMeshIndex)
        {
            var max = Vec3.Zero;
            var min = Vec3.Zero;

            var morphTargetCount = model.LogicalMeshes[0].Primitives[0].MorphTargetsCount;

            // Need to flip to LHCS Zup here (...and again later)
            for (var targetIndex = 0; targetIndex < morphTargetCount; targetIndex++)
            {
                var positionDeltas = model.LogicalMeshes[subMeshIndex].Primitives[0].GetMorphTargetAccessors(targetIndex)["POSITION"].AsVector3Array();

                max.X = Math.Max(max.X, positionDeltas.Max(l => l.X));
                max.Y = Math.Max(max.Y, positionDeltas.Max(l => -l.Z));
                max.Z = Math.Max(max.Z, positionDeltas.Max(l => l.Y));

                min.X = Math.Min(min.X, positionDeltas.Min(l => l.X));
                min.Y = Math.Min(min.Y, positionDeltas.Min(l => -l.Z));
                min.Z = Math.Min(min.Z, positionDeltas.Min(l => l.Y));
            }

            return (max, min);
        }

        // Quantization reduces vertex data to the range of values in the model.
        // ...But the algorithm isn't always the same.
        private (Vec4 scale, Vec4 offset) CalculateQuantizationForTargetInZUp(ModelRoot model, int morphTargetId)
        {
            var logicalMesh = model.LogicalMeshes[0].Primitives[0];
            var morphTarget = logicalMesh.GetMorphTargetAccessors(morphTargetId);
            var morphPositionDeltas = morphTarget["POSITION"].AsVector3Array();

            var max = new Vec3(morphPositionDeltas[0].X, -morphPositionDeltas[0].Z, morphPositionDeltas[0].Y);
            var min = new Vec3(morphPositionDeltas[0].X, -morphPositionDeltas[0].Z, morphPositionDeltas[0].Y);

            for (var i = 0; i < model.LogicalMeshes.Count; i++)
            {
                morphPositionDeltas = model.LogicalMeshes[i].Primitives[0].GetMorphTargetAccessors(morphTargetId)["POSITION"].AsVector3Array();

                max.X = Math.Max(max.X, morphPositionDeltas.Max(l => l.X));
                max.Y = Math.Max(max.Y, morphPositionDeltas.Max(l => -l.Z));
                max.Z = Math.Max(max.Z, morphPositionDeltas.Max(l => l.Y));

                min.X = Math.Min(min.X, morphPositionDeltas.Min(l => l.X));
                min.Y = Math.Min(min.Y, morphPositionDeltas.Min(l => -l.Z));
                min.Z = Math.Min(min.Z, morphPositionDeltas.Min(l => l.Y));
            }

            var quantScale = new Vec4(max.X - min.X, max.Y - min.Y, max.Z - min.Z, 0);
            var quantOffset = new Vec4(min.X, min.Y, min.Z, 0);

            return (quantScale, quantOffset);
        }

        // Inverse, export transform is (mostly) in `ContainRawTarget()`
        private void ConvertAndSetTargetsData(CR2WFile cr2w, uint morphTargetCount, uint subMeshCount, ModelRoot model, rendRenderMorphTargetMeshBlob blob, Stream diffsBuffer, Stream mappingsBuffer)
        {
            var diffsWriter = new BinaryWriter(diffsBuffer);
            var mappingsWriter = new BinaryWriter(mappingsBuffer);

            for (var targetIndex = 0; targetIndex < morphTargetCount; targetIndex++)
            {
                var (targetQuantScale, targetQuantOffset) = CalculateQuantizationForTargetInZUp(model, targetIndex);

                blob.Header.TargetPositionDiffOffset[targetIndex] = targetQuantOffset; 
                blob.Header.TargetPositionDiffScale[targetIndex] = targetQuantScale;

                for (var subMeshIndex = 0; subMeshIndex < subMeshCount; subMeshIndex++)
                {
                    var subMesh = model.LogicalMeshes[subMeshIndex].Primitives[0];
                    var morphTarget = subMesh.GetMorphTargetAccessors(targetIndex);

                    if (!morphTarget.ContainsKey("TANGENT"))
                    {
                        throw new Exception($"Morph target {targetIndex} does not contain any tangents. Did you remember to export them?");
                    }

                    if (!morphTarget.ContainsKey("NORMAL"))
                    {
                        throw new Exception($"Morph target {targetIndex} does not contain any normals. Did you remember to export them?");
                    }

                    var positionDeltas = morphTarget["POSITION"].AsVector3Array();
                    var normalDeltas = morphTarget["NORMAL"].AsVector3Array();
                    var tangentDeltas = morphTarget["TANGENT"].AsVector3Array();

                    var mappingsInSubmesh = new List<ushort>();
                    uint actionableDiffCountInSubmesh = 0;
                    var diffsWithOnlyNormalOrTangentCount = 0;

                    for (var diffIndex = 0; diffIndex < positionDeltas.Count; diffIndex++)
                    {
                        var positionDelta = positionDeltas[diffIndex];
                        var normalDelta = normalDeltas[diffIndex];
                        var tangentDelta = tangentDeltas[diffIndex];

                        var hasPositionDelta = positionDelta.X != 0 || positionDelta.Y != 0 || positionDelta.Z != 0;
                        var hasNormalDelta = normalDelta.X != 0 || normalDelta.Y != 0 || normalDelta.Z != 0;
                        var hasTangentDelta = tangentDelta.X != 0 || tangentDelta.Y != 0 || tangentDelta.Z != 0;

                        if (!hasPositionDelta)
                        {
                            if (!hasNormalDelta && !hasTangentDelta)
                            {
                                continue;
                            }

                            diffsWithOnlyNormalOrTangentCount += 1;   // Dunno if this is actually relevant info?
                        }

                        mappingsInSubmesh.Add((ushort)diffIndex);

                        actionableDiffCountInSubmesh += 1;

                        // GLTF's RHCS Y up -> Red4 LHCS Z up
                        var zUpPositionDelta = new TargetVec3(positionDelta.X, -positionDelta.Z, positionDelta.Y);
                        var zUpNormalDelta = new Vec4(normalDelta.X, -normalDelta.Z, normalDelta.Y, 0f);
                        var zUpTangentDelta = new Vec4(tangentDelta.X, -tangentDelta.Z, tangentDelta.Y, 0f);

                        // Quant already converted earlier
                        var zUpQuantizedPositionDelta =
                            new TargetVec3(
                                targetQuantScale.X != 0 ? ((zUpPositionDelta.X - targetQuantOffset.X) / targetQuantScale.X) : 0,
                                targetQuantScale.Y != 0 ? ((zUpPositionDelta.Y - targetQuantOffset.Y) / targetQuantScale.Y) : 0,
                                targetQuantScale.Z != 0 ? ((zUpPositionDelta.Z - targetQuantOffset.Z) / targetQuantScale.Z) : 0);

                        // NB different encoding for position!
                        var positionAs10BitUnsignedInt = Converters.Vec3ToU32(zUpQuantizedPositionDelta, 1);
                        var normalAs10BitShiftedInt = Converters.Vec4ToU32(zUpNormalDelta);
                        var tangentAs10BitShiftedInt = Converters.Vec4ToU32(zUpTangentDelta);

                        // 4 + 4 + 4 bytes per diff, no padding
                        diffsWriter.Write(positionAs10BitUnsignedInt);
                        diffsWriter.Write(normalAs10BitShiftedInt);
                        diffsWriter.Write(tangentAs10BitShiftedInt);
                    }

                    // 2 bytes per mapping
                    foreach (var mapping in mappingsInSubmesh)
                    {
                        mappingsWriter.Write(mapping);
                    }

                    var oddDiffCountNeedsMappingsPadding = mappingsInSubmesh.Count % 2 != 0;

                    if (oddDiffCountNeedsMappingsPadding)
                    {
                        mappingsWriter.Write((ushort)0);
                    }

                    // Fun story
                    var mappingCountHalvedRoundedUpForRE4 =
                        oddDiffCountNeedsMappingsPadding
                            ? (uint)(mappingsInSubmesh.Count / 2) + 1
                            : (uint)(mappingsInSubmesh.Count / 2);

                    blob.Header.NumVertexDiffsInEachChunk[targetIndex][subMeshIndex] = actionableDiffCountInSubmesh;
                    blob.Header.NumVertexDiffsMappingInEachChunk[targetIndex][subMeshIndex] = mappingCountHalvedRoundedUpForRE4;

                    _loggerService.Debug($"Target {targetIndex} submesh {subMeshIndex} ({positionDeltas.Count} vertices): {actionableDiffCountInSubmesh} diffs applied (of which {diffsWithOnlyNormalOrTangentCount} diffs with only normal/tangent, no position)");
                }
            }

            // Set rest of blob-level stuff computed from the import.
            // (This should really be immutable or returned but here we are.)

            blob.Header.NumTargets = morphTargetCount;

            blob.Header.NumDiffs = 0;
            blob.Header.NumDiffsMapping = 0;

            // Reduce into totals and subtotals... f# where art thou
            for (var targetIndex = (int)morphTargetCount - 1; targetIndex >= 0; targetIndex--)
            {
                blob.Header.TargetStartsInVertexDiffs[targetIndex] = 0;
                blob.Header.TargetStartsInVertexDiffsMapping[targetIndex] = 0;

                uint diffCountInTarget = 0;
                uint mappingCountInTarget = 0;

                for (var subMeshIndex = 0; subMeshIndex < subMeshCount; subMeshIndex++)
                {
                    diffCountInTarget += blob.Header.NumVertexDiffsInEachChunk[targetIndex][subMeshIndex];
                    mappingCountInTarget += blob.Header.NumVertexDiffsMappingInEachChunk[targetIndex][subMeshIndex];
                }

                blob.Header.NumDiffs += diffCountInTarget;
                blob.Header.NumDiffsMapping += mappingCountInTarget;

                for (var higherTargetIndex = targetIndex + 1; higherTargetIndex < morphTargetCount; higherTargetIndex++)
                {
                    blob.Header.TargetStartsInVertexDiffs[higherTargetIndex] += diffCountInTarget;
                    blob.Header.TargetStartsInVertexDiffsMapping[higherTargetIndex] += mappingCountInTarget;
                }
            }

            return;
        }
    }
}
