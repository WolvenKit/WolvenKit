using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSubtreeDefinition : AIbehaviorNestedTreeDefinition
	{
		[Ordinal(2)] [RED("tree")] public CHandle<AIbehaviorParameterizedBehavior> Tree { get; set; }

		public AIbehaviorSubtreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
