using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioDeviceSettings : audioEntitySettings
	{
		private audioDeviceStateSettings _deviceSettings;

		[Ordinal(6)] 
		[RED("deviceSettings")] 
		public audioDeviceStateSettings DeviceSettings
		{
			get => GetProperty(ref _deviceSettings);
			set => SetProperty(ref _deviceSettings, value);
		}
	}
}
