
namespace WolvenKit.RED4.Types
{
	public abstract partial class questConfigurableAICommandNode : questAICommandNodeBase
	{
		public questConfigurableAICommandNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
