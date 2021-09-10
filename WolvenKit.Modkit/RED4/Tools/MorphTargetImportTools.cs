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
using SharpGLTF.Validation;
using WolvenKit.Modkit.RED4;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Oodle;
using CP77.CR2W;

namespace WolvenKit.Modkit.RED4
{
    using Vec4 = System.Numerics.Vector4;
    using Vec2 = System.Numerics.Vector2;
    using Vec3 = System.Numerics.Vector3;
    public partial class ModTools
    {

        public bool ImportTargetBaseMesh(FileInfo inGltfFile, Stream intargetStream, List<Archive> archives, string modFolder, ValidationMode vmode = ValidationMode.Strict, Stream outStream = null)
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
            using FileStream meshStream = new FileStream(baseMeshPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
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

            var model = ModelRoot.Load(inGltfFile.FullName, new ReadSettings(vmode));
            VerifyGLTF(model);

            var submeshCount = model.LogicalMeshes.Count;

            if (submeshCount == 0)
                throw new Exception("No submeshes found in model file.");

            var renderblob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMorphTargetMeshBlob>().First();

            var diffsBufferId = renderblob.DiffsBuffer.Buffer.Value - 1;
            var mappingsBufferId = renderblob.MappingBuffer.Buffer.Value - 1;

            using MemoryStream diffsBuffer = new MemoryStream();
            using MemoryStream mappingsBuffer = new MemoryStream();

            // Deserialize mappings buffer
            /*if (renderblob.MappingBuffer.IsSerialized)
            {
                intargetStream.Seek(cr2w.Buffers[mappingsBufferId].Offset, SeekOrigin.Begin);
                intargetStream.DecompressAndCopySegment(mappingsBuffer, cr2w.Buffers[mappingsBufferId].DiskSize, cr2w.Buffers[mappingsBufferId].MemSize);
            }*/

            // Zero out some values that will be set later
            renderblob.Header.NumDiffs.Value = 0;
            for (int i = 0; i < renderblob.Header.TargetStartsInVertexDiffs.Count; i++)
                renderblob.Header.TargetStartsInVertexDiffs[i].Value = 0;

            for (int i = 0; i < renderblob.Header.TargetStartsInVertexDiffsMapping.Count; i++)
                renderblob.Header.TargetStartsInVertexDiffsMapping[i].Value = 0;

            SetTargets(cr2w, model, renderblob, diffsBuffer, mappingsBuffer);
            WriteTargetBuffer(cr2w, diffsBuffer, diffsBufferId);
            WriteTargetBuffer(cr2w, mappingsBuffer, mappingsBufferId);

            VerifyGLTF(model);
            List<RawMeshContainer> Meshes = new List<RawMeshContainer>();

            for (int i = 0; i < model.LogicalMeshes.Count; i++)
            {
                Meshes.Add(GltfMeshToRawContainer(model.LogicalMeshes[i]));
            }
            Vec3 max = new Vec3(Meshes[0].positions[0].X, Meshes[0].positions[0].Y, Meshes[0].positions[0].Z);
            Vec3 min = new Vec3(Meshes[0].positions[0].X, Meshes[0].positions[0].Y, Meshes[0].positions[0].Z);

            for (int e = 0; e < Meshes.Count; e++)
                for (int i = 0; i < Meshes[e].positions.Length; i++)
                {
                    if (Meshes[e].positions[i].X >= max.X)
                        max.X = Meshes[e].positions[i].X;
                    if (Meshes[e].positions[i].Y >= max.Y)
                        max.Y = Meshes[e].positions[i].Y;
                    if (Meshes[e].positions[i].Z >= max.Z)
                        max.Z = Meshes[e].positions[i].Z;
                    if (Meshes[e].positions[i].X <= min.X)
                        min.X = Meshes[e].positions[i].X;
                    if (Meshes[e].positions[i].Y <= min.Y)
                        min.Y = Meshes[e].positions[i].Y;
                    if (Meshes[e].positions[i].Z <= min.Z)
                        min.Z = Meshes[e].positions[i].Z;
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

            RawArmature newRig = MeshTools.GetOrphanRig(cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First());
            RawArmature oldRig = null;
            if (model.LogicalSkins.Count != 0)
            {
                oldRig = new RawArmature();
                oldRig.Names = new string[model.LogicalSkins[0].JointsCount];

                for (int i = 0; i < model.LogicalSkins[0].JointsCount; i++)
                {
                    oldRig.Names[i] = model.LogicalSkins[0].GetJoint(i).Joint.Name;
                }
            }
            MeshTools.UpdateMeshJoints(ref Meshes, newRig, oldRig);

            List<Re4MeshContainer> expMeshes = new List<Re4MeshContainer>();

            for (int i = 0; i < Meshes.Count; i++)
                expMeshes.Add(RawMeshToRE4Mesh(Meshes[i], QuantScale, QuantTrans));

            MemoryStream meshBuffer = new MemoryStream();
            MeshesInfo meshesInfo = BufferWriter(expMeshes, ref meshBuffer);

            meshesInfo.quantScale = QuantScale;
            meshesInfo.quantTrans = QuantTrans;

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
            return ImportMesh(inGltfFile, meshStream, archives, vmode);
        }

        private void WriteTargetBuffer(CR2WFile cr2w, MemoryStream inBuffer, int bufferId)
        {
            var compressedDiffs = new MemoryStream();
            using var diffsWriter = new BinaryWriter(compressedDiffs);
            var bufferBytes = inBuffer.ToArray();
            var (zsize, crc) = diffsWriter.CompressAndWrite(bufferBytes);

            var buffer = cr2w.Buffers[bufferId];
            buffer.DiskSize = zsize;
            buffer.Crc32 = crc;
            buffer.MemSize = (uint)bufferBytes.Length;

            var offset = buffer.Offset;
            buffer.Offset = 0;
            buffer.ReadData(new BinaryReader(compressedDiffs));
            //buffer.Offset = offset;
        }

        private (Vec4 scale, Vec4 offset) CalculateTargetQuant(ModelRoot model, int morphTargetId)
        {
            var logicalMesh = model.LogicalMeshes[0].Primitives[0];
            var morphTarget = logicalMesh.GetMorphTargetAccessors(morphTargetId);
            var morphVertices = morphTarget["POSITION"].AsVector3Array();
            
            var max = new Vec3(morphVertices[0].X, -morphVertices[0].Z, morphVertices[0].Y);
            var min = new Vec3(morphVertices[0].X, -morphVertices[0].Z, morphVertices[0].Y);

            for (int i = 0; i < model.LogicalMeshes.Count; i++)
            {
                morphVertices = model.LogicalMeshes[i].Primitives[0].GetMorphTargetAccessors(morphTargetId)["POSITION"].AsVector3Array();
                var maxX = morphVertices.Max(l => l.X);
                var maxY = morphVertices.Max(l => -l.Z);
                var maxZ = morphVertices.Max(l => l.Y);

                if (maxX > max.X)
                    max.X = maxX;
                if (maxY > max.Y)
                    max.Y = maxY;
                if (maxZ > max.Z)
                    max.Z = maxZ;

                var minX = morphVertices.Min(l => l.X);
                var minY = morphVertices.Min(l => -l.Z);
                var minZ = morphVertices.Min(l => l.Y);

                if (minX < min.X)
                    min.X = minX;
                if (minY < min.Y)
                    min.Y = minY;
                if (minZ < min.Z)
                    min.Z = minZ;
            }

            var quantScale = new Vec4((max.X - min.X), (max.Y - min.Y), (max.Z - min.Z), 0);
            var quantOffset = new Vec4(min.X, min.Y, min.Z, 1);

            return (quantScale, quantOffset);

        }

        private uint GetVertexCountInMorphTarget(ModelRoot model, int morphTargetId)
        {
            uint count = 0;
            for (int i = 0; i < model.LogicalMeshes.Count; i++)
            {
                count += (uint)model.LogicalMeshes[i].Primitives[0].GetMorphTargetAccessors(morphTargetId)["POSITION"].AsVector3Array().Where(l => l.X != 0 && l.Y != 0 && l.Z != 0).Count();
            }

            return count;
        }

        private void SetTargets(CR2WFile cr2w, ModelRoot model, rendRenderMorphTargetMeshBlob blob, Stream diffsBuffer, Stream mappingsBuffer)
        {

            // Validate that all submeshes contain the same number of morph targets
            int morphTargetCount = model.LogicalMeshes[0].Primitives[0].MorphTargetsCount;
            if (model.LogicalMeshes.Any(l => l.Primitives[0].MorphTargetsCount != morphTargetCount))
                throw new Exception("All submeshes must have the same number of morph targets.");

            if (morphTargetCount == 0)
                throw new Exception("Mesh contains no morph targets to import.");

            // Set global headers for blob
            blob.Header.NumTargets.Value = (uint)morphTargetCount;

            // Write buffer positions for all the morph targets
            for (int morphTarget = 0; morphTarget < morphTargetCount; morphTarget++)
            {
                blob.Header.TargetStartsInVertexDiffs[morphTarget].Value = (uint)morphTarget;
                blob.Header.TargetStartsInVertexDiffsMapping[morphTarget].Value = (uint)morphTarget;

                for (int i = 0; i < morphTarget; i++)
                {
                    var vertexCount = GetVertexCountInMorphTarget(model, i);
                    blob.Header.TargetStartsInVertexDiffs[morphTarget].Value += vertexCount - 1;
                    blob.Header.TargetStartsInVertexDiffsMapping[morphTarget].Value += vertexCount - 1;
                }
            }

            var diffsWriter = new BinaryWriter(diffsBuffer);
            var mappingsWriter = new BinaryWriter(mappingsBuffer);

            for (int i = 0; i < morphTargetCount; i++)
            {

                // Write scale and offsets
                var quant = CalculateTargetQuant(model, i);
                blob.Header.TargetPositionDiffOffset[i].X.Value = quant.offset.X;
                blob.Header.TargetPositionDiffOffset[i].Y.Value = quant.offset.Y;
                blob.Header.TargetPositionDiffOffset[i].Z.Value = quant.offset.Z;
                blob.Header.TargetPositionDiffScale[i].X.Value = quant.scale.X;
                blob.Header.TargetPositionDiffScale[i].Y.Value = quant.scale.Y;
                blob.Header.TargetPositionDiffScale[i].Z.Value = quant.scale.Z;


                for (int subMeshId = 0; subMeshId < model.LogicalMeshes.Count; subMeshId++)
                {
                    var logicalMesh = model.LogicalMeshes[subMeshId].Primitives[0];
                    var morphTarget = logicalMesh.GetMorphTargetAccessors(i);

                    if (!morphTarget.ContainsKey("TANGENT"))
                        throw new Exception($"Morph target {i} does not contain any tangents. Did you remember to export them?");

                    if (!morphTarget.ContainsKey("NORMAL"))
                        throw new Exception($"Morph target {i} does not contain any normals. Did you remember to export them?");

                    var vertices = morphTarget["POSITION"].AsVector3Array();
                    var normals = morphTarget["NORMAL"].AsVector3Array();
                    var tangents = morphTarget["TANGENT"].AsVector3Array();

                    var mappings = new List<ushort>();
                    int deltaCount = 0;

                    for (int x = 0; x < vertices.Count; x++)
                    {
                        var vertexDelta = vertices[x];
                        var normalsDelta = normals[x];
                        var tangentsDelta = tangents[x];

                        if (vertexDelta.X == 0 && vertexDelta.Y == 0 && vertexDelta.Z == 0)
                            continue;


                        // Mappings
                        mappings.Add((ushort)x);

                        deltaCount++;

                        var convertX = (vertexDelta.X - quant.offset.X) / quant.scale.X;
                        var convertY = (vertexDelta.Y - quant.offset.Z) / quant.scale.Z;
                        var convertZ = (vertexDelta.Z - -quant.offset.Y) / quant.scale.Y;

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

                    blob.Header.NumVertexDiffsInEachChunk[i][subMeshId].Value = (uint)deltaCount;
                    blob.Header.NumVertexDiffsMappingInEachChunk[i][subMeshId].Value = (uint)deltaCount;
                    blob.Header.NumDiffs.Value += (uint)deltaCount;
                }
            }
        }        
    }
}
