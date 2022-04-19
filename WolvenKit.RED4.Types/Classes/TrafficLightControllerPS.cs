
namespace WolvenKit.RED4.Types
{
	public partial class TrafficLightControllerPS : ScriptableDeviceComponentPS
	{
		public TrafficLightControllerPS()
		{
			DeviceName = "LocKey#127";
			TweakDBRecord = 86578523053;
			TweakDBDescriptionRecord = 137459607504;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
