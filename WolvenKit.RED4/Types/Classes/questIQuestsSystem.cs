
namespace WolvenKit.RED4.Types
{
	public abstract partial class questIQuestsSystem : gameIReplicatedGameSystem
	{
		public questIQuestsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
