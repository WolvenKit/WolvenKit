using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDeviceSettings : audioEntitySettings
	{
		[Ordinal(6)] 
		[RED("deviceSettings")] 
		public audioDeviceStateSettings DeviceSettings
		{
			get => GetPropertyValue<audioDeviceStateSettings>();
			set => SetPropertyValue<audioDeviceStateSettings>(value);
		}

		public audioDeviceSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
