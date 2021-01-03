using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PassiveAlertedConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)]  [RED("delayEvaluationCbId")] public CUInt32 DelayEvaluationCbId { get; set; }
		[Ordinal(1)]  [RED("highLevelCbId")] public CUInt32 HighLevelCbId { get; set; }

		public PassiveAlertedConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
