
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkLayerProxy : ISerializable
	{
		public inkLayerProxy()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
