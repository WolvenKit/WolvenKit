
namespace WolvenKit.RED4.Types
{
	public abstract partial class questTypedSignalStoppingNodeDefinition : questSignalStoppingNodeDefinition
	{
		public questTypedSignalStoppingNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
