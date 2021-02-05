using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsColliderMesh : physicsICollider
	{
		[Ordinal(0)]  [RED("faceMaterials")] public CArray<CName> FaceMaterials { get; set; }
		[Ordinal(1)]  [RED("compiledGeometryBuffer")] public DataBuffer CompiledGeometryBuffer { get; set; }

        [Ordinal(1000)] [REDBuffer] public CArrayVLQInt32<physicsColliderMeshData> Unk1 { get; set; }
        [Ordinal(1001)] [REDBuffer] public CArrayVLQInt32<physicsColliderMeshData> Unk2 { get; set; }
        [Ordinal(1002)] [REDBuffer] public CArrayVLQInt32<physicsColliderMeshData> Unk3 { get; set; }

		public physicsColliderMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        

    }

    [REDMeta(EREDMetaInfo.REDStruct)]
    public class physicsColliderMeshData : CVariable
    {
        [Ordinal(0)] [RED] public CUInt16 Unk1 { get; set; }

        public physicsColliderMeshData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }



    }
}
