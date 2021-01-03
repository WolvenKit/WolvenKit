using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ConditionalSegmentBegin : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("condition")] public animConditionalSegmentCondition Condition { get; set; }

		public animAnimNode_ConditionalSegmentBegin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
