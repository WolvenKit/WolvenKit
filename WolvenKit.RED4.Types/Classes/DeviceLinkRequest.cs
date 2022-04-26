using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceLinkRequest : redEvent
	{
		[Ordinal(0)] 
		[RED("deviceLink")] 
		public DeviceLink DeviceLink
		{
			get => GetPropertyValue<DeviceLink>();
			set => SetPropertyValue<DeviceLink>(value);
		}

		public DeviceLinkRequest()
		{
			DeviceLink = new() { PSID = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
