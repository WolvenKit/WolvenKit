using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SkillCheckBase : IScriptable
	{
		private TweakDBID _alternativeName;
		private CEnum<EGameplayChallengeLevel> _difficulty;
		private CHandle<GameplayConditionContainer> _additionalRequirements;
		private CFloat _duration;
		private CBool _isActive;
		private CBool _wasPassed;
		private CBool _skillCheckPerformed;
		private CEnum<EDeviceChallengeSkill> _skillToCheck;
		private CHandle<GameplaySkillCondition> _baseSkill;
		private CBool _isDynamic;

		[Ordinal(0)] 
		[RED("alternativeName")] 
		public TweakDBID AlternativeName
		{
			get => GetProperty(ref _alternativeName);
			set => SetProperty(ref _alternativeName, value);
		}

		[Ordinal(1)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetProperty(ref _difficulty);
			set => SetProperty(ref _difficulty, value);
		}

		[Ordinal(2)] 
		[RED("additionalRequirements")] 
		public CHandle<GameplayConditionContainer> AdditionalRequirements
		{
			get => GetProperty(ref _additionalRequirements);
			set => SetProperty(ref _additionalRequirements, value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(4)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(5)] 
		[RED("wasPassed")] 
		public CBool WasPassed
		{
			get => GetProperty(ref _wasPassed);
			set => SetProperty(ref _wasPassed, value);
		}

		[Ordinal(6)] 
		[RED("skillCheckPerformed")] 
		public CBool SkillCheckPerformed
		{
			get => GetProperty(ref _skillCheckPerformed);
			set => SetProperty(ref _skillCheckPerformed, value);
		}

		[Ordinal(7)] 
		[RED("skillToCheck")] 
		public CEnum<EDeviceChallengeSkill> SkillToCheck
		{
			get => GetProperty(ref _skillToCheck);
			set => SetProperty(ref _skillToCheck, value);
		}

		[Ordinal(8)] 
		[RED("baseSkill")] 
		public CHandle<GameplaySkillCondition> BaseSkill
		{
			get => GetProperty(ref _baseSkill);
			set => SetProperty(ref _baseSkill, value);
		}

		[Ordinal(9)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get => GetProperty(ref _isDynamic);
			set => SetProperty(ref _isDynamic, value);
		}

		public SkillCheckBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
