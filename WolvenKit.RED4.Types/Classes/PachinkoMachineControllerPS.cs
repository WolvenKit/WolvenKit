
namespace WolvenKit.RED4.Types
{
	public partial class PachinkoMachineControllerPS : ArcadeMachineControllerPS
	{
		public PachinkoMachineControllerPS()
		{
			DeviceName = "LocKey#172";
			TweakDBRecord = 102188727223;
			TweakDBDescriptionRecord = 153491964164;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
