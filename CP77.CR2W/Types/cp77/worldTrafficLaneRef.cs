using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneRef : CVariable
	{
		[Ordinal(0)]  [RED("isReversed")] public CBool IsReversed { get; set; }
		[Ordinal(1)]  [RED("laneNumber")] public CUInt16 LaneNumber { get; set; }
		[Ordinal(2)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }

		public worldTrafficLaneRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
