using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
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
