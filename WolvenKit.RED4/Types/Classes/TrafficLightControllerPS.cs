
namespace WolvenKit.RED4.Types
{
	public partial class TrafficLightControllerPS : ScriptableDeviceComponentPS
	{
		public TrafficLightControllerPS()
		{
			DeviceName = "LocKey#127";
			TweakDBRecord = "Devices.TrafficLight";
			TweakDBDescriptionRecord = 137459607504;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
