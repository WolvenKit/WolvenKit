
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDamageSystem : gameIReplicatedGameSystem
	{
		public gameIDamageSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
