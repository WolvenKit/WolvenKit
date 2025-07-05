
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamemountingIMountingPublisher : gameIGameSystem
	{
		public gamemountingIMountingPublisher()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
