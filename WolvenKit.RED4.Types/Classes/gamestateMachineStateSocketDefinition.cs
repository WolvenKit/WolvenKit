
namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineStateSocketDefinition : graphGraphSocketDefinition
	{
		public gamestateMachineStateSocketDefinition()
		{
			Connections = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
