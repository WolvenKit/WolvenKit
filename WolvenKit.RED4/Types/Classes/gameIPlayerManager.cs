
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIPlayerManager : gameIGameSystem
	{
		public gameIPlayerManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
