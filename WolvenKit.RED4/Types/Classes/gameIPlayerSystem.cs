
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIPlayerSystem : gameIGameSystem
	{
		public gameIPlayerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
