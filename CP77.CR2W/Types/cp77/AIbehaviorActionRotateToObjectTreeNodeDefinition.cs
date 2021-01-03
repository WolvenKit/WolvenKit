using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionRotateToObjectTreeNodeDefinition : AIbehaviorActionRotateBaseTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("completeWhenRotated")] public CHandle<AIArgumentMapping> CompleteWhenRotated { get; set; }

		public AIbehaviorActionRotateToObjectTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
