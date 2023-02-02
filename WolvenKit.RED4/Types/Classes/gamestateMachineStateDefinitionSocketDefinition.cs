
namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateDefinitionSocketDefinition : graphGraphSocketDefinition
	{
		public gamestateMachineStateDefinitionSocketDefinition()
		{
			Connections = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
