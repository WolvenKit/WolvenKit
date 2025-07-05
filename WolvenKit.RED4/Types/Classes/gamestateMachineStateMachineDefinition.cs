
namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateMachineDefinition : graphGraphDefinition
	{
		public gamestateMachineStateMachineDefinition()
		{
			Nodes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
