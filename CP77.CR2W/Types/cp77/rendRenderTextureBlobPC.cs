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
