
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkILayerSystemData : IScriptable
	{
		public inkILayerSystemData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
