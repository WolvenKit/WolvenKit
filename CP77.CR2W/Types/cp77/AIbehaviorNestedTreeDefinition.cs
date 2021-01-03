using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorNestedTreeDefinition : AIbehaviorTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("initializeOnEvent")] public CArray<CName> InitializeOnEvent { get; set; }
		[Ordinal(1)]  [RED("lateInitialization")] public CBool LateInitialization { get; set; }

		public AIbehaviorNestedTreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
