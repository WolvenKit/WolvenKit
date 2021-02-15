using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIInjectCombatThreatCommand : AICombatRelatedCommand
	{
		[Ordinal(5)] [RED("targetNodeRef")] public NodeRef TargetNodeRef { get; set; }
		[Ordinal(6)] [RED("targetPuppetRef")] public gameEntityReference TargetPuppetRef { get; set; }
		[Ordinal(7)] [RED("dontForceHostileAttitude")] public CBool DontForceHostileAttitude { get; set; }
		[Ordinal(8)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(9)] [RED("isPersistent")] public CBool IsPersistent { get; set; }

		public AIInjectCombatThreatCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
