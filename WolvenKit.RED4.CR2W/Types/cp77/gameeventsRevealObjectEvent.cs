using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsRevealObjectEvent : redEvent
	{
		[Ordinal(0)] [RED("reveal")] public CBool Reveal { get; set; }
		[Ordinal(1)] [RED("reason")] public gameVisionModeSystemRevealIdentifier Reason { get; set; }
		[Ordinal(2)] [RED("lifetime")] public CFloat Lifetime { get; set; }

		public gameeventsRevealObjectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
