using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PassiveCombatConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)]  [RED("activeCombatConditionCbId")] public CUInt32 ActiveCombatConditionCbId { get; set; }
		[Ordinal(1)]  [RED("combatCommandCbId")] public CUInt32 CombatCommandCbId { get; set; }
		[Ordinal(2)]  [RED("delayEvaluationCbId")] public CUInt32 DelayEvaluationCbId { get; set; }
		[Ordinal(3)]  [RED("playerCombatCbId")] public CUInt32 PlayerCombatCbId { get; set; }
		[Ordinal(4)]  [RED("roleCbId")] public CUInt32 RoleCbId { get; set; }
		[Ordinal(5)]  [RED("threatCbId")] public CUInt32 ThreatCbId { get; set; }

		public PassiveCombatConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
