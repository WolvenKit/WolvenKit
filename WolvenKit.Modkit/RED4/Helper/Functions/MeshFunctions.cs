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

namespace CP77.CR2W
{
    using Vec2 = System.Numerics.Vector2;
    using Vec3 = System.Numerics.Vector3;
    using Vec4 = System.Numerics.Vector4;

    public class MeshTools
    {
        private readonly Red4ParserService _modTools;
        private readonly RIG _rig;

        public MeshTools(Red4ParserService modtools, RIG rig)
        {
            _modTools = modtools;
            _rig = rig;
        }


        public string ExportMeshSimple(IGameFile file, string FilePath, string v)
        {

            using var meshStream = new MemoryStream();
            file.Extract(meshStream);
            meshStream.Seek(0, SeekOrigin.Begin);
            var cr2w = _modTools.TryReadRED4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any())
            {
                return "";
            }
            var ms = GetMeshBufferStream(meshStream, cr2w);

            var meshinfo = GetMeshesinfo(cr2w);

            var expMeshes = ContainRawMesh(ms, meshinfo, true);

            if (!Directory.Exists(v))
                Directory.CreateDirectory(v);

            if (Directory.GetFiles(v).Length > 5)
            {
                foreach (var f in Directory.GetFiles(v))
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

            ModelRoot model = RawMeshesToMinimalGLTF(expMeshes);
            string outfile;


            if (true)
            {
                outfile = Path.Combine(v, Path.GetFileNameWithoutExtension(FilePath) + ".glb");
                model.SaveGLB(outfile);
            }

            meshStream.Dispose();
            meshStream.Close();

            return outfile;
        }


        public string ExportMeshWithoutRigPreviewer(IGameFile file, string FilePath, string tempmodels, bool LodFilter = true, bool isGLBinary = true)
        {
            using var meshStream = new MemoryStream();
            file.Extract(meshStream);
            meshStream.Seek(0, SeekOrigin.Begin);
            var cr2w = _modTools.TryReadRED4File(meshStream);

            return ExportMeshWithoutRigPreviewerInner(meshStream, cr2w, FilePath, tempmodels, LodFilter, isGLBinary);
        }

        public string ExportMeshWithoutRigPreviewer(string FilePath, string tempmodels, bool LodFilter = true, bool isGLBinary = true)
        {
            using var meshStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var cr2w = _modTools.TryReadRED4File(meshStream);

            return ExportMeshWithoutRigPreviewerInner(meshStream, cr2w, FilePath, tempmodels, LodFilter, isGLBinary);
        }

        private string ExportMeshWithoutRigPreviewerInner(Stream meshStream, CR2WFile cr2w, string FilePath, string tempmodels, bool LodFilter = true, bool isGLBinary = true)
        {
            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any())
            {
                return "";
            }
            var ms = GetMeshBufferStream(meshStream, cr2w);

            var meshinfo = GetMeshesinfo(cr2w);

            var expMeshes = ContainRawMesh(ms, meshinfo, LodFilter);

            ModelRoot model = RawMeshesToMinimalGLTF(expMeshes);
            string outfile;

            if (!Directory.Exists(tempmodels))
                Directory.CreateDirectory(tempmodels);

            if (Directory.GetFiles(tempmodels).Length > 5)
            {
                foreach (var f in Directory.GetFiles(tempmodels))
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


            if (isGLBinary)
            {
                outfile = Path.Combine(tempmodels, Path.GetFileNameWithoutExtension(FilePath) + ".glb");
                model.SaveGLB(outfile);
            }
            else
            {
                outfile = Path.Combine(tempmodels, Path.GetFileNameWithoutExtension(FilePath) + ".gltf");
                model.SaveGLTF(outfile);
            }
            meshStream.Dispose();
            meshStream.Close();

            return outfile;
        }

        public bool ExportMesh(Stream meshStream, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            var cr2w = _modTools.TryReadRED4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any())
            {
                return false;
            }

            if (!cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return WriteFakeMeshToFile();
            }

            MeshBones meshBones = new MeshBones();

            meshBones.boneCount = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First().BoneNames.Count;

            if (meshBones.boneCount != 0)    // for rigid meshes
            {
                meshBones.Names = RIG.GetboneNames(cr2w);
                meshBones.WorldPosn = GetMeshBonesPosn(cr2w);
            }
            RawArmature Rig = GetNonParentedRig(meshBones);

