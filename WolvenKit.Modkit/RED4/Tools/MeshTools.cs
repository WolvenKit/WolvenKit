using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using SharpGLTF.Scenes;
using SharpGLTF.Schema2;
using WolvenKit.Common;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using SharpGLTF.Validation;

namespace CP77.CR2W
{
    using Vec2 = System.Numerics.Vector2;
    using Vec3 = System.Numerics.Vector3;
    using Vec4 = System.Numerics.Vector4;

    public class MeshTools
    {
        private readonly Red4ParserService _red4ParserService;

        public MeshTools(Red4ParserService red4ParserService)
        {
            _red4ParserService = red4ParserService;
        }
        public bool ExportMeshPreviewer(Stream meshStream, FileInfo outFile)
        {
            var cr2w = _red4ParserService.TryReadRED4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            var cachedFiles = Directory.GetFiles(outFile.DirectoryName);
            if (cachedFiles.Length > 5)
            {
                foreach (var f in cachedFiles)
                {
                    try
                    {
                        File.Delete(f);
                    }
                    catch
                    {
                    }
                }
            }

            var rendblob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First();

            var rendbuffer = cr2w.Buffers[rendblob.RenderBuffer.Buffer.Value - 1];
            meshStream.Seek(rendbuffer.Offset, SeekOrigin.Begin);
            var ms = new MemoryStream();
            meshStream.DecompressAndCopySegment(ms, rendbuffer.DiskSize, rendbuffer.MemSize);

            var meshesinfo = GetMeshesinfo(rendblob);

            var expMeshes = ContainRawMesh(ms, meshesinfo, true);

            ModelRoot model = RawMeshesToMinimalGLTF(expMeshes);

            model.SaveGLB(outFile.FullName);

            return true;
        }
        public bool ExportMesh(Stream meshStream, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.Strict)
        {
            var cr2w = _red4ParserService.TryReadRED4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any())
            {
                return false;
            }

            if (!cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return WriteFakeMeshToFile();
            }

            var rendblob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First();

            RawArmature Rig = GetOrphanRig(rendblob);

            var rendbuffer = cr2w.Buffers[rendblob.RenderBuffer.Buffer.Value - 1];
            meshStream.Seek(rendbuffer.Offset, SeekOrigin.Begin);
            var ms = new MemoryStream();
            meshStream.DecompressAndCopySegment(ms, rendbuffer.DiskSize, rendbuffer.MemSize);

            var meshesinfo = GetMeshesinfo(rendblob);

            List<RawMeshContainer> expMeshes = ContainRawMesh(ms, meshesinfo, LodFilter);
            UpdateSkinningParamCloth(ref expMeshes, meshStream, cr2w);

            ModelRoot model = RawMeshesToGLTF(expMeshes, Rig);

            WriteMeshToFile();

            meshStream.Dispose();
            meshStream.Close();

            return true;

            bool WriteFakeMeshToFile()
            {
                if (WolvenTesting.IsTesting)
                {
                    return true;
                }
                if (isGLBinary)
                {
                    ModelRoot.CreateModel().SaveGLB(outfile.FullName);
                }
                else
                {
                    ModelRoot.CreateModel().SaveGLTF(outfile.FullName);
                }

                return true;
            }

            void WriteMeshToFile()
            {
                if (WolvenTesting.IsTesting)
                {
                    return;
                }

                if (isGLBinary)
                {
                    model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
                }
                else
                {
                    model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
                }
            }
        }
        public bool ExportMeshWithoutRig(Stream meshStream, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.Strict)
        {
            var cr2w = _red4ParserService.TryReadRED4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any())
            {
                return false;
            }

