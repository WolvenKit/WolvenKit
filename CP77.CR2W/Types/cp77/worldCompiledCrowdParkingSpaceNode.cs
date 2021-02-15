using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCompiledCrowdParkingSpaceNode : worldNode
	{
		[Ordinal(2)] [RED("crowdCreationIndex")] public CUInt32 CrowdCreationIndex { get; set; }
		[Ordinal(3)] [RED("parkingSpaceId")] public CUInt32 ParkingSpaceId { get; set; }

		public worldCompiledCrowdParkingSpaceNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
