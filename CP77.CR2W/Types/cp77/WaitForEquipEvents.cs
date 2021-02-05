using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WaitForEquipEvents : UpperBodyEventsTransition
	{
		[Ordinal(0)]  [RED("switchButtonPushed")] public CBool SwitchButtonPushed { get; set; }
		[Ordinal(1)]  [RED("cyclePushed")] public CBool CyclePushed { get; set; }
		[Ordinal(2)]  [RED("delay")] public CFloat Delay { get; set; }
		[Ordinal(3)]  [RED("cycleBlock")] public CFloat CycleBlock { get; set; }
		[Ordinal(4)]  [RED("switchPending")] public CBool SwitchPending { get; set; }
		[Ordinal(5)]  [RED("counter")] public CInt32 Counter { get; set; }

		public WaitForEquipEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
