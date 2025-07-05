
namespace WolvenKit.RED4.Types
{
	public abstract partial class questStartEndNodeDefinition : questDisableableNodeDefinition
	{
		public questStartEndNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
