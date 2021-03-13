using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNestedTreeDefinition : AIbehaviorTreeNodeDefinition
	{
		[Ordinal(0)] [RED("lateInitialization")] public CBool LateInitialization { get; set; }
		[Ordinal(1)] [RED("initializeOnEvent")] public CArray<CName> InitializeOnEvent { get; set; }

		public AIbehaviorNestedTreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
