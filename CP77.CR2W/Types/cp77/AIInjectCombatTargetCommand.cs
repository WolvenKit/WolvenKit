using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIInjectCombatTargetCommand : AICombatRelatedCommand
	{
		[Ordinal(0)]  [RED("targetNodeRef")] public NodeRef TargetNodeRef { get; set; }
		[Ordinal(1)]  [RED("targetPuppetRef")] public gameEntityReference TargetPuppetRef { get; set; }
		[Ordinal(2)]  [RED("duration")] public CFloat Duration { get; set; }

		public AIInjectCombatTargetCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
