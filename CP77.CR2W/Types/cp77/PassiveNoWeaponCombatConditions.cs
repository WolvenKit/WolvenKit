using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PassiveNoWeaponCombatConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)] [RED("delayEvaluationCbId")] public CUInt32 DelayEvaluationCbId { get; set; }
		[Ordinal(1)] [RED("onItemAddedToSlotCbId")] public CUInt32 OnItemAddedToSlotCbId { get; set; }

		public PassiveNoWeaponCombatConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
