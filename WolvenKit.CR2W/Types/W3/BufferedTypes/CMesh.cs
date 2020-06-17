using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta]
    public class CMesh : CMeshTypeResource
    {
        [RED("collisionMesh")] public CHandle<CCollisionMesh> CollisionMesh { get; set; }

        [RED("useExtraStreams")] public CBool UseExtraStreams { get; set; }

        [RED("generalizedMeshRadius")] public CFloat GeneralizedMeshRadius { get; set; }

        [RED("mergeInGlobalShadowMesh")] public CBool MergeInGlobalShadowMesh { get; set; }

        [RED("isOccluder")] public CBool IsOccluder { get; set; }

        [RED("smallestHoleOverride")] public CFloat SmallestHoleOverride { get; set; }

        [RED("chunks", 2, 0)] public CArray<SMeshChunkPacked> Chunks { get; set; }

        [RED("rawVertices")] public DeferredDataBuffer RawVertices { get; set; }

        [RED("rawIndices")] public DeferredDataBuffer RawIndices { get; set; }

        [RED("isStatic")] public CBool IsStatic { get; set; }

        [RED("entityProxy")] public CBool EntityProxy { get; set; }

        [RED("cookedData")] public SMeshCookedData CookedData { get; set; }

        [RED("soundInfo")] public CPtr<SMeshSoundInfo> SoundInfo { get; set; }

        [RED("internalVersion")] public CUInt8 InternalVersion { get; set; }

        [RED("chunksBuffer")] public DeferredDataBuffer ChunksBuffer { get; set; }

        // ATTENTION: don't read and write like a normal VLQ array
        // this one is padded by 4 bytes after each inner list
        public CBufferVLQ<CPaddedBuffer<CUInt16>> chunkgroupIndeces; 

        public CBufferVLQ<CName> boneNames;
        public CBufferVLQ<CMatrix4x4> bonematrices;
        public CBufferVLQ<CFloat> block3;
        public CBufferVLQ<CUInt32> boneIndecesMappingBoneIndex;
        
            
        public CMesh(CR2WFile cr2w) :
            base(cr2w)
        {
            chunkgroupIndeces = new CBufferVLQ<CPaddedBuffer<CUInt16>>(cr2w);

            boneNames = new CBufferVLQ<CName>(cr2w);
            bonematrices = new CBufferVLQ<CMatrix4x4>(cr2w);
            block3 = new CBufferVLQ<CFloat>(cr2w);
            boneIndecesMappingBoneIndex = new CBufferVLQ<CUInt32>(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            chunkgroupIndeces.Read(file, size);
            boneNames.Read(file, 2);
            bonematrices.Read(file, 64);
            block3.Read(file, 4);
            boneIndecesMappingBoneIndex.Read(file, 4);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            chunkgroupIndeces.Write(file);
            boneNames.Write(file);
            bonematrices.Write(file);
            block3.Write(file);
            boneIndecesMappingBoneIndex.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CMesh(cr2w);
        }
    }
}