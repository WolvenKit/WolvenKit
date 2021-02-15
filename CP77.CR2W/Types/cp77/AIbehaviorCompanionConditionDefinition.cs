using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCompanionConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("spline")] public CHandle<AIArgumentMapping> Spline { get; set; }
		[Ordinal(2)] [RED("companion")] public CHandle<AIArgumentMapping> Companion { get; set; }

		public AIbehaviorCompanionConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
