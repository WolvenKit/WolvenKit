using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HoloDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HoloDeviceControllerPS()
		{
			TweakDBRecord = "Devices.HoloDevice";
			TweakDBDescriptionRecord = "device_descriptions.HoloDevice";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
