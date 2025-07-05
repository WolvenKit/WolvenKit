
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameICompanionSystem : gameIGameSystem
	{
		public gameICompanionSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
