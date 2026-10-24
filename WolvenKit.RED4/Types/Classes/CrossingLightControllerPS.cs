using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrossingLightControllerPS : TrafficLightControllerPS
	{
		[Ordinal(107)] 
		[RED("crossingLightSFXSetup")] 
		public CrossingLightSetup CrossingLightSFXSetup
		{
			get => GetPropertyValue<CrossingLightSetup>();
			set => SetPropertyValue<CrossingLightSetup>(value);
		}

		public CrossingLightControllerPS()
		{
			DeviceName = "LocKey#125";
			TweakDBRecord = "Devices.CrossingLight";
			TweakDBDescriptionRecord = "device_descriptions.CrossingLight";
			CrossingLightSFXSetup = new CrossingLightSetup();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
