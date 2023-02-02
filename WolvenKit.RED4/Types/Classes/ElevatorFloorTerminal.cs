
namespace WolvenKit.RED4.Types
{
	public partial class ElevatorFloorTerminal : Terminal
	{
		public ElevatorFloorTerminal()
		{
			ControllerTypeName = "ElevatorFloorTerminalController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
