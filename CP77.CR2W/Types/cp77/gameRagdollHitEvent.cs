using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameRagdollHitEvent : gameeventsHitEvent
	{
		[Ordinal(0)]  [RED("heightDelta")] public CFloat HeightDelta { get; set; }
		[Ordinal(1)]  [RED("impactForce")] public CFloat ImpactForce { get; set; }
		[Ordinal(2)]  [RED("speedDelta")] public CFloat SpeedDelta { get; set; }

		public gameRagdollHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
