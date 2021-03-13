using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_CombatTarget : questCombatNodeParams
	{
		[Ordinal(0)] [RED("targetNode")] public NodeRef TargetNode { get; set; }
		[Ordinal(1)] [RED("targetPuppet")] public gameEntityReference TargetPuppet { get; set; }
		[Ordinal(2)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(3)] [RED("immediately")] public CBool Immediately { get; set; }

		public questCombatNodeParams_CombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
