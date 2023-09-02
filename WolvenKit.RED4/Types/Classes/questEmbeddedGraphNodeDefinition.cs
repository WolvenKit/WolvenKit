
namespace WolvenKit.RED4.Types
{
	public abstract partial class questEmbeddedGraphNodeDefinition : questSignalStoppingNodeDefinition
	{
		public questEmbeddedGraphNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
