using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTrafficLaneSpanInfo : CVariable
	{
		[Ordinal(0)]  [RED("laneId")] public worldTrafficLaneUID LaneId { get; set; }
		[Ordinal(1)]  [RED("laneX1")] public CFloat LaneX1 { get; set; }
		[Ordinal(2)]  [RED("laneX2")] public CFloat LaneX2 { get; set; }

		public gameTrafficLaneSpanInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
