using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsTargetDamageEvent : gameeventsTargetHitEvent
	{
		[Ordinal(12)] [RED("damage")] public CFloat Damage { get; set; }

		public gameeventsTargetDamageEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
