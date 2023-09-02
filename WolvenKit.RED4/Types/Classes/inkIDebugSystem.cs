
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkIDebugSystem : inkILayerSystem
	{
		public inkIDebugSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
