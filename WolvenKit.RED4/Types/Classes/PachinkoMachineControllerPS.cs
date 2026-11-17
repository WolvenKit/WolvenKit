
namespace WolvenKit.RED4.Types
{
	public partial class PachinkoMachineControllerPS : ArcadeMachineControllerPS
	{
		public PachinkoMachineControllerPS()
		{
			DeviceName = "LocKey#172";
			TweakDBRecord = "Devices.PachinkoMachine";
			TweakDBDescriptionRecord = "device_descriptions.PachinkoMachine";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
