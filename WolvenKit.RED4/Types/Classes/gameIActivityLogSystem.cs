
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIActivityLogSystem : gameIGameSystem
	{
		public gameIActivityLogSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
