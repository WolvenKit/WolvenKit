using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameplayPerkCondition : GameplayConditionBase
	{
		[Ordinal(1)] [RED("perkToCheck")] public TweakDBID PerkToCheck { get; set; }
		[Ordinal(2)] [RED("difficulty")] public CEnum<EGameplayChallengeLevel> Difficulty { get; set; }

		public GameplayPerkCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
