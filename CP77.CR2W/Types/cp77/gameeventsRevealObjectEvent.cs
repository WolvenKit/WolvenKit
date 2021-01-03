using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameeventsRevealObjectEvent : redEvent
	{
		[Ordinal(0)]  [RED("lifetime")] public CFloat Lifetime { get; set; }
		[Ordinal(1)]  [RED("reason")] public gameVisionModeSystemRevealIdentifier Reason { get; set; }
		[Ordinal(2)]  [RED("reveal")] public CBool Reveal { get; set; }

		public gameeventsRevealObjectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
