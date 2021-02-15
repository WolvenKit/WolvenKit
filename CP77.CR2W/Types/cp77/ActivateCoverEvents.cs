using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActivateCoverEvents : CoverActionEventsTransition
	{
		[Ordinal(0)] [RED("usingCover")] public CBool UsingCover { get; set; }

		public ActivateCoverEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