            if (!cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            var rendblob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First();
            var rendbuffer = cr2w.Buffers[rendblob.RenderBuffer.Buffer.Value - 1];
            meshStream.Seek(rendbuffer.Offset, SeekOrigin.Begin);
            var ms = new MemoryStream();
            meshStream.DecompressAndCopySegment(ms, rendbuffer.DiskSize, rendbuffer.MemSize);

            var meshesinfo = GetMeshesinfo(rendblob);

            List<RawMeshContainer> expMeshes = ContainRawMesh(ms, meshesinfo, LodFilter);

            ModelRoot model = RawMeshesToGLTF(expMeshes, null);

            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            meshStream.Dispose();
            meshStream.Close();
            return true;
        }
        public bool ExportMultiMeshWithoutRig(List<Stream> meshStreamS, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.Strict)
        {
            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            for (int m = 0; m < meshStreamS.Count; m++)
            {
                var cr2w = _red4ParserService.TryReadRED4File(meshStreamS[m]);
                if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
                    continue;

                var rendblob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First();
                var rendbuffer = cr2w.Buffers[rendblob.RenderBuffer.Buffer.Value - 1];
                meshStreamS[m].Seek(rendbuffer.Offset, SeekOrigin.Begin);
                var ms = new MemoryStream();
                meshStreamS[m].DecompressAndCopySegment(ms, rendbuffer.DiskSize, rendbuffer.MemSize);

                var meshesinfo = GetMeshesinfo(rendblob);

                var Meshes = ContainRawMesh(ms, meshesinfo, LodFilter);
                for (int i = 0; i < Meshes.Count; i++)
                    Meshes[i].name = m + "_" + Meshes[i].name;
                expMeshes.AddRange(Meshes);
            }

            ModelRoot model = RawMeshesToGLTF(expMeshes, null);
            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            for (int i = 0; i < meshStreamS.Count; i++)
            {
                meshStreamS[i].Dispose();
                meshStreamS[i].Close();
            }

            return true;
        }
        public bool ExportMeshWithRig(Stream meshStream, Stream rigStream, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.Strict)
        {
            var cr2w = _red4ParserService.TryReadRED4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            var rendblob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First();
            var rendbuffer = cr2w.Buffers[rendblob.RenderBuffer.Buffer.Value - 1];
            meshStream.Seek(rendbuffer.Offset, SeekOrigin.Begin);
            var ms = new MemoryStream();
            meshStream.DecompressAndCopySegment(ms, rendbuffer.DiskSize, rendbuffer.MemSize);

            var meshesinfo = GetMeshesinfo(rendblob);

            List<RawMeshContainer> expMeshes = ContainRawMesh(ms, meshesinfo, LodFilter);
            UpdateSkinningParamCloth(ref expMeshes, meshStream, cr2w);

            RawArmature meshRig = GetOrphanRig(rendblob);
            RawArmature Rig = RIG.ProcessRig(_red4ParserService.TryReadRED4File(rigStream));

            UpdateMeshJoints(ref expMeshes, Rig, meshRig);

            ModelRoot model = RawMeshesToGLTF(expMeshes, Rig);

            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            meshStream.Dispose();
            meshStream.Close();
            rigStream.Dispose();
            rigStream.Close();

            return true;
        }
        public bool ExportMultiMeshWithRig(List<Stream> meshStreamS, List<Stream> rigStreamS, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true, ValidationMode vmode = ValidationMode.Strict)
        {
            List<RawArmature> Rigs = new List<RawArmature>();
            for (int r = 0; r < rigStreamS.Count; r++)
            {
                RawArmature Rig = RIG.ProcessRig(_red4ParserService.TryReadRED4File(rigStreamS[r]));
                Rigs.Add(Rig);
            }
            RawArmature expRig = RIG.CombineRigs(Rigs);

            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            for (int m = 0; m < meshStreamS.Count; m++)
            {
                var cr2w = _red4ParserService.TryReadRED4File(meshStreamS[m]);
                if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
                {
                    continue;
                }

                var rendblob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First();
                var rendbuffer = cr2w.Buffers[rendblob.RenderBuffer.Buffer.Value - 1];
                meshStreamS[m].Seek(rendbuffer.Offset, SeekOrigin.Begin);
                var ms = new MemoryStream();
                meshStreamS[m].DecompressAndCopySegment(ms, rendbuffer.DiskSize, rendbuffer.MemSize);

                var meshesinfo = GetMeshesinfo(rendblob);

                List<RawMeshContainer> Meshes = ContainRawMesh(ms, meshesinfo, LodFilter);
                UpdateSkinningParamCloth(ref Meshes, meshStreamS[m], cr2w);

                RawArmature meshRig = GetOrphanRig(rendblob);

                UpdateMeshJoints(ref expMeshes, expRig, meshRig);

                expMeshes.AddRange(Meshes);
            }
            ModelRoot model = RawMeshesToGLTF(expMeshes, expRig);
            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            for (int i = 0; i < meshStreamS.Count; i++)
            {
                meshStreamS[i].Dispose();
                meshStreamS[i].Close();
            }
            for (int i = 0; i < rigStreamS.Count; i++)
            {
                rigStreamS[i].Dispose();
                rigStreamS[i].Close();
            }
            return true;
        }
        public static MeshesInfo GetMeshesinfo(rendRenderMeshBlob rendmeshblob)
        {
            MeshesInfo meshesInfo = new MeshesInfo(rendmeshblob.Header.RenderChunkInfos.Count);
            Vector4 redquantScale = rendmeshblob.Header.QuantizationScale;
            Vector4 redquantTrans = rendmeshblob.Header.QuantizationOffset;

            meshesInfo.quantScale = new Vec4(redquantScale.X.Value, redquantScale.Y.Value, redquantScale.Z.Value, redquantScale.W.Value);
            meshesInfo.quantTrans = new Vec4(redquantTrans.X.Value, redquantTrans.Y.Value, redquantTrans.Z.Value, redquantTrans.W.Value);

            meshesInfo.vertBufferSize = rendmeshblob.Header.VertexBufferSize.Value;
            meshesInfo.indexBufferOffset = rendmeshblob.Header.IndexBufferOffset.Value;
            meshesInfo.indexBufferSize = rendmeshblob.Header.IndexBufferSize.Value;

            for (int i = 0; i < meshesInfo.meshCount; i++)
            {
                meshesInfo.vertCounts[i] = rendmeshblob.Header.RenderChunkInfos[i].NumVertices.Value;
                meshesInfo.indCounts[i] = rendmeshblob.Header.RenderChunkInfos[i].NumIndices.Value;
                meshesInfo.posnOffsets[i] = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[0].Value;
                meshesInfo.unknownOffsets[i] = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[4].Value;

                var cv = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices;
                for (int e = 0; e < cv.VertexLayout.Elements.Count; e++)
                {
                    if (cv.VertexLayout.Elements[e].Usage.EnumValueList[0] == "PS_Normal")
                    {
                        meshesInfo.normalOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex.Value].Value;
                    }
                    if (cv.VertexLayout.Elements[e].Usage.EnumValueList[0] == "PS_Tangent")
                    {
                        meshesInfo.tangentOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex.Value].Value;
                    }
                    if (cv.VertexLayout.Elements[e].Usage.EnumValueList[0] == "PS_Color")
                    {
                        meshesInfo.colorOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex.Value].Value;
                    }
                    if (cv.VertexLayout.Elements[e].Usage.EnumValueList[0] == "PS_TexCoord")
                    {
                        if (meshesInfo.tex0Offsets[i] == 0)
                            meshesInfo.tex0Offsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex.Value].Value;
                        else
                            meshesInfo.tex1Offsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex.Value].Value;
                    }
                }

                if (rendmeshblob.Header.RenderChunkInfos[i].ChunkIndices.TeOffset == null)
                {
                    meshesInfo.indicesOffsets[i] = rendmeshblob.Header.IndexBufferOffset.Value;
                }
                else
                {
                    meshesInfo.indicesOffsets[i] = rendmeshblob.Header.IndexBufferOffset.Value + rendmeshblob.Header.RenderChunkInfos[i].ChunkIndices.TeOffset.Value;
                }
                meshesInfo.vpStrides[i] = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.SlotStrides[0].Value;
                meshesInfo.LODLvl[i] = rendmeshblob.Header.RenderChunkInfos[i].LodMask.Value;
            }

            int count = 0;
            UInt32 counter = 0;
            string checker = string.Empty;
            // getting number of weights for the meshes
            for (int i = 0; i < meshesInfo.meshCount; i++)
            {
                count = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements.Count;
                counter = 0;
                for (int e = 0; e < count; e++)
                {
                    checker = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].Usage.EnumValueList[0];
                    if (checker == "PS_SkinIndices")
                        counter++;
                }
                meshesInfo.weightCounts[i] = counter * 4;
            }

            for (int i = 0; i < meshesInfo.meshCount; i++)
            {
                meshesInfo.garmentSupportExists[i] = false;
                count = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements.Count;

                for (int e = 0; e < count; e++)
                {
                    checker = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].Usage.EnumValueList[0];
                    if (checker == "PS_ExtraData")
                    {
                        if (rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].StreamIndex.Value == 0)
                            meshesInfo.garmentSupportExists[i] = true;
                    }
                }
                if(!rendmeshblob.cr2w.Chunks.Select(_=>_.Data).OfType<meshMeshParamGarmentSupport>().Any())
                {
                    meshesInfo.garmentSupportExists[i] = false;
                }
            }

            meshesInfo.appearances = new Dictionary<string, string[]>();
            var apps = rendmeshblob.cr2w.Chunks.Select(_ => _.Data).OfType<meshMeshAppearance>().ToList();
            for (int i = 0; i < apps.Count; i++)
            {
                string[] materialNames = new string[apps[i].ChunkMaterials.Count];
                for (int e = 0; e < apps[i].ChunkMaterials.Count; e++)
                {
                    materialNames[e] = apps[i].ChunkMaterials[e].Value;
                }
                meshesInfo.appearances.Add(apps[i].Name.Value, materialNames);
            }

            return meshesInfo;
        }
        public static List<RawMeshContainer> ContainRawMesh(MemoryStream gfs, MeshesInfo info, bool LODFilter)
        {
            BinaryReader gbr = new BinaryReader(gfs);

            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            for (int index = 0; index < info.meshCount; index++)
            {
                if (info.LODLvl[index] != 1 && LODFilter)
                    continue;

                RawMeshContainer meshContainer = new RawMeshContainer();

                // getting positions
                meshContainer.positions = new Vec3[info.vertCounts[index]];
                for (int i = 0; i < info.vertCounts[index]; i++)
                {
                    gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index];

                    float x = (gbr.ReadInt16() / 32767f) * info.quantScale.X + info.quantTrans.X;
                    float y = (gbr.ReadInt16() / 32767f) * info.quantScale.Y + info.quantTrans.Y;
                    float z = (gbr.ReadInt16() / 32767f) * info.quantScale.Z + info.quantTrans.Z;

                    // Z up to Y up and LHCS to RHCS
                    meshContainer.positions[i] = new Vec3(x, z, -y);
                }

                // getting uvcoordinates0 from half floats
                meshContainer.texCoords0 = new Vec2[0];
                if (info.tex0Offsets[index] != 0)
                {
                    meshContainer.texCoords0 = new Vec2[info.vertCounts[index]];
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.tex0Offsets[index] + i * 4;
                        meshContainer.texCoords0[i] = new Vec2(Converters.hfconvert(gbr.ReadUInt16()), Converters.hfconvert(gbr.ReadUInt16()));
                    }
                }

                // getting float normals from 10bits
                meshContainer.normals = new Vec3[0];
                UInt32 invalidNormalsCount = 0;
                if (info.normalOffsets[index] != 0)
                {
                    meshContainer.normals = new Vec3[info.vertCounts[index]];

                    UInt32 stride = 4;
                    if (info.tangentOffsets[index] != 0)
                        stride += 4;
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.normalOffsets[index] + stride * i;
                        uint read = gbr.ReadUInt32();
                        Vec4 vec = Converters.TenBitShifted(read);

                        // Z up to Y up and LHCS to RHCS
                        meshContainer.normals[i] = new Vec3(vec.X, vec.Z, -vec.Y);
                        meshContainer.normals[i] = Vec3.Normalize(meshContainer.normals[i]);
                        if (read == 0x5FF7FDFF)
                        {
                            invalidNormalsCount++;
                        }
                    }
                }

                // getting float tangents from 10bits
                meshContainer.tangents = new Vec4[0];
                UInt32 invalidTangentsCount = 0;
                if (info.tangentOffsets[index] != 0)
                {
                    meshContainer.tangents = new Vec4[info.vertCounts[index]];

                    UInt32 stride = 4;
                    UInt32 off = 0;
                    if (info.normalOffsets[index] != 0)
                    {
                        off = 4;
                        stride += 4;
                    }
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.tangentOffsets[index] + stride * i + off;
                        uint read = gbr.ReadUInt32();
                        Vec4 vec0 = Converters.TenBitShifted(read);

                        // Z up to Y up and LHCS to RHCS
                        Vec3 vec1 = Vec3.Normalize(new Vec3(vec0.X, vec0.Z, -vec0.Y));
                        meshContainer.tangents[i] = new Vec4(vec1.X, vec1.Y, vec1.Z, 1f);
                        if (read == 0)
                        {
                            invalidTangentsCount++;
                        }
                    }
                }
                if (invalidNormalsCount > (info.vertCounts[index] / 2))
                {
                    meshContainer.normals = new Vec3[0];
                }
                if (invalidTangentsCount > (info.vertCounts[index] / 2))
                {
                    meshContainer.tangents = new Vec4[0];
                }

                // getting uvcoordinates1 from half floats
                meshContainer.texCoords1 = new Vec2[0];
                if (info.tex1Offsets[index] != 0)
                {
                    meshContainer.texCoords1 = new Vec2[info.vertCounts[index]];

                    UInt32 stride = 4;
                    UInt32 off = 0;
                    if (info.colorOffsets[index] != 0)
                    {
                        off = 4;
                        stride += 4;
                    }

                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.tex1Offsets[index] + i * stride + off;

                        meshContainer.texCoords1[i] = new Vec2(Converters.hfconvert(gbr.ReadUInt16()), Converters.hfconvert(gbr.ReadUInt16()));
                    }
                }

                // getting colors from Byte
                meshContainer.colors0 = new Vec4[0];
                if (info.colorOffsets[index] != 0)
                {
                    meshContainer.colors0 = new Vec4[info.vertCounts[index]];

                    UInt32 stride = 4;
                    if (info.tex1Offsets[index] != 0)
                        stride += 4;

                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.colorOffsets[index] + i * stride;
                        meshContainer.colors0[i] = new Vec4(gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f);
                    }
                }

                // getting bone indices
                meshContainer.boneindices = new ushort[info.vertCounts[index], info.weightCounts[index]];
                for (int i = 0; i < info.vertCounts[index]; i++)
                {
                    gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index] + 8;
                    for (int e = 0; e < info.weightCounts[index]; e++)
                    {
                        meshContainer.boneindices[i, e] = gbr.ReadByte();
                    }
                }

                // getting weights
                meshContainer.weightCount = info.weightCounts[index];
                meshContainer.weights = new float[info.vertCounts[index], info.weightCounts[index]];
                for (int i = 0; i < info.vertCounts[index]; i++)
                {
                    float sum = 0;
                    gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index] + 8 + meshContainer.weightCount;
                    for (int e = 0; e < meshContainer.weightCount; e++)
                    {
                        meshContainer.weights[i, e] = gbr.ReadByte() / 255f;
                        sum += meshContainer.weights[i, e];
                    }
                    if (sum == 0 && meshContainer.weightCount > 0)
                    {
                        meshContainer.boneindices[i, 0] = 0;
                        meshContainer.weights[i, 0] = 1f;
                        sum = 1;
                    }
                    for (int e = 0; e < meshContainer.weightCount; e++)
                    {
                        meshContainer.weights[i, e] *= 1f / sum;
                    }
                }

                // getting garment morphs
                meshContainer.garmentMorph = new Vec3[0];
                if (info.garmentSupportExists[index])
                {
                    meshContainer.garmentMorph = new Vec3[info.vertCounts[index]];
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.posnOffsets[index] + i * info.vpStrides[index] + 8 + 2 * meshContainer.weightCount;
                        float x = Converters.hfconvert(gbr.ReadUInt16());
                        float y = Converters.hfconvert(gbr.ReadUInt16());
                        float z = Converters.hfconvert(gbr.ReadUInt16());
                        meshContainer.garmentMorph[i] = new Vec3(x, z, -y);
                    }
                }

                // getting uint16 face indices
                meshContainer.indices = new uint[info.indCounts[index]];
                gfs.Position = info.indicesOffsets[index];
                for (int i = 0; i < info.indCounts[index]; i++)
                {
                    meshContainer.indices[i] = gbr.ReadUInt16();
                }

                meshContainer.name = "submesh_" + Convert.ToString(index).PadLeft(2, '0') + "_LOD_" + info.LODLvl[index];

                meshContainer.materialNames = new string[info.appearances.Count];
                var apps = info.appearances.Keys.ToList();
                for (int e = 0; e < apps.Count; e++)
                {
                    meshContainer.materialNames[e] = info.appearances[apps[e]][index];
                }

                meshContainer.colors1 = new Vec4[0];
                expMeshes.Add(meshContainer);
            }
            return expMeshes;
        }
        public static void UpdateMeshJoints(ref List<RawMeshContainer> Meshes, RawArmature newRig, RawArmature oldRig)
        {
            // updating mesh bone indices
            if(newRig != null && oldRig != null)
            {
                for (int i = 0; i < Meshes.Count; i++)
                {
                    for (int e = 0; e < Meshes[i].positions.Length; e++)
                    {
                        for (int eye = 0; eye < Meshes[i].weightCount; eye++)
                        {
                            if(Meshes[i].boneindices[e, eye] >= oldRig.BoneCount && Meshes[i].weights[e, eye] == 0)
                            {
                                Meshes[i].boneindices[e, eye] = 0;
                            }
                            bool found = false;
                            for (UInt16 r = 0; r < newRig.BoneCount; r++)
                            {
                                if (newRig.Names[r] == oldRig.Names[Meshes[i].boneindices[e, eye]])
                                {
                                    Meshes[i].boneindices[e, eye] = r;
                                    found = true;
                                    break;
                                }
                            }
                            if (!found)
                            {
                                throw new Exception($"Bone: {oldRig.Names[Meshes[i].boneindices[e, eye]]} not present in export Rig(s)/Import Mesh");
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < Meshes.Count; i++)
                {
                    for (int e = 0; e < Meshes[i].weightCount; e++)
                    {
                        Meshes[i].weightCount = 0;
                    }
                }
            }
        }
        public static ModelRoot RawMeshesToGLTF(List<RawMeshContainer> meshes, RawArmature Rig)
        {
            var model = ModelRoot.CreateModel();
            var mat = model.CreateMaterial("Default");
            mat.WithPBRMetallicRoughness().WithDefault();
            mat.DoubleSided = true;
            List<Skin> skins = new List<Skin>();
            if(Rig != null)
            {
                var skin = model.CreateSkin();
                skin.BindJoints(RIG.ExportNodes(ref model, Rig).Values.ToArray());
                skins.Add(skin);
            }

            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);
            foreach (var mesh in meshes)
            {
                for (int i = 0; i < mesh.positions.Length; i++)
                {
                    bw.Write(mesh.positions[i].X);
                    bw.Write(mesh.positions[i].Y);
                    bw.Write(mesh.positions[i].Z);
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
                for (int i = 0; i < mesh.texCoords0.Length; i++)
                {
                    bw.Write(mesh.texCoords0[i].X);
                    bw.Write(mesh.texCoords0[i].Y);
                }
                for (int i = 0; i < mesh.texCoords1.Length; i++)
                {
                    bw.Write(mesh.texCoords1[i].X);
                    bw.Write(mesh.texCoords1[i].Y);
                }
                
                if (mesh.weightCount > 0)
                {
                    if(Rig != null)
                    {
                        for (int i = 0; i < mesh.positions.Length; i++)
                        {
                            bw.Write(mesh.boneindices[i, 0]);
                            bw.Write(mesh.boneindices[i, 1]);
                            bw.Write(mesh.boneindices[i, 2]);
                            bw.Write(mesh.boneindices[i, 3]);
                        }
                        for (int i = 0; i < mesh.positions.Length; i++)
                        {
                            bw.Write(mesh.weights[i, 0]);
                            bw.Write(mesh.weights[i, 1]);
                            bw.Write(mesh.weights[i, 2]);
                            bw.Write(mesh.weights[i, 3]);
                        }
                        if (mesh.weightCount > 4)
                        {
                            for (int i = 0; i < mesh.positions.Length; i++)
                            {
                                bw.Write(mesh.boneindices[i, 4]);
                                bw.Write(mesh.boneindices[i, 5]);
                                bw.Write(mesh.boneindices[i, 6]);
                                bw.Write(mesh.boneindices[i, 7]);
                            }
                            for (int i = 0; i < mesh.positions.Length; i++)
                            {
                                bw.Write(mesh.weights[i, 4]);
                                bw.Write(mesh.weights[i, 5]);
                                bw.Write(mesh.weights[i, 6]);
                                bw.Write(mesh.weights[i, 7]);
                            }
                        }
                    }
                }
                for(int i = 0; i < mesh.indices.Length; i+= 3)
                {
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 1]));
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 0]));
                    bw.Write(Convert.ToUInt16(mesh.indices[i + 2]));
                }
                if (mesh.garmentMorph.Length > 0)
                {
                    for (int i = 0; i < mesh.positions.Length; i++)
                    {
                        bw.Write(mesh.garmentMorph[i].X);
                        bw.Write(mesh.garmentMorph[i].Y);
                        bw.Write(mesh.garmentMorph[i].Z);
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
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.positions.Length * 12);
                    acc.SetData(buff, 0, mesh.positions.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("POSITION", acc);
                    BuffViewoffset += mesh.positions.Length * 12;
                }
                if(mesh.normals.Length > 0)
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
                if(mesh.weightCount > 0)
                {
                    if(Rig != null)
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
                if (Rig != null && mesh.weightCount > 0)
                    nod.Skin = skins[0];

                if(mesh.garmentMorph.Length > 0)
                {
                    string[] arr = { "GarmentSupport" };
                    var obj = new { materialNames = mesh.materialNames, targetNames = arr };
                    mes.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);
                }
                else
                {
                    var obj = new { materialNames = mesh.materialNames };
                    mes.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);
                }
                if(mesh.garmentMorph.Length > 0)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.garmentMorph.Length * 12);
                    acc.SetData(buff, 0, mesh.garmentMorph.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    var dict = new Dictionary<string, Accessor>();
                    dict.Add("POSITION", acc);
                    prim.SetMorphTargetAccessors(0, dict);
                    BuffViewoffset += mesh.garmentMorph.Length * 12;
                }
            }
            model.UseScene(0).Name = "Scene";
            model.DefaultScene = model.UseScene(0);
            model.MergeBuffers();
            return model;
        }
        private static ModelRoot RawMeshesToMinimalGLTF(List<RawMeshContainer> meshes)
        {
            var scene = new SceneBuilder();

            foreach (var mesh in meshes)
            {
                long indCount = mesh.indices.Length;
                var expmesh = new MeshBuilder<VertexPosition, VertexEmpty, VertexEmpty>(mesh.name);

                var prim = expmesh.UsePrimitive(new MaterialBuilder("Default").WithDoubleSide(true));
                for (int i = 0; i < indCount; i += 3)
                {
                    uint idx0 = mesh.indices[i + 1];
                    uint idx1 = mesh.indices[i];
                    uint idx2 = mesh.indices[i + 2];

                    //VPNT
                    Vec3 p_0 = new Vec3(mesh.positions[idx0].X, mesh.positions[idx0].Y, mesh.positions[idx0].Z);
                    Vec3 p_1 = new Vec3(mesh.positions[idx1].X, mesh.positions[idx1].Y, mesh.positions[idx1].Z);
                    Vec3 p_2 = new Vec3(mesh.positions[idx2].X, mesh.positions[idx2].Y, mesh.positions[idx2].Z);

                    // vertex build
                    var v0 = new VertexBuilder<VertexPosition, VertexEmpty, VertexEmpty>(new VertexPosition(p_0));
                    var v1 = new VertexBuilder<VertexPosition, VertexEmpty, VertexEmpty>(new VertexPosition(p_1));
                    var v2 = new VertexBuilder<VertexPosition, VertexEmpty, VertexEmpty>(new VertexPosition(p_2));
                    // triangle build
                    prim.AddTriangle(v0, v1, v2);
                }
                scene.AddRigidMesh(expmesh, System.Numerics.Matrix4x4.Identity);
            }
            var model = scene.ToGltf2();
            return model;
        }
        public static RawArmature GetOrphanRig(rendRenderMeshBlob rendmeshblob)
        {
            if (rendmeshblob.Header.BonePositions.Count != 0)
            {
                RawArmature Rig = new RawArmature();
                Rig.BoneCount = rendmeshblob.Header.BonePositions.Count;
                Rig.LocalPosn = new Vec3[Rig.BoneCount];
                Rig.LocalRot = new System.Numerics.Quaternion[Rig.BoneCount];
                Rig.LocalScale = new Vec3[Rig.BoneCount];
                Rig.Parent = new Int16[Rig.BoneCount];
                Rig.Names = new string[Rig.BoneCount];

                for (int i = 0; i < Rig.BoneCount; i++)
                {
                    var vec = rendmeshblob.Header.BonePositions[i];
                    Rig.LocalPosn[i] = new Vec3(vec.X.Value, vec.Z.Value, -vec.Y.Value);
                    Rig.LocalRot[i] = System.Numerics.Quaternion.Identity;
                    Rig.LocalScale[i] = Vec3.One;
                    Rig.Parent[i] = -1;
                }
                if(rendmeshblob.cr2w.Chunks.Select(_=>_.Data).OfType<CMesh>().Any())
                {
                    var meshBlob = rendmeshblob.cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First();
                    for (int i = 0; i < Rig.BoneCount; i++)
                    {
                        Rig.Names[i] = meshBlob.BoneNames[i].Value;
                    }
                }
                return Rig;
            }
            return null;
        }
        public static void UpdateSkinningParamCloth(ref List<RawMeshContainer> meshes,Stream ms, CR2WFile cr2w)
        {
            if (cr2w.Chunks.Select(_ => _.Data).OfType<meshMeshParamCloth>().Any())
            {
                var blob = cr2w.Chunks.Select(_ => _.Data).OfType<meshMeshParamCloth>().First();

                for (int i = 0; (i < blob.Chunks.Count) && (i < meshes.Count); i++)
                {
                    if (blob.Chunks[i].SkinIndices.IsSerialized && blob.Chunks[i].SkinWeights.IsSerialized)
                    {
                        meshes[i].weightCount = 4;
                    }
                    if (blob.Chunks[i].SkinIndicesExt.IsSerialized && blob.Chunks[i].SkinWeightsExt.IsSerialized)
                    {
                        meshes[i].weightCount += 4;
                    }
                    meshes[i].boneindices = new ushort[meshes[i].positions.Length, meshes[i].weightCount];
                    meshes[i].weights = new float[meshes[i].positions.Length, meshes[i].weightCount];
                    if (blob.Chunks[i].SkinIndices.IsSerialized)
                    {
                        var bufferIdx = blob.Chunks[i].SkinIndices.Buffer.Value;
                        var buffer = cr2w.Buffers[bufferIdx - 1];
                        ms.Seek(buffer.Offset, SeekOrigin.Begin);
                        var stream = new MemoryStream();
                        ms.DecompressAndCopySegment(stream, buffer.DiskSize, buffer.MemSize);
                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 0] = br.ReadByte();
                            meshes[i].boneindices[e, 1] = br.ReadByte();
                            meshes[i].boneindices[e, 2] = br.ReadByte();
                            meshes[i].boneindices[e, 3] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeights.IsSerialized)
                    {
                        var bufferIdx = blob.Chunks[i].SkinWeights.Buffer.Value;
                        var buffer = cr2w.Buffers[bufferIdx - 1];
                        ms.Seek(buffer.Offset, SeekOrigin.Begin);
                        var stream = new MemoryStream();
                        ms.DecompressAndCopySegment(stream, buffer.DiskSize, buffer.MemSize);
                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 0] = br.ReadSingle();
                            meshes[i].weights[e, 1] = br.ReadSingle();
                            meshes[i].weights[e, 2] = br.ReadSingle();
                            meshes[i].weights[e, 3] = br.ReadSingle();
                        }
                    }
                    if (blob.Chunks[i].SkinIndicesExt.IsSerialized)
                    {
                        var bufferIdx = blob.Chunks[i].SkinIndicesExt.Buffer.Value;
                        var buffer = cr2w.Buffers[bufferIdx - 1];
                        ms.Seek(buffer.Offset, SeekOrigin.Begin);
                        var stream = new MemoryStream();
                        ms.DecompressAndCopySegment(stream, buffer.DiskSize, buffer.MemSize);
                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 4] = br.ReadByte();
                            meshes[i].boneindices[e, 5] = br.ReadByte();
                            meshes[i].boneindices[e, 6] = br.ReadByte();
                            meshes[i].boneindices[e, 7] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeightsExt.IsSerialized)
                    {
                        var bufferIdx = blob.Chunks[i].SkinWeightsExt.Buffer.Value;
                        var buffer = cr2w.Buffers[bufferIdx - 1];
                        ms.Seek(buffer.Offset, SeekOrigin.Begin);
                        var stream = new MemoryStream();
                        ms.DecompressAndCopySegment(stream, buffer.DiskSize, buffer.MemSize);
                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 4] = br.ReadSingle();
                            meshes[i].weights[e, 5] = br.ReadSingle();
                            meshes[i].weights[e, 6] = br.ReadSingle();
                            meshes[i].weights[e, 7] = br.ReadSingle();
                        }
                    }
                    for (int e = 0; e < meshes[i].positions.Length; e++)
                    {
                        float sum = 0;
                        for (int y = 0; y < meshes[i].weightCount; y++)
                        {
                            sum += meshes[i].weights[e, y];
                        }
                        if (sum == 0 && meshes[i].weightCount > 0)
                        {
                            meshes[i].boneindices[e, 0] = 0;
                            meshes[i].weights[e, 0] = 1f;
                            sum = 1;
                        }
                        for (int y = 0; y < meshes[i].weightCount; y++)
                        {
                            meshes[i].weights[e, y] *= 1f / sum;
                        }
                    }
                }
            }
            if (cr2w.Chunks.Select(_ => _.Data).OfType<meshMeshParamCloth_Graphical>().Any())
            {
                var blob = cr2w.Chunks.Select(_ => _.Data).OfType<meshMeshParamCloth_Graphical>().First();

                for (int i = 0; (i < blob.Chunks.Count) && (i < meshes.Count); i++)
                {
                    if(blob.Chunks[i].Simulation.Count > 0 && meshes[i].colors1.Length != meshes[i].positions.Length)
                        meshes[i].colors1 = new Vec4[meshes[i].positions.Length];

                    for (int e = 0; e < meshes[i].colors1.Length; e++)
                    {
                        meshes[i].colors1[e] = Vec4.Zero;
                    }
                    for (int e = 0; e < blob.Chunks[i].Simulation.Count; e++)
                    {
                        meshes[i].colors1[blob.Chunks[i].Simulation[e].Value].X = 1f;
                    }
                    if (blob.Chunks[i].SkinIndices.IsSerialized && blob.Chunks[i].SkinWeights.IsSerialized)
                    {
                        meshes[i].weightCount = 4;
                    }
                    if (blob.Chunks[i].SkinIndicesExt.IsSerialized && blob.Chunks[i].SkinWeightsExt.IsSerialized)
                    {
                        meshes[i].weightCount += 4;
                    }
                    meshes[i].boneindices = new ushort[meshes[i].positions.Length, meshes[i].weightCount];
                    meshes[i].weights = new float[meshes[i].positions.Length, meshes[i].weightCount];
                    if (blob.Chunks[i].SkinIndices.IsSerialized)
                    {
                        var bufferIdx = blob.Chunks[i].SkinIndices.Buffer.Value;
                        var buffer = cr2w.Buffers[bufferIdx - 1];
                        ms.Seek(buffer.Offset, SeekOrigin.Begin);
                        var stream = new MemoryStream();
                        ms.DecompressAndCopySegment(stream, buffer.DiskSize, buffer.MemSize);
                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 0] = br.ReadByte();
                            meshes[i].boneindices[e, 1] = br.ReadByte();
                            meshes[i].boneindices[e, 2] = br.ReadByte();
                            meshes[i].boneindices[e, 3] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeights.IsSerialized)
                    {
                        var bufferIdx = blob.Chunks[i].SkinWeights.Buffer.Value;
                        var buffer = cr2w.Buffers[bufferIdx - 1];
                        ms.Seek(buffer.Offset, SeekOrigin.Begin);
                        var stream = new MemoryStream();
                        ms.DecompressAndCopySegment(stream, buffer.DiskSize, buffer.MemSize);
                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 0] = br.ReadSingle();
                            meshes[i].weights[e, 1] = br.ReadSingle();
                            meshes[i].weights[e, 2] = br.ReadSingle();
                            meshes[i].weights[e, 3] = br.ReadSingle();
                        }
                    }
                    if (blob.Chunks[i].SkinIndicesExt.IsSerialized)
                    {
                        var bufferIdx = blob.Chunks[i].SkinIndicesExt.Buffer.Value;
                        var buffer = cr2w.Buffers[bufferIdx - 1];
                        ms.Seek(buffer.Offset, SeekOrigin.Begin);
                        var stream = new MemoryStream();
                        ms.DecompressAndCopySegment(stream, buffer.DiskSize, buffer.MemSize);
                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].boneindices[e, 4] = br.ReadByte();
                            meshes[i].boneindices[e, 5] = br.ReadByte();
                            meshes[i].boneindices[e, 6] = br.ReadByte();
                            meshes[i].boneindices[e, 7] = br.ReadByte();
                        }
                    }
                    if (blob.Chunks[i].SkinWeightsExt.IsSerialized)
                    {
                        var bufferIdx = blob.Chunks[i].SkinWeightsExt.Buffer.Value;
                        var buffer = cr2w.Buffers[bufferIdx - 1];
                        ms.Seek(buffer.Offset, SeekOrigin.Begin);
                        var stream = new MemoryStream();
                        ms.DecompressAndCopySegment(stream, buffer.DiskSize, buffer.MemSize);
                        var br = new BinaryReader(stream);
                        stream.Seek(0, SeekOrigin.Begin);
                        for (int e = 0; e < meshes[i].positions.Length; e++)
                        {
                            meshes[i].weights[e, 4] = br.ReadSingle();
                            meshes[i].weights[e, 5] = br.ReadSingle();
                            meshes[i].weights[e, 6] = br.ReadSingle();
                            meshes[i].weights[e, 7] = br.ReadSingle();
                        }
                    }
                    for (int e = 0; e < meshes[i].positions.Length; e++)
                    {
                        float sum = 0;
                        for (int y = 0; y < meshes[i].weightCount; y++)
                        {
                            sum += meshes[i].weights[e, y];
                        }
                        if (sum == 0 && meshes[i].weightCount > 0)
                        {
                            meshes[i].boneindices[e, 0] = 0;
                            meshes[i].weights[e, 0] = 1f;
                            sum = 1;
                        }
                        for (int y = 0; y < meshes[i].weightCount; y++)
                        {
                            meshes[i].weights[e, y] *= 1f / sum;
                        }
                    }
                }
            }
        }
    }
}
