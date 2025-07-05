using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Build_ScriptConditionType : BluelineConditionTypeBase
	{
		[Ordinal(0)] 
		[RED("questAssignment")] 
		public TweakDBID QuestAssignment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("buildId")] 
		public TweakDBID BuildId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetPropertyValue<CEnum<EGameplayChallengeLevel>>();
			set => SetPropertyValue<CEnum<EGameplayChallengeLevel>>(value);
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<ECompareOp> ComparisonType
		{
			get => GetPropertyValue<CEnum<ECompareOp>>();
			set => SetPropertyValue<CEnum<ECompareOp>>(value);
		}

		public Build_ScriptConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
