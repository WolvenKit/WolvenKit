using System;
using System.Collections.Generic;
using WolvenKit.RED4.GeneralStructs;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using System.IO;
using WolvenKit.Common.DDS;
using WolvenKit.RED4.MeshFile;
using WolvenKit.Common.Oodle;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;
using SharpGLTF.Schema2;
using SharpGLTF.Memory;

namespace WolvenKit.RED4.MorphTargetFile
{
    using Vec4 = System.Numerics.Vector4;
    using Vec3 = System.Numerics.Vector3;
    using Vec2 = System.Numerics.Vector2;

    using RIGIDVERTEX = VertexBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexEmpty>;
    using RIGIDMESH = MeshBuilder<VertexPositionNormalTangent, VertexColor1Texture2, VertexEmpty>;
    using VPNT = VertexPositionNormalTangent;
    using VCT = VertexColor1Texture2;
    public class TARGET
    {
        public static void ExportTargets(Stream targetStream,string outfile, bool isGLBinary = true)
        {
            var cr2w = CP77.CR2W.ModTools.TryReadCr2WFile(targetStream);

            List<RawMeshContainer> expMeshes = new List<RawMeshContainer>();
            MemoryStream meshbuffer = MESH.GetMeshBufferStream(targetStream, cr2w);


            var buffers = cr2w.Buffers;

            targetStream.Seek(cr2w.Buffers[0].Offset, SeekOrigin.Begin);
            MemoryStream diffsbuffer = new MemoryStream();
            targetStream.DecompressAndCopySegment(diffsbuffer, buffers[0].DiskSize, buffers[0].MemSize);

            targetStream.Seek(cr2w.Buffers[1].Offset, SeekOrigin.Begin);
            MemoryStream mappingbuffer = new MemoryStream();
            targetStream.DecompressAndCopySegment(mappingbuffer, buffers[1].DiskSize, buffers[1].MemSize);

            targetStream.Seek(cr2w.Buffers[2].Offset, SeekOrigin.Begin);
            MemoryStream texbuffer = new MemoryStream();
            targetStream.DecompressAndCopySegment(texbuffer, buffers[2].DiskSize, buffers[2].MemSize);

            MeshesInfo meshinfo = MESH.GetMeshesinfo(cr2w);

            for (int i = 0; i < meshinfo.meshC; i++)
            {

                if (meshinfo.LODLvl[i] != 1)
                    continue;
                RawMeshContainer mesh = MESH.ContainRawMesh(meshbuffer, meshinfo.vertCounts[i], meshinfo.indCounts[i], meshinfo.vertOffsets[i], meshinfo.tx0Offsets[i], meshinfo.normalOffsets[i], meshinfo.colorOffsets[i], meshinfo.unknownOffsets[i], meshinfo.indicesOffsets[i], meshinfo.vpStrides[i], meshinfo.qScale, meshinfo.qTrans, meshinfo.weightcounts[i]);
                mesh.name = "mesh_" + i;
                expMeshes.Add(mesh);
            }

            TargetsInfo targetsInfo = GetTargetInfos(cr2w, meshinfo.meshC);

            List<RawTargetContainer[]> expTargets = new List<RawTargetContainer[]>();

            for (int i = 0; i < targetsInfo.NumTargets; i++)
            {
                UInt32[] temp_NumVertexDiffsInEachChunk = new UInt32[meshinfo.meshC];
                UInt32[] temp_NumVertexDiffsMappingInEachChunk = new UInt32[meshinfo.meshC];
                for (int e = 0; e < meshinfo.meshC; e++)
                {
                    temp_NumVertexDiffsInEachChunk[e] = targetsInfo.NumVertexDiffsInEachChunk[i, e];
                    temp_NumVertexDiffsMappingInEachChunk[e] = targetsInfo.NumVertexDiffsMappingInEachChunk[i, e];
                }
                expTargets.Add(ContainRawTargets(diffsbuffer, mappingbuffer, temp_NumVertexDiffsInEachChunk, temp_NumVertexDiffsMappingInEachChunk, targetsInfo.TargetStartsInVertexDiffs[i], targetsInfo.TargetStartsInVertexDiffsMapping[i], targetsInfo.TargetPositionDiffOffset[i], targetsInfo.TargetPositionDiffScale[i], meshinfo.meshC));
            }

            for (int i = 0; i < targetsInfo.NumTargets; i++)
            {
                //ExportASCII(expMeshes, outfile, expTargets[i], targetsInfo.Names[i]);
            }
            string[] names = new string[targetsInfo.NumTargets];
            for (int i = 0; i < targetsInfo.NumTargets; i++)
            {
                names[i] = targetsInfo.Names[i] + "_" + targetsInfo.RegionNames[i];
            }

            List<MemoryStream> textureStreams =  ContainTextureStreams(cr2w, texbuffer);
            ModelRoot model = RawTargetsToGLTF(expMeshes, expTargets, names, textureStreams);

            if (isGLBinary)
                model.SaveGLB(outfile);
            else
                model.SaveGLTF(outfile);
        }
        static TargetsInfo GetTargetInfos(CR2WFile cr2w, int SubMeshC)
        {
            int Index = int.MaxValue;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "rendRenderMorphTargetMeshBlob")
                {
                    Index = i;
                }
            }

