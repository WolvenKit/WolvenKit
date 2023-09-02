
namespace WolvenKit.RED4.Types
{
	public partial class PachinkoMachineControllerPS : ArcadeMachineControllerPS
	{
		public PachinkoMachineControllerPS()
		{
			DeviceName = "LocKey#172";
			TweakDBRecord = "Devices.PachinkoMachine";
			TweakDBDescriptionRecord = 153491964164;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
