using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NotifyHighlightedDevice : redEvent
	{
		private CBool _isDeviceHighlighted;
		private CBool _isNotifiedByMasterDevice;

		[Ordinal(0)] 
		[RED("IsDeviceHighlighted")] 
		public CBool IsDeviceHighlighted
		{
			get => GetProperty(ref _isDeviceHighlighted);
			set => SetProperty(ref _isDeviceHighlighted, value);
		}

		[Ordinal(1)] 
		[RED("IsNotifiedByMasterDevice")] 
		public CBool IsNotifiedByMasterDevice
		{
			get => GetProperty(ref _isNotifiedByMasterDevice);
			set => SetProperty(ref _isNotifiedByMasterDevice, value);
		}
	}
}
