
namespace WolvenKit.RED4.Types
{
	public partial class questMinigameSateListenerNodeDefinition : questSignalStoppingNodeDefinition
	{
		public questMinigameSateListenerNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
