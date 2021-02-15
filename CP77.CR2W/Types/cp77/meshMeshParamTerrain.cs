using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamTerrain : meshMeshParameter
	{
		[Ordinal(0)] [RED("chunkBoundingBoxes")] public CArray<Box> ChunkBoundingBoxes { get; set; }

		public meshMeshParamTerrain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
