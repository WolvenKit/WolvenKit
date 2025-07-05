
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIGodModeSystem : gameIReplicatedGameSystem
	{
		public gameIGodModeSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
