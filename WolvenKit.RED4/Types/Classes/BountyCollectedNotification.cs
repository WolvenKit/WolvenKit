using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BountyCollectedNotification : GenericNotificationController
	{
		[Ordinal(16)] 
		[RED("bountyCollectedUpdateAnimation")] 
		public CName BountyCollectedUpdateAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public BountyCollectedNotification()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
