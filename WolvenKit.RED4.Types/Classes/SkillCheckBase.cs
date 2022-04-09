using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SkillCheckBase : IScriptable
	{
		[Ordinal(0)] 
		[RED("alternativeName")] 
		public TweakDBID AlternativeName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetPropertyValue<CEnum<EGameplayChallengeLevel>>();
			set => SetPropertyValue<CEnum<EGameplayChallengeLevel>>(value);
		}

		[Ordinal(2)] 
		[RED("additionalRequirements")] 
		public CHandle<GameplayConditionContainer> AdditionalRequirements
		{
			get => GetPropertyValue<CHandle<GameplayConditionContainer>>();
			set => SetPropertyValue<CHandle<GameplayConditionContainer>>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("wasPassed")] 
		public CBool WasPassed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("skillCheckPerformed")] 
		public CBool SkillCheckPerformed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("skillToCheck")] 
		public CEnum<EDeviceChallengeSkill> SkillToCheck
		{
			get => GetPropertyValue<CEnum<EDeviceChallengeSkill>>();
			set => SetPropertyValue<CEnum<EDeviceChallengeSkill>>(value);
		}

		[Ordinal(8)] 
		[RED("baseSkill")] 
		public CHandle<GameplaySkillCondition> BaseSkill
		{
			get => GetPropertyValue<CHandle<GameplaySkillCondition>>();
			set => SetPropertyValue<CHandle<GameplaySkillCondition>>(value);
		}

		[Ordinal(9)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SkillCheckBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
