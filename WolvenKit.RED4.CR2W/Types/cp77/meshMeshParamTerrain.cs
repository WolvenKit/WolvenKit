using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamTerrain : meshMeshParameter
	{
		[Ordinal(0)] [RED("chunkBoundingBoxes")] public CArray<Box> ChunkBoundingBoxes { get; set; }

		public meshMeshParamTerrain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
