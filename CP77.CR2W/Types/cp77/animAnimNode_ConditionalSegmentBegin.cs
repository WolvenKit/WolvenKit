using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ConditionalSegmentBegin : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("condition")] public animConditionalSegmentCondition Condition { get; set; }

        [Ordinal(991)] [RED("segmentEndNodeId")] public CUInt32 segmentEndNodeId { get; set; }

		public animAnimNode_ConditionalSegmentBegin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
