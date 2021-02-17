using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TemporaryUnequipEvents : UpperBodyEventsTransition
	{
		[Ordinal(6)] [RED("forceOpen")] public CBool ForceOpen { get; set; }

		public TemporaryUnequipEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
