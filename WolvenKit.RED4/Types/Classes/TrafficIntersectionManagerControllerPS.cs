using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TrafficIntersectionManagerControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("trafficLightStatus")] 
		public CEnum<worldTrafficLightColor> TrafficLightStatus
		{
			get => GetPropertyValue<CEnum<worldTrafficLightColor>>();
			set => SetPropertyValue<CEnum<worldTrafficLightColor>>(value);
		}

		public TrafficIntersectionManagerControllerPS()
		{
			DeviceName = "Traffic Intersection Manager";
			TweakDBRecord = "Devices.TrafficIntersectionManager";
			TweakDBDescriptionRecord = "device_descriptions.TrafficIntersectionManager";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
