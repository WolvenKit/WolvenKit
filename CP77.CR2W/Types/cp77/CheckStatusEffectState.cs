using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckStatusEffectState : AIStatusEffectCondition
	{
		[Ordinal(0)]  [RED("statusEffectType")] public CEnum<gamedataStatusEffectType> StatusEffectType { get; set; }
		[Ordinal(1)]  [RED("stateToCheck")] public CEnum<EstatusEffectsState> StateToCheck { get; set; }
		[Ordinal(2)]  [RED("topPrioStatusEffect")] public CHandle<gameStatusEffect> TopPrioStatusEffect { get; set; }

		public CheckStatusEffectState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
