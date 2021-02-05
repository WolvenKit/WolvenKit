using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameeventsTargetDamageEvent : gameeventsTargetHitEvent
	{
		[Ordinal(0)]  [RED("wasAliveBeforeHit")] public CBool WasAliveBeforeHit { get; set; }
		[Ordinal(1)]  [RED("projectionPipeline")] public CBool ProjectionPipeline { get; set; }
		[Ordinal(2)]  [RED("damage")] public CFloat Damage { get; set; }

		public gameeventsTargetDamageEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
