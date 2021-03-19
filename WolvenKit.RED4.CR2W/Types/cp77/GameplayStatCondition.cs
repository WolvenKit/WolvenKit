using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayStatCondition : GameplayConditionBase
	{
		private TweakDBID _statToCheck;
		private CEnum<EDeviceChallengeAttribute> _stat;
		private CEnum<EGameplayChallengeLevel> _difficulty;

		[Ordinal(1)] 
		[RED("statToCheck")] 
		public TweakDBID StatToCheck
		{
			get => GetProperty(ref _statToCheck);
			set => SetProperty(ref _statToCheck, value);
		}

		[Ordinal(2)] 
		[RED("stat")] 
		public CEnum<EDeviceChallengeAttribute> Stat
		{
			get => GetProperty(ref _stat);
			set => SetProperty(ref _stat, value);
		}

		[Ordinal(3)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetProperty(ref _difficulty);
			set => SetProperty(ref _difficulty, value);
		}

		public GameplayStatCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
