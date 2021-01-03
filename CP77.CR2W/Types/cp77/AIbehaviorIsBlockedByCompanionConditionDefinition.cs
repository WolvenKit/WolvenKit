using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIsBlockedByCompanionConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		[Ordinal(0)]  [RED("distance")] public CHandle<AIArgumentMapping> Distance { get; set; }

		public AIbehaviorIsBlockedByCompanionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
