
namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateDefinition : graphGraphNodeDefinition
	{
		public gamestateMachineStateDefinition()
		{
			Sockets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
