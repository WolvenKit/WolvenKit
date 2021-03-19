using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayPerkCondition : GameplayConditionBase
	{
		private TweakDBID _perkToCheck;
		private CEnum<EGameplayChallengeLevel> _difficulty;

		[Ordinal(1)] 
		[RED("perkToCheck")] 
		public TweakDBID PerkToCheck
		{
			get => GetProperty(ref _perkToCheck);
			set => SetProperty(ref _perkToCheck, value);
		}

		[Ordinal(2)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetProperty(ref _difficulty);
			set => SetProperty(ref _difficulty, value);
		}

		public GameplayPerkCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
