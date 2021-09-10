using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrafficIntersectionManagerControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("trafficLightStatus")] 
		public CEnum<worldTrafficLightColor> TrafficLightStatus
		{
			get => GetPropertyValue<CEnum<worldTrafficLightColor>>();
			set => SetPropertyValue<CEnum<worldTrafficLightColor>>(value);
		}

		public TrafficIntersectionManagerControllerPS()
		{
			DeviceName = "Traffic Intersection Manager";
			TweakDBRecord = new() { Value = 147361436664 };
			TweakDBDescriptionRecord = new() { Value = 201737502228 };
		}
	}
}
