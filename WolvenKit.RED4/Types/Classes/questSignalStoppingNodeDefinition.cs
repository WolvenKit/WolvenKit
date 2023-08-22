
namespace WolvenKit.RED4.Types
{
	public abstract partial class questSignalStoppingNodeDefinition : questDisableableNodeDefinition
	{
		public questSignalStoppingNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
