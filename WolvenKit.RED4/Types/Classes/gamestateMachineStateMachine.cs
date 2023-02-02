
namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateMachine : graphGraphDefinition
	{
		public gamestateMachineStateMachine()
		{
			Nodes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
