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

                    // Mesh logic automatically construes morphtargets as
                    // garmentSupport. We don't want that. Can't be both.
                    /*
                    rawMesh.garmentMorph = Array.Empty<Vec3>();
                    rawMesh.garmentSupportCap = Array.Empty<Vec4>();
                    rawMesh.garmentSupportWeight = Array.Empty<Vec4>();
                    */

                    RawMeshes.Add(rawMesh);
                }
                else if (args.FillEmpty)
                {
                    RawMeshes.Add(CreateEmptyMesh(node.Name));
                }
            }

            RawMeshes = RawMeshes.OrderBy(o => o.name).ToList();

            // Conversion also switches us to RHCSZup for the
            // base mesh - the morphtargets remain LHCSYup for now
            var baseMax = new Vec3(float.MinValue, float.MinValue, float.MinValue);
            var baseMin = new Vec3(float.MaxValue, float.MaxValue, float.MaxValue);

            foreach (var rawMesh in RawMeshes)
            {
                ArgumentNullException.ThrowIfNull(rawMesh.positions);
                foreach (var rawPosition in rawMesh.positions.ToList())
                {
                    baseMax.X = Math.Max(rawPosition.X, baseMax.X);
                    baseMax.Y = Math.Max(rawPosition.Y, baseMax.Y);
                    baseMax.Z = Math.Max(rawPosition.Z, baseMax.Z);

                    baseMin.X = Math.Min(rawPosition.X, baseMin.X);
                    baseMin.Y = Math.Min(rawPosition.Y, baseMin.Y);
                    baseMin.Z = Math.Min(rawPosition.Z, baseMin.Z);
                }
            }

            // Should we really be ignoring the morphtarget dimensions here?
            //targetRoot.BoundingBox.Max = new Vector4 { X = 0.23732093f, Y = 0.130813986f, Z = 1.65285742f, W = 1f };
            //targetRoot.BoundingBox.Min = new Vector4 { X = -0.237320989f, Y = -0.180782944f, Z = -0.117004514f, W = 1f };

            targetRoot.BoundingBox.Min = new Vector4 { X = baseMin.X, Y = baseMin.Y, Z = baseMin.Z, W = 1f };
            targetRoot.BoundingBox.Max = new Vector4 { X = baseMax.X, Y = baseMax.Y, Z = baseMax.Z, W = 1f };

            // So this is a bit weird. The offset can use
            // Maybe it can't go outside the bounding box? 
            var baseQuantOffset = new Vec4((baseMax.X + baseMin.X) / 2, (baseMax.Y + baseMin.Y) / 2, (baseMax.Z + baseMin.Z) / 2, 0);

            var baseQuantScale = new Vec4(0.237320215f, 0.144603401f, 0.884930849f, 0f);
        

            //var baseQuantOffset = new Vec4(0f, -0.0346356034f, 0.767926455f, 1f);

            //var baseQuantScale = new Vec4((baseMax.X - baseMin.X) / 2, (baseMax.Y - baseMin.Y) / 2, (baseMax.Z - baseMin.Z) / 2, 0);
        

            //var baseQuantScale = new Vec4((baseMax.X - baseMin.X), (baseMax.Y - baseMin.Y), (baseMax.Z - baseMin.Z), 0);
            //var baseQuantOffset = new Vec4(baseMin.X, baseMin.Y, baseMin.Z, 1f);

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

        // Quantization reduces vertex data to the range of values in the model.
        private (Vec4 scale, Vec4 offset) CalculateQuantizationForTargetInZUp(ModelRoot model, int morphTargetId)
        {
            var logicalMesh = model.LogicalMeshes[0].Primitives[0];
            var morphTarget = logicalMesh.GetMorphTargetAccessors(morphTargetId);
            var morphVertices = morphTarget["POSITION"].AsVector3Array();

            var max = new Vec3(morphVertices[0].X, -morphVertices[0].Z, morphVertices[0].Y);
            var min = new Vec3(morphVertices[0].X, -morphVertices[0].Z, morphVertices[0].Y);

            for (var i = 0; i < model.LogicalMeshes.Count; i++)
            {
                morphVertices = model.LogicalMeshes[i].Primitives[0].GetMorphTargetAccessors(morphTargetId)["POSITION"].AsVector3Array();
                var maxX = morphVertices.Max(l => l.X);
                var maxY = morphVertices.Max(l => -l.Z);
                var maxZ = morphVertices.Max(l => l.Y);

                if (maxX > max.X)
                {
                    max.X = maxX;
                }

                if (maxY > max.Y)
                {
                    max.Y = maxY;
                }

                if (maxZ > max.Z)
                {
                    max.Z = maxZ;
                }

                var minX = morphVertices.Min(l => l.X);
                var minY = morphVertices.Min(l => -l.Z);
                var minZ = morphVertices.Min(l => l.Y);

                if (minX < min.X)
                {
                    min.X = minX;
                }

                if (minY < min.Y)
                {
                    min.Y = minY;
                }

                if (minZ < min.Z)
                {
                    min.Z = minZ;
                }
            }

            var quantScale = new Vec4(max.X - min.X, max.Y - min.Y, max.Z - min.Z, 0);
            var quantOffset = new Vec4(min.X, min.Y, min.Z, 0);

            return (quantScale, quantOffset);

        }

        private static uint GetNonzeroVertexPositionDiffCount(ModelRoot model, int morphTargetId)
        {
            uint count = 0;
            for (var i = 0; i < model.LogicalMeshes.Count; i++)
            {
                count += (uint)model.LogicalMeshes[i].Primitives[0].GetMorphTargetAccessors(morphTargetId)["POSITION"].AsVector3Array().Where(l => l.X != 0 && l.Y != 0 && l.Z != 0).Count();
            }

            return count;
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
                    var ignoredDiffsWithOnlyNormalOrTangent = 0;

                    for (var diffIndex = 0; diffIndex < positionDeltas.Count; diffIndex++)
                    {
                        var positionDelta = positionDeltas[diffIndex];
                        var normalDelta = normalDeltas[diffIndex];
                        var tangentDelta = tangentDeltas[diffIndex];

                        var hasPositionDelta = positionDelta.X != 0 || positionDelta.Y != 0 || positionDelta.Z != 0;
                        var hasNormalDelta = normalDelta.X != 0 || normalDelta.Y != 0 || normalDelta.Z != 0;
                        var hasTangentDelta = tangentDelta.X != 0 || tangentDelta.Y != 0 || tangentDelta.Z != 0;

                        // It seems like normal/tangent only should be applied too (consider a
                        // vertex that is rotated but not moved) but doing so seems to cause
                        // problems... may need to encode those specially, somehow?
                        if (!hasPositionDelta)
                        {
                            if (hasNormalDelta || hasTangentDelta)
                            {
                                ignoredDiffsWithOnlyNormalOrTangent += 1;
                            }
                            continue;
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

                    _loggerService.Debug($"Target {targetIndex} submesh {subMeshIndex} ({positionDeltas.Count} vertices): {actionableDiffCountInSubmesh} diffs applied ({ignoredDiffsWithOnlyNormalOrTangent} normal/tangent only diffs skipped).");
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
