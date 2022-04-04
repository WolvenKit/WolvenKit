using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpGLTF.Schema2;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.CR2W;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.Common.Model.Arguments;

using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public bool ImportMorphTargets(FileInfo inGltfFile, Stream intargetStream, GltfImportArgs args, Stream outStream = null)
        {
            var cr2w = _wolvenkitFileService.ReadRed4File(intargetStream);
            if (cr2w == null || cr2w.RootChunk is not MorphTargetMesh blob || blob.Blob.Chunk is not rendRenderMorphTargetMeshBlob renderblob || renderblob.BaseBlob.Chunk is not rendRenderMeshBlob)
            {
                return false;
            }

            RawArmature newRig = null;
            {
                var hash = FNV1A64HashAlgorithm.HashString(blob.BaseMesh.DepotPath);
                var meshStream = new MemoryStream();
                foreach (var ar in args.Archives)
                {
                    if (ar.Files.ContainsKey(hash))
                    {
                        ExtractSingleToStream(ar, hash, meshStream);
                        break;
                    }
                }
                var meshCr2w = _wolvenkitFileService.ReadRed4File(meshStream);
                if (meshCr2w != null && meshCr2w.RootChunk is CMesh mesh && mesh.RenderResourceBlob.Chunk is rendRenderMeshBlob rendBlob)
                {
                    newRig = MeshTools.GetOrphanRig(mesh);
                }
            }

            var model = ModelRoot.Load(inGltfFile.FullName, new ReadSettings(args.validationMode));
            VerifyGLTF(model);

            var Meshes = new List<RawMeshContainer>();
            foreach (var node in model.LogicalNodes)
            {
                if (node.Mesh != null)
                {
                    Meshes.Add(GltfMeshToRawContainer(node));
                }
                else if (args.FillEmpty)
                {
                    Meshes.Add(CreateEmptyMesh(node.Name));
                }
            }
            Meshes = Meshes.OrderBy(o => o.name).ToList();

            var max = new Vec3(Single.MinValue, Single.MinValue, Single.MinValue);
            var min = new Vec3(Single.MaxValue, Single.MaxValue, Single.MaxValue);

            Meshes.ForEach(p => p.positions.ToList().ForEach(q => { max.X = Math.Max(q.X, max.X); max.Y = Math.Max(q.Y, max.Y); max.Z = Math.Max(q.Z, max.Z); }));
            Meshes.ForEach(p => p.positions.ToList().ForEach(q => { min.X = Math.Min(q.X, min.X); min.Y = Math.Min(q.Y, min.Y); min.Z = Math.Min(q.Z, min.Z); }));

            blob.BoundingBox.Min = new Vector4 { X = min.X, Y = min.Y, Z = min.Z, W = 1f };
            blob.BoundingBox.Max = new Vector4 { X = max.X, Y = max.Y, Z = max.Z, W = 1f };

            var QuantScale = new Vec4((max.X - min.X) / 2, (max.Y - min.Y) / 2, (max.Z - min.Z) / 2, 0);
            var QuantTrans = new Vec4((max.X + min.X) / 2, (max.Y + min.Y) / 2, (max.Z + min.Z) / 2, 1);


            RawArmature oldRig = null;
            if (model.LogicalSkins.Count > 0 && model.LogicalSkins[0].JointsCount > 0)
            {
                oldRig = new RawArmature
                {
                    BoneCount = model.LogicalSkins[0].JointsCount,
                    Names = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_=> model.LogicalSkins[0].GetJoint(_).Joint.Name).ToArray()
                };
            }

            MeshTools.UpdateMeshJoints(ref Meshes, newRig, oldRig);

            var expMeshes = Meshes.Select(_=> RawMeshToRE4Mesh(_, QuantScale, QuantTrans)).ToList();

            var meshBuffer = new MemoryStream();
            var meshesInfo = BufferWriter(expMeshes, ref meshBuffer);

            meshesInfo.quantScale = QuantScale;
            meshesInfo.quantTrans = QuantTrans;

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
            if (outStream != null)
            {
                ms.CopyTo(outStream);
            }
            else
            {
                intargetStream.SetLength(0);
                ms.CopyTo(intargetStream);
            }
            return true;
        }

        private (Vec4 scale, Vec4 offset) CalculateTargetQuant(ModelRoot model, int morphTargetId)
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
            var quantOffset = new Vec4(min.X, min.Y, min.Z, 1);

            return (quantScale, quantOffset);

        }

        private uint GetVertexCountInMorphTarget(ModelRoot model, int morphTargetId)
        {
            uint count = 0;
            for (var i = 0; i < model.LogicalMeshes.Count; i++)
            {
                count += (uint)model.LogicalMeshes[i].Primitives[0].GetMorphTargetAccessors(morphTargetId)["POSITION"].AsVector3Array().Where(l => l.X != 0 && l.Y != 0 && l.Z != 0).Count();
            }

            return count;
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
                blob.Header.TargetPositionDiffOffset[i].X = offset.X;
                blob.Header.TargetPositionDiffOffset[i].Y = offset.Y;
                blob.Header.TargetPositionDiffOffset[i].Z = offset.Z;
                blob.Header.TargetPositionDiffScale[i].X = scale.X;
                blob.Header.TargetPositionDiffScale[i].Y = scale.Y;
                blob.Header.TargetPositionDiffScale[i].Z = scale.Z;


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

                    blob.Header.NumVertexDiffsInEachChunk[i][subMeshId] = (uint)deltaCount;
                    blob.Header.NumVertexDiffsMappingInEachChunk[i][subMeshId] = (uint)deltaCount;
                    blob.Header.NumDiffs += (uint)deltaCount;
                }
            }
        }
    }
}
