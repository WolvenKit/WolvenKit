using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsReadyEvents : QuickSlotsEvents
	{
		[Ordinal(0)]  [RED("shouldSendEvent")] public CBool ShouldSendEvent { get; set; }
		[Ordinal(1)]  [RED("timePressed")] public CFloat TimePressed { get; set; }

		public QuickSlotsReadyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
