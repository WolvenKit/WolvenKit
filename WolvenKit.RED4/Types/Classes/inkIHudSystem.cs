
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkIHudSystem : inkILayerSystem
	{
		public inkIHudSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
