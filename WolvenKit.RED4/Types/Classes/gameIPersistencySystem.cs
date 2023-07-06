
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIPersistencySystem : gameIGameSystem
	{
		public gameIPersistencySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
