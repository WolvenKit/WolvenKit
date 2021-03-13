using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsReadyEvents : QuickSlotsEvents
	{
		[Ordinal(0)] [RED("shouldSendEvent")] public CBool ShouldSendEvent { get; set; }
		[Ordinal(1)] [RED("timePressed")] public CFloat TimePressed { get; set; }

		public QuickSlotsReadyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
