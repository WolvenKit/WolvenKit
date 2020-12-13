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
    public class rendRenderTextureBlobPC : CVariable
    {
        [Ordinal(1)] [RED("header")] public rendRenderTextureBlobHeader Header { get; set; }
        [Ordinal(2)] [RED("textureData")] public serializationDeferredDataBuffer TextureData { get; set; }

        public rendRenderTextureBlobPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class serializationDeferredDataBuffer : CVariable
    {
        
        public serializationDeferredDataBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

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
    public class rendRenderTextureBlobHeader : CVariable
    {
        [Ordinal(1)] [RED("version")] public CUInt32 Version { get; set; }

        [Ordinal(2)] [RED("sizeInfo")] public rendRenderTextureBlobSizeInfo SizeInfo { get; set; }
        [Ordinal(3)] [RED("textureInfo")] public rendRenderTextureBlobTextureInfo TextureInfo { get; set; }
        [Ordinal(4)] [RED("mipMapInfo")] public CArray<rendRenderTextureBlobMipMapInfo> MipMapInfo { get; set; }
        [Ordinal(5)] [RED("flags")] public CUInt32 Flags { get; set; }

        public rendRenderTextureBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class rendRenderTextureBlobSizeInfo : CVariable
    {
        [Ordinal(1)] [RED("width")] public CUInt16 Width { get; set; }
        [Ordinal(2)] [RED("height")] public CUInt16 Height { get; set; }

        public rendRenderTextureBlobSizeInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class rendRenderTextureBlobTextureInfo : CVariable
    {
        [Ordinal(1)] [RED("textureDataSize")] public CUInt32 TextureDataSize { get; set; }
        [Ordinal(2)] [RED("sliceSize")] public CUInt32 SliceSize { get; set; }
        [Ordinal(3)] [RED("dataAlignment")] public CUInt32 DataAlignment { get; set; }
        [Ordinal(4)] [RED("sliceCount")] public CUInt16 SliceCount { get; set; }
        [Ordinal(5)] [RED("mipCount")] public CUInt8 MipCount { get; set; }


        public rendRenderTextureBlobTextureInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class rendRenderTextureBlobMipMapInfo : CVariable
    {
        [Ordinal(1)] [RED("layout")] public rendRenderTextureBlobMemoryLayout Width { get; set; }
        [Ordinal(2)] [RED("placement")] public rendRenderTextureBlobPlacement Placement { get; set; }


        public rendRenderTextureBlobMipMapInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }


    }
    [REDMeta]
    public class rendRenderTextureBlobMemoryLayout : CVariable
    {
        [Ordinal(1)] [RED("rowPitch")] public CUInt32 RowPitch { get; set; }
        [Ordinal(2)] [RED("slicePitch")] public CUInt32 SlicePitch { get; set; }


        public rendRenderTextureBlobMemoryLayout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }


    }
    [REDMeta]
    public class rendRenderTextureBlobPlacement : CVariable
    {
        [Ordinal(1)] [RED("offset")] public CUInt32 Offset { get; set; }
        [Ordinal(2)] [RED("size")] public CUInt32 Size { get; set; }


        public rendRenderTextureBlobPlacement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }


    }



}
