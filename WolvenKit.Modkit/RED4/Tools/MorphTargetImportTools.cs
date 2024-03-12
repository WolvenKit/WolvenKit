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

using TargetAccessor = System.Collections.Generic.IReadOnlyDictionary<string, SharpGLTF.Schema2.Accessor>;


namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        #region importapi

        public bool ImportMorphTargets(FileInfo inGltfFile, Stream inTargetStream, GltfImportArgs args/*, Stream outStream = null*/)
        {
            if (args.FillEmpty)
            {
                throw new NotImplementedException("FillEmpty not supported for morphtarget import! Should it be?");
            }

            var cr2w = _parserService.ReadRed4File(inTargetStream);
            if (cr2w is not { RootChunk: MorphTargetMesh targetRoot } 
                || targetRoot.Blob.Chunk is not rendRenderMorphTargetMeshBlob renderBlob 
                || renderBlob.BaseBlob.Chunk is not rendRenderMeshBlob)
            {
                return false;
            }

            RawArmature? newRig = null;
            
            if (TryFindFile(targetRoot.BaseMesh.DepotPath, out var result) == FindFileResult.NoError &&
                result.File is { RootChunk: CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob } mesh })
            {
                newRig = MeshTools.GetOrphanRig(mesh);
            }

            var model = ModelRoot.Load(inGltfFile.FullName, new ReadSettings(args.ValidationMode));
            VerifyGLTF(model, args);

            // Quick validations and GarmentSupport vs. real targets handling first...

            var subMeshesCount = model.LogicalMeshes.Count;

            var gsAndTargetsPerSubmesh = model.LogicalMeshes.Select(submesh => {
                var targets = Enumerable.Range(0, submesh.Primitives[0].MorphTargetsCount).Select(t =>
                    submesh.Primitives[0].GetMorphTargetAccessors(t)
                );

                var hasGS = submesh.Primitives[0].GetVertexAccessor("_GARMENTSUPPORTWEIGHT") != null &&
                            submesh.Primitives[0].GetVertexAccessor("_GARMENTSUPPORTCAP") != null;

                var gsCount = hasGS ? 1 : 0;

                return (gs: targets.Take(gsCount).ToArray(), real: targets.Skip(gsCount).ToArray());
            });

            var garmentSupportPerSubmesh = gsAndTargetsPerSubmesh.Select(_ => _.gs).ToArray();
            var realTargetsPerSubmesh = gsAndTargetsPerSubmesh.Select(_ => _.real).ToArray();

            var hasAtMostOneGsPerSubmesh = garmentSupportPerSubmesh.All(gs => gs.Length <= 1);

            if (!hasAtMostOneGsPerSubmesh)
            {
                throw new ArgumentException("Multiple GarmentSupport targets per submesh are not allowed!");
            }

            _loggerService.Debug($"{garmentSupportPerSubmesh.Count(gs => gs.Length == 1)} out of {subMeshesCount} submeshes have GarmentSupport");

            var targetCounts = realTargetsPerSubmesh.Select(targets => targets.Length);
            var targetCountsMatch = targetCounts.All(count => count == targetCounts.First());

            if (!targetCountsMatch)
            {
                throw new ArgumentException($"All submeshes don't have the same number of morph targets! (GarmentSupport targets excluded.)");
            }

            var morphTargetCount = targetCounts.First();

            if (morphTargetCount == 0)
            {
                throw new ArgumentException("Mesh contains no morph targets to import.");
            }

            // Ok, moving on to importing...

            var rawMeshes = new List<RawMeshContainer>();

            for (var i = 0; i < subMeshesCount; i++)
            {
                var submesh = model.LogicalMeshes[i];
                var rawMesh = GltfMeshToRawContainer(submesh, args);

                // Substitute whatever mesh import did with what we know to be the GarmentSupport (or none)
                rawMesh.garmentMorph = garmentSupportPerSubmesh[i].Select(gs =>
                    gs["POSITION"].AsVector3Array().Select(p => new Vec3(p.X, -p.Z, p.Y)).ToArray()
                ).FirstOrDefault([]);

                rawMeshes.Add(rawMesh);
            }

            var rawMeshesSorted = rawMeshes.OrderBy(r => r.name).ToList();

            // TODO: Calculated without GarmentSupport for now because that's what mesh import does
            // TODO: https://github.com/WolvenKit/WolvenKit/issues/1504 
            var (maxBound, minBound) = WholeModelAdditiveBoundsZup(rawMeshesSorted, realTargetsPerSubmesh);

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

            MeshTools.UpdateMeshJoints(ref rawMeshesSorted, newRig, oldRig);

            // Finish up creating the baseBlob (not the base mesh!)

            var red4Meshes = rawMeshesSorted.Select(_ => RawMeshToRE4Mesh(_, baseQuantScale, baseQuantOffset)).ToList();

            var meshBuffer = new MemoryStream();
            var meshesInfo = BufferWriter(red4Meshes, ref meshBuffer, args);

            // And then finally the targets

            meshesInfo.quantScale = baseQuantScale;
            meshesInfo.quantTrans = baseQuantOffset;

            var diffsBuffer = new MemoryStream();
            var mappingsBuffer = new MemoryStream();

            renderBlob.Header.NumDiffs = 0;
            renderBlob.Header.NumDiffsMapping = 0;
            renderBlob.Header.NumVertexDiffsInEachChunk = new CArray<CArray<CUInt32>>(morphTargetCount);
            renderBlob.Header.NumVertexDiffsMappingInEachChunk = new CArray<CArray<CUInt32>>(morphTargetCount);
            renderBlob.Header.TargetStartsInVertexDiffs = new CArray<CUInt32>(morphTargetCount);
            renderBlob.Header.TargetStartsInVertexDiffsMapping = new CArray<CUInt32>(morphTargetCount);
            renderBlob.Header.TargetPositionDiffOffset = new CArray<Vector4>(morphTargetCount);
            renderBlob.Header.TargetPositionDiffScale = new CArray<Vector4>(morphTargetCount);

            for (var i = 0; i < morphTargetCount; i++)
            {
                renderBlob.Header.NumVertexDiffsInEachChunk[i] = new CArray<CUInt32>(subMeshesCount);
                renderBlob.Header.NumVertexDiffsMappingInEachChunk[i] = new CArray<CUInt32>(subMeshesCount);

                renderBlob.Header.TargetStartsInVertexDiffs[i] = 0;
                renderBlob.Header.TargetStartsInVertexDiffsMapping[i] = 0;

                renderBlob.Header.TargetPositionDiffOffset[i] = new Vec4(0f, 0f, 0f, 0);
                renderBlob.Header.TargetPositionDiffScale[i] = new Vec4(1f, 1f, 1f, 0);
            }

            // Do the thing
            
            ConvertAndSetTargetsData(cr2w, realTargetsPerSubmesh, renderBlob, diffsBuffer, mappingsBuffer);

            // Well most of the thing, this part of the thing is here instead
            renderBlob.DiffsBuffer.Buffer.SetBytes(diffsBuffer.ToArray());
            renderBlob.MappingBuffer.Buffer.SetBytes(mappingsBuffer.ToArray());

            // Fill out the rest (render data mostly)
            var ms = GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer);

            ms.Seek(0, SeekOrigin.Begin);
            inTargetStream.SetLength(0);
            ms.CopyTo(inTargetStream);
 
            return true;
        }

        #endregion
        #region targetimport

        // Inverse, export transform is (mostly) in `ContainRawTarget()`
        private void ConvertAndSetTargetsData(CR2WFile cr2w, TargetAccessor[][] morphTargetsPerSubmesh, rendRenderMorphTargetMeshBlob blob, Stream diffsBuffer, Stream mappingsBuffer)
        {
            uint subMeshCount = Convert.ToUInt32(morphTargetsPerSubmesh.Length);
            uint morphTargetCount = Convert.ToUInt32(morphTargetsPerSubmesh[0].Length);

            var diffsWriter = new BinaryWriter(diffsBuffer);
            var mappingsWriter = new BinaryWriter(mappingsBuffer);

            for (var targetIndex = 0; targetIndex < morphTargetCount; targetIndex++)
            {
                var (targetQuantScale, targetQuantOffset) = TargetwiseQuantizationZup(morphTargetsPerSubmesh, targetIndex);

                blob.Header.TargetPositionDiffOffset[targetIndex] = targetQuantOffset; 
                blob.Header.TargetPositionDiffScale[targetIndex] = targetQuantScale;

                for (var subMeshIndex = 0; subMeshIndex < subMeshCount; subMeshIndex++)
                {
                    var morphTarget = morphTargetsPerSubmesh[subMeshIndex][targetIndex];

                    if (!morphTarget.ContainsKey("TANGENT"))
                    {
                        throw new Exception($"Morph target {targetIndex} is missing TANGENT data. Use the cp77 Blender plugin or ensure they're exported.");
                    }

                    if (!morphTarget.ContainsKey("NORMAL"))
                    {
                        throw new Exception($"Morph target {targetIndex} is missing NORMAL data. Use the cp77 Blender plugin or ensure they're exported.");
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

        #endregion
        #region boundsandquantizationhelpers

        // This is calculated including possible GarmentSupport, may need to revisit.
        // TODO: https://github.com/WolvenKit/WolvenKit/issues/1504 
        private (Vec3 maxBounds, Vec3 minBounds) WholeModelAdditiveBoundsZup(List<RawMeshContainer> rawMeshes, TargetAccessor[][] morphTargetsPerSubmesh)
        {
            var modelMax = new Vec3(float.MinValue, float.MinValue, float.MinValue);
            var modelMin = new Vec3(float.MaxValue, float.MaxValue, float.MaxValue);

            for (var subMeshIndex = 0; subMeshIndex < rawMeshes.Count; subMeshIndex++)
            {
                var (submeshAdditiveMax, submeshAdditiveMin) = SubmeshwiseAdditiveBoundsZup(morphTargetsPerSubmesh, subMeshIndex);

                var subMeshPositions = rawMeshes[subMeshIndex].positions;
                ArgumentNullException.ThrowIfNull(subMeshPositions);

                foreach (var position in subMeshPositions)
                {
                    modelMax.X = Math.Max(modelMax.X, position.X + submeshAdditiveMax.X);
                    modelMax.Y = Math.Max(modelMax.Y, position.Y + submeshAdditiveMax.Y);
                    modelMax.Z = Math.Max(modelMax.Z, position.Z + submeshAdditiveMax.Z);

                    modelMin.X = Math.Min(modelMin.X, position.X + submeshAdditiveMin.X);
                    modelMin.Y = Math.Min(modelMin.Y, position.Y + submeshAdditiveMin.Y);
                    modelMin.Z = Math.Min(modelMin.Z, position.Z + submeshAdditiveMin.Z);
                }
            }

            return (modelMax, modelMin);
        }

        // Is this info already in the GLTF? Yes
        // Can I somehow get the POSITION.min/.max values with SharpGLTF? Also y-- no. Definitely no.
        // Are we therefore looping through all the vertices for like the 15th time? We sure are!
        private (Vec3 additiveMax, Vec3 additiveMin) SubmeshwiseAdditiveBoundsZup(TargetAccessor[][] morphTargetsPerSubmesh, int subMeshIndex)
        {
            var morphTargetCount = morphTargetsPerSubmesh[subMeshIndex].Length;

            var maxDeltasPerTarget = new Vec3[morphTargetCount];
            var minDeltasPerTarget = new Vec3[morphTargetCount];

            // Need to flip to LHCS Zup here (...and again later)
            for (var targetIndex = 0; targetIndex < morphTargetCount; targetIndex++)
            {
                var positionDeltas = morphTargetsPerSubmesh[subMeshIndex][targetIndex]["POSITION"].AsVector3Array();

                maxDeltasPerTarget[targetIndex] = new Vec3( positionDeltas.Max(l => l.X), positionDeltas.Max(l => -l.Z), positionDeltas.Max(l => l.Y));
                minDeltasPerTarget[targetIndex] = new Vec3( positionDeltas.Min(l => l.X), positionDeltas.Min(l => -l.Z), positionDeltas.Min(l => l.Y));
            }

            var cumulativeMax = new Vec3(
                maxDeltasPerTarget.Select(v => v.X > 0 ? v.X : 0).Sum(),
                maxDeltasPerTarget.Select(v => v.Y > 0 ? v.Y : 0).Sum(),
                maxDeltasPerTarget.Select(v => v.Z > 0 ? v.Z : 0).Sum()
            );

            var cumulativeMin = new Vec3(
                minDeltasPerTarget.Select(v => v.X < 0 ? v.X : 0).Sum(),
                minDeltasPerTarget.Select(v => v.Y < 0 ? v.Y : 0).Sum(),
                minDeltasPerTarget.Select(v => v.Z < 0 ? v.Z : 0).Sum()
            );

            return (cumulativeMax, cumulativeMin);
        }


        // Quantization for each target across all submeshes
        private (Vec4 scale, Vec4 offset) TargetwiseQuantizationZup(TargetAccessor[][] morphTargetsPerSubmesh, int targetIndex)
        {
            var max = new Vec3(float.MinValue, float.MinValue, float.MinValue);
            var min = new Vec3(float.MaxValue, float.MaxValue, float.MaxValue);

            foreach (var submesh in morphTargetsPerSubmesh)
            {
                var morphPositionDeltas = submesh[targetIndex]["POSITION"].AsVector3Array();

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

        #endregion

    }
}