            MemoryStream ms = GetMeshBufferStream(meshStream, cr2w);

            MeshesInfo meshinfo = GetMeshesinfo(cr2w);

            List<RawMeshContainer> expMeshes = ContainRawMesh(ms, meshinfo, LodFilter);
            if (meshBones.boneCount == 0)    // for rigid meshes
            {
                for (int i = 0; i < expMeshes.Count; i++)
                    expMeshes[i].weightcount = 0;
            }
            UpdateMeshJoints(ref expMeshes, Rig, meshBones);

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
                    model.SaveGLB(outfile.FullName);
                }
                else
                {
                    model.SaveGLTF(outfile.FullName);
                }
            }
        }

        public bool ExportMeshWithoutRig(Stream meshStream, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            var cr2w = _modTools.TryReadRED4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any())
            {
                return false;
            }

            if (!cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            MemoryStream ms = GetMeshBufferStream(meshStream, cr2w);

            MeshesInfo meshinfo = GetMeshesinfo(cr2w);

            List<RawMeshContainer> expMeshes = ContainRawMesh(ms, meshinfo, LodFilter);

            ModelRoot model = RawMeshesToGLTF(expMeshes, null);

            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            meshStream.Dispose();
            meshStream.Close();
            return true;
        }

        public bool ExportMultiMeshWithoutRig(List<Stream> meshStreamS, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            for (int m = 0; m < meshStreamS.Count; m++)
            {
                var cr2w = _modTools.TryReadRED4File(meshStreamS[m]);
                if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
                    continue;

                MemoryStream ms = GetMeshBufferStream(meshStreamS[m], cr2w);

                MeshesInfo meshinfo = GetMeshesinfo(cr2w);
                var Meshes = ContainRawMesh(ms, meshinfo, LodFilter);
                for (int i = 0; i < Meshes.Count; i++)
                    Meshes[i].name = m + "_" + Meshes[i].name;
                expMeshes.AddRange(Meshes);
            }

            ModelRoot model = RawMeshesToGLTF(expMeshes, null);
            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            for (int i = 0; i < meshStreamS.Count; i++)
            {
                meshStreamS[i].Dispose();
                meshStreamS[i].Close();
            }

            return true;
        }

        public bool ExportMeshWithRig(Stream meshStream, Stream rigStream, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            RawArmature Rig = _rig.ProcessRig(rigStream);

            var cr2w = _modTools.TryReadRED4File(meshStream);

            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any())
            {
                return false;
            }

            if (!cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
            {
                return false;
            }

            MemoryStream ms = GetMeshBufferStream(meshStream, cr2w);
            MeshesInfo meshinfo = GetMeshesinfo(cr2w);

            MeshBones bones = new MeshBones();

            CMesh cmesh = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First();
            if (cmesh.BoneNames.Count != 0)    // for rigid meshes
            {
                bones.Names = RIG.GetboneNames(cr2w);
                bones.WorldPosn = GetMeshBonesPosn(cr2w);
            }

            List<RawMeshContainer> expMeshes = ContainRawMesh(ms, meshinfo, LodFilter);

            if (cmesh.BoneNames.Count == 0)    // for rigid meshes
            {
                for (int i = 0; i < expMeshes.Count; i++)
                    expMeshes[i].weightcount = 0;
            }
            UpdateMeshJoints(ref expMeshes, Rig, bones);

            ModelRoot model = RawMeshesToGLTF(expMeshes, Rig);

            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            meshStream.Dispose();
            meshStream.Close();
            rigStream.Dispose();
            rigStream.Close();

            return true;
        }

        public bool ExportMultiMeshWithRig(List<Stream> meshStreamS, List<Stream> rigStreamS, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            List<RawArmature> Rigs = new List<RawArmature>();
            rigStreamS = rigStreamS.OrderByDescending(r => r.Length).ToList();  // not so smart hacky method to get bodybase rigs on top/ orderby descending
            for (int r = 0; r < rigStreamS.Count; r++)
            {
                RawArmature Rig = _rig.ProcessRig(rigStreamS[r]);
                Rigs.Add(Rig);
            }
            RawArmature expRig = RIG.CombineRigs(Rigs);

            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            for (int m = 0; m < meshStreamS.Count; m++)
            {
                var cr2w = _modTools.TryReadRED4File(meshStreamS[m]);
                if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any() || !cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().Any())
                {
                    continue;
                }

                MemoryStream ms = GetMeshBufferStream(meshStreamS[m], cr2w);
                MeshesInfo meshinfo = GetMeshesinfo(cr2w);

                MeshBones bones = new MeshBones();

                CMesh cmesh = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First();

                if (cmesh.BoneNames.Count != 0)    // for rigid meshes
                {
                    bones.Names = RIG.GetboneNames(cr2w);
                    bones.WorldPosn = GetMeshBonesPosn(cr2w);
                }

                List<RawMeshContainer> Meshes = ContainRawMesh(ms, meshinfo, LodFilter);

                for (int i = 0; i < Meshes.Count; i++)
                {
                    Meshes[i].name = m + "_" + Meshes[i].name;
                    if (cmesh.BoneNames.Count == 0)    // for rigid meshes
                        Meshes[i].weightcount = 0;
                }
                UpdateMeshJoints(ref Meshes, expRig, bones);

                expMeshes.AddRange(Meshes);
            }
            ModelRoot model = RawMeshesToGLTF(expMeshes, expRig);
            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

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

        public static Vec3[] GetMeshBonesPosn(CR2WFile cr2w)
        {
            rendRenderMeshBlob rendmeshblob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First();

            int boneCount = rendmeshblob.Header.BonePositions.Count;
            Vec3[] posn = new Vec3[boneCount];
            float x, y, z = 0;
            for (int i = 0; i < boneCount; i++)
            {
                x = rendmeshblob.Header.BonePositions[i].X.Value;
                y = rendmeshblob.Header.BonePositions[i].Y.Value;
                z = rendmeshblob.Header.BonePositions[i].Z.Value;
                posn[i] = new Vec3(x, z, -y);
            }
            return posn;
        }

        public static MeshesInfo GetMeshesinfo(CR2WFile cr2w)
        {
            rendRenderMeshBlob rendmeshblob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First();

            int meshC = rendmeshblob.Header.RenderChunkInfos.Count;

            UInt32[] vertCounts = new UInt32[meshC];
            UInt32[] indCounts = new UInt32[meshC];
            UInt32[] vertOffsets = new UInt32[meshC];
            UInt32[] tx0Offsets = new UInt32[meshC];
            UInt32[] normalOffsets = new UInt32[meshC];
            UInt32[] tangentOffsets = new UInt32[meshC];
            UInt32[] colorOffsets = new UInt32[meshC];
            UInt32[] tx1Offsets = new UInt32[meshC];
            UInt32[] unknownOffsets = new UInt32[meshC];
            UInt32[] indicesOffsets = new UInt32[meshC];
            UInt32[] vpStrides = new UInt32[meshC];
            UInt32[] LODLvl = new UInt32[meshC];
            bool[] extraExists = new bool[meshC];

            for (int i = 0; i < meshC; i++)
            {
                vertCounts[i] = rendmeshblob.Header.RenderChunkInfos[i].NumVertices.Value;
                indCounts[i] = rendmeshblob.Header.RenderChunkInfos[i].NumIndices.Value;
                vertOffsets[i] = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[0].Value;
                unknownOffsets[i] = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[4].Value;

                var cv = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices;
                for (int e = 0; e < cv.VertexLayout.Elements.Count; e++)
                {
                    if (cv.VertexLayout.Elements[e].Usage.EnumValueList[0] == "PS_Normal")
                    {
                        normalOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex.Value].Value;
                    }
                    if (cv.VertexLayout.Elements[e].Usage.EnumValueList[0] == "PS_Tangent")
                    {
                        tangentOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex.Value].Value;
                    }
                    if (cv.VertexLayout.Elements[e].Usage.EnumValueList[0] == "PS_Color")
                    {
                        colorOffsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex.Value].Value;
                    }
                    if (cv.VertexLayout.Elements[e].Usage.EnumValueList[0] == "PS_TexCoord")
                    {
                        if (tx0Offsets[i] == 0)
                            tx0Offsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex.Value].Value;
                        else
                            tx1Offsets[i] = cv.ByteOffsets[cv.VertexLayout.Elements[e].StreamIndex.Value].Value;
                    }
                }

                if (rendmeshblob.Header.RenderChunkInfos[i].ChunkIndices.TeOffset == null)
                {
                    indicesOffsets[i] = rendmeshblob.Header.IndexBufferOffset.Value;
                }
                else
                {
                    indicesOffsets[i] = rendmeshblob.Header.IndexBufferOffset.Value + rendmeshblob.Header.RenderChunkInfos[i].ChunkIndices.TeOffset.Value;
                }
                vpStrides[i] = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.SlotStrides[0].Value;
                LODLvl[i] = rendmeshblob.Header.RenderChunkInfos[i].LodMask.Value;
            }
            Vector4 qSc = rendmeshblob.Header.QuantizationScale;
            Vector4 qTr = rendmeshblob.Header.QuantizationOffset;

            Vec4 qScale = new Vec4(qSc.X.Value, qSc.Y.Value, qSc.Z.Value, qSc.W.Value);
            Vec4 qTrans = new Vec4(qTr.X.Value, qTr.Y.Value, qTr.Z.Value, qTr.W.Value);

            // getting number of weights for the meshes
            UInt32[] weightcounts = new UInt32[meshC];
            int count = 0;
            UInt32 counter = 0;
            string checker = string.Empty;

            for (int i = 0; i < meshC; i++)
            {
                count = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements.Count;
                counter = 0;
                for (int e = 0; e < count; e++)
                {
                    checker = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].Usage.EnumValueList[0];
                    if (checker == "PS_SkinIndices")
                        counter++;
                }
                weightcounts[i] = counter * 4;
            }

            for (int i = 0; i < meshC; i++)
            {
                extraExists[i] = false;
                count = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements.Count;

                for (int e = 0; e < count; e++)
                {
                    checker = rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].Usage.EnumValueList[0];
                    if (checker == "PS_ExtraData")
                    {
                        if (rendmeshblob.Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].StreamIndex.Value == 0)
                            extraExists[i] = true;
                    }
                }
            }

            List<Appearance> appearances = new List<Appearance>();
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "meshMeshAppearance")
                {
                    Appearance appearance = new Appearance();
                    appearance.Name = (cr2w.Chunks[i].Data as meshMeshAppearance).Name.Value;
                    if (appearance.Name == string.Empty)
                        appearance.Name = "DEFAULT";
                    int mtCount = (cr2w.Chunks[i].Data as meshMeshAppearance).ChunkMaterials.Count;
                    appearance.MaterialNames = new string[mtCount];
                    for (int e = 0; e < mtCount; e++)
                    {
                        appearance.MaterialNames[e] = (cr2w.Chunks[i].Data as meshMeshAppearance).ChunkMaterials[e].Value;
                    }
                    appearances.Add(appearance);
                }
            }
            MeshesInfo meshesInfo = new MeshesInfo()
            {
                vertCounts = vertCounts,
                indCounts = indCounts,
                vertOffsets = vertOffsets,
                tx0Offsets = tx0Offsets,
                normalOffsets = normalOffsets,
                tangentOffsets = tangentOffsets,
                colorOffsets = colorOffsets,
                tx1Offsets = tx1Offsets,
                unknownOffsets = unknownOffsets,
                indicesOffsets = indicesOffsets,
                vpStrides = vpStrides,
                weightcounts = weightcounts,
                extraExists = extraExists,
                LODLvl = LODLvl,
                qScale = qScale,
                qTrans = qTrans,
                meshC = meshC,
                appearances = appearances,
                vertBufferSize = rendmeshblob.Header.VertexBufferSize.Value,
                indexBufferOffset = rendmeshblob.Header.IndexBufferOffset.Value,
                indexBufferSize = rendmeshblob.Header.IndexBufferSize.Value
            };
            return meshesInfo;
        }
        public static List<RawMeshContainer> ContainRawMesh(MemoryStream gfs, MeshesInfo info, bool LODFilter)
        {
            BinaryReader gbr = new BinaryReader(gfs);

            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            for (int index = 0; index < info.meshC; index++)
            {
                if (info.LODLvl[index] != 1 && LODFilter)
                    continue;
                Vec3[] vertices = new Vec3[info.vertCounts[index]];
                uint[] indices = new uint[info.indCounts[index]];
                Vec2[] tx0coords = new Vec2[info.vertCounts[index]];
                Vec3[] normals = new Vec3[0];
                Vec4[] tangents = new Vec4[0];
                Vec4[] colors = new Vec4[info.vertCounts[index]];
                Vec2[] tx1coords = new Vec2[info.vertCounts[index]];
                float[,] weights = new float[info.vertCounts[index], info.weightcounts[index]];
                UInt16[,] boneindices = new UInt16[info.vertCounts[index], info.weightcounts[index]];
                Vec3[] extradata = new Vec3[info.vertCounts[index]];

                // geting vertices
                for (int i = 0; i < info.vertCounts[index]; i++)
                {
                    gfs.Position = info.vertOffsets[index] + i * info.vpStrides[index];

                    float x = (gbr.ReadInt16() / 32767f) * info.qScale.X + info.qTrans.X;
                    float y = (gbr.ReadInt16() / 32767f) * info.qScale.Y + info.qTrans.Y;
                    float z = (gbr.ReadInt16() / 32767f) * info.qScale.Z + info.qTrans.Z;
                    // changing orientation of geomerty, Y+ Z+ RHS-LHS BS
                    vertices[i] = new Vec3(x, z, -y);
                }
                // got vertices

                float[] values = new float[info.vertCounts[index] * 2];

                if (info.tx0Offsets[index] != 0)
                {
                    // getting texturecoord0 as half floats
                    gfs.Position = info.tx0Offsets[index];
                    for (int i = 0; i < info.vertCounts[index] * 2; i++)
                    {
                        UInt16 read = gbr.ReadUInt16();
                        values[i] = Converters.hfconvert(read);
                    }
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        tx0coords[i] = new Vec2(values[2 * i], values[2 * i + 1]);
                    }
                    // got texturecoord0 as half floats
                }

                UInt32 NorRead32;
                bool invalidNors = true;
                if (info.normalOffsets[index] != 0)
                {
                    normals = new Vec3[info.vertCounts[index]];
                    // getting 10bit normals
                    int str = 4;
                    if (info.tangentOffsets[index] != 0)
                        str += 4;
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.normalOffsets[index] + str * i;
                        NorRead32 = gbr.ReadUInt32();
                        Vec4 tempv = Converters.TenBitShifted(NorRead32);
                        // changing orientation of geomerty, Y+ Z+ RHS-LHS BS
                        normals[i] = new Vec3(tempv.X, tempv.Z, -tempv.Y);
                        normals[i] = Vec3.Normalize(normals[i]);
                        if (NorRead32 != 0x5FF7FDFF)
                        {
                            invalidNors = false;
                        }
                    }
                }
                // got 10bit normals
                if (info.tangentOffsets[index] != 0 && info.normalOffsets[index] != 0)
                {
                    tangents = new Vec4[info.vertCounts[index]];
                    info.tangentOffsets[index] += 4;
                    // getting 10bit tangents
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.tangentOffsets[index] + 8 * i;
                        NorRead32 = gbr.ReadUInt32();
                        Vec4 tempv = Converters.TenBitShifted(NorRead32);
                        // changing orientation of geomerty, Y+ Z+ RHS-LHS BS
                        Vec3 vec = Vec3.Normalize(new Vec3(tempv.X, tempv.Z, -tempv.Y));
                        tangents[i] = new Vec4(vec.X, vec.Y, vec.Z, 1f);
                    }
                }

                if (invalidNors)
                {
                    normals = new Vec3[0];
                    tangents = new Vec4[0];
                }

                if (info.tx1Offsets[index] != 0)
                {
                    if (info.colorOffsets[index] != 0)
                        info.tx1Offsets[index] += 4;
                    gfs.Position = info.tx1Offsets[index];
                    // getting texturecoord1 as half floats
                    for (int i = 0; i < info.vertCounts[index] * 2; i++)
                    {
                        UInt16 read = gbr.ReadUInt16();
                        values[i] = Converters.hfconvert(read);
                        if (i % 2 != 0)
                            gfs.Position += 4;
                    }
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        tx1coords[i] = new Vec2(values[2 * i], values[2 * i + 1]);
                    }
                    // got texturecoord1 as half floats
                }

                if (info.colorOffsets[index] != 0)
                {
                    int str = 4;
                    if (info.tx1Offsets[index] != 0)
                        str += 4;
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.colorOffsets[index] + i * str;
                        Vec4 tempv = new Vec4(gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f);
                        colors[i] = new Vec4(tempv.X, tempv.Y, tempv.Z, tempv.W);
                    }
                    // got vert colors
                }

                // getting bone indices
                for (int i = 0; i < info.vertCounts[index]; i++)
                {
                    gfs.Position = info.vertOffsets[index] + i * info.vpStrides[index] + 8;
                    for (int e = 0; e < info.weightcounts[index]; e++)
                    {
                        boneindices[i, e] = gbr.ReadByte();
                    }
                }
                // got bone indexes

                // getting weights
                for (int i = 0; i < info.vertCounts[index]; i++)
                {
                    float sum = 0;
                    gfs.Position = info.vertOffsets[index] + i * info.vpStrides[index] + 8 + info.weightcounts[index];
                    for (int e = 0; e < info.weightcounts[index]; e++)
                    {
                        weights[i, e] = gbr.ReadByte() / 255f;
                        sum += weights[i, e];
                    }
                    if (sum == 0 && info.weightcounts[index] > 0)
                    {
                        boneindices[i, 0] = 0;
                        weights[i, 0] = 1f;
                        sum = 1;
                    }
                    for (int e = 0; e < info.weightcounts[index]; e++)
                    {
                        weights[i, e] *= 1f / sum;
                    }
                }
                // got weights

                if (info.extraExists[index])
                {
                    for (int i = 0; i < info.vertCounts[index]; i++)
                    {
                        gfs.Position = info.vertOffsets[index] + i * info.vpStrides[index] + 8 + 2 * info.weightcounts[index];
                        float x = Converters.hfconvert(gbr.ReadUInt16());
                        float y = Converters.hfconvert(gbr.ReadUInt16());
                        float z = Converters.hfconvert(gbr.ReadUInt16());
                        extradata[i] = new Vec3(x, z, -y);
                    }
                }
                // getting uint16 faces/indices
                gfs.Position = info.indicesOffsets[index];
                for (int i = 0; i < info.indCounts[index]; i++)
                {
                    indices[i] = gbr.ReadUInt16();
                }
                // got uint16 faces/indices

                RawMeshContainer mesh = new RawMeshContainer()
                {
                    vertices = vertices,
                    indices = indices,
                    tx0coords = tx0coords,
                    normals = normals,
                    tangents = tangents,
                    colors = colors,
                    tx1coords = tx1coords,
                    boneindices = boneindices,
                    weights = weights,
                    weightcount = info.weightcounts[index],
                    extradata = extradata,
                    extraExist = info.extraExists[index]
                };
                mesh.name = "submesh_" + Convert.ToString(index).PadLeft(2, '0') + "_LOD_" + info.LODLvl[index];

                mesh.appNames = new string[info.appearances.Count];
                mesh.materialNames = new string[info.appearances.Count];
                for (int e = 0; e < info.appearances.Count; e++)
                {
                    mesh.appNames[e] = info.appearances[e].Name;
                    mesh.materialNames[e] = info.appearances[e].MaterialNames[index];
                }
                expMeshes.Add(mesh);
            }
            return expMeshes;
        }
        public static void UpdateMeshJoints(ref List<RawMeshContainer> Meshes, RawArmature Rig, MeshBones Bones)
        {
            // updating mesh bone indexes
            for (int i = 0; i < Meshes.Count; i++)
            {
                for (int e = 0; e < Meshes[i].vertices.Length; e++)
                {
                    for (int eye = 0; eye < Meshes[i].weightcount; eye++)
                    {
                        bool found = false;
                        for (UInt16 r = 0; r < Rig.BoneCount; r++)
                        {
                            if (Rig.Names[r] == Bones.Names[Meshes[i].boneindices[e, eye]])
                            {
                                Meshes[i].boneindices[e, eye] = r;
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            throw new Exception("Bone: " + Bones.Names[Meshes[i].boneindices[e, eye]] + " is not present in the Provided .rig(s).\nInput .rig(s) are incompatible or incomplete, Please provide a/more compatible .rig(s)\nTIP: 1. For body .rig(s) provide {BodyType}_base_deformations.rig instead of {BodyType}_base.rig.\n2. if Input .mesh(s) contains any dangle/physics bones, provide the compatible dangle.rig also.\n");
                        }
                    }
                }
            }
        }
        public static MemoryStream GetMeshBufferStream(Stream ms, CR2WFile cr2w)
        {
            var blob = cr2w.Chunks.Select(_ => _.Data).OfType<rendRenderMeshBlob>().First();
            var bufferIdx = blob.RenderBuffer.Buffer.Value;

            var buffer = cr2w.Buffers[bufferIdx - 1];
            ms.Seek(buffer.Offset, SeekOrigin.Begin);
            var meshstream = new MemoryStream();
            ms.DecompressAndCopySegment(meshstream, buffer.DiskSize, buffer.MemSize);
            return meshstream;
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
                for (int i = 0; i < mesh.vertices.Length; i++)
                {
                    bw.Write(mesh.vertices[i].X);
                    bw.Write(mesh.vertices[i].Y);
                    bw.Write(mesh.vertices[i].Z);
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
                for (int i = 0; i < mesh.colors.Length; i++)
                {
                    bw.Write(mesh.colors[i].X);
                    bw.Write(mesh.colors[i].Y);
                    bw.Write(mesh.colors[i].Z);
                    bw.Write(mesh.colors[i].W);
                }
                for (int i = 0; i < mesh.tx0coords.Length; i++)
                {
                    bw.Write(mesh.tx0coords[i].X);
                    bw.Write(mesh.tx0coords[i].Y);
                }
                for (int i = 0; i < mesh.tx1coords.Length; i++)
                {
                    bw.Write(mesh.tx1coords[i].X);
                    bw.Write(mesh.tx1coords[i].Y);
                }
                
                if (mesh.weightcount > 0)
                {
                    if(Rig != null)
                    {
                        for (int i = 0; i < mesh.vertices.Length; i++)
                        {
                            bw.Write(mesh.boneindices[i, 0]);
                            bw.Write(mesh.boneindices[i, 1]);
                            bw.Write(mesh.boneindices[i, 2]);
                            bw.Write(mesh.boneindices[i, 3]);
                        }
                        for (int i = 0; i < mesh.vertices.Length; i++)
                        {
                            bw.Write(mesh.weights[i, 0]);
                            bw.Write(mesh.weights[i, 1]);
                            bw.Write(mesh.weights[i, 2]);
                            bw.Write(mesh.weights[i, 3]);
                        }
                        if (mesh.weightcount > 4)
                        {
                            for (int i = 0; i < mesh.vertices.Length; i++)
                            {
                                bw.Write(mesh.boneindices[i, 4]);
                                bw.Write(mesh.boneindices[i, 5]);
                                bw.Write(mesh.boneindices[i, 6]);
                                bw.Write(mesh.boneindices[i, 7]);
                            }
                            for (int i = 0; i < mesh.vertices.Length; i++)
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
                if (mesh.extraExist)
                {
                    for (int i = 0; i < mesh.vertices.Length; i++)
                    {
                        bw.Write(mesh.extradata[i].X);
                        bw.Write(mesh.extradata[i].Y);
                        bw.Write(mesh.extradata[i].Z);
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
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.vertices.Length * 12);
                    acc.SetData(buff, 0, mesh.vertices.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("POSITION", acc);
                    BuffViewoffset += mesh.vertices.Length * 12;
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
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.colors.Length * 16);
                    acc.SetData(buff, 0, mesh.colors.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("COLOR_0", acc);
                    BuffViewoffset += mesh.colors.Length * 16;
                }
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.tx0coords.Length * 8);
                    acc.SetData(buff, 0, mesh.tx0coords.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_0", acc);
                    BuffViewoffset += mesh.tx0coords.Length * 8;
                }
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.tx1coords.Length * 8);
                    acc.SetData(buff, 0, mesh.tx1coords.Length, DimensionType.VEC2, EncodingType.FLOAT, false);
                    prim.SetVertexAccessor("TEXCOORD_1", acc);
                    BuffViewoffset += mesh.tx1coords.Length * 8;
                }
                if(mesh.weightcount > 0)
                {
                    if(Rig != null)
                    {
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.vertices.Length * 8);
                            acc.SetData(buff, 0, mesh.vertices.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                            prim.SetVertexAccessor("JOINTS_0", acc);
                            BuffViewoffset += mesh.vertices.Length * 8;
                        }
                        {
                            var acc = model.CreateAccessor();
                            var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.vertices.Length * 16);
                            acc.SetData(buff, 0, mesh.vertices.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                            prim.SetVertexAccessor("WEIGHTS_0", acc);
                            BuffViewoffset += mesh.vertices.Length * 16;
                        }
                        if (mesh.weightcount > 4)
                        {
                            {
                                var acc = model.CreateAccessor();
                                var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.vertices.Length * 8);
                                acc.SetData(buff, 0, mesh.vertices.Length, DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, false);
                                prim.SetVertexAccessor("JOINTS_1", acc);
                                BuffViewoffset += mesh.vertices.Length * 8;
                            }
                            {
                                var acc = model.CreateAccessor();
                                var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.vertices.Length * 16);
                                acc.SetData(buff, 0, mesh.vertices.Length, DimensionType.VEC4, EncodingType.FLOAT, false);
                                prim.SetVertexAccessor("WEIGHTS_1", acc);
                                BuffViewoffset += mesh.vertices.Length * 16;
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
                if (Rig != null && mesh.weightcount > 0)
                    nod.Skin = skins[0];

                if(mesh.extraExist)
                {
                    string[] arr = { "GarmentSupport" };
                    var obj = new { appNames = mesh.appNames, materialNames = mesh.materialNames, targetNames = arr };
                    mes.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);
                }
                else
                {
                    var obj = new { appNames = mesh.appNames, materialNames = mesh.materialNames };
                    mes.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);
                }
                if(mesh.extraExist)
                {
                    var acc = model.CreateAccessor();
                    var buff = model.UseBufferView(buffer, BuffViewoffset, mesh.extradata.Length * 12);
                    acc.SetData(buff, 0, mesh.extradata.Length, DimensionType.VEC3, EncodingType.FLOAT, false);
                    var dict = new Dictionary<string, Accessor>();
                    dict.Add("POSITION", acc);
                    prim.SetMorphTargetAccessors(0, dict);
                    BuffViewoffset += mesh.extradata.Length * 12;
                }
            }
            model.UseScene(0).Name = "Scene";
            model.DefaultScene = model.UseScene(0);
            model.MergeBuffers();
            return model;
        }
        public class MeshBones
        {
            public string[] Names;
            public Vec3[] WorldPosn;
            public int boneCount;
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
                    Vec3 p_0 = new Vec3(mesh.vertices[idx0].X, mesh.vertices[idx0].Y, mesh.vertices[idx0].Z);
                    Vec3 p_1 = new Vec3(mesh.vertices[idx1].X, mesh.vertices[idx1].Y, mesh.vertices[idx1].Z);
                    Vec3 p_2 = new Vec3(mesh.vertices[idx2].X, mesh.vertices[idx2].Y, mesh.vertices[idx2].Z);

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
        public static RawArmature GetNonParentedRig(MeshBones meshBones)
        {
            RawArmature Rig = new RawArmature();
            if (meshBones.boneCount != 0)    // for rigid meshes
            {
                Rig.BoneCount = meshBones.boneCount + 1;
                Rig.LocalPosn = new Vec3[Rig.BoneCount];
                Rig.LocalRot = new System.Numerics.Quaternion[Rig.BoneCount];
                Rig.LocalScale = new Vec3[Rig.BoneCount];
                Rig.Parent = new Int16[Rig.BoneCount];
                Rig.Names = new string[Rig.BoneCount];

                Rig.Parent[0] = -1;
                Rig.Names[0] = "WolvenKit_Root";
                Rig.LocalPosn[0] = new Vec3(0f, 0f, 0f);
                Rig.LocalRot[0] = new System.Numerics.Quaternion(0f, 0f, 0f, 1f);
                Rig.LocalScale[0] = new Vec3(1f, 1f, 1f);

                for (int i = 0; i < Rig.BoneCount - 1; i++)
                {
                    Rig.LocalPosn[i + 1] = meshBones.WorldPosn[i];
                    Rig.Names[i + 1] = meshBones.Names[i];
                    Rig.LocalRot[i + 1] = new System.Numerics.Quaternion(-0.707107f, 0f, 0f, 0.707107f);
                    Rig.LocalScale[i + 1] = new Vec3(1f, 1f, 1f);
                    Rig.Parent[i + 1] = 0;
                }
            }
            return Rig;
        }
    }
}
