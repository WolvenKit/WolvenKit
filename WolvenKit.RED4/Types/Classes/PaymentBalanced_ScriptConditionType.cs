using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PaymentBalanced_ScriptConditionType : PaymentConditionTypeBase
	{
		[Ordinal(2)] 
		[RED("questAssignment")] 
		public TweakDBID QuestAssignment
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetPropertyValue<CEnum<EGameplayChallengeLevel>>();
			set => SetPropertyValue<CEnum<EGameplayChallengeLevel>>(value);
		}

		public PaymentBalanced_ScriptConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
