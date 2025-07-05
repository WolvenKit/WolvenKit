using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeRewardSettingsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("forceDefeatReward")] 
		public CBool ForceDefeatReward
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("disableKillReward")] 
		public CBool DisableKillReward
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ChangeRewardSettingsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
