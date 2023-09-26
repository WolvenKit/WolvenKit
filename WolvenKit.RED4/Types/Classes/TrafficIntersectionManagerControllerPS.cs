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
			TweakDBRecord = 147361436664;
			TweakDBDescriptionRecord = 201737502228;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
