
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIOnlineSystem : gameIGameSystem
	{
		public gameIOnlineSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
