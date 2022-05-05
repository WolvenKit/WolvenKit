
namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineState : graphGraphNodeDefinition
	{
		public gamestateMachineState()
		{
			Sockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
