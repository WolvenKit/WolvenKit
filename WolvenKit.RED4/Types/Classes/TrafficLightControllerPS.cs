
namespace WolvenKit.RED4.Types
{
	public partial class TrafficLightControllerPS : ScriptableDeviceComponentPS
	{
		public TrafficLightControllerPS()
		{
			DeviceName = "LocKey#127";
			TweakDBRecord = "Devices.TrafficLight";
			TweakDBDescriptionRecord = "device_descriptions.TrafficLight";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
