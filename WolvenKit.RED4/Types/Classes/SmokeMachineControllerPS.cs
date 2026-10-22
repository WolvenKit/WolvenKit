
namespace WolvenKit.RED4.Types
{
	public partial class SmokeMachineControllerPS : BasicDistractionDeviceControllerPS
	{
		public SmokeMachineControllerPS()
		{
			DeviceName = "LocKey#146";
			TweakDBRecord = "Devices.SmokeMachine";
			TweakDBDescriptionRecord = "device_descriptions.SmokeMachine";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
