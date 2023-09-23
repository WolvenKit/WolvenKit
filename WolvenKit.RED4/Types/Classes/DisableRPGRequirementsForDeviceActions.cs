using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisableRPGRequirementsForDeviceActions : redEvent
	{
		[Ordinal(0)] 
		[RED("action")] 
		public TweakDBID Action
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("disable")] 
		public CBool Disable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DisableRPGRequirementsForDeviceActions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
