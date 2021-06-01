using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Catel.IoC;
using CP77.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common.Oodle;
using WolvenKit.RED4.GeneralStructs;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using SharpGLTF.Scenes;
using SharpGLTF.Schema2;
using WolvenKit.RED4.RigFile;

namespace WolvenKit.RED4.MeshFile
{
    using Vec4 = System.Numerics.Vector4;
    using Vec3 = System.Numerics.Vector3;
    using Vec2 = System.Numerics.Vector2;

    using SKINNEDVERTEX = VertexBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexJoints8>;
    using SKINNEDMESH = MeshBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexJoints8>;
    using RIGIDVERTEX = VertexBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexEmpty>;
    using RIGIDMESH = MeshBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexEmpty>;
    using VPNT = VertexPositionNormalTangent;
    using VCT = VertexColor1Texture2;
    using VJ = VertexJoints8;

    public class MESH
    {
        private readonly ModTools ModTools;

        public MESH()
        {
            ModTools = ServiceLocator.Default.ResolveType<ModTools>();
        }

        private const string tempmodels = "tempmodels\\OBJ\\";
        public string ExportMeshWithoutRigPreviewer(string FilePath, bool LodFilter = true, bool isGLBinary = true)
        {
            try
            {
                string outfile;

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



                FileStream meshStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                string _meshName = Path.GetFileNameWithoutExtension(FilePath);


                List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();
                var cr2w = ModTools.TryReadCr2WFile(meshStream);

                MemoryStream ms = GetMeshBufferStream(meshStream, cr2w);


                MeshesInfo meshinfo = GetMeshesinfo(cr2w);


                for (int i = 0; i < meshinfo.meshC; i++)
                {
                    if (meshinfo.LODLvl[i] != 1 && LodFilter)
                        continue;
                    RawMeshContainer mesh = ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i]);
                    mesh.name = _meshName + "_" + i;

                    mesh.appNames = new string[meshinfo.appearances.Count];
                    mesh.materialNames = new string[meshinfo.appearances.Count];
                    for (int e = 0; e < meshinfo.appearances.Count; e++)
                    {
                        mesh.appNames[e] = meshinfo.appearances[e].Name;
                        mesh.materialNames[e] = meshinfo.appearances[e].MaterialNames[i];
                    }
                    expMeshes.Add(mesh);
                }
                ModelRoot model = RawRigidMeshesToGLTF(expMeshes);
                if (isGLBinary)
                {
                    outfile = tempmodels + Path.GetFileNameWithoutExtension(FilePath) + ".glb";
                    model.SaveGLB(outfile);
                }
                else
                {
                    outfile = tempmodels + Path.GetFileNameWithoutExtension(FilePath) + ".gltf";
                    model.SaveGLTF(outfile);
                }
                meshStream.Dispose();
                meshStream.Close();
                return outfile;
            }
            catch
            {
                return "";
            }



        }
        public void ExportMeshWithPlaceHolderRig(Stream meshStream, string _meshName, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();
            var cr2w = ModTools.TryReadCr2WFile(meshStream);

            RawArmature Rig = new RawArmature();
            MeshBones bones = new MeshBones();

            int last = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "CMesh")
                {
                    last = i;
                }
            }
            if ((cr2w.Chunks[last].data as CMesh).BoneNames.Count != 0)    // for rigid meshes
            {
                bones.Names = RIG.GetboneNames(cr2w, "CMesh");
                bones.WorldPosn = GetMeshBonesPosn(cr2w);

                Rig.BoneCount = (cr2w.Chunks[last].data as CMesh).BoneNames.Count + 1;
                Rig.LocalPosn = new Vec3[Rig.BoneCount];
                Rig.LocalRot = new System.Numerics.Quaternion[Rig.BoneCount];
                Rig.LocalScale = new Vec3[Rig.BoneCount];
                Rig.Parent = new Int16[Rig.BoneCount];
                Rig.Names = new string[Rig.BoneCount];

                Rig.Parent[0] = -1;
                Rig.Names[0] = "WkitPlaceHolderBone";
                Rig.LocalPosn[0] = new Vec3(0f, 0f, 0f);
                Rig.LocalRot[0] = new System.Numerics.Quaternion(0f, 0f, 0f, 1f);
                Rig.LocalScale[0] = new Vec3(1f, 1f, 1f);

                for (int i = 0; i < Rig.BoneCount - 1; i++)
                {
                    Rig.LocalPosn[i + 1] = bones.WorldPosn[i];
                    Rig.Names[i + 1] = bones.Names[i];
                    Rig.LocalRot[i + 1] = new System.Numerics.Quaternion(-0.707107f, 0f, 0f, 0.707107f);
                    Rig.LocalScale[i + 1] = new Vec3(1f, 1f, 1f);
                    Rig.Parent[i + 1] = 0;
                }
            }

            MemoryStream ms = GetMeshBufferStream(meshStream, cr2w);
            MeshesInfo meshinfo = GetMeshesinfo(cr2w);
            for (int i = 0; i < meshinfo.meshC; i++)
            {
                if (meshinfo.LODLvl[i] != 1 && LodFilter)
                    continue;
                RawMeshContainer mesh = ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i], meshinfo.extraExists[i]);
                mesh.name = _meshName + "_" + i + "_" + meshinfo.LODLvl[i];
                UpdateMeshJoints(ref mesh, Rig, bones);

                mesh.appNames = new string[meshinfo.appearances.Count];
                mesh.materialNames = new string[meshinfo.appearances.Count];
                for (int e = 0; e < meshinfo.appearances.Count; e++)
                {
                    mesh.appNames[e] = meshinfo.appearances[e].Name;
                    mesh.materialNames[e] = meshinfo.appearances[e].MaterialNames[i];
                }
                expMeshes.Add(mesh);
            }
            ModelRoot model = RawSkinnedMeshesToGLTF(expMeshes,Rig);
            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            meshStream.Dispose();
            meshStream.Close();
        }
        public bool ExportMeshWithoutRig(Stream meshStream, string _meshName, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();
            var cr2w = ModTools.TryReadCr2WFile(meshStream);

            MemoryStream ms = GetMeshBufferStream(meshStream,cr2w);
            MeshesInfo meshinfo = GetMeshesinfo(cr2w);
            for(int i = 0; i < meshinfo.meshC; i ++)
            {
                if (meshinfo.LODLvl[i] != 1 && LodFilter)
                    continue;
                RawMeshContainer mesh = ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i],meshinfo.extraExists[i]);
                mesh.name = _meshName + "_" + i + "_" + meshinfo.LODLvl[i];

                mesh.appNames = new string[meshinfo.appearances.Count];
                mesh.materialNames = new string[meshinfo.appearances.Count];
                for (int e = 0; e < meshinfo.appearances.Count; e++)
                {
                    mesh.appNames[e] = meshinfo.appearances[e].Name;
                    mesh.materialNames[e] = meshinfo.appearances[e].MaterialNames[i];
                }
                expMeshes.Add(mesh);
            }
            ModelRoot model = RawRigidMeshesToGLTF(expMeshes);
            if(isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);


            meshStream.Dispose();
            meshStream.Close();
            return true;

        }
        public void ExportMultiMeshWithoutRig(List<Stream> meshStreamS, List<string> _meshNameS, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            for(int m = 0; m < meshStreamS.Count; m++)
            {
                var cr2w = ModTools.TryReadCr2WFile(meshStreamS[m]);

                MemoryStream ms = GetMeshBufferStream(meshStreamS[m], cr2w);
                MeshesInfo meshinfo = GetMeshesinfo(cr2w);
                for (int i = 0; i < meshinfo.meshC; i++)
                {
                    if (meshinfo.LODLvl[i] != 1 && LodFilter)
                        continue;
                    RawMeshContainer mesh = ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i], meshinfo.extraExists[i]);
                    mesh.name = _meshNameS[m] + "_" + i + "_" + meshinfo.LODLvl[i];
                    mesh.appNames = new string[meshinfo.appearances.Count];
                    mesh.materialNames = new string[meshinfo.appearances.Count];
                    for (int e = 0; e < meshinfo.appearances.Count; e++)
                    {
                        mesh.appNames[e] = meshinfo.appearances[e].Name;
                        mesh.materialNames[e] = meshinfo.appearances[e].MaterialNames[i];
                    }
                    expMeshes.Add(mesh);
                }
            }
            ModelRoot model = RawRigidMeshesToGLTF(expMeshes);
            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            for(int i = 0; i < meshStreamS.Count; i++)
            {
                meshStreamS[i].Dispose();
                meshStreamS[i].Close();
            }
        }
        public void ExportMeshWithRig(Stream meshStream, Stream rigStream,string _meshName, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            RawArmature Rig = (new RIG()).ProcessRig(rigStream);

            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            var cr2w = ModTools.TryReadCr2WFile(meshStream);

            MemoryStream ms = GetMeshBufferStream(meshStream, cr2w);
            MeshesInfo meshinfo = GetMeshesinfo(cr2w);

            MeshBones bones = new MeshBones();

            int last = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "CMesh")
                {
                    last = i;
                }
            }
            if ((cr2w.Chunks[last].data as CMesh).BoneNames.Count != 0)    // for rigid meshes
            {
                bones.Names = RIG.GetboneNames(cr2w, "CMesh");
                bones.WorldPosn = GetMeshBonesPosn(cr2w);
            }

            for (int i = 0; i < meshinfo.meshC; i++)
            {
                if (meshinfo.LODLvl[i] != 1 && LodFilter)
                    continue;
                RawMeshContainer mesh = ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i], meshinfo.extraExists[i]);
                mesh.name = _meshName + "_" + i + "_" + meshinfo.LODLvl[i];
                UpdateMeshJoints(ref mesh, Rig, bones);

                mesh.appNames = new string[meshinfo.appearances.Count];
                mesh.materialNames = new string[meshinfo.appearances.Count];
                for (int e = 0; e < meshinfo.appearances.Count; e++)
                {
                    mesh.appNames[e] = meshinfo.appearances[e].Name;
                    mesh.materialNames[e] = meshinfo.appearances[e].MaterialNames[i];
                }
                expMeshes.Add(mesh);
            }

            ModelRoot model = RawSkinnedMeshesToGLTF(expMeshes,Rig);
            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            meshStream.Dispose();
            meshStream.Close();
            rigStream.Dispose();
            rigStream.Close();
        }
        public void ExportMultiMeshWithRig(List<Stream> meshStreamS, List<Stream> rigStreamS, List<string> _meshNameS, FileInfo outfile, bool LodFilter = true, bool isGLBinary = true)
        {
            List<RawArmature> Rigs = new List<RawArmature>();
            rigStreamS = rigStreamS.OrderByDescending(r => r.Length).ToList();  // not so smart hacky method to get bodybase rigs on top/ orderby descending
            for (int r = 0; r < rigStreamS.Count; r++)
            {
                RawArmature Rig = (new RIG()).ProcessRig(rigStreamS[r]);
                Rigs.Add(Rig);
            }
            RawArmature expRig = RIG.CombineRigs(Rigs);

            List <RawMeshContainer> expMeshes = new List<RawMeshContainer>();

            for (int m = 0; m < meshStreamS.Count; m++)
            {
                BinaryReader br = new BinaryReader(meshStreamS[m]);

                var cr2w = ModTools.TryReadCr2WFile(meshStreamS[m]);

                MemoryStream ms = GetMeshBufferStream(meshStreamS[m], cr2w);
                MeshesInfo meshinfo = GetMeshesinfo(cr2w);

                MeshBones bones = new MeshBones();

                int last = 0;
                for (int i = 0; i < cr2w.Chunks.Count; i++)
                {
                    if (cr2w.Chunks[i].REDType == "CMesh")
                    {
                        last = i;
                    }
                }
                if ((cr2w.Chunks[last].data as CMesh).BoneNames.Count != 0)    // for rigid meshes
                {
                    bones.Names = RIG.GetboneNames(cr2w, "CMesh");
                    bones.WorldPosn = GetMeshBonesPosn(cr2w);
                }

                for (int i = 0; i < meshinfo.meshC; i++)
                {
                    if (meshinfo.LODLvl[i] != 1 && LodFilter)
                        continue;
                    RawMeshContainer mesh = ContainRawMesh(ms, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i], meshinfo.extraExists[i]);
                    mesh.name = _meshNameS[m] + "_" + i + "_" + meshinfo.LODLvl[i];
                    if (meshinfo.weightcounts[0] != 0)   // for static meshes
                        UpdateMeshJoints(ref mesh, expRig, bones);

                    mesh.appNames = new string[meshinfo.appearances.Count];
                    mesh.materialNames = new string[meshinfo.appearances.Count];
                    for (int e = 0; e < meshinfo.appearances.Count; e++)
                    {
                        mesh.appNames[e] = meshinfo.appearances[e].Name;
                        mesh.materialNames[e] = meshinfo.appearances[e].MaterialNames[i];
                    }
                    expMeshes.Add(mesh);
                }
            }
            ModelRoot model = RawSkinnedMeshesToGLTF(expMeshes, expRig);
            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            for(int i = 0; i < meshStreamS.Count; i++)
            {
                meshStreamS[i].Dispose();
                meshStreamS[i].Close();
            }
            for (int i = 0; i < rigStreamS.Count; i++)
            {
                rigStreamS[i].Dispose();
                rigStreamS[i].Close();
            }
        }
        static Vec3[] GetMeshBonesPosn(CR2WFile cr2w)
        {
            int Index = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "rendRenderMeshBlob")
                {
                    Index = i;
                }
            }
            int boneCount = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.BonePositions.Count;
            Vec3[] posn = new Vec3[boneCount];
            float x, y, z = 0;
            for (int i = 0; i < boneCount; i++)
            {
                x = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.BonePositions[i].X.Value;
                y = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.BonePositions[i].Y.Value;
                z = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.BonePositions[i].Z.Value;
                posn[i] = new Vec3(x, z, -y);
            }
            return posn;
        }
        public static MeshesInfo GetMeshesinfo(CR2WFile cr2w)
        {
            int Index = 0;
            bool renderBlobExists = false;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "rendRenderMeshBlob")
                {
                    Index = i;
                    renderBlobExists = true;
                }
            }
            int meshC = 0;
            if(renderBlobExists)
            meshC = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos.Count;
            else
            {
                return (new MeshesInfo()
                {
                    meshC = 0,
                });
            }

            UInt32[] vertCounts = new UInt32[meshC];
            UInt32[] indCounts = new UInt32[meshC];
            UInt32[] vertOffsets = new UInt32[meshC];
            UInt32[] tx0Offsets = new UInt32[meshC];
            UInt32[] normalOffsets = new UInt32[meshC];
            UInt32[] colorOffsets = new UInt32[meshC];
            UInt32[] unknownOffsets = new UInt32[meshC];
            UInt32[] indicesOffsets = new UInt32[meshC];
            UInt32[] vpStrides = new UInt32[meshC];
            UInt32[] LODLvl = new UInt32[meshC];
            bool[] extraExists = new bool[meshC];

            for (int i = 0; i < meshC; i++)
            {
                vertCounts[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].NumVertices.Value;
                indCounts[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].NumIndices.Value;
                vertOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[0].Value;
                tx0Offsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[1].Value;
                normalOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[2].Value;
                colorOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[3].Value;
                unknownOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.ByteOffsets[4].Value;

                if ((cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkIndices.TeOffset == null)
                {
                    indicesOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.IndexBufferOffset.Value;
                }
                else
                {
                    indicesOffsets[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.IndexBufferOffset.Value + (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkIndices.TeOffset.Value;
                }
                vpStrides[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.SlotStrides[0].Value;
                LODLvl[i] = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].LodMask.Value;
            }
            Vector4 qSc = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.QuantizationScale;
            Vector4 qTr = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.QuantizationOffset;

            Vec4 qScale = new Vec4(qSc.X.Value, qSc.Y.Value, qSc.Z.Value, qSc.W.Value);
            Vec4 qTrans = new Vec4(qTr.X.Value, qTr.Y.Value, qTr.Z.Value, qTr.W.Value);

            // getting number of weights for the meshes
            UInt32[] weightcounts = new UInt32[meshC];
            int count = 0;
            UInt32 counter = 0;
            string checker = string.Empty;

            for (int i = 0; i < meshC; i++)
            {
                count = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements.Count;
                counter = 0;
                for (int e = 0; e < count; e++)
                {
                    checker = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].Usage.EnumValueList[0];
                    if (checker == "PS_SkinIndices")
                        counter++;
                }
                weightcounts[i] = counter * 4;
            }

            for (int i = 0; i < meshC; i++)
            {
                extraExists[i] = false;
                count = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements.Count;

                for (int e = 0; e < count; e++)
                {
                    checker = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.RenderChunkInfos[i].ChunkVertices.VertexLayout.Elements[e].Usage.EnumValueList[0];
                    if (checker == "PS_ExtraData")
                    {
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
                    appearance.Name = (cr2w.Chunks[i].data as meshMeshAppearance).Name.Value;
                    if(appearance.Name == string.Empty)
                        appearance.Name = "DEFAULT";
                    int mtCount = (cr2w.Chunks[i].data as meshMeshAppearance).ChunkMaterials.Count;
                    appearance.MaterialNames = new string[mtCount];
                    for(int e = 0; e < mtCount; e++)
                    {
                        appearance.MaterialNames[e] = (cr2w.Chunks[i].data as meshMeshAppearance).ChunkMaterials[e].Value;
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
                colorOffsets = colorOffsets,
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
                vertBufferSize = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.VertexBufferSize.Value,
                indexBufferOffset = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.IndexBufferOffset.Value,
                indexBufferSize = (cr2w.Chunks[Index].data as rendRenderMeshBlob).Header.IndexBufferSize.Value
            };
            return meshesInfo;
        }
        public static RawMeshContainer ContainRawMesh(MemoryStream gfs, UInt32 vertCount, UInt32 indCount, UInt32 vertOffset, UInt32 tx0Offset, UInt32 normalOffset, UInt32 colorOffset, UInt32 unknownOffset, UInt32 indOffset, UInt32 vpStride, Vec4 qScale, Vec4 qTrans, UInt32 weightcount, bool extraExist = false)
        {
            BinaryReader gbr = new BinaryReader(gfs);

            Vec3[] vertices = new Vec3[vertCount];
            uint[] indices = new uint[indCount];
            Vec2[] tx0coords = new Vec2[vertCount];
            Vec3[] normals = new Vec3[vertCount];
            Vec4[] tangents = new Vec4[vertCount];
            Vec4[] colors = new Vec4[vertCount];
            Vec2[] tx1coords = new Vec2[vertCount];
            float[,] weights = new float[vertCount, weightcount];
            UInt16[,] boneindices = new UInt16[vertCount, weightcount];
            Vec3[] extradata = new Vec3[vertCount];

            // geting vertices
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = vertOffset + i * vpStride;

                float x = (gbr.ReadInt16() / 32767f) * qScale.X + qTrans.X;
                float y = (gbr.ReadInt16() / 32767f) * qScale.Y + qTrans.Y;
                float z = (gbr.ReadInt16() / 32767f) * qScale.Z + qTrans.Z;
                // changing orientation of geomerty, Y+ Z+ RHS-LHS BS
                vertices[i] = new Vec3(x, z, -y);
            }
            // got vertices

            float[] values = new float[vertCount * 2];

            if (tx0Offset != 0)
            {
                // getting texturecoord0 as half floats
                gfs.Position = tx0Offset;
                for (int i = 0; i < vertCount * 2; i++)
                {
                    UInt16 read = gbr.ReadUInt16();
                    values[i] = Converters.hfconvert(read);
                }
                for (int i = 0; i < vertCount; i++)
                {
                    tx0coords[i] = new Vec2(values[2 * i], values[2 * i + 1]);
                }
                // got texturecoord0 as half floats
            }

            UInt32 NorRead32;
            // getting 10bit normals
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = normalOffset + 8 * i;
                NorRead32 = gbr.ReadUInt32();
                Vec4 tempv = Converters.TenBitShifted(NorRead32);
                // changing orientation of geomerty, Y+ Z+ RHS-LHS BS
                normals[i] = new Vec3(tempv.X, tempv.Z, - tempv.Y);
            }
            // got 10bit normals

            // getting 10bit tangents
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = normalOffset + 4 + 8 * i;
                NorRead32 = gbr.ReadUInt32();
                Vec4 tempv = Converters.TenBitShifted(NorRead32);
                // changing orientation of geomerty, Y+ Z+ RHS-LHS BS
                tangents[i] = new Vec4(tempv.X, tempv.Z, - tempv.Y, 1f);
            }


            if (colorOffset != 0)
            {
                gfs.Position = colorOffset + 4;
                // getting texturecoord1 as half floats
                for (int i = 0; i < vertCount * 2; i++)
                {
                    UInt16 read = gbr.ReadUInt16();
                    values[i] = Converters.hfconvert(read);
                    if (i % 2 != 0)
                        gfs.Position += 4;
                }
                for (int i = 0; i < vertCount; i++)
                {
                    tx1coords[i] = new Vec2(values[2 * i], values[2 * i + 1]);
                }
                // got texturecoord1 as half floats
            }

            if (colorOffset != 0)
            {
                for (int i = 0; i < vertCount; i++)
                {
                    gfs.Position = colorOffset + i * 8;
                    Vec4 tempv = new Vec4(gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f, gbr.ReadByte() / 255f);
                    colors[i] = new Vec4(tempv.X, tempv.Y, tempv.Z, tempv.W);

                }
                // got vert colors
            }

            // getting bone indices
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = vertOffset + i * vpStride + 8;
                for (int e = 0; e < weightcount; e++)
                {
                    boneindices[i, e] = gbr.ReadByte();
                }
            }
            // got bone indexes

            // getting weights
            for (int i = 0; i < vertCount; i++)
            {
                gfs.Position = vertOffset + i * vpStride + 8 + weightcount;
                for (int e = 0; e < weightcount; e++)
                {
                    weights[i, e] = gbr.ReadByte() / 255f;
                }
            }
            // got weights

            if(extraExist)
            {
                for (int i = 0; i < vertCount; i++)
                {
                    gfs.Position = vertOffset + i * vpStride + 8 + 2 * weightcount;
                    float x = Converters.hfconvert(gbr.ReadUInt16());
                    float y = Converters.hfconvert(gbr.ReadUInt16());
                    float z = Converters.hfconvert(gbr.ReadUInt16());
                    extradata[i] = new Vec3(x, z, -y);
                }
            }
            // getting uint16 faces/indices
            gfs.Position = indOffset;
            for (int i = 0; i < indCount; i++)
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
                weightcount = weightcount,
                extradata = extradata,
                extraExist = extraExist
            };
            return mesh;
        }
        static void UpdateMeshJoints(ref RawMeshContainer Mesh, RawArmature Rig, MeshBones Bones)
        {
            // updating mesh bone indexes
            for (int e = 0; e < Mesh.vertices.Length; e++)
            {
                for (int eye = 0; eye < Mesh.weightcount; eye++)
                {
                    for (UInt16 r = 0; r < Rig.BoneCount; r++)
                    {
                        if (Rig.Names[r] == Bones.Names[Mesh.boneindices[e, eye]])
                        {
                            Mesh.boneindices[e, eye] = r;
                            break;
                        }
                    }
                }
            }

        }
        public static MemoryStream GetMeshBufferStream(Stream ms, CR2WFile cr2w)
        {
            int Index = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "rendRenderMeshBlob")
                {
                    Index = i;
                }

            }
            UInt16 p = BitConverter.ToUInt16((cr2w.Chunks[Index].data as rendRenderMeshBlob).RenderBuffer.Buffer.Bytes);
            var b = cr2w.Buffers[p - 1];
            ms.Seek(b.Offset, SeekOrigin.Begin);
            MemoryStream meshstream = new MemoryStream();
            ms.DecompressAndCopySegment(meshstream, b.DiskSize, b.MemSize);
            return meshstream;
        }
        public static ModelRoot RawSkinnedMeshesToGLTF(List<RawMeshContainer> meshes,RawArmature Rig)
        {
            var scene = new SceneBuilder();

            var bones = RIG.ExportNodes(Rig);
            var rootbone = bones.Values.Where(n => n.Parent == null).FirstOrDefault();

            foreach (var mesh in meshes)
            {
                long indCount = mesh.indices.Length;
                var expmesh = new SKINNEDMESH(mesh.name);

                var prim = expmesh.UsePrimitive(new MaterialBuilder("Default").WithDoubleSide(true));
                for (int i = 0; i < indCount; i += 3)
                {
                    uint idx0 = mesh.indices[i + 1];
                    uint idx1 = mesh.indices[i];
                    uint idx2 = mesh.indices[i + 2];

                    //VPNT
                    Vec3 p_0 = new Vec3(mesh.vertices[idx0].X, mesh.vertices[idx0].Y, mesh.vertices[idx0].Z);
                    Vec3 n_0 = new Vec3(mesh.normals[idx0].X, mesh.normals[idx0].Y, mesh.normals[idx0].Z);
                    Vec4 t_0 = new Vec4(mesh.tangents[idx0].X, mesh.tangents[idx0].Y, mesh.tangents[idx0].Z, mesh.tangents[idx0].W);

                    Vec3 p_1 = new Vec3(mesh.vertices[idx1].X, mesh.vertices[idx1].Y, mesh.vertices[idx1].Z);
                    Vec3 n_1 = new Vec3(mesh.normals[idx1].X, mesh.normals[idx1].Y, mesh.normals[idx1].Z);
                    Vec4 t_1 = new Vec4(mesh.tangents[idx1].X, mesh.tangents[idx1].Y, mesh.tangents[idx1].Z, mesh.tangents[idx1].W);

                    Vec3 p_2 = new Vec3(mesh.vertices[idx2].X, mesh.vertices[idx2].Y, mesh.vertices[idx2].Z);
                    Vec3 n_2 = new Vec3(mesh.normals[idx2].X, mesh.normals[idx2].Y, mesh.normals[idx2].Z);
                    Vec4 t_2 = new Vec4(mesh.tangents[idx2].X, mesh.tangents[idx2].Y, mesh.tangents[idx2].Z, mesh.tangents[idx2].W);

                    //VCT
                    Vec2 tx0_0 = new Vec2(mesh.tx0coords[idx0].X, mesh.tx0coords[idx0].Y);
                    Vec2 tx1_0 = new Vec2(mesh.tx1coords[idx0].X, mesh.tx1coords[idx0].Y);

                    Vec2 tx0_1 = new Vec2(mesh.tx0coords[idx1].X, mesh.tx0coords[idx1].Y);
                    Vec2 tx1_1 = new Vec2(mesh.tx1coords[idx1].X, mesh.tx1coords[idx1].Y);

                    Vec2 tx0_2 = new Vec2(mesh.tx0coords[idx2].X, mesh.tx0coords[idx2].Y);
                    Vec2 tx1_2 = new Vec2(mesh.tx1coords[idx2].X, mesh.tx1coords[idx2].Y);

                    Vec4 col_0 = new Vec4(mesh.colors[idx0].X, mesh.colors[idx0].Y, mesh.colors[idx0].Z, mesh.colors[idx0].W);
                    Vec4 col_1 = new Vec4(mesh.colors[idx1].X, mesh.colors[idx1].Y, mesh.colors[idx1].Z, mesh.colors[idx1].W);
                    Vec4 col_2 = new Vec4(mesh.colors[idx2].X, mesh.colors[idx2].Y, mesh.colors[idx2].Z, mesh.colors[idx2].W);


                    (int, float)[] bind0 = new (int, float)[8];
                    (int, float)[] bind1 = new (int, float)[8];
                    (int, float)[] bind2 = new (int, float)[8];

                    if(mesh.weightcount == 0)   // for rigid meshes
                    {
                        bind0[0].Item2 = 1f;
                        bind1[0].Item2 = 1f;
                        bind2[0].Item2 = 1f;
                    }

                    for (int w = 0; w < mesh.weightcount ; w++)
                    {
                        bind0[w].Item1 = mesh.boneindices[idx0, w];
                        bind0[w].Item2 = mesh.weights[idx0, w];
                        bind1[w].Item1 = mesh.boneindices[idx1, w];
                        bind1[w].Item2 = mesh.weights[idx1, w];
                        bind2[w].Item1 = mesh.boneindices[idx2, w];
                        bind2[w].Item2 = mesh.weights[idx2, w];
                    }
                    // vertex build
                    var v0 = new SKINNEDVERTEX(new VPNT(p_0, n_0, t_0), new VCT(col_0, tx0_0, tx1_0), new VJ(bind0));
                    var v1 = new SKINNEDVERTEX(new VPNT(p_1, n_1, t_1), new VCT(col_1, tx0_1, tx1_1), new VJ(bind1));
                    var v2 = new SKINNEDVERTEX(new VPNT(p_2, n_2, t_2), new VCT(col_2, tx0_2, tx1_2), new VJ(bind2));
                    // triangle build
                    prim.AddTriangle(v0, v1, v2);
                }

                if (mesh.extraExist)
                {
                    var morphbuilder = expmesh.UseMorphTarget(0);
                    for (int i = 0; i < mesh.vertices.Length; i++)
                    {
                        morphbuilder.SetVertexDelta(mesh.vertices[i], mesh.extradata[i]);
                    }
                }

                var obj = new { appNames = mesh.appNames, materialNames = mesh.materialNames }; // anonymous variable/obj

                expmesh.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);

                scene.AddSkinnedMesh(expmesh, rootbone.WorldMatrix, bones.Values.ToArray());
            }
            var model = scene.ToGltf2();

            return model;
        }
        public static ModelRoot RawRigidMeshesToGLTF(List<RawMeshContainer> meshes)
        {
            var scene = new SceneBuilder();

            foreach (var mesh in meshes)
            {
                long indCount = mesh.indices.Length;
                var expmesh = new RIGIDMESH(mesh.name);

                var prim = expmesh.UsePrimitive(new MaterialBuilder("Default").WithDoubleSide(true));
                for (int i = 0; i < indCount; i += 3)
                {
                    uint idx0 = mesh.indices[i + 1];
                    uint idx1 = mesh.indices[i];
                    uint idx2 = mesh.indices[i + 2];

                    //VPNT
                    Vec3 p_0 = new Vec3(mesh.vertices[idx0].X, mesh.vertices[idx0].Y, mesh.vertices[idx0].Z);
                    Vec3 n_0 = new Vec3(mesh.normals[idx0].X, mesh.normals[idx0].Y, mesh.normals[idx0].Z);
                    Vec4 t_0 = new Vec4(mesh.tangents[idx0].X, mesh.tangents[idx0].Y, mesh.tangents[idx0].Z, mesh.tangents[idx0].W);

                    Vec3 p_1 = new Vec3(mesh.vertices[idx1].X, mesh.vertices[idx1].Y, mesh.vertices[idx1].Z);
                    Vec3 n_1 = new Vec3(mesh.normals[idx1].X, mesh.normals[idx1].Y, mesh.normals[idx1].Z);
                    Vec4 t_1 = new Vec4(mesh.tangents[idx1].X, mesh.tangents[idx1].Y, mesh.tangents[idx1].Z, mesh.tangents[idx1].W);

                    Vec3 p_2 = new Vec3(mesh.vertices[idx2].X, mesh.vertices[idx2].Y, mesh.vertices[idx2].Z);
                    Vec3 n_2 = new Vec3(mesh.normals[idx2].X, mesh.normals[idx2].Y, mesh.normals[idx2].Z);
                    Vec4 t_2 = new Vec4(mesh.tangents[idx2].X, mesh.tangents[idx2].Y, mesh.tangents[idx2].Z, mesh.tangents[idx2].W);

                    //VCT
                    Vec2 tx0_0 = new Vec2(mesh.tx0coords[idx0].X, mesh.tx0coords[idx0].Y);
                    Vec2 tx1_0 = new Vec2(mesh.tx1coords[idx0].X, mesh.tx1coords[idx0].Y);

                    Vec2 tx0_1 = new Vec2(mesh.tx0coords[idx1].X, mesh.tx0coords[idx1].Y);
                    Vec2 tx1_1 = new Vec2(mesh.tx1coords[idx1].X, mesh.tx1coords[idx1].Y);

                    Vec2 tx0_2 = new Vec2(mesh.tx0coords[idx2].X, mesh.tx0coords[idx2].Y);
                    Vec2 tx1_2 = new Vec2(mesh.tx1coords[idx2].X, mesh.tx1coords[idx2].Y);

                    Vec4 col_0 = new Vec4(mesh.colors[idx0].X, mesh.colors[idx0].Y, mesh.colors[idx0].Z, mesh.colors[idx0].W);
                    Vec4 col_1 = new Vec4(mesh.colors[idx1].X, mesh.colors[idx1].Y, mesh.colors[idx1].Z, mesh.colors[idx1].W);
                    Vec4 col_2 = new Vec4(mesh.colors[idx2].X, mesh.colors[idx2].Y, mesh.colors[idx2].Z, mesh.colors[idx2].W);

                    // vertex build
                    var v0 = new RIGIDVERTEX(new VPNT(p_0, n_0, t_0), new VCT(col_0, tx0_0, tx1_0));
                    var v1 = new RIGIDVERTEX(new VPNT(p_1, n_1, t_1), new VCT(col_1, tx0_1, tx1_1));
                    var v2 = new RIGIDVERTEX(new VPNT(p_2, n_2, t_2), new VCT(col_2, tx0_2, tx1_2));
                    // triangle build
                    prim.AddTriangle(v0, v1, v2);
                }

                if(mesh.extraExist)
                {
                    var morphbuilder = expmesh.UseMorphTarget(0);
                    for (int i = 0; i < mesh.vertices.Length; i++)
                    {
                        morphbuilder.SetVertexDelta(mesh.vertices[i], mesh.extradata[i]);
                    }
                }
                var obj = new { appNames = mesh.appNames, materialNames = mesh.materialNames }; // anonymous variable/obj

                expmesh.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);
                scene.AddRigidMesh(expmesh, System.Numerics.Matrix4x4.Identity);
            }
            var model = scene.ToGltf2();
            return model;
        }
        class MeshBones
        {
            public string[] Names;
            public Vec3[] WorldPosn;
        }
    }
}
