using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneRef : CVariable
	{
		[Ordinal(0)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(1)]  [RED("laneNumber")] public CUInt16 LaneNumber { get; set; }
		[Ordinal(2)]  [RED("isReversed")] public CBool IsReversed { get; set; }

		public worldTrafficLaneRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
