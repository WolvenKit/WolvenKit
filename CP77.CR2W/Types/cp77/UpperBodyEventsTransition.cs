using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UpperBodyEventsTransition : UpperBodyTransition
	{
		[Ordinal(0)]  [RED("counter")] public CInt32 Counter { get; set; }
		[Ordinal(1)]  [RED("cycleBlock")] public CFloat CycleBlock { get; set; }
		[Ordinal(2)]  [RED("cyclePushed")] public CBool CyclePushed { get; set; }
		[Ordinal(3)]  [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(4)]  [RED("switchButtonPushed")] public CBool SwitchButtonPushed { get; set; }
		[Ordinal(5)]  [RED("switchPending")] public CBool SwitchPending { get; set; }

		public UpperBodyEventsTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
