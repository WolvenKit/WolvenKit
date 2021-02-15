using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamCloth_Graphical : meshMeshParameter
	{
		[Ordinal(0)] [RED("lodChunkIndices")] public CArray<CArray<CUInt16>> LodChunkIndices { get; set; }
		[Ordinal(1)] [RED("chunks")] public CArray<meshGfxClothChunkData> Chunks { get; set; }
		[Ordinal(2)] [RED("latchers")] public CArray<CArray<CArray<CUInt16>>> Latchers { get; set; }

		public meshMeshParamCloth_Graphical(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
