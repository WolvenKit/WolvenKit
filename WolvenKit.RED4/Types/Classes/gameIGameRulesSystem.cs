
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIGameRulesSystem : gameIGameSystem
	{
		public gameIGameRulesSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
