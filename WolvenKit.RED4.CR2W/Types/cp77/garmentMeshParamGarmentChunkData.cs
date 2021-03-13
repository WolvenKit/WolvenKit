using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class garmentMeshParamGarmentChunkData : CVariable
	{
		[Ordinal(0)] [RED("numVertices")] public CUInt32 NumVertices { get; set; }
		[Ordinal(1)] [RED("lodMask")] public CUInt8 LodMask { get; set; }
		[Ordinal(2)] [RED("isTwoSided")] public CBool IsTwoSided { get; set; }
		[Ordinal(3)] [RED("vertices")] public DataBuffer Vertices { get; set; }
		[Ordinal(4)] [RED("indices")] public DataBuffer Indices { get; set; }
		[Ordinal(5)] [RED("morphOffsets")] public DataBuffer MorphOffsets { get; set; }
		[Ordinal(6)] [RED("garmentFlags")] public DataBuffer GarmentFlags { get; set; }

		public garmentMeshParamGarmentChunkData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
