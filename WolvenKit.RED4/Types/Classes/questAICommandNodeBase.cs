
namespace WolvenKit.RED4.Types
{
	public abstract partial class questAICommandNodeBase : questSignalStoppingNodeDefinition
	{
		public questAICommandNodeBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
