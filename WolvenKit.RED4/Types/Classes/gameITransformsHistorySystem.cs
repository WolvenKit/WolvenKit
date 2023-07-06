
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameITransformsHistorySystem : gameIGameSystem
	{
		public gameITransformsHistorySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
