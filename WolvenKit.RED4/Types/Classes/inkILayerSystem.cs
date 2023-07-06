
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkILayerSystem : IScriptable
	{
		public inkILayerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
