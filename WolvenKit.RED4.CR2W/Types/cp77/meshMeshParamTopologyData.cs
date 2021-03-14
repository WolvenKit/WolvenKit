using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamTopologyData : meshMeshParameter
	{
		[Ordinal(0)] [RED("data")] public DataBuffer Data { get; set; }
		[Ordinal(1)] [RED("offsets")] public CArray<CUInt32> Offsets { get; set; }
		[Ordinal(2)] [RED("sizes")] public CArray<CUInt32> Sizes { get; set; }

		public meshMeshParamTopologyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
