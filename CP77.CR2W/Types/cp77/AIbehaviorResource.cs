using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorResource : CResource
	{
		[Ordinal(1)] [RED("root")] public CHandle<AIbehaviorTreeNodeDefinition> Root { get; set; }
		[Ordinal(2)] [RED("arguments")] public AITreeArgumentsDefinition Arguments { get; set; }
		[Ordinal(3)] [RED("delegate")] public CHandle<AIbehaviorBehaviorDelegate> Delegate { get; set; }
		[Ordinal(4)] [RED("initializationEvents")] public CArray<CName> InitializationEvents { get; set; }

		public AIbehaviorResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
