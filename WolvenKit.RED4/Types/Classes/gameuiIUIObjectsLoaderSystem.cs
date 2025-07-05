
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiIUIObjectsLoaderSystem : gameIGameSystem
	{
		public gameuiIUIObjectsLoaderSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
