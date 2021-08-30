using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BountyCollectedNotificationQueue : gameuiGenericNotificationGameController
	{
		private CFloat _duration;
		private CName _bountyNotification;

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("bountyNotification")] 
		public CName BountyNotification
		{
			get => GetProperty(ref _bountyNotification);
			set => SetProperty(ref _bountyNotification, value);
		}

		public BountyCollectedNotificationQueue()
		{
			_duration = 2.000000F;
			_bountyNotification = "notification_bounty";
		}
	}
}
