using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PassiveAlertedConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)] [RED("highLevelCbId")] public CUInt32 HighLevelCbId { get; set; }
		[Ordinal(1)] [RED("delayEvaluationCbId")] public CUInt32 DelayEvaluationCbId { get; set; }

		public PassiveAlertedConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
