
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkFullscreenCompositionManager : ISerializable
	{
		public inkFullscreenCompositionManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
