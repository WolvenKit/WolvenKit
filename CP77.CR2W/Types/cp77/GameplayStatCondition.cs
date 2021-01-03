using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameplayStatCondition : GameplayConditionBase
	{
		[Ordinal(0)]  [RED("difficulty")] public CEnum<EGameplayChallengeLevel> Difficulty { get; set; }
		[Ordinal(1)]  [RED("stat")] public CEnum<EDeviceChallengeAttribute> Stat { get; set; }
		[Ordinal(2)]  [RED("statToCheck")] public TweakDBID StatToCheck { get; set; }

		public GameplayStatCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
