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
    public class meshMeshParamGarmentSupport : CVariable
    {
        [Ordinal(1)] [RED("chunkCapVertices")] public CArray<CArray<CUInt32>> ChunkCapVertices { get; set; }
        [Ordinal(2)] [RED("customMorph")] public CBool CustomMorph { get; set; }

        public meshMeshParamGarmentSupport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class meshMeshAppearance : CVariable
    {
        [Ordinal(1)] [RED("name")] public CName Name { get; set; }
        [Ordinal(2)] [RED("chunkMaterials")] public CArray<CName> ChunkMaterials { get; set; }

        public meshMeshAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    
}
