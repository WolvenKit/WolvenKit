using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSubtreeDefinition : AIbehaviorNestedTreeDefinition
	{
		[Ordinal(0)]  [RED("tree")] public CHandle<AIbehaviorParameterizedBehavior> Tree { get; set; }

		public AIbehaviorSubtreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
