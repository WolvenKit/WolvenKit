using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneCrowdFragment : CVariable
	{
		[Ordinal(0)]  [RED("crowdCreationDataIndex")] public CUInt32 CrowdCreationDataIndex { get; set; }
		[Ordinal(1)]  [RED("desiredSlotCountsPerTimePeriod", 4)] public CStatic<worldDesiredSlotsCountInfo> DesiredSlotCountsPerTimePeriod { get; set; }
		[Ordinal(2)]  [RED("laneX1")] public CFloat LaneX1 { get; set; }
		[Ordinal(3)]  [RED("laneX2")] public CFloat LaneX2 { get; set; }

		public worldTrafficLaneCrowdFragment(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
