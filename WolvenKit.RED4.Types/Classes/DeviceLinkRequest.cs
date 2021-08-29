using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceLinkRequest : redEvent
	{
		private DeviceLink _deviceLink;

		[Ordinal(0)] 
		[RED("deviceLink")] 
		public DeviceLink DeviceLink
		{
			get => GetProperty(ref _deviceLink);
			set => SetProperty(ref _deviceLink, value);
		}
	}
}
