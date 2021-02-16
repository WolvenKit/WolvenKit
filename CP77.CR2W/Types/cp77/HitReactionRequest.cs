using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitReactionRequest : redEvent
	{
		[Ordinal(0)] [RED("hitEvent")] public CHandle<gameeventsHitEvent> HitEvent { get; set; }

		public HitReactionRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
