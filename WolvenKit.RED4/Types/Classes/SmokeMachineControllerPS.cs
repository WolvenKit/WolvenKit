
namespace WolvenKit.RED4.Types
{
	public partial class SmokeMachineControllerPS : BasicDistractionDeviceControllerPS
	{
		public SmokeMachineControllerPS()
		{
			DeviceName = "LocKey#146";
			TweakDBRecord = "Devices.SmokeMachine";
			TweakDBDescriptionRecord = 139901527839;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
