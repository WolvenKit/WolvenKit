
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIStatPoolsSystem : gameIGameSystem
	{
		public gameIStatPoolsSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
