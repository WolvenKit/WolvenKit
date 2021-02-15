using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIJoinTargetsSquadCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] [RED("targetPuppetRef")] public gameEntityReference TargetPuppetRef { get; set; }

		public AIJoinTargetsSquadCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
