using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneUID : CVariable
	{
		[Ordinal(0)] [RED("nodeRefHash")] public CUInt64 NodeRefHash { get; set; }
		[Ordinal(1)] [RED("laneNumber")] public CUInt16 LaneNumber { get; set; }
		[Ordinal(2)] [RED("seqNumber")] public CUInt16 SeqNumber { get; set; }
		[Ordinal(3)] [RED("isReversed")] public CBool IsReversed { get; set; }

		public worldTrafficLaneUID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
