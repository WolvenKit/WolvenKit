using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectCombatTargetTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(1)]  [RED("targetClosest")] public CBool TargetClosest { get; set; }

		public AIbehaviorSelectCombatTargetTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
