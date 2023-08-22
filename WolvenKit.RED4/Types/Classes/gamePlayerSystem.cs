
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamePlayerSystem : gameIPlayerSystem
	{
		public gamePlayerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
