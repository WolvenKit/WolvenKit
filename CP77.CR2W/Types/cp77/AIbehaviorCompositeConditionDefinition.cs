using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCompositeConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("conditions")] public CArray<CHandle<AIbehaviorConditionDefinition>> Conditions { get; set; }

		public AIbehaviorCompositeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
