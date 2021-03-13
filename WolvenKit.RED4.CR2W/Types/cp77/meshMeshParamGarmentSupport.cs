using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamGarmentSupport : meshMeshParameter
	{
		[Ordinal(0)] [RED("chunkCapVertices")] public CArray<CArray<CUInt32>> ChunkCapVertices { get; set; }
		[Ordinal(1)] [RED("customMorph")] public CBool CustomMorph { get; set; }

		public meshMeshParamGarmentSupport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
