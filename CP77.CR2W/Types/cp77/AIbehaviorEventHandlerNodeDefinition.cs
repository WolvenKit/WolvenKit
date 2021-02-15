using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEventHandlerNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(2)] [RED("resolver")] public CHandle<AIbehaviorEventResolverDefinition> Resolver { get; set; }

		public AIbehaviorEventHandlerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
