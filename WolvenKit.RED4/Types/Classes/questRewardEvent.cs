using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRewardEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("rewardName")] 
		public TweakDBID RewardName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public questRewardEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
