
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIPhantomEntitySystem : gameIGameSystem
	{
		public gameIPhantomEntitySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
