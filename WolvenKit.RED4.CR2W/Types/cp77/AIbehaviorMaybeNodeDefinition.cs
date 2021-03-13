using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMaybeNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] [RED("onChildSuccess")] public CEnum<AIbehaviorMaybeNodeAction> OnChildSuccess { get; set; }
		[Ordinal(2)] [RED("onChildFailure")] public CEnum<AIbehaviorMaybeNodeAction> OnChildFailure { get; set; }

		public AIbehaviorMaybeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
