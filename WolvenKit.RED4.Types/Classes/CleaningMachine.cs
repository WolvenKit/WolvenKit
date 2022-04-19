
namespace WolvenKit.RED4.Types
{
	public partial class CleaningMachine : BasicDistractionDevice
	{
		public CleaningMachine()
		{
			ControllerTypeName = "CleaningMachineController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
