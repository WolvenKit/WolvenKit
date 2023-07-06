
namespace WolvenKit.RED4.Types
{
	public abstract partial class questDisableableNodeDefinition : questNodeDefinition
	{
		public questDisableableNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
