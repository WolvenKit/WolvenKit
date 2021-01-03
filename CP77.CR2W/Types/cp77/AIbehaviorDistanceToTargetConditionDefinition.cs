using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDistanceToTargetConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("comparisonOperator")] public CEnum<EComparisonType> ComparisonOperator { get; set; }
		[Ordinal(1)]  [RED("distance")] public CHandle<AIArgumentMapping> Distance { get; set; }
		[Ordinal(2)]  [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }

		public AIbehaviorDistanceToTargetConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
