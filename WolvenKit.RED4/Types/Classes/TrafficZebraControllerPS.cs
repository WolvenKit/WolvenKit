
namespace WolvenKit.RED4.Types
{
	public partial class TrafficZebraControllerPS : TrafficLightControllerPS
	{
		public TrafficZebraControllerPS()
		{
			DeviceName = "Gameplay-Devices-DisplayNames-Zebra";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
