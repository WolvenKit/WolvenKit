using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BountyCollectedNotificationQueue : gameuiGenericNotificationGameController
	{
		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("bountyNotification")] 
		public CName BountyNotification
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public BountyCollectedNotificationQueue()
		{
			Duration = 2.000000F;
			BountyNotification = "notification_bounty";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
