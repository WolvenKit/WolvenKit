using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldStreamingQueryDataResource : CResource
	{
		[Ordinal(1)] [RED("roadDatas")] public CArray<worldStreamingQueryRoadData> RoadDatas { get; set; }
		[Ordinal(2)] [RED("connectedRoadDataIndices")] public CArray<CUInt16> ConnectedRoadDataIndices { get; set; }

		public worldStreamingQueryDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