            UInt32 NumTargets = (cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.NumTargets.Value;

            UInt32[,] NumVertexDiffsInEachChunk = new UInt32[NumTargets, SubMeshC];
            UInt32 NumDiffs = (cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.NumDiffs.Value;
            UInt32 NumDiffsMapping = (cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.NumDiffsMapping.Value;
            UInt32[,] NumVertexDiffsMappingInEachChunk = new UInt32[NumTargets, SubMeshC];
            UInt32[] TargetStartsInVertexDiffs = new UInt32[NumTargets];
            UInt32[] TargetStartsInVertexDiffsMapping = new UInt32[NumTargets];
            Vec4[] TargetPositionDiffOffset = new Vec4[NumTargets];
            Vec4[] TargetPositionDiffScale = new Vec4[NumTargets];
            for (int i = 0; i < NumTargets; i++)
            {
                for (int e = 0; e < SubMeshC; e++)
                {
                    NumVertexDiffsInEachChunk[i, e] = (cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.NumVertexDiffsInEachChunk[i][e].Value;
                    NumVertexDiffsMappingInEachChunk[i, e] = (cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.NumVertexDiffsMappingInEachChunk[i][e].Value;
                }

                TargetStartsInVertexDiffs[i] = (cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.TargetStartsInVertexDiffs[i].Value;
                TargetStartsInVertexDiffsMapping[i] = (cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.TargetStartsInVertexDiffsMapping[i].Value;


                var o = (cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.TargetPositionDiffOffset[i];
                TargetPositionDiffOffset[i] = new Vec4(o.X.Value, o.Y.Value, o.Z.Value, o.W.Value);
                var s = (cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.TargetPositionDiffScale[i];
                TargetPositionDiffScale[i] = new Vec4(s.X.Value, s.Y.Value, s.Z.Value, s.W.Value);
            }


            Index = int.MaxValue;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "MorphTargetMesh")
                {
                    Index = i;
                }
            }

            string[] Names = new string[NumTargets];
            string[] RegionNames = new string[NumTargets];
            string BaseMesh = (cr2w.Chunks[Index].data as MorphTargetMesh).BaseMesh.DepotPath;
            string BaseTexture = (cr2w.Chunks[Index].data as MorphTargetMesh).BaseTexture.DepotPath;

            for (int i = 0; i < NumTargets; i++)
            {
                Names[i] = (cr2w.Chunks[Index].data as MorphTargetMesh).Targets[i].Name.Value;
                RegionNames[i] = (cr2w.Chunks[Index].data as MorphTargetMesh).Targets[i].RegionName.Value;
            }

            TargetsInfo targetsInfo = new TargetsInfo()
            {
                NumVertexDiffsInEachChunk = NumVertexDiffsInEachChunk,
                NumDiffs = NumDiffs,
                NumDiffsMapping = NumDiffsMapping,
                NumVertexDiffsMappingInEachChunk = NumVertexDiffsMappingInEachChunk,
                TargetStartsInVertexDiffs = TargetStartsInVertexDiffs,
                TargetStartsInVertexDiffsMapping = TargetStartsInVertexDiffsMapping,
                TargetPositionDiffOffset = TargetPositionDiffOffset,
                TargetPositionDiffScale = TargetPositionDiffScale,
                Names = Names,
                RegionNames = RegionNames,
                NumTargets = NumTargets,
                BaseMesh = BaseMesh,
                BaseTexture = BaseTexture,
            };

            return targetsInfo;
        }
        static RawTargetContainer[] ContainRawTargets(MemoryStream diffsbuffer, MemoryStream mappingbuffer, UInt32[] NumVertexDiffsInEachChunk, UInt32[] NumVertexDiffsMappingInEachChunk, UInt32 TargetStartsInVertexDiffs, UInt32 TargetStartsInVertexDiffsMapping, Vec4 TargetPositionDiffOffset, Vec4 TargetPositionDiffScale, int SubMeshC)
        {
            RawTargetContainer[] rawtarget = new RawTargetContainer[SubMeshC];

            BinaryReader diffsbr = new BinaryReader(diffsbuffer);
            BinaryReader mappingbr = new BinaryReader(mappingbuffer);

            for (int i = 0; i < SubMeshC; i++)
            {
                UInt32 diffsCount = NumVertexDiffsInEachChunk[i];
                Vec3[] vertexDelta = new Vec3[diffsCount];
                Vec3[] normalDelta = new Vec3[diffsCount];
                Vec3[] tangentDelta = new Vec3[diffsCount];

                if (i == 0)
                    diffsbuffer.Position = TargetStartsInVertexDiffs * 12;
                else
                {
                    diffsbuffer.Position = TargetStartsInVertexDiffs * 12;

                    for (int eye = 0; eye < i; eye++)
                    {
                        diffsbuffer.Position += NumVertexDiffsInEachChunk[eye] * 12;
                    }
                }


                for (int e = 0; e < diffsCount; e++)
                {
                    Vec4 v = Converters.TenBitUnsigned(diffsbr.ReadUInt32());
                    vertexDelta[e] = new Vec3(v.X * TargetPositionDiffScale.X + TargetPositionDiffOffset.X, v.Y * TargetPositionDiffScale.Y + TargetPositionDiffOffset.Y, v.Z * TargetPositionDiffScale.Z + TargetPositionDiffOffset.Z);
                    Vec4 n = Converters.TenBitShifted(diffsbr.ReadUInt32());
                    normalDelta[e] = new Vec3(n.X, n.Y, n.Z);
                    Vec4 t = Converters.TenBitShifted(diffsbr.ReadUInt32());
                    tangentDelta[e] = new Vec3(t.X, t.Y, t.Z);
                }

                UInt16[] vertexMapping = new UInt16[diffsCount];

                if (i == 0)
                    mappingbuffer.Position = TargetStartsInVertexDiffsMapping * 4;
                else
                {
                    mappingbuffer.Position = TargetStartsInVertexDiffsMapping * 4;

                    for (int eye = 0; eye < i; eye++)
                    {
                        mappingbuffer.Position += NumVertexDiffsMappingInEachChunk[eye] * 4;
                    }
                }

                for (int e = 0; e < diffsCount; e++)
                {
                    vertexMapping[e] = mappingbr.ReadUInt16();
                }

                rawtarget[i] = new RawTargetContainer()
                {
                    vertexDelta = vertexDelta,
                    normalDelta = normalDelta,
                    tangentDelta = tangentDelta,
                    vertexMapping = vertexMapping,
                    diffsCount = diffsCount
                };
            }

            return rawtarget;
        }
        static List<MemoryStream> ContainTextureStreams(CR2WFile cr2w, MemoryStream texbuffer)
        {
            List <MemoryStream> textureStreams = new List<MemoryStream>();

            int Index = int.MaxValue;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == "rendRenderMorphTargetMeshBlob")
                {
                    Index = i;
                }
            }
            int Count = (cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.TargetTextureDiffsData.Count;
            int texCount = 0;
            List<UInt32> TargetDiffsDataOffset = new List<UInt32>();
            List<UInt32> TargetDiffsDataSize = new List<UInt32>();
            List<UInt32> TargetDiffsMipLevelCounts = new List<UInt32>();
            List<UInt32> TargetDiffsWidth = new List<UInt32>();

            for (int i = 0; i < Count; i++)
            {
                if ((cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.TargetTextureDiffsData[i].TargetDiffsDataSize.Count == 0)
                    break;
                TargetDiffsDataOffset.Add((cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.TargetTextureDiffsData[i].TargetDiffsDataOffset[0].Value);
                TargetDiffsDataSize.Add((cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.TargetTextureDiffsData[i].TargetDiffsDataSize[0].Value);
                TargetDiffsMipLevelCounts.Add((cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.TargetTextureDiffsData[i].TargetDiffsMipLevelCounts[0].Value);
                TargetDiffsWidth.Add((cr2w.Chunks[Index].data as rendRenderMorphTargetMeshBlob).Header.TargetTextureDiffsData[i].TargetDiffsWidth[0].Value);
                texCount++;
            }

            BinaryReader texbr = new BinaryReader(texbuffer);
            for (int i = 0; i < texCount; i++)
            {
                texbuffer.Position = TargetDiffsDataOffset[i];
                byte[] bytes = texbr.ReadBytes((int)TargetDiffsDataSize[i]);

                MemoryStream ms = new MemoryStream();
                DDSMetadata metadata = new DDSMetadata(TargetDiffsWidth[i], TargetDiffsWidth[i], TargetDiffsMipLevelCounts[i], EFormat.BC7_UNORM,16,false,0,true);
                DDSUtils.GenerateAndWriteHeader(ms, metadata);
                BinaryWriter bw = new BinaryWriter(ms);
                bw.Write(bytes);
                textureStreams.Add(ms);
            }

            return textureStreams;
        }
        static ModelRoot RawTargetsToGLTF(List<RawMeshContainer> meshes, List<RawTargetContainer[]> expTargets, string[] names, List<MemoryStream> textures)
        {
            var scene = new SharpGLTF.Scenes.SceneBuilder();

            int mIndex = -1;
            foreach (var mesh in meshes)
            {
                ++mIndex;
                long indCount = mesh.indices.Length;
                var expmesh = new RIGIDMESH(mesh.name);

                var prim = expmesh.UsePrimitive(new MaterialBuilder(mesh.name));
                for (long i = 0; i < indCount; i += 3)
                {
                    uint idx0 = mesh.indices[i + 1];
                    uint idx1 = mesh.indices[i];
                    uint idx2 = mesh.indices[i + 2];

                    //VPNT
                    Vec3 p_0 = new Vec3(mesh.vertices[idx0].X, mesh.vertices[idx0].Y, mesh.vertices[idx0].Z);
                    Vec3 n_0 = new Vec3(mesh.normals[idx0].X, mesh.normals[idx0].Y, mesh.normals[idx0].Z);
                    Vec4 t_0 = new Vec4(new Vec3(mesh.tangents[idx0].X, mesh.tangents[idx0].Y, mesh.tangents[idx0].Z), 1);

                    Vec3 p_1 = new Vec3(mesh.vertices[idx1].X, mesh.vertices[idx1].Y, mesh.vertices[idx1].Z);
                    Vec3 n_1 = new Vec3(mesh.normals[idx1].X, mesh.normals[idx1].Y, mesh.normals[idx1].Z);
                    Vec4 t_1 = new Vec4(new Vec3(mesh.tangents[idx1].X, mesh.tangents[idx1].Y, mesh.tangents[idx1].Z), 1);

                    Vec3 p_2 = new Vec3(mesh.vertices[idx2].X, mesh.vertices[idx2].Y, mesh.vertices[idx2].Z);
                    Vec3 n_2 = new Vec3(mesh.normals[idx2].X, mesh.normals[idx2].Y, mesh.normals[idx2].Z);
                    Vec4 t_2 = new Vec4(new Vec3(mesh.tangents[idx2].X, mesh.tangents[idx2].Y, mesh.tangents[idx2].Z), 1);

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
                for (int i = 0; i < expTargets.Count; i++)
                {
                    var morphBuilder = expmesh.UseMorphTarget(i);

                    for (int e = 0; e < expTargets[i][mIndex].diffsCount; e++)
                    {
                        morphBuilder.SetVertexDelta(mesh.vertices[expTargets[i][mIndex].vertexMapping[e]], new VertexGeometryDelta(expTargets[i][mIndex].vertexDelta[e], expTargets[i][mIndex].normalDelta[e], expTargets[i][mIndex].tangentDelta[e]));
                    }
                }
                var obj = new { targetNames = names }; // anonymous variable/obj

                expmesh.Extras = SharpGLTF.IO.JsonContent.Serialize(obj);
                scene.AddRigidMesh(expmesh, System.Numerics.Matrix4x4.CreateFromQuaternion(new System.Numerics.Quaternion((float)-0.707107, 0, 0, (float)0.707107)));
            }
            var model = scene.ToGltf2();

            return model;
        }
    }
}
