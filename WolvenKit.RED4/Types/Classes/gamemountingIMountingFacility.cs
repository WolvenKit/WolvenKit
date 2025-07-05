
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamemountingIMountingFacility : gameIGameSystem
	{
		public gamemountingIMountingFacility()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
