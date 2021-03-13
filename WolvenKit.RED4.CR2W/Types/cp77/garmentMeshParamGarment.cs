using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class garmentMeshParamGarment : meshMeshParameter
	{
		[Ordinal(0)] [RED("chunks")] public CArray<garmentMeshParamGarmentChunkData> Chunks { get; set; }

		public garmentMeshParamGarment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
