using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplaySkillCondition : GameplayConditionBase
	{
		private TweakDBID _skillToCheck;
		private CEnum<EGameplayChallengeLevel> _difficulty;

		[Ordinal(1)] 
		[RED("skillToCheck")] 
		public TweakDBID SkillToCheck
		{
			get => GetProperty(ref _skillToCheck);
			set => SetProperty(ref _skillToCheck, value);
		}

		[Ordinal(2)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetProperty(ref _difficulty);
			set => SetProperty(ref _difficulty, value);
		}

		public GameplaySkillCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
