using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questForcedBehaviourNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("behavior")] public CHandle<AIbehaviorParameterizedBehavior> Behavior { get; set; }
		[Ordinal(1)]  [RED("puppet")] public gameEntityReference Puppet { get; set; }
		[Ordinal(2)]  [RED("tree")] public CHandle<questForcedBehaviorReference> Tree { get; set; }

		public questForcedBehaviourNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
