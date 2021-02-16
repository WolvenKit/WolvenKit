using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamBakedDestructionData : meshMeshParameter
	{
		[Ordinal(0)] [RED("regionData")] public CArray<meshRegionData> RegionData { get; set; }
		[Ordinal(1)] [RED("indices")] public CArray<DataBuffer> Indices { get; set; }

		public meshMeshParamBakedDestructionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
