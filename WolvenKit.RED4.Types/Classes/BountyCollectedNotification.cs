using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BountyCollectedNotification : GenericNotificationController
	{
		private CName _bountyCollectedUpdateAnimation;

		[Ordinal(12)] 
		[RED("bountyCollectedUpdateAnimation")] 
		public CName BountyCollectedUpdateAnimation
		{
			get => GetProperty(ref _bountyCollectedUpdateAnimation);
			set => SetProperty(ref _bountyCollectedUpdateAnimation, value);
		}
	}
}
