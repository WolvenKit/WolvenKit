using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorClearSearchInfluenceTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("clearedAreaRadius")] public CHandle<AIArgumentMapping> ClearedAreaRadius { get; set; }
		[Ordinal(2)] [RED("clearedAreaDistance")] public CHandle<AIArgumentMapping> ClearedAreaDistance { get; set; }
		[Ordinal(3)] [RED("clearedAreaAngle")] public CHandle<AIArgumentMapping> ClearedAreaAngle { get; set; }

		public AIbehaviorClearSearchInfluenceTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
