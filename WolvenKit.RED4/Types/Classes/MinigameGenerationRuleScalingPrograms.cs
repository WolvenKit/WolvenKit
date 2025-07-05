using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinigameGenerationRuleScalingPrograms : gameuiMinigameGenerationRule
	{
		[Ordinal(7)] 
		[RED("bbNetwork")] 
		public CWeakHandle<gameIBlackboard> BbNetwork
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(8)] 
		[RED("isOfficerBreach")] 
		public CBool IsOfficerBreach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isRemoteBreach")] 
		public CBool IsRemoteBreach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isFirstAttempt")] 
		public CBool IsFirstAttempt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MinigameGenerationRuleScalingPrograms()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
