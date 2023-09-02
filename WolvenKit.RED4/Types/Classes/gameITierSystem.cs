
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameITierSystem : gameIGameSystem
	{
		public gameITierSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
