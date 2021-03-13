using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questForcedBehaviourNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("puppet")] public gameEntityReference Puppet { get; set; }
		[Ordinal(3)] [RED("tree")] public CHandle<questForcedBehaviorReference> Tree { get; set; }
		[Ordinal(4)] [RED("behavior")] public CHandle<AIbehaviorParameterizedBehavior> Behavior { get; set; }

		public questForcedBehaviourNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
