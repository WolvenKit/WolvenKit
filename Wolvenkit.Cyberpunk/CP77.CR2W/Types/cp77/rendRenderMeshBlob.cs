using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using FastMember;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{


    [REDMeta]
    public class DataBuffer : CVariable
    {
        
        public DataBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public CBytes Buffer { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            Buffer = new CBytes(cr2w, this, nameof(Buffer))
            {
                Bytes = new byte[0],
                IsSerialized = true
            };

            Buffer.Read(file, size);
        }
    }




    [REDMeta]
    public class rendChunk : CVariable
    {
        [Ordinal(1)] [RED("chunkVertices")] public rendVertexBufferChunk ChunkVertices { get; set; }
        [Ordinal(2)] [RED("chunkIndices")] public rendIndexBufferChunk ChunkIndices { get; set; }
        [Ordinal(3)] [RED("numVertices")] public CUInt16 NumVertices { get; set; }
        [Ordinal(4)] [RED("numIndices")] public CUInt32 NumIndices { get; set; }
        [Ordinal(5)] [RED("vertexFactory")] public CUInt8 VertexFactory { get; set; }
        [Ordinal(6)] [RED("renderMask")] public CEnum<Enums.EMeshChunkFlags> renderMask { get; set; }
        [Ordinal(7)] [RED("lodMask")] public CUInt8 LodMask { get; set; }


        public rendChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class rendVertexBufferChunk : CVariable
    {
        [Ordinal(1)] [RED("vertexLayout")] public GpuWrapApiVertexLayoutDesc VertexLayout { get; set; }
        [Ordinal(2)] [RED("byteOffsets", 5)] public CStatic<CUInt32> ByteOffsets { get; set; }

        public rendVertexBufferChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class rendIndexBufferChunk : CVariable
    {
        [Ordinal(1)] [RED("pe")] public CEnum<Enums.GpuWrapApieIndexBufferChunkType> Pe { get; set; }
        [Ordinal(2)] [RED("teOffset")] public CUInt32 TeOffset { get; set; }

        public rendIndexBufferChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    

    [REDMeta]
    public class GpuWrapApiVertexLayoutDesc : CVariable
    {
        [Ordinal(1)] [RED("elements", 32)] public CStatic<GpuWrapApiVertexPackingPackingElement> Elements { get; set; }
        [Ordinal(2)] [RED("slotStrides", 8)] public CStatic<CUInt8> SlotStrides { get; set; }
        [Ordinal(3)] [RED("slotMask")] public CUInt32 SlotMask { get; set; }
        [Ordinal(4)] [RED("hash")] public CUInt32 Hash { get; set; }

        public GpuWrapApiVertexLayoutDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class GpuWrapApiVertexPackingPackingElement : CVariable
    {
        [Ordinal(1)] [RED("type")] public CEnum<Enums.GpuWrapApiVertexPackingePackingType> Type { get; set; }
        [Ordinal(2)] [RED("usage")] public CEnum<Enums.GpuWrapApiVertexPackingePackingUsage> Usage { get; set; }
        [Ordinal(2)] [RED("streamType")] public CEnum<Enums.GpuWrapApiVertexPackingEStreamType> StreamType { get; set; }

        public GpuWrapApiVertexPackingPackingElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
