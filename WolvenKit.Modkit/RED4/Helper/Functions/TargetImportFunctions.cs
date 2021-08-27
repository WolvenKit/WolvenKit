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

namespace WolvenKit.Modkit.RED4
{
    using Vec4 = System.Numerics.Vector4;
    using Vec2 = System.Numerics.Vector2;
    using Vec3 = System.Numerics.Vector3;
    public partial class ModTools
    {

        public bool ImportTargetBaseMesh2(FileInfo inGltfFile, Stream intargetStream, List<Archive> archives, string modFolder, ValidationMode vmode = ValidationMode.Strict, Stream outStream = null)
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
            FileStream meshStream = new FileStream(baseMeshPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
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

            for (int i = 0; i < submeshCount; i++)
                SetTargets(cr2w, model, renderblob, diffsBuffer, mappingsBuffer, i);

            WriteTargetBuffer(cr2w, diffsBuffer, diffsBufferId);
            WriteTargetBuffer(cr2w, mappingsBuffer, mappingsBufferId);

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
            return ImportMesh(inGltfFile, meshStream, vmode);
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
            var vertices = morphTarget["POSITION"].AsVector3Array();

            var max = new Vec3(vertices[0].X, vertices[0].Y, vertices[0].Z);
            var min = new Vec3(vertices[0].X, vertices[0].Y, vertices[0].Z);

            for (int i = 0; i < model.LogicalMeshes.Count; i++)
            {
                vertices = model.LogicalMeshes[i].Primitives[0].GetMorphTargetAccessors(morphTargetId)["POSITION"].AsVector3Array();
                var maxX = vertices.Max(l => l.X);
                var maxY = vertices.Max(l => l.Y);
                var maxZ = vertices.Max(l => l.Z);

                if (maxX > max.X)
                    max.X = maxX;
                if (maxY > max.Y)
                    max.Y = maxY;
                if (maxZ > max.Z)
                    max.Z = maxZ;

                var minX = vertices.Min(l => l.X);
                var minY = vertices.Min(l => l.Y);
                var minZ = vertices.Min(l => l.Z);

                if (minX < min.X)
                    min.X = minX;
                if (minY < min.Y)
                    min.Y = minY;
                if (minZ < min.Z)
                    min.Z = minZ;
            }

            var quantScale = new Vec4((max.X - min.X), (max.Y - min.Y), (max.Z - min.Z), 0);
            var quantOffset = new Vec4((max.X + min.X - 1) / 2, (max.Y + min.Y - 1) / 2, (max.Z + min.Z - 1) / 2, 1);

            return (quantScale, quantOffset);

        }

        private void SetTargets(CR2WFile cr2w, ModelRoot model, rendRenderMorphTargetMeshBlob blob, Stream diffsBuffer, Stream mappingsBuffer, int subMeshId)
        {

            var logicalMesh = model.LogicalMeshes[subMeshId].Primitives[0];
            var morphTargetCount = model.LogicalMeshes[subMeshId].Primitives[0].MorphTargetsCount;

            // Set global headers for blob
            blob.Header.NumTargets.Value = (uint)morphTargetCount;
            
            var diffsWriter = new BinaryWriter(diffsBuffer);
            var mappingsWriter = new BinaryWriter(mappingsBuffer);

            for (int i = 0; i < morphTargetCount; i++)
            {
                var morphTarget = logicalMesh.GetMorphTargetAccessors(i);
                var vertices = morphTarget["POSITION"].AsVector3Array();
                var normals = morphTarget["NORMAL"].AsVector3Array();
                var tangents = morphTarget["TANGENT"].AsVector3Array();

                if (blob.Header.TargetStartsInVertexDiffs[i].Value == 0 && i != 0)
                    blob.Header.TargetStartsInVertexDiffs[i].Value = (uint)diffsBuffer.Position / 12;

                if (blob.Header.TargetStartsInVertexDiffsMapping[i].Value == 0 && i != 0)
                    blob.Header.TargetStartsInVertexDiffsMapping[i].Value = (uint)mappingsBuffer.Position / 4;

                // Write scale and offsets
                var quant = CalculateTargetQuant(model, i);
                blob.Header.TargetPositionDiffOffset[i].X.Value = quant.offset.X;
                blob.Header.TargetPositionDiffOffset[i].Y.Value = quant.offset.Y;
                blob.Header.TargetPositionDiffOffset[i].Z.Value = quant.offset.Z;
                blob.Header.TargetPositionDiffScale[i].X.Value = quant.scale.X;
                blob.Header.TargetPositionDiffScale[i].Y.Value = quant.scale.Y;
                blob.Header.TargetPositionDiffScale[i].Z.Value = quant.scale.Z;

                //var mappings = GetTargetMappings(i, subMeshId, blob, mappingsBuffer);
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

                    var convertX = (vertexDelta.X - blob.Header.TargetPositionDiffOffset[i].X.Value) / blob.Header.TargetPositionDiffScale[i].X.Value;
                    var convertY = (vertexDelta.Y - blob.Header.TargetPositionDiffOffset[i].Y.Value) / blob.Header.TargetPositionDiffScale[i].Y.Value;
                    var convertZ = (vertexDelta.Z - blob.Header.TargetPositionDiffOffset[i].Z.Value) / blob.Header.TargetPositionDiffScale[i].Z.Value;

                    // Position
                    var output = Converters.Vec3ToU32(new Vec3((float)convertX, -(float)convertZ, (float)convertY));
                    
                    diffsWriter.Write(output);

                    // Normal
                    output = Converters.Vec4ToU32(new Vec4(normalsDelta.X, -normalsDelta.Z, normalsDelta.Y, 1f));
                    diffsWriter.Write(output);

                    // Tangent
                    output = Converters.Vec4ToU32(new Vec4(tangentsDelta.X, -tangentsDelta.Z, tangentsDelta.Y, 0));
                    diffsWriter.Write(output);
                }

                // Write mappings
                foreach(var mapping in mappings)
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

        /*private List<ushort> GetTargetMappings(int mappingId, int submeshId, rendRenderMorphTargetMeshBlob blob, Stream mappingsBuffer)
        {
            mappingsBuffer.Position = blob.Header.TargetStartsInVertexDiffsMapping[mappingId].Value * 4;
            if (submeshId > 0)
            {
                for (int i = 0; i < submeshId; i++)
                    mappingsBuffer.Position += blob.Header.NumVertexDiffsMappingInEachChunk[mappingId][i].Value * 4;
            }

            ushort[] vertexMapping = new ushort[blob.Header.NumVertexDiffsInEachChunk[mappingId][submeshId].Value];
            var mappingsReader = new BinaryReader(mappingsBuffer);

            for (int i = 0; i < vertexMapping.Length; i++)
                vertexMapping[i] = mappingsReader.ReadUInt16();

            return vertexMapping.ToList();
        }*/

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
            
            
            var model = ModelRoot.Load(inGltfFile.FullName,new ReadSettings(vmode));

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
            return ImportMesh(inGltfFile, meshStream, vmode);
        }
    }
}
