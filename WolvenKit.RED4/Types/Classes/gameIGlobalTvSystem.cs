
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIGlobalTvSystem : gameIGameSystem
	{
		public gameIGlobalTvSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
