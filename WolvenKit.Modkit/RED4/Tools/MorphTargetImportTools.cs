using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            var max = new Vec3(float.MinValue, float.MinValue, float.MinValue);
            var min = new Vec3(float.MaxValue, float.MaxValue, float.MaxValue);

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
            // Hardcoded from pwa
            //var baseQuantScale = new Vec4(0.237320215f, 0.144603401f, 0.884930849f, 0f);
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

            var diffsBuffer = new MemoryStream();
            var mappingsBuffer = new MemoryStream();
            var texbuffer = new MemoryStream();

            // Deserialize mappings buffer
            /*if (renderblob.MappingBuffer.IsSerialized)
            {
                intargetStream.Seek(cr2w.Buffers[mappingsBufferId].Offset, SeekOrigin.Begin);
                intargetStream.DecompressAndCopySegment(mappingsBuffer, cr2w.Buffers[mappingsBufferId].DiskSize, cr2w.Buffers[mappingsBufferId].MemSize);
            }*/

            // Zero out some values that will be set later
            renderblob.Header.NumDiffs = 0;

            for (var i = 0; i < renderblob.Header.TargetStartsInVertexDiffs.Count; i++)
            {
                renderblob.Header.TargetStartsInVertexDiffs[i] = 0;
            }

            for (var i = 0; i < renderblob.Header.TargetStartsInVertexDiffsMapping.Count; i++)
            {
                renderblob.Header.TargetStartsInVertexDiffsMapping[i] = 0;
            }

            SetTargets(cr2w, model, renderblob, diffsBuffer, mappingsBuffer);
            renderblob.DiffsBuffer.Buffer.SetBytes(diffsBuffer.ToArray());
            renderblob.MappingBuffer.Buffer.SetBytes(mappingsBuffer.ToArray());

            var ms = GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer);

            ms.Seek(0, SeekOrigin.Begin);
            //if (outStream != null)
            //{
            //    ms.CopyTo(outStream);
            //}
            //else
            {
                intargetStream.SetLength(0);
                ms.CopyTo(intargetStream);
            }
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

        private void SetTargets(CR2WFile cr2w, ModelRoot model, rendRenderMorphTargetMeshBlob blob, Stream diffsBuffer, Stream mappingsBuffer)
        {

            // Validate that all submeshes contain the same number of morph targets
            var morphTargetCount = model.LogicalMeshes[0].Primitives[0].MorphTargetsCount;
            if (model.LogicalMeshes.Any(l => l.Primitives[0].MorphTargetsCount != morphTargetCount))
            {
                throw new Exception("All submeshes must have the same number of morph targets.");
            }

            if (morphTargetCount == 0)
            {
                throw new Exception("Mesh contains no morph targets to import.");
            }

            // Set global headers for blob
            blob.Header.NumTargets = (uint)morphTargetCount;

            // Write buffer positions for all the morph targets
            for (var morphTarget = 0; morphTarget < morphTargetCount; morphTarget++)
            {
                blob.Header.TargetStartsInVertexDiffs[morphTarget] = (uint)morphTarget;
                blob.Header.TargetStartsInVertexDiffsMapping[morphTarget] = (uint)morphTarget;

                for (var i = 0; i < morphTarget; i++)
                {
                    var vertexCount = GetVertexCountInMorphTarget(model, i);
                    blob.Header.TargetStartsInVertexDiffs[morphTarget] += vertexCount - 1;
                    blob.Header.TargetStartsInVertexDiffsMapping[morphTarget] += vertexCount - 1;
                }
            }

            var diffsWriter = new BinaryWriter(diffsBuffer);
            var mappingsWriter = new BinaryWriter(mappingsBuffer);

            for (var i = 0; i < morphTargetCount; i++)
            {
                // Write scale and offsets
                var (scale, offset) = CalculateTargetQuant(model, i);

                var posOffset = blob.Header.TargetPositionDiffOffset[i];
                var posScale = blob.Header.TargetPositionDiffScale[i];

                ArgumentNullException.ThrowIfNull(posOffset);
                ArgumentNullException.ThrowIfNull(posScale);

                posOffset.X = offset.X;
                posOffset.Y = offset.Y;
                posOffset.Z = offset.Z;
                posScale.X = scale.X;
                posScale.Y = scale.Y;
                posScale.Z = scale.Z;


                for (var subMeshId = 0; subMeshId < model.LogicalMeshes.Count; subMeshId++)
                {
                    var logicalMesh = model.LogicalMeshes[subMeshId].Primitives[0];
                    var morphTarget = logicalMesh.GetMorphTargetAccessors(i);

                    if (!morphTarget.ContainsKey("TANGENT"))
                    {
                        throw new Exception($"Morph target {i} does not contain any tangents. Did you remember to export them?");
                    }

                    if (!morphTarget.ContainsKey("NORMAL"))
                    {
                        throw new Exception($"Morph target {i} does not contain any normals. Did you remember to export them?");
                    }

                    var vertices = morphTarget["POSITION"].AsVector3Array();
                    var normals = morphTarget["NORMAL"].AsVector3Array();
                    var tangents = morphTarget["TANGENT"].AsVector3Array();

                    var mappings = new List<ushort>();
                    var deltaCount = 0;

                    for (var x = 0; x < vertices.Count; x++)
                    {
                        var vertexDelta = vertices[x];
                        var normalsDelta = normals[x];
                        var tangentsDelta = tangents[x];

                        if (vertexDelta.X == 0 && vertexDelta.Y == 0 && vertexDelta.Z == 0)
                        {
                            continue;
                        }


                        // Mappings
                        mappings.Add((ushort)x);

                        deltaCount++;

                        var convertX = (vertexDelta.X - offset.X) / scale.X;
                        var convertY = (vertexDelta.Y - offset.Z) / scale.Z;
                        var convertZ = (vertexDelta.Z - -offset.Y) / scale.Y;

                        // Position
                        var output = Converters.Vec3ToU32(new TargetVec3(convertX, -convertZ, convertY), 1);

                        diffsWriter.Write(output);

                        // Normal
                        output = Converters.Vec4ToU32(new Vec4(normalsDelta.X, -normalsDelta.Z, normalsDelta.Y, 1f));
                        diffsWriter.Write(output);

                        // Tangent
                        output = Converters.Vec4ToU32(new Vec4(tangentsDelta.X, -tangentsDelta.Z, tangentsDelta.Y, 1f));
                        diffsWriter.Write(output);
                    }

                    // Write mappings
                    foreach (var mapping in mappings)
                    {
                        mappingsWriter.Write(mapping);
                    }

                    // Padding?
                    foreach (var mapping in mappings)
                    {
                        mappingsWriter.Write((ushort)0);
                    }

                    blob.Header.NumVertexDiffsInEachChunk[i].NotNull()[subMeshId] = (uint)deltaCount;
                    blob.Header.NumVertexDiffsMappingInEachChunk[i].NotNull()[subMeshId] = (uint)deltaCount;
                    blob.Header.NumDiffs += (uint)deltaCount;
                }
            }
        }
    }
}
