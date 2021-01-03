using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorResource : CResource
	{
		[Ordinal(0)]  [RED("arguments")] public AITreeArgumentsDefinition Arguments { get; set; }
		[Ordinal(1)]  [RED("delegate")] public CHandle<AIbehaviorBehaviorDelegate> Delegate { get; set; }
		[Ordinal(2)]  [RED("initializationEvents")] public CArray<CName> InitializationEvents { get; set; }
		[Ordinal(3)]  [RED("root")] public CHandle<AIbehaviorTreeNodeDefinition> Root { get; set; }

		public AIbehaviorResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
