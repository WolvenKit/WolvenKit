using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDelegateTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("onActivate")] public AIbehaviorDelegateTaskRef OnActivate { get; set; }
		[Ordinal(2)] [RED("onUpdate")] public AIbehaviorDelegateTaskRef OnUpdate { get; set; }
		[Ordinal(3)] [RED("onDeactivate")] public AIbehaviorDelegateTaskRef OnDeactivate { get; set; }

		public AIbehaviorDelegateTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
