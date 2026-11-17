using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BlindingLightControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(113)] 
		[RED("reflectorSFX")] 
		public ReflectorSFX ReflectorSFX
		{
			get => GetPropertyValue<ReflectorSFX>();
			set => SetPropertyValue<ReflectorSFX>(value);
		}

		public BlindingLightControllerPS()
		{
			DeviceName = "LocKey#168";
			TweakDBRecord = "Devices.MetroLights";
			TweakDBDescriptionRecord = "device_descriptions.MetroLights";
			ReflectorSFX = new ReflectorSFX();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
