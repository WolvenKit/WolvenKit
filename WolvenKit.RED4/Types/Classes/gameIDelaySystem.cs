
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDelaySystem : gameIGameSystem
	{
		public gameIDelaySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
