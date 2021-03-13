using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIMeleeAttackCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] [RED("targetOverrideNodeRef")] public NodeRef TargetOverrideNodeRef { get; set; }
		[Ordinal(1)] [RED("targetOverridePuppetRef")] public gameEntityReference TargetOverridePuppetRef { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }

		public AIMeleeAttackCommandParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
