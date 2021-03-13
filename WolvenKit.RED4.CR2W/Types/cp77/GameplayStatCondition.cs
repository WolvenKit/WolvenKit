using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayStatCondition : GameplayConditionBase
	{
		[Ordinal(1)] [RED("statToCheck")] public TweakDBID StatToCheck { get; set; }
		[Ordinal(2)] [RED("stat")] public CEnum<EDeviceChallengeAttribute> Stat { get; set; }
		[Ordinal(3)] [RED("difficulty")] public CEnum<EGameplayChallengeLevel> Difficulty { get; set; }

		public GameplayStatCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
