using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NotifyHighlightedDevice : redEvent
	{
		[Ordinal(0)] 
		[RED("IsDeviceHighlighted")] 
		public CBool IsDeviceHighlighted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("IsNotifiedByMasterDevice")] 
		public CBool IsNotifiedByMasterDevice
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NotifyHighlightedDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
